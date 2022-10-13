

namespace Interface
{
    public interface IRectangle
    {
        int Length { get; set; }
         int Width { get; set; }
         void GetData(int length,int width);
         void CalcualteArea();
    }
}