using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2MVC.Models {
    static class SampleData {
        public static List<Book> Books = new List<Book>() {
            new Book {
                BookID = "9b0896fa-3880-4c2e-bfd6-925c87f22878",
                CustomerID = "N/A",
                BookName = "CQRS for Dummies",
                ReserveStatus = false,
                BookingNo = 0
            },
            new Book {
                BookID = "0550818d-36ad-4a8d-9c3a-a715bf15de76",
                CustomerID = "N/A",
                BookName = "Visual Studio Tips",
                ReserveStatus = false,
                BookingNo = 0
            },
            new Book {
                BookID = "8e0f11f1-be5c-4dbc-8012-c19ce8cbe8e1",
                CustomerID = "N/A",
                BookName = "NHibernate Cookbook",
                ReserveStatus = false,
                BookingNo = 0
            }
        };
    }
}
