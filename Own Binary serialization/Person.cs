using System;
using System.Runtime.Serialization;

namespace Own_Binary_serialization
{
    [Serializable]
    public class Person : ISerializable
    {
        public Person()
        {
        }

        public Person(SerializationInfo info, StreamingContext context)
        {
            _name = (string)info.GetValue("name", typeof(string));
            _age = (int)info.GetValue("age", typeof(int));
        }

        private string _name;
        private int _age;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("name", _name, typeof(string));
            info.AddValue("age", _age, typeof(int));
        }
    }
}
