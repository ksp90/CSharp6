namespace CSharp_6._0
{
    class AutoPropertyInitializer
    {
        public int TestProperty { get; set; } = 1;
    }

    class AutoPropertyInitializerOldStyle
    {
        public int TestProperty { get; set; }

        public AutoPropertyInitializerOldStyle()
        {
            TestProperty = 1;
        }
    }
}
