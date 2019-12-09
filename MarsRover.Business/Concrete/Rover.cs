using MarsRover.Business.Abstract;
using static MarsRover.Business.Enum.Enums;

namespace MarsRover.Business.Concrete
{
    public class Rover : IRover
    {
        public IPlateau Plateau { get; set; }
        public IPosition Position { get; set; }
        public Commands Command { get; set; }

        public Rover(IPlateau plateau, IPosition position, Commands command)
        {
            Plateau = plateau;
            Position = position;
            Command = command;
        }

        public string Start(string commands)
        {
            foreach (var command in commands)
            {
                switch (command)
                {
                    case ('L'):
                        Command = (Command - 1) < Commands.N ? Commands.W : Command - 1;
                        break;
                    case ('R'):
                        Command = (Command + 1) > Commands.W ? Commands.N : Command + 1;
                        break;
                    case ('M'):
                        switch (Command)
                        {
                            case Commands.N:
                                Position.Y++;
                                break;
                            case Commands.E:
                                Position.X++;
                                break;
                            case Commands.S:
                                Position.Y--;
                                break;
                            case Commands.W:
                                Position.X--;
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
            return string.Format("{0} {1} {2}", Position.X, Position.Y, Command);
        }

    }
}
