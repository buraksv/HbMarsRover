using HBMarsRoverProject.Entity;

namespace HBMarsRoverProject.Business.Abstracts
{
    public interface IRover
    {
        void Relocation(Coordinate coordinate);
        void Turn(EnumRotation roration);
        void Move();
        void Command(char command);
        void Reset();
    }
}
