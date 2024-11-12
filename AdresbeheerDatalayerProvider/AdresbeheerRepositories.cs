using AdresbeheerADOlayer.Repositories;
using AdresbeheerDomain.Interfaces;
using AdresbeheerEFlayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdresbeheerDatalayerProvider
{
    public class AdresbeheerRepositories
    {
        public IAdresRepository AdresRepository { get; }
        public IStraatRepository StraatRepository { get; }
        public IGemeenteRepository GemeenteRepository { get; }
        public AdresbeheerRepositories(string connectionsString,RepositoryType repositoryType)
        {
            try
            {
                switch (repositoryType)
                {
                    case RepositoryType.ADO: 
                        GemeenteRepository=new GemeenteRepositoryADO(connectionsString);
                        StraatRepository=new StraatRepositoryADO(connectionsString);
                        AdresRepository=new AdresRepositoryADO(connectionsString);
                        break;
                    case RepositoryType.EFCore:
                        GemeenteRepository = new GemeenteRepositoryEF(connectionsString);
                        StraatRepository = new StraatRepositoryEF(connectionsString);
                        AdresRepository = new AdresRepositoryEF(connectionsString);
                        break;
                    default: throw new Exception();
                }
            }
            catch (Exception ex) { throw; }
        }
    }
}
