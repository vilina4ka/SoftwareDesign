namespace MiniHW1;

public class VetClinic
{
    public virtual bool IsHealthy(IAlive animal)
    {
        Random rnd = new Random();
        int healthy = rnd.Next(0, 2);
        return healthy == 1;
    }
}