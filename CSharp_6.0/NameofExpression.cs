using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CSharp_6._0
{
    class NameofExpression
    {
        public int SomeProperty { get; set; }
        public void Foo()
        {
            try
            {
                internalFoo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void internalFoo()
        {
            if (SomeProperty==0)
            {
                //old
                //this style leads to hardcoding of data.
                //throw new ArgumentException(string.Format("{0} is zero", "SomeProperty"));
                //now
                throw new ArgumentException(string.Format("{0} is zero", nameof(SomeProperty)));
            }
        }
    }

    class TestModel : BindableBase
    {
        private string _TestProperty;

        public string TestProperty
        {
            get
            {
                return _TestProperty;
            }

            set
            {
                //old
                //SetProperty(ref _TestProperty, value, "TestProperty");
                
                //now
                //SetProperty(ref _TestProperty, value, nameof(TestProperty));
                
                //using caller member information
                SetProperty(ref _TestProperty, value);
            }
        }
    }

    class BindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void SetProperty(ref string storage, string value, [CallerMemberName] string propertyName = null)
        {
            storage = value;
            RaiseChange(propertyName);
        }

        private void RaiseChange(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
