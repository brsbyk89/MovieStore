using MovieStore.Data.Contract;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Data
{
    [Export(typeof(IMovieRepository))]
    public class MovieRepository : IMovieRepository
    {
        public int Add()
        {
            var dummy = 10;

            return dummy;
        }


    }
}
