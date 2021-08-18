using SerializationHomework.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SerializationHomework
{
    public class Generator
    {
        public List<Figure> GetListFigure(int listLength)
        {
            List<Figure> figures = new List<Figure>();

            for (int i = 0; i < listLength; i++)
            {
                figures.Add(new Figure() { Name = $"{i}", SideCount = i, SideLength = i });
            }

            return figures;
        }

        public FigureContainer GetFigureContainer(int keyGeneration)
        {
            Figure triangle = new Figure() { Name = $"{keyGeneration}", SideCount = keyGeneration, SideLength = keyGeneration };
            Figure square = new Figure() { Name = $"{keyGeneration}", SideCount = keyGeneration, SideLength = keyGeneration };
            Figure trapezoid = new Figure() { Name = $"{keyGeneration}", SideCount = keyGeneration, SideLength = keyGeneration };

            return new FigureContainer() { Square = square, Triangle = triangle, Trapezoid = trapezoid };
        }
    }
}
