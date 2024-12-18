using DuckReunion.Ducks;
using DuckReunion.Interfaces;

namespace DuckReunion
{
    public class CoutingDuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateDuckCall()
        {
            return new QuackCounter(new DuckCall());
        }

        public override IQuackable CreateGooseDuck(Goose goose)
        {
            return new QuackCounter(new GooseAdapter(goose));
        }

        public override IQuackable CreateMallardDuck()
        {
            return new QuackCounter(new MallardDuck());
        }

        public override IQuackable CreateRedheadDuck()
        {
            return new QuackCounter(new RedheadDuck());
        }

        public override IQuackable CreateRubberDuck()
        {
            return new QuackCounter(new RubberDuck());
        }
    }
}
