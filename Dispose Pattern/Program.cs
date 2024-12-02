namespace Dispose_Pattern
{
    namespace Dispose
    {
        class Product : IDisposable
        {


            private bool disposed = false;
            public int Id { get; set; }
            public string? Name { get; set; }
            public decimal Price { get; set; }

            ~Product() // called automatically by the GC
            {
                //destruct unmanaged resources

                // Never remove managed resources in the finalizer

                Dispose(false);
            }
            private void Dispose(bool disposing)
            {
                if (disposing)
                {
                    //dispose managed resources
                }

                //dispose unmanaged resources 
            }
            public void Dispose() //called manualy by the user
            {
                if (!disposed)
                {
                    //dispose managed resources

                    //dispose unmanaged resources 

                    Dispose(true);
                    GC.SuppressFinalize(this);
                    disposed = true;
                }
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Dispose");
            }
        }
    }
}
