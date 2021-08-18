using SerializationHomework.Models;
using System;
using System.Collections.Generic;

namespace SerializationHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator generator = new Generator();
            Serializator serializator = new Serializator();

            List<Figure> figures = generator.GetListFigure(100);

            string serializedListFigures = serializator.GetSerializedListFigure(figures);
            List<Figure> newFigures = serializator.GetDeserializedListFigure(serializedListFigures);

            FigureContainer container = generator.GetFigureContainer(26);

            string serializedContainer = serializator.GetSerializedObject<FigureContainer>(container);
            FigureContainer newContainer = serializator.GetDeserializedObject<FigureContainer>(serializedContainer);

            //в случае сериализации обьекта, который содержит ссылку на самого себя возникнет исключение JsonSerializationException.
        }
    }
}
