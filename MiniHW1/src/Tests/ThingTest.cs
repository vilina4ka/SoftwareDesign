namespace Tests;
using Xunit;
using MiniHW1;

public class ThingTest
{
    [Fact] 
    public void Thing_Test()
    {
        Thing computer = new Computer();
        computer.Number = 1;
        
        string res = computer.ToString();
        
        Assert.Equal("№ 1 : Computer", res);
    }
}