using System;

namespace CSharp_6._0
{
    class ExceptionFilter
    {
        public void Foo()
        {
            try
            {
                Bar();
            }
            catch (Exception ex) when (ex.InnerException != null)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// This method may fail and throw exception
        /// </summary>
        private void Bar()
        {
            throw new ApplicationException("This is test exception",new ArgumentException("Test argument exception"));
            //throw new ApplicationException("This is test exception", null);
            //throw new ApplicationException();
        }
    }
}
