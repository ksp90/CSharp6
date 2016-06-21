using static System.Console;

namespace CSharp_6._0
{
    class StaticImport
    {
        public void Foo()
        {
            //old
            //Console.WriteLine("We have to import System namespace");
            //now
            WriteLine("We have import System.Console static class");
        }
    }
}
