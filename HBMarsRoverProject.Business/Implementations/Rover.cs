using System;
using HBMarsRoverProject.Business.Abstracts;
using HBMarsRoverProject.Entity;

namespace HBMarsRoverProject.Business.Implementations
{
    public class Rover : IRover
    {
        private readonly IPlateau _plateau;

        public Rover(IPlateau plateau)
        {
            _plateau = plateau;

        }
        public Rover(IPlateau plateau, int x, int y, string direction)
        {
            CurrentCoordinate = new Coordinate(x, y, direction);
            _plateau = plateau;

        }

        public Coordinate CurrentCoordinate { get; private set; }

        public bool IsInBoundaries
        {
            get => CurrentCoordinate.X <= _plateau.CurrentDimension.X && CurrentCoordinate.Y <= _plateau.CurrentDimension.Y;
        }

        public void Command(char command)
        {
            switch (command)
            {
                case 'M':
                    Move();

                    break;

                case 'L':
                    TurnLeft();
                    break;
                case 'R':
                    TurnRight();

                    break;
                default:
                    throw new ArgumentException($"Invalid Command"); 
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
            }

        }

        public void Relocation(Coordinate coordinate)
        {
            CurrentCoordinate = coordinate;


        }

        public void TurnLeft()
        {
            int currentPosition = (int)CurrentCoordinate.Direction;

            currentPosition--;
            if (currentPosition < 1)
                currentPosition = 4;

            CurrentCoordinate.Direction = (EnumDirection)currentPosition;

        }

        public void TurnRight()
        {
            int currentPosition = (int)CurrentCoordinate.Direction;

            currentPosition++;
            if (currentPosition > 4)
                currentPosition = 1;

            CurrentCoordinate.Direction = (EnumDirection)currentPosition;

        }

        public override string ToString()
        {
            string returnCoordinates = $"{CurrentCoordinate.X} {CurrentCoordinate.Y} {CurrentCoordinate.Direction}";

            if (!IsInBoundaries)
                returnCoordinates = $"Rover outside the plateau.Rover current position : {returnCoordinates}. Plateau current limit: {_plateau}";

            return returnCoordinates;
        }
    }
}
