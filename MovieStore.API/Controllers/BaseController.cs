using MovieStore.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace MovieStore.API.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {
            if(ObjectBase.Container!=null)
            {
                ObjectBase.Container.SatisfyImportsOnce(this);
            }
        }

    }
}
