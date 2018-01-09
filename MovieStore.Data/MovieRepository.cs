using MovieStore.Business.Entities;
using MovieStore.Data.Contract;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Data
{
    [Export(typeof(IMovieRepository))]
    public class MovieRepository : EntityFrameworkRepository<Movie>, IMovieRepository
    {
        public MovieRepository()
        {

        }
        
    }
}
