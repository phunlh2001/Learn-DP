using DuckReunion.Ducks;
using DuckReunion.Interfaces;

namespace DuckReunion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<3 Hung Phu <3");
            Console.WriteLine("========== Simple ==========");
            SimulateDucks();

            Console.WriteLine("========== Decorators ==========");
            SimulateWithDecorator();

            Console.WriteLine("========== Factory ==========");
            Console.WriteLine("creates ducks without decorators:");
            SimulateWithAbstractFactory(new DuckFactory());
            Console.WriteLine("creates ducks with decorators:");
            SimulateWithAbstractFactory(new CoutingDuckFactory());

            Console.WriteLine("========== Composite ==========");
            Console.WriteLine("creates ducks without decorators:");
            SimulateWithComposite(new DuckFactory());
            Console.WriteLine("creates ducks without decorators:");
            SimulateWithComposite(new CoutingDuckFactory());

            Console.WriteLine("========== Observer ==========");
            Console.WriteLine("creates ducks without decorators:");
            SimulateWithObserver(new DuckFactory());
            Console.WriteLine("creates ducks without decorators:");
            SimulateWithObserver(new CoutingDuckFactory());
        }

        private static void SimulateDucks()
        {
            Console.WriteLine("Duck Simulator");

            var mallardDuck = new MallardDuck();
            var redheadDuck = new RedheadDuck();
            var duckCall = new DuckCall();
            var rubberDuck = new RubberDuck();

            Simulate(mallardDuck);
            Simulate(redheadDuck);
            Simulate(duckCall);
            Simulate(rubberDuck);
        }

        private static void Simulate(IQuackable duck)
        {
            duck.Quack();
        }

        private static void SimulateWithDecorator()
        {
            Console.WriteLine("Duck Simulator: With Composite - Flocks");

            new QuackCounter(new MallardDuck());
            new QuackCounter(new RedheadDuck());
            new QuackCounter(new DuckCall());
            new QuackCounter(new RubberDuck());

            Console.WriteLine($"The ducks quacked {QuackCounter.GetQuacks()} times");
        }

        private static void SimulateWithAbstractFactory(AbstractDuckFactory duckFactory)
        {
            Console.WriteLine("Duck Simulator: With Abstract Factory");

            duckFactory.CreateMallardDuck();
            duckFactory.CreateRedheadDuck();
            duckFactory.CreateDuckCall();
            duckFactory.CreateRubberDuck();

            var goose = new Goose();
            duckFactory.CreateGooseDuck(goose);
        }

        private static void SimulateWithComposite(AbstractDuckFactory duckFactory)
        {
            Console.WriteLine("Duck Simulator: With Composite");

            var goose = new Goose();

            var flockOfDucks = new Flock();
            flockOfDucks.Add(duckFactory.CreateMallardDuck());
            flockOfDucks.Add(duckFactory.CreateDuckCall());
            flockOfDucks.Add(duckFactory.CreateRedheadDuck());
            flockOfDucks.Add(duckFactory.CreateRubberDuck());
            flockOfDucks.Add(duckFactory.CreateGooseDuck(goose));

            Simulate(flockOfDucks);
        }

        private static void SimulateWithObserver(AbstractDuckFactory duckFactory)
        {
            Console.WriteLine("Duck Simulator: With Observer");

            var goose = new Goose();

            var flockOfDucks = new Flock();
            flockOfDucks.Add(duckFactory.CreateMallardDuck());
            flockOfDucks.Add(duckFactory.CreateDuckCall());
            flockOfDucks.Add(duckFactory.CreateRedheadDuck());
            flockOfDucks.Add(duckFactory.CreateRubberDuck());
            flockOfDucks.Add(duckFactory.CreateGooseDuck(goose));

            IObserver quackologist = new Quackologist();
            quackologist.Subscribe(flockOfDucks);

            Simulate(flockOfDucks);
        }
    }
}