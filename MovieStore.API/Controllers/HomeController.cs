using MovieStore.Business;
using MovieStore.Business.Contract;
using MovieStore.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieStore.API.Controllers
{
    public class HomeController : Controller
    {
        [Import]
        private IMovieEngine movieEngine;

        public int Index()
        {
            var d = MEFLoader.Container.SatisfyImportsOnce(this);
            var k = MEFLoader.Container.GetExportedValue<IMovieEngine>();
            k.Add();
            return 0;
        }
    }
}
