namespace CSharp_6._0
{
    class GetterOnlyAutoProperty
    {
        public int TestProperty { get; } = 1;
        public int TestProperty1 { get; private set; } = 2;
        public int TestProperty2 { get; protected set; } = 3;
        //public GetterOnlyAutoProperty()
        //{
        //    TestProperty = 0;
        //}
    }
}
