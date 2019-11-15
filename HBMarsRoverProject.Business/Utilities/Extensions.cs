using System;
using System.Collections.Generic;
using System.Text;
using HBMarsRoverProject.Business.Abstracts;
using HBMarsRoverProject.Business.Implementations;
using HBMarsRoverProject.Entity;

namespace HBMarsRoverProject.Business.Utilities
{
    public static class Extensions
    {
        public static List<Rover> Run(this List<Input> roverList,IPlateau plateau)
        {
            List<Rover> returnList = new List<Rover>();

            foreach (var item in roverList)
            {

                Rover rover = new Rover(plateau);

                rover.Relocation(item.Coordinates);

                foreach (var command in item.Directions)
                {
                    rover.Command(command);
                }

                returnList.Add(rover);

            }

            return returnList;
        }

        public static string Run(this Input input,IPlateau plateau)
        {

            Rover rover = new Rover(plateau);

            rover.Relocation(input.Coordinates);

            foreach (var command in input.Directions)
            {
                rover.Command(command);
            }

            return $"{rover}";


        }

        public static void Reset(this List<Rover> rovers)
        {
            foreach (var item in rovers)
            {
                item.Reset();
            }
        }
    }
}
