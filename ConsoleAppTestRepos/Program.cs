using AdresbeheerDatalayerProvider;
using AdresbeheerDomain.Model;
using System.Configuration;

namespace ConsoleAppTestRepos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string dataLayer = ConfigurationManager.AppSettings["DataLayer"];
            string connectionString = ConfigurationManager.ConnectionStrings["EFconnection"].ConnectionString;

            AdresbeheerRepositories repos=null;
            switch (dataLayer)
            {
                case "EFCore": repos = AdresbeheerDatalayerFactory.GeefRepositories(connectionString, RepositoryType.EFCore); break;
                case "ADO": repos = AdresbeheerDatalayerFactory.GeefRepositories(connectionString, RepositoryType.ADO); break;
            }
            Gemeente g = new Gemeente(20089, "Brugge");
            Straat s=new Straat("Rozenstraat",g);
            repos.StraatRepository.VoegStraatToe(s);
            //repos.GemeenteRepository.VoegGemeenteToe(g);
            //g = new Gemeente(20005, "Waregem");
            //var x = repos.GemeenteRepository.GeefGemeente(20009);
            ////repos.GemeenteRepository.VerwijderGemeente(20007);
            //x.ZetGemeentenaam("Gr Gent");
            //repos.GemeenteRepository.UpdateGemeente(x);
            //x.ZetGemeentenaam("Klein Gent");
            //repos.GemeenteRepository.UpdateGemeente(x);
        }
    }
}
