using System;
using HBMarsRoverProject.Business.Abstracts;
using HBMarsRoverProject.Entity;

namespace HBMarsRoverProject.Business.Implementations
{
    public class Plateau : IPlateau
    {

        public Plateau()
        {
            CurrentDimension=new Dimension
            {
                X = 0,
                Y = 0
            };
        }

        public Dimension CurrentDimension { get; }

        public void Resize(int x,int y)
        {
            CurrentDimension.X = x;
            CurrentDimension.Y = y;
             
        }
    }
}
