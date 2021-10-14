using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gradinaru_Alexandra_Lab2.Models
{
    public class Customer
    {
        //permite introducerea cheii primare 
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }
        public String Name { get; set; }
        public String Adress { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Order> Orders { get; set; }
        //relationarea cu proprietatea Order
    }
}
