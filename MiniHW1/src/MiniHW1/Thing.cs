namespace MiniHW1;

public abstract class Thing : IInventory
{
    public int Number { get; set; }

    public Thing()
    {
    }
    public override string ToString()
    {
        return $"№ {this.Number} : {this.GetType().Name}";
    }
}