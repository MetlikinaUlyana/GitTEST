using System;

namespace MetanitStrings
{
    // определение класса Person
    public class Person 
    {
        public Person()
        {
        }
        
        public Person(string name, int age)
        {
            _age = age;
            _name = name;
        }

        private string _name = "Undefined";
        private readonly int _age;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        public int Age { get; set; }
     
        public void Print()
        {
            Console.WriteLine($"Имя: {_name}  Возраст: {_age}");
        }
        
        public void Print2()
        {
            Console.WriteLine($"Имя: {Name}  Возраст: {Age}");
        }
    }
}