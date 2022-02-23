#pragma warning disable SYSLIB0011

using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Own_Binary_serialization
{
    public static class Program
    {
        static void Main()
        {
            string fileName = "dataStuff.myData";

            IFormatter formatter = new BinaryFormatter();

            SerializeItem(fileName, formatter);
            DeserializeItem(fileName, formatter);
        }

        public static void SerializeItem(string fileName, IFormatter formatter)
        {
            Person person = new Person();
            person.Name = "Ivan";
            person.Age = 30;

            FileStream s = new FileStream(fileName, FileMode.OpenOrCreate);
            formatter.Serialize(s, person);
            s.Close();
        }

        public static void DeserializeItem(string fileName, IFormatter formatter)
        {
            FileStream s = new FileStream(fileName, FileMode.Open);
            Person person = (Person)formatter.Deserialize(s);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }
    }
}
