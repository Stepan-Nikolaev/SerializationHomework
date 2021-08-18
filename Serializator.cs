using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace SerializationHomework
{
    public class Serializator
    {
        public string GetSerializedListFigure(List<Figure> figures)
        {
            return JsonConvert.SerializeObject(figures);
        }

        public List<Figure> GetDeserializedListFigure(string serializedListFigure)
        {
            return JsonConvert.DeserializeObject<List<Figure>>(serializedListFigure);
        }

        public string GetSerializedObject<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public T GetDeserializedObject<T>(string serializedObject)
        {
            return JsonConvert.DeserializeObject<T>(serializedObject);
        }
    }
}
