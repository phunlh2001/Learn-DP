using DuckReunion.Interfaces;

namespace DuckReunion.Ducks
{
    public class MallardDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack quack!");
        }
    }
}
