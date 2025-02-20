namespace MiniHW1;

public class WriteToConsole
{
    private Zoo _zoo;
        public WriteToConsole(Zoo zoo)
        {
            _zoo = zoo;
        }

        public void Run()
        {
            // Empty zoo without everything and everybody.
            PrintAnimalInfo();
            PrintInventoryInfo();
            PrintContactZooInfo();
            PrintAnimalsCount();
            PrintTotalFood();

            // Add animals.
            AddAnimal(new Wolf(26));
            AddAnimal(new Tiger(55));
            AddAnimal(new Rabbit(1, 3));
            AddAnimal(new Monkey(14, 7));
            AddAnimal(new Wolf(78));
            AddAnimal(new Rabbit(6, 2));
            AddAnimal(new Rabbit(4, 10));
            AddAnimal(new Monkey(7, 3));
            AddAnimal(new Tiger( 90));

            // Add inventory.
            AddThing(new Computer());
            AddThing(new Table());
            AddThing(new Table());
            AddThing(new Computer());
            

            // Print updated info about zoo.
            PrintAnimalInfo();
            PrintInventoryInfo();
            PrintContactZooInfo();
            PrintAnimalsCount();
            PrintTotalFood();
        }

        public void AddAnimal(Animal animal)
        {
            Console.WriteLine(_zoo.AddAnimal(animal)
                ? $" № {animal.Number} : {animal.GetType().Name} added!"
                : $"{animal.GetType().Name} rejected because of low level of health!");
        }

        public void AddThing(Thing thing)
        {
            _zoo.AddThing(thing);
            Console.WriteLine($" № {thing.Number} : {thing.GetType().Name} added!");
        }

        public void PrintAnimalsCount()
        {
            Console.WriteLine($"Total animal count = {_zoo.GetAnimalsCount()}.");
        }

        public void PrintTotalFood()
        {
            Console.WriteLine($"Total food amount for animals per day = {_zoo.GetTotalFood()} kg.");
        }
        public void PrintAnimalInfo()
        {
            List<Animal> animals = _zoo.GetAnimals();
            if (animals.Count > 0)
            {
                Console.WriteLine("In the zoo live such animals:");
                foreach (var animal in animals)
                {
                    Console.WriteLine(animal.ToString());
                }
            }
            else
            {
                Console.WriteLine("There are no animals in the zoo.");
            }
        }

        public void PrintInventoryInfo()
        {
            List<Thing> things = _zoo.GetThings();
            if (things.Count > 0)
            {
                Console.WriteLine("In the zoo there are such things:");
                foreach (var thing in things)
                {
                    Console.WriteLine(thing.ToString());
                }
            }
            else
            {
                Console.WriteLine("There are no things in the zoo.");
            }
        }
        
        public void PrintContactZooInfo()
        {
            List<Animal> animals = _zoo.GetContactZoo();
            if (animals.Count > 0)
            {
                Console.WriteLine("Contact animals in zoo:");
                foreach (var animal in animals)
                {
                    Console.WriteLine(animal.ToString());
                }
            }
            else
            {
                Console.WriteLine("There are no contact animals in zoo.");
            }
        }
}