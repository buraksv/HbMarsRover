using HBMarsRoverProject.Entity;

namespace HBMarsRoverProject.Business.Abstracts
{
    public interface IPlateau
    {
        Dimension CurrentDimension { get; }

        void Resize(int x,int y);
    }
}
