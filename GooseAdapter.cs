using DuckReunion.Ducks;
using DuckReunion.Interfaces;

namespace DuckReunion
{
    public class GooseAdapter : IQuackable
    {
        private readonly Goose _goose;
        public GooseAdapter(Goose goose)
        {
            _goose = goose;
        }
        public void Quack()
        {
            _goose.Honk();
        }
    }
}
