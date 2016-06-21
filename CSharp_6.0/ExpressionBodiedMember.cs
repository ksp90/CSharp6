using System;

namespace CSharp_6._0
{
    class ExpressionBodiedMember
    {
        //expression bodied property
        public string TestProperty => "This is a test property";
        
        //expression bodied method
        public void Print() => Console.WriteLine(TestProperty);
    }
}
