﻿using System;

namespace ExerciseSolution
{
    class Program
    {
        public static void Main()
        {
            // Get a polygon from the method.
            Polygon poly = CreatePolygon();
            Console.WriteLine("The area of this polygon is " + poly.Area + ".");

            double distance = poly.Vertices[0].calculateEuclideanDistanceTo(poly.Vertices[2]);
            Console.WriteLine("The distance between the first and the third point is " + distance + ".");

            Console.ReadLine();
        }

        public static Polygon CreatePolygon()
        {
            // Read the number of vertices of the polygon.
            Console.WriteLine("How many vertices:");
            string vertexCountString = Console.ReadLine();
            int vertexCount = int.Parse(vertexCountString);

            // Only continue if there are more than 2 vertices.
            while(vertexCount < 3)
            {
                Console.WriteLine("There are not enough vertex. Please enter a new number:");
                vertexCountString = Console.ReadLine();
                vertexCount = int.Parse(vertexCountString);
            }

            // The arrays of the points.
            Point2D[] vertices = new Point2D[vertexCount];

            Console.WriteLine("Your vertex input:");

            char[] splitChar = { '-' };
            for(int c = 0; c < vertexCount; c++)
            {
                // Get the new input and look if it is a correct input.
                string inputString = Console.ReadLine();
                // Split the string in x and y value and convert them.
                string[] inputValues = inputString.Split(splitChar, StringSplitOptions.RemoveEmptyEntries);
                vertices[c] = new Point2D(int.Parse(inputValues[0]), int.Parse(inputValues[1]));
            }

            return new Polygon(vertices);
        }
    }
}
