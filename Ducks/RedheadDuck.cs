using DuckReunion.Interfaces;

namespace DuckReunion.Ducks
{
    public class RedheadDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack quack!");
        }
    }
}
