using DuckReunion.Interfaces;

namespace DuckReunion.Ducks
{
    public class RubberDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
