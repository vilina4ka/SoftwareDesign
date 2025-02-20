namespace MiniHW1;

public abstract class Herbo : Animal
{
    public int Kindness { get; set; }

    protected Herbo(int food, int kindness) : base(food)
    {
        Kindness = kindness;
    }

    public bool IsKind()
    {
        return Kindness > 5;
    }
}