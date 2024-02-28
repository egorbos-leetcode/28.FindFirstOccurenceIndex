namespace Solution;

public static class Solution
{
    public static int StrStr(string haystack, string needle)
    {
        return haystack.IndexOf(needle, StringComparison.Ordinal);
    }
}
