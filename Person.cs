using System;
using System.Collections.Generic;
using System.Text;

namespace Right
{
    public class Person
    {
        private const int MIN_AGE_PERSON = 0;
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name 
        {
            get 
            {
                return this.name;
            }
            private set 
            {                
                this.name = value; 
            } 
        }

        public virtual int Age 
        {
            get 
            {
                return this.age;
            }
            protected set 
            {
                if (value >= MIN_AGE_PERSON)
                {
                    this.age = value;
                }                
            }       
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("Name: {0}, Age: {1}" , this.Name, this.Age));

            return sb.ToString().TrimEnd();
        }
    }
}
