using System.Collections.Generic;

namespace CSharp_6._0
{
    class DictionaryInitializer
    {
        public void Foo()
        {
            Dictionary<int, string> testDictionaryOldStyle = new Dictionary<int, string>()
            {
                { 1,"Test data with key 1"},
                { 3,"Test data with key 3"},
                { 5,"Test data with key 5"},
            };

            Dictionary<int, string> testDictionary = new Dictionary<int, string>()
            {
                [1] = "Test data with key 1",
                [3] = "Test data with key 3",
                [5] = "Test data with key 5"
            };
        }
    }
}
