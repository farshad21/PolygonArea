using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonArea
{
    class Calculate
    {
        public static double CalculatePolygonArea(double[,] vertices, int numVertices)
        {
            double area = 0;

            // Shoelace formula
            for (int i = 0; i < numVertices - 1; i++)
            {
                area += vertices[i, 0] * vertices[i + 1, 1];
                area -= vertices[i + 1, 0] * vertices[i, 1];
            }

            // Add the last vertex back to the first vertex
            area += vertices[numVertices - 1, 0] * vertices[0, 1];
            area -= vertices[0, 0] * vertices[numVertices - 1, 1];

            area = Math.Abs(area) / 2.0;

            return area;

        }
    }
}
