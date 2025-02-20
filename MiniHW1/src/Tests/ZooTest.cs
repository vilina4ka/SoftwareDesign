namespace Tests;
using Xunit;
using MiniHW1;
using NSubstitute;

public class ZooTest
{
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void AddAnimal_Test(bool expected)
        {
            var vetClinic = Substitute.For<VetClinic>();
            vetClinic.IsHealthy(Arg.Any<IAlive>()).Returns(expected);
            var zoo = new Zoo(vetClinic);
            var wolf = new Wolf(65);
            
            zoo.AddAnimal(wolf);
            bool res = zoo.GetAnimals().Contains(wolf);
            
            Assert.Equal(res, expected);
        }

        [Fact]
        public void AddThing_Bool()
        {
            var vetClinic = Substitute.For<VetClinic>();
            var zoo = new Zoo(vetClinic);
            var computer = new Table();
            
            zoo.AddThing(computer);
            bool res = zoo.GetThings().Contains(computer);
            
            Assert.True(res);
        }

        [Fact]
        public void GetTotalFood_Correct()
        {
            var vetClinic = Substitute.For<VetClinic>();
            vetClinic.IsHealthy(Arg.Any<IAlive>()).Returns(true);
            var zoo = new Zoo(vetClinic);
            zoo.AddAnimal(new Wolf(90));
            zoo.AddAnimal(new Monkey(5, 5));
            zoo.AddAnimal(new Rabbit(2, 9));
            zoo.AddAnimal(new Tiger(52));
            
            int total = zoo.GetTotalFood();

            Assert.Equal(149, total);
        }

        [Fact]
        public void GetContactZoo_Correct()
        {
            var vetClinic = Substitute.For<VetClinic>();
            vetClinic.IsHealthy(Arg.Any<IAlive>()).Returns(true);
            var zoo = new Zoo(vetClinic);
            var monkey1 = new Monkey(12, 9);
            var monkey2 = new Monkey(4, 3);
            var rabbit = new Rabbit(1, 8);
            var tiger = new Tiger(66);
            var wolf = new Wolf(75);
            zoo.AddAnimal(monkey1);
            zoo.AddAnimal(monkey2);
            zoo.AddAnimal(rabbit);
            zoo.AddAnimal(tiger);
            zoo.AddAnimal(wolf);
            
            List<Animal> contactAnimals = zoo.GetContactZoo();
            
            Assert.Equal(2, contactAnimals.Count);
            Assert.Contains(monkey1, contactAnimals);
            Assert.Contains(rabbit, contactAnimals);
            Assert.DoesNotContain(monkey2, contactAnimals);
            Assert.DoesNotContain(tiger, contactAnimals);
            Assert.DoesNotContain(wolf, contactAnimals);
        }

        [Fact]
        public void GetAnimals_Correct()
        
        {
            var vetClinic = Substitute.For<VetClinic>();
            vetClinic.IsHealthy(Arg.Any<IAlive>()).Returns(true);
            var zoo = new Zoo(vetClinic);
            var monkey1 = new Monkey(12, 9);
            var monkey2 = new Monkey(4, 3);
            var rabbit = new Rabbit(1, 8);
            var tiger = new Tiger(66);
            var wolf = new Wolf(75);
            zoo.AddAnimal(monkey1);
            zoo.AddAnimal(monkey2);
            zoo.AddAnimal(rabbit);
            zoo.AddAnimal(tiger);
            zoo.AddAnimal(wolf);
            
            var animals = zoo.GetAnimals();
            
            Assert.Equal(5, animals.Count);
            Assert.Contains(monkey1, animals);
            Assert.Contains(rabbit, animals);
            Assert.Contains(monkey2, animals);
            Assert.Contains(tiger, animals);
            Assert.Contains(wolf, animals);
        }

        [Fact]
        public void GetThings_Correct()
        {
            var vetClinic = Substitute.For<VetClinic>();
            var zoo = new Zoo(vetClinic);
            var table = new Table();
            var computer = new Computer();
            zoo.AddThing(table);
            zoo.AddThing(computer);
            
            List<Thing> things = zoo.GetThings();
            
            Assert.Equal(2, things.Count);
            Assert.Contains(table, things);
            Assert.Contains(computer, things);
        }

        [Fact]
        public void GetAnimalsCount_Correct()
        {
            // Arrange
            var vetClinic = Substitute.For<VetClinic>();
            vetClinic.IsHealthy(Arg.Any<IAlive>()).Returns(true); // Ensure animals are added
            var zoo = new Zoo(vetClinic);
            var monkey1 = new Monkey(12, 9);
            var monkey2 = new Monkey(4, 3);
            var rabbit = new Rabbit(1, 8);
            var tiger = new Tiger(66);
            var wolf = new Wolf(75);
            zoo.AddAnimal(monkey1);
            zoo.AddAnimal(monkey2);
            zoo.AddAnimal(rabbit);
            zoo.AddAnimal(tiger);
            zoo.AddAnimal(wolf);

            // Act
            int count = zoo.GetAnimalsCount();

            // Assert
            Assert.Equal(5, count);
        }

        [Fact]
        public void AnimalsNumbers_Correct()
        {
            var vetClinic = Substitute.For<VetClinic>();
            vetClinic.IsHealthy(Arg.Any<IAlive>()).Returns(true);
            var zoo = new Zoo(vetClinic);
            var monkey = new Monkey(12, 9);
            var rabbit = new Rabbit(1, 8);
            var tiger = new Tiger(66);
            var wolf = new Wolf(75);
            zoo.AddAnimal(monkey);
            zoo.AddAnimal(rabbit);
            zoo.AddAnimal(tiger);
            zoo.AddAnimal(wolf);
            
            var animals = zoo.GetAnimals();
            
            Assert.Equal(0, animals[0].Number);
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            Assert.Equal(1, animals[1].Number);
            Assert.Equal(2, animals[2].Number);
            Assert.Equal(3, animals[3].Number); 
        }

        [Fact]
        public void ThingsNumbers_Correct()
        {
            var vetClinic = Substitute.For<VetClinic>();
            var zoo = new Zoo(vetClinic);
            var table = new Table();
            var computer = new Computer();
            zoo.AddThing(table);
            zoo.AddThing(computer);

            var things = zoo.GetThings();

            Assert.Equal(0, things[0].Number);
            Assert.Equal(1, things[1].Number);
        }
}