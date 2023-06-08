using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace LineComparisionProblem
{
    internal class LineComputation
    {

        int X_One;
        int X_Two;
        int Y_One;
        int Y_Two;
        int S_One;
        int S_Two;
        int R_One;
        int R_Two;
        double LengthOfXY;
        double LengthOfSR;
        public void LenghtOfLine()
        {
            Console.WriteLine("Enter x, y  co ordinate of line 1");
            Console.WriteLine("Enter value X_one");
            X_One = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value X_Two");
            X_Two = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value Y_One");
            Y_One = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value Y_Two");
            Y_Two = Convert.ToInt32(Console.ReadLine());

            //coordinates 2
            Console.WriteLine("Enter x, y co ordinates of the line 2 :");
            Console.WriteLine("Enter value of S_One");
            S_One = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of S_Two");
            S_Two = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value R_One");
            R_One = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value R_Two");
            R_Two = Convert.ToInt32(Console.ReadLine());

            //calculate value XY

            LengthOfXY = Math.Sqrt(Math.Pow((X_Two - X_One), 2) + Math.Pow((Y_Two - Y_One), 2));
            Console.WriteLine("Length of Value 1 is:: " + LengthOfXY);
            //Calculating value of SR
            double LengthOfSR = Math.Sqrt(Math.Pow((S_Two - S_One), 2) + Math.Pow((R_Two - R_One), 2));
            Console.WriteLine("Length of Value 2 is: " + LengthOfSR);
        }
    }
        

    
}
