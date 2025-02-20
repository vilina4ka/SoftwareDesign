namespace MiniHW1;

public class Zoo
{
    private readonly VetClinic _vetClinic;
    private readonly List<Animal> _animals = new List<Animal>();
    private readonly List<Thing> _things = new List<Thing>();
    private int _animalCountN = 0;
    private int _thingCountN = 0;

    public Zoo(VetClinic vetClinic)
    {
        _vetClinic = vetClinic;
    }

    public bool AddAnimal(Animal animal)
    {
        if (_vetClinic.IsHealthy(animal))
        {
            animal.Number = _animalCountN;
            _animalCountN += 1;
            _animals.Add(animal);
            return true;
        }
        return false;
    }

    public void AddThing(Thing thing)
    {
        thing.Number = _thingCountN;
        _thingCountN += 1;
        _things.Add(thing);
    }
    
    public List<Animal> GetAnimals()
    {
        return _animals.ToList();
    }

    public List<Thing> GetThings()
    {
        return _things.ToList();
    }
    
    public int GetTotalFood()
    {
        return _animals.Sum(animal => animal.Food);
    }

    public int GetAnimalsCount()
    {
        return _animals.Count;
    }

    public List<Animal> GetContactZoo()
    {
        List<Animal> contactAnimals = new List<Animal>();
        foreach (var animal in _animals)
        {
            if (animal is Herbo && ((Herbo)animal).Kindness > 5)
            {
                contactAnimals.Add(animal);
            }
        }
        return contactAnimals;
    }
}