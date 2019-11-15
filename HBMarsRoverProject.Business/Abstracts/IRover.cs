using HBMarsRoverProject.Entity;

namespace HBMarsRoverProject.Business.Abstracts
{
    public interface IRover
    {
        void Relocation(Coordinate coordinate);
        void TurnLeft();
        void TurnRight();
        void Move();
        void Command(char command);
        void Reset();
    }
}
