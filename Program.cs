static int[] CountPositivesSumNegatives(int[] input)
{
    return input != null && input.Length != 0
 ? new int[] { input.Count(x => x > 0), input.Where(x => x < 0).Sum() }
 : new int[] { };
}

//Given a string s. You have to return another string such that even-indexed
//and odd-indexed characters of s are grouped and groups are space-separated (see sample below)
static string SortMyString(string s) => string.Concat(s.Where((x, i) => i % 2 == 0)) + " " + string.Concat(s.Where((x, i) => i % 2 != 0));
