
namespace Labb_2___Arv.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Horse horse = new Horse("Spirit", 5, 500.0, "Hay", "Male", true);
            horse.MakeSound();

            Cat cat = new Cat("Whiskers", 2, 10.5, "Cat food", "Female", true);
            cat.MakeSound();

            Dog dog = new Dog("Jacky", 3, 20.5, "Dog food", "Male", "Labrador", true);
            dog.MakeSound();

            Bulldog bulldog = new Bulldog("Max", 4, 25.0, "Dog food", "Male", true, true);
            bulldog.MakeSound();

            Chihuahua chihuahua = new Chihuahua("Tiny", 1, 5.0, "Dog food", "Female", true, true);
            chihuahua.MakeSound();
        }


    }
}