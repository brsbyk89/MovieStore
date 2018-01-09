using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Business.Entities
{
    public class Movie : ModelBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
