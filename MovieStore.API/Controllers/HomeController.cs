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
    public class HomeController : BaseController
    {

        [Import]
        private IBusinessEngineFactory businessEngine;

        //[Import]
        //private IMovieEngine businessEngine;

        public int Index()
        {
            //var d =  ObjectBase.Container.GetExportedValue<IMovieEngine>();
            // d.Add();
            var engine = businessEngine.GetBusinessEngine<IMovieEngine>();
            engine.Add();

            return 0;
        }
    }
}
