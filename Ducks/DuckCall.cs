using DuckReunion.Interfaces;

namespace DuckReunion.Ducks
{
    public class DuckCall : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Kwak");
        }
    }
}
