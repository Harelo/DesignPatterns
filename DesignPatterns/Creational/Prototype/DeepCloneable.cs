using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DesignPatterns.Prototype
{
    [Serializable]
    public class DeepCloneable<T>
    {
        public static T DeepClone(T obj)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;

                return (T)formatter.Deserialize(ms);
            }
        }
    }
}
