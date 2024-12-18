using DuckReunion.Interfaces;

namespace DuckReunion
{
    public class QuackCounter : IQuackable
    {
        //private static int numberOfQuacks;
        public static int GetQuacks()
        {
            return QuackStore.Instance.NumberOfQuacks;
        }

        public QuackCounter(IQuackable duck)
        {
            QuackStore.Instance.Increment();
            duck.Quack();
        }

        public void Quack()
        {
            Console.WriteLine("Quack Quack!");
        }
    }
}
