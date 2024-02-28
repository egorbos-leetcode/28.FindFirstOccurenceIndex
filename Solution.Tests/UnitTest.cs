namespace Solution.Tests;

public class UnitTest
{
    [Theory]
    [InlineData("sadbutsad", "sad", 0)]
    [InlineData("leetcode", "leeto", -1)]
    public void Test(string haystack, string needle, int expected)
    {
        var index = Solution.StrStr(haystack, needle);

        Assert.Equal(expected, index);
    }
}
