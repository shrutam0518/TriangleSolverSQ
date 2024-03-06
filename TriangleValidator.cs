
namespace TriangleSolver
{
    public class TriangleValidator
    {
        public string ValidateTriangle(int sideOne, int sideTwo, int sideThree)
        {
            //rule for equilateral triangle
            if (sideOne == sideTwo && sideTwo == sideThree)
            {
                return "Equilateral Triangle";
            }
            //rule for isosceles  triangles
            if (sideOne == sideTwo || sideOne == sideThree || sideTwo == sideThree)
            {
                return "Isosceles Triangle";
            }
            return "Invalid Response";
        }
    }
}