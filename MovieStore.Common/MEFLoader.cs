using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Common
{
    public static class MEFLoader
    {
        private static CompositionContainer container;

        public static CompositionContainer Container
        {
            get
            {
                if (container == null)
                {
                    var catalog = new AggregateCatalog();
                    catalog.Catalogs.Add(new AssemblyCatalog(@"D:\Lab\MovieStore.Business\bin\Debug\MovieStore.Business.dll"));
                    //var catalog = new AssemblyCatalog(@"D:\Lab");
                    container = new CompositionContainer(catalog);

                    //AssemblyCatalog catalog = new AssemblyCatalog(System.Reflection.Assembly.GetExecutingAssembly());
                    //container = new CompositionContainer(catalog);

                }
                return container;
            }
        }
    }
}
