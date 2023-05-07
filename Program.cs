static int[] CountPositivesSumNegatives(int[] input)
{
    return input != null && input.Length != 0
 ? new int[] { input.Count(x => x > 0), input.Where(x => x < 0).Sum() }
 : new int[] { };
}
