namespace Tests;
using Xunit;
using MiniHW1;

public class AnimalTest
{
    [Fact]
    public void Animal_Test()
    {
        Animal tiger = new Tiger( 65);
        tiger.Number = 0;
        
        string res = tiger.ToString();
        
        Assert.Equal($" № 0 : Tiger, food amount - 65 kg.", res);
    }
}