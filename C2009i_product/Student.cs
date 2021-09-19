using System;
namespace C2009i_product
{
    public class Student
    {
        public String name;
        public int age;
        //constructor
        public Student(String name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public override string ToString() => $"name = {this.name},age = {this.age}";
       
    }
}

