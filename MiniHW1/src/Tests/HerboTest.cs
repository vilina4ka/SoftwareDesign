namespace Tests;
using Xunit;
using MiniHW1;

public class HerboTest
{
    [Theory]
    [InlineData(10, true)]
    [InlineData(2, false)]
    public void Herbo_IsKind(int kindness, bool expected)
    {
        Herbo monkey = new Monkey(9, kindness);
        
        bool res = monkey.IsKind();
        
        Assert.Equal(expected, res);
    }
}