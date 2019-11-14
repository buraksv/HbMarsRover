using System;
using System.Collections.Generic;
using HBMarsRoverProject.Business.Implementations;
using HBMarsRoverProject.Business.Utilities;
using HBMarsRoverProject.Entity;

namespace HbMarsRoverProject.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            if (string.IsNullOrEmpty(args[0]))
            {
                ConsoleKeyInfo cki;

                Plateau plateau = new Plateau();

                plateau.Resize(5, 5);

                Rover rover = new Rover();
                rover.Relocation(new Coordinate(1, 2, "N"));

                do
                {
                    cki = Console.ReadKey();

                    switch (cki.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            rover.Turn(EnumRotation.Left);
                            break;
                        case ConsoleKey.RightArrow:
                            rover.Turn(EnumRotation.Right);
                            break;
                        case ConsoleKey.UpArrow:
                            rover.Move();
                            break;
                        default:
                            break;
                    }

                } while (cki.Key != ConsoleKey.Escape);
            }
            else if (args[0] == "auto")
            {
                int plateauX = 5, plateauY = 5;

                Plateau plateau = new Plateau();


                Console.WriteLine($"{plateauX} {plateauY}");
                Console.WriteLine(" ");


                plateau.Resize(plateauX, plateauY);

                
                var roverList = new List<Input>
                {
                    new Input("1 2 N","LMLMLMLMM"),
                    new Input("3 3 E","MMRMMRMRRM")
                };


                foreach (var item in roverList)
                {
                    Console.WriteLine($"{item.Location}");
                    Console.WriteLine($"{item.Directions}");
                    Console.WriteLine(" ");
                }


                Console.WriteLine("OUTPUT");
                Console.WriteLine("======================");

                foreach (var item in roverList)
                {
                   Console.WriteLine(item.Run());
                }

                  

            }

        }


    }
}
