using MarsRover.Business.Abstract;

namespace MarsRover.Business.Concrete
{
    public class Plateau : IPlateau
    {
        public Position Position { get; private set; }

        public Plateau(Position position)
        {
            Position = position;
        }
    }
}
