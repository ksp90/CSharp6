namespace CSharp_6._0
{
    class ConstructorAssignmentGetterProperty
    {
        public int TestProperty { get;} = 1;
        public int TestProperty1 { get; }

        public ConstructorAssignmentGetterProperty()
        {
            TestProperty1 = 2;
        }
    }
}
