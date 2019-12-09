using static MarsRover.Business.Enum.Enums;

namespace MarsRover.Business.Abstract
{
    public interface IRover
    {
        IPlateau Plateau { get; set; }
        IPosition Position { get; set; }
        Commands Command { get; set; }
        string Start(string commands);  
    }
}
