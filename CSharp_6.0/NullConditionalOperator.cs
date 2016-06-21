using System.Collections.Generic;

namespace CSharp_6._0
{
    class NullConditionalOperator
    {
        public void Foo()
        {
            Foo f = new Foo();
            //old
            string result;
            if (f.Bar != null)
                result = f.Bar.SomeProperty;
            //now
            //string result = f.Bar?.SomeProperty;

            List<int> someList = GetSomeList();
            int res = someList[0];
            //int? res = someList?[0];
        }

        private List<int> GetSomeList() => null;
    }

    class Foo
    {
        public Bar Bar { get; set; }
    }

    class Bar
    {
        public string SomeProperty { get; set; }
    }
}
