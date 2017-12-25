using MovieStore.Business.Contract;
using MovieStore.Common;
using MovieStore.Data.Contract;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Business
{
    [Export(typeof(IMovieEngine))]
    public class MovieEngine : IMovieEngine
    {
        //[Import]
        //private IMovieRepository movieRepository;

        public int Add()
        {
            //movieRepository = MEFLoader.Container.GetExportedValue<IMovieRepository>();
            //return movieRepository.Add();
            return 0;
        }
    }
}
