using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gradinaru_Alexandra_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
        public String Title { get; set; }
        public String Author { get; set; }
        public decimal Price { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
