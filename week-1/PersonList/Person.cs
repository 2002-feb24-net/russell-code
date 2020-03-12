using System;

namespace PersonList
{
    class Person
    {
        string Name;
        string PhoneNumber;
        public Person(string name, string phone)
        {
            Name = name;
            PhoneNumber = phone;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
