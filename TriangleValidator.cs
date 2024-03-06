
using System.Security.Policy;

namespace TriangleSolver
{
    public class TriangleValidator
    {
        public string ValidateTriangle(int sideOne, int sideTwo, int sideThree)
        {
            if ((sideOne == 0) || (sideTwo == 0) || (sideThree == 0))
            {
                return "Invalid Triangle - a zero has been detected";
                 
            }
            if (((sideOne + sideTwo) > sideThree) && ((sideOne + sideThree) > sideTwo) && ((sideTwo + sideThree) > sideOne))
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
                else
                {
                    return "Scalene Triangle";
                }
            }
            else
            {
                return "Invalid Response";
            }

        }
    }
}