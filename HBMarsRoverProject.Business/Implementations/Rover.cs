using System;
using HBMarsRoverProject.Business.Abstracts; 
using HBMarsRoverProject.Entity;

namespace HBMarsRoverProject.Business.Implementations
{
    public class Rover:IRover
    { 
        public Rover() { }
        public Rover(int x,int y,string direction)
        {
            CurrentCoordinate = new Coordinate(x, y, direction);
        
        }

        public Coordinate CurrentCoordinate { get; private set; }

        public void Command(char command)
        {
            if (command == 'M')
            {
                Move();
            }
            else if(command=='L')
            {
                Turn(EnumRotation.Left);
            }
            else if (command == 'R')
            {
                Turn(EnumRotation.Right);
            }
 
        }

        public void Reset()
        {
            CurrentCoordinate.X = 0;
            CurrentCoordinate.Y = 0;
            CurrentCoordinate.Direction = EnumDirection.N;
        }

        public void Move()
        {
            switch (CurrentCoordinate.Direction)
            {
                case EnumDirection.N:
                    CurrentCoordinate.Y++;
                    break;
                case EnumDirection.E:
                    CurrentCoordinate.X++;
                    break;
                case EnumDirection.S:
                    CurrentCoordinate.Y--;
                    break;
                case EnumDirection.W:
                    CurrentCoordinate.X--;
                    break;
                default:
                    break;
            }
             
        }

        public void Relocation(Coordinate coordinate)
        {
            CurrentCoordinate = coordinate;
             
             
        }

        public void Turn(EnumRotation rotation)
        {
            int currentPosition = (int)CurrentCoordinate.Direction;

            switch (rotation)
            {
                case EnumRotation.Left:
                    currentPosition--;
                    if (currentPosition < 1)
                        currentPosition = 4;
                    break;
                case EnumRotation.Right:
                    currentPosition++;
                    if (currentPosition > 4)
                        currentPosition = 1;
                    break;
                default:
                    currentPosition = 1;
                    break;
            }

            CurrentCoordinate.Direction = (EnumDirection)currentPosition;
              
        }

   
    }
}
