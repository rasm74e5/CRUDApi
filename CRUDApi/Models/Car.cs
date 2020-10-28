using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDApi.Models
{
    public class Car
    {
        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string Colour
        {
            get;
            set;
        }
        public double Price
        {
            get;
            set;
        }
    }
}
