using MovieStore.Business;
using MovieStore.Common;
using MovieStore.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Bootstrapper
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
                    //catalog.Catalogs.Add(new AssemblyCatalog(@"D:\Lab\MovieStore.Business\bin\Debug\MovieStore.Business.dll"));
                    //catalog.Catalogs.Add(new AssemblyCatalog(@"D:\Lab\MovieStore.Business\bin\Debug\MovieStore.Business.dll"));

                    catalog.Catalogs.Add(new AssemblyCatalog(typeof(MovieEngine).Assembly));
                    catalog.Catalogs.Add(new AssemblyCatalog(typeof(MovieRepository).Assembly));

                    //var catalog = new AssemblyCatalog(@"D:\Lab");
                    //container = new CompositionContainer(catalog);

                    //AssemblyCatalog catalog = new AssemblyCatalog(System.Reflection.Assembly.GetExecutingAssembly());
                    container = new CompositionContainer(catalog);
                }
                return container;
            }
        }


        public static void Init()
        {
            ObjectBase.Container = MEFLoader.Container;
        }
    }
}
