using MarsRover.Business.Concrete;
using System;
using static MarsRover.Business.Enum.Enums;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            string testInput= "Test Input:\n5 5\n1 2 N\nLMLMLMLMM\n3 3E\nMMRMMRMRRM\n";
            Console.WriteLine(testInput);
            Plateau plateau = new Plateau(new Position(5, 5));
            Rover first = new Rover(plateau, new Position(1, 2), Commands.N);
            var firstOutput = first.Start("LMLMLMLMM");
            Rover second = new Rover(plateau, new Position(3, 3), Commands.E);
            var secondOutput = second.Start("MMRMMRMRRM");
            string expectedOutput = "Expected Output:\n" + firstOutput + "\n" + secondOutput;
            Console.WriteLine(expectedOutput);
            Console.ReadLine();

        }
    }
}
