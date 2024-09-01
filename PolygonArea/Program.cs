using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonArea
{
    class Program
    {
        public static void Main()
        {
            // Define the vertices of the polygon
            double[,] vertices = {
            {2, 4},
            {4, 8},
            {6, 6},
            {8, 4},
            {4, 2}
            };

            int numVertices = vertices.GetLength(0);
            double area = Calculate.CalculatePolygonArea(vertices, numVertices);
            Console.WriteLine(area);

            Console.ReadKey();
        }
    }
}
