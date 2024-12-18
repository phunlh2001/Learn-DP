using DuckReunion.Ducks;
using DuckReunion.Interfaces;

namespace DuckReunion
{
    public class DuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateDuckCall()
        {
            return new DuckCall();
        }

        public override IQuackable CreateGooseDuck(Goose goose)
        {
            return new GooseAdapter(goose);
        }

        public override IQuackable CreateMallardDuck()
        {
            return new MallardDuck();
        }

        public override IQuackable CreateRedheadDuck()
        {
            return new RedheadDuck();
        }

        public override IQuackable CreateRubberDuck()
        {
            return new RubberDuck();
        }
    }
}
