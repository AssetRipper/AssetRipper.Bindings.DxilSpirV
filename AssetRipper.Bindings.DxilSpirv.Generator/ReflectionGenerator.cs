using System.Reflection;
using System.Text.RegularExpressions;

namespace AssetRipper.Bindings.DxilSpirv.Generator;

internal sealed partial class ReflectionGenerator
{
	private readonly Dictionary<string, string> remappedNames = new();
	private readonly HashSet<string> conflictingNames = new();
	private static readonly string[] prefixes = ["dxil_spv_", "DXIL_SPV_"];

	[GeneratedRegex("^[a-z0-9]+(_[a-z0-9]+)*$")]
	private static partial Regex SnakeCaseRegex();

	[GeneratedRegex("^[A-Z0-9]+(_[A-Z0-9]+)*$")]
	private static partial Regex UpperSnakeCaseRegex();

	internal IReadOnlyDictionary<string, string> RemappedNames => remappedNames;

	internal void AnalyzeAssembly(Assembly assembly)
	{
		foreach (Type type in assembly.GetTypes().Where(t => !t.Name.Contains('<')))
		{
			TryAdd(type.Name, CleanName(MaybeRemoveUnderscoreSSuffix(type.Name)));
			if (type.IsEnum)
			{
				string[] items = Enum.GetNames(type);
				if (items.Length == 0)
				{
				}
				else if (items.Length == 1)
				{
					string item = items[0];
					string prefix = type.Name;
					if (item.StartsWith(prefix, System.StringComparison.Ordinal))
					{
						string itemWithoutPrefix = item.Substring(prefix.Length);
						TryAdd(item, CleanName(itemWithoutPrefix));
					}
					else
					{
						TryAdd(item, CleanName(item));
					}
				}
				else
				{
					ReadOnlySpan<char> prefix = items[0];

					for (int i = 1; i < items.Length; i++)
					{
						string item = items[i];
						int index = FindFirstDifferenceIndex(prefix, item);
						prefix = prefix[..index];
					}

					foreach (string item in items)
					{
						TryAdd(item, CleanName(item.Substring(prefix.Length)));
					}
				}
			}
			else
			{
				foreach (MemberInfo memberInfo in type.GetMembers())
				{
					string name = memberInfo.Name;
					TryAdd(name, CleanName(name));
				}
			}
		}

	}

	private static string MaybeRemoveUnderscoreSSuffix(string name)
	{
		if (name.EndsWith("_s", StringComparison.Ordinal))
		{
			return name[..^2];
		}
		return name;
	}

	private static string CleanName(string name)
	{
		string cleanedName = RemovePrefix(name);
		cleanedName = RemoveLeadingAndTrailingUnderscores(cleanedName);

		if (SnakeCaseRegex().IsMatch(cleanedName))
		{
			cleanedName = SnakeToPascal(cleanedName);
		}
		else if (UpperSnakeCaseRegex().IsMatch(cleanedName))
		{
			cleanedName = SnakeToPascal(cleanedName.ToLowerInvariant());
		}

		return char.IsDigit(cleanedName[0]) ? "_" + cleanedName : cleanedName;

		static string RemovePrefix(string name)
		{
			foreach (string prefix in prefixes)
			{
				if (name.StartsWith(prefix, StringComparison.Ordinal))
				{
					return name.Substring(prefix.Length);
				}
			}
			return name;
		}

		static string RemoveLeadingAndTrailingUnderscores(string str)
		{
			int startIndex = 0;
			int endIndex = str.Length - 1;

			while (startIndex < endIndex && str[startIndex] == '_')
			{
				startIndex++;
			}

			while (endIndex > startIndex && str[endIndex] == '_')
			{
				endIndex--;
			}

			return str[startIndex..(endIndex + 1)];
		}

		static string SnakeToPascal(string str)
		{
			string[] parts = str.Split('_');
			for (int i = 0; i < parts.Length; i++)
			{
				string part = parts[i];
				if (part.Length > 0)
				{
					parts[i] = char.ToUpperInvariant(part[0]) + part[1..];
				}
			}
			return string.Join("", parts);
		}
	}

	private bool TryAdd(string name, string remappedName)
	{
		if (name == remappedName)
		{
			return false;
		}
		else if (conflictingNames.Contains(name))
		{
			return false;
		}
		else if (remappedNames.TryGetValue(name, out string? existingRemappedName))
		{
			if (existingRemappedName != remappedName)
			{
				conflictingNames.Add(name);
				remappedNames.Remove(name);
				return false;
			}
		}
		else
		{
			remappedNames.Add(name, remappedName);
		}
		return true;
	}

	private static int FindFirstDifferenceIndex(ReadOnlySpan<char> span1, ReadOnlySpan<char> span2)
	{
		int minLength = Math.Min(span1.Length, span2.Length);

		for (int i = 0; i < minLength; i++)
		{
			if (span1[i] != span2[i])
			{
				return i;
			}
		}

		return minLength;
	}
}
