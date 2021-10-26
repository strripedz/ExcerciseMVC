using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2MVC.Models {
    public class Book {
        public string BookID { get; set; }
        public string CustomerID { get; set; }
        public string BookName { get; set; }
        public bool ReserveStatus { get; set; }
        public int BookingNo { get; set; }
    }
}
