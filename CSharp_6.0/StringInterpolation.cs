using System;

namespace CSharp_6._0
{
    class StringInterpolation
    {
        public void Foo()
        {
            string name = "TestName";
            int age = 20;
            //un-readable style
            Console.WriteLine(name+" is "+age+" years old");
            //old
            Console.WriteLine(string.Format("{0} is {1} years old",name,age));
            //now
            Console.WriteLine($"{name} is {age} year old");
            //even formatting of text is also possible in string interpolation
            Console.WriteLine($"{name,20} is {age:D3} year old");
        }
    }
}
