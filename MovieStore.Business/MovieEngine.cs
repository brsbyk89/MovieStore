using MovieStore.Business.Contract;
using MovieStore.Business.Entities;
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
        [Import]
        private IDataRepositoryFactory _dataRepositoryFactory;

        public int Add()
        {
            var movie = new Movie() { Id = 1, Name = "Test",CreationDate=DateTime.Now,LastModifyDate =DateTime.Now };
            _dataRepositoryFactory.GetDataRepository<IMovieRepository>().Create(movie);

            return 0;
        }
    }
}
