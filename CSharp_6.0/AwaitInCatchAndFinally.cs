using System;
using System.Threading.Tasks;

namespace CSharp_6._0
{
    class AwaitInCatchAndFinally
    {
        public async Task Foo()
        {
            try
            {
                await Bar();
            }
            catch (Exception ex)
            {
                await LogError(ex.Message);
            }
            finally
            {
                await CleanUpResource();
            }
        }

        private async Task Bar()
        {
            Console.WriteLine("Executing some task");
            await Task.Delay(500);
            throw new ApplicationException("Task execution error");
        }

        private async Task LogError(string msg)
        {
            Console.WriteLine("Logged : " + msg);
            await Task.Delay(500);
        }

        private async Task CleanUpResource()
        {
            Console.WriteLine("Clean up");
            await Task.Delay(500);
        }
    }
}
