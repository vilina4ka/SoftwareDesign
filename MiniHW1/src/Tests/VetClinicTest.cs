namespace Tests;
using Xunit;
using MiniHW1;

public class VetClinicTest
{
    [Fact]
    public void IsHealthy_Bool()
    {
        var vetClinic = new VetClinic();
        var wolf = new Wolf(43);
        
        bool res = vetClinic.IsHealthy(wolf);
        
        Assert.IsType<bool>(res);
    }
}