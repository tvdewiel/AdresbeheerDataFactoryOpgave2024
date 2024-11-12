using AdresbeheerEFlayer;

namespace ConsoleAppTestDBModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string connectionString = @"Data Source=NB21-6CDPYD3\SQLEXPRESS;Initial Catalog=AdresbeheerEF;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            AdresbeheerContext ctx=new AdresbeheerContext(connectionString);
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();
        }
    }
}
