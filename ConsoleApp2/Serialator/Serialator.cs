using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialator
{
    public class Serialator<T> where T : class
    {
        #region Serialize
        public string Serialize(T obj, string path)
        {
            string serializedObj = JsonConvert.SerializeObject(obj);
            File.WriteAllText(path, serializedObj);
            return serializedObj;
        }
        public string Serialize(List<T> listObj, string path)
        {
            string serializedList = JsonConvert.SerializeObject(listObj);
            File.WriteAllText(path, serializedList);
            return serializedList;
        }

        #endregion
        #region Deserialize
        public T Deserialize (string serializedObj)
        {
            return (T)JsonConvert.DeserializeObject<T>(serializedObj);
        }
        public List<T> DeserializeList(string serializedList)
        {
            return (List<T>)JsonConvert.DeserializeObject(serializedList);
        }
        #endregion
        #region Xml
        public void xmlSerialize(T obj, string path)
        {
            XmlSerializer xml = new XmlSerializer(typeof(T));
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                xml.Serialize(stream, obj);
            }
        }
        public T xmlDeserialized(FileStream stream)
        {
            T obj;
            XmlSerializer xml = new XmlSerializer(typeof(T));
            using (stream)
            {
                obj = (T)xml.Deserialize(stream);
            }
            return obj;
        }
        #endregion
    }
}
