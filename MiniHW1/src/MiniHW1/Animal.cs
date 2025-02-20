namespace MiniHW1;

public abstract class Animal : IAlive, IInventory
{
    public int Food { get; set; }
    public int Number { get; set; }

    protected Animal(int food)
    {
        Food = food;
    }
    public override string ToString()
    {
        return $" № {this.Number} : {this.GetType().Name}, food amount - {this.Food} kg.";
    }
}