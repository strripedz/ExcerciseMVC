using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Excercise2MVC.Models;

namespace Excercise2MVC.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        [HttpPost]
        public ActionResult Search(String nameToFind)
        {
            // Search book by name and return its model
            Book toReturn = null;
            if (ModelState.IsValid)
            {
                List<Book> books = SampleData.Books;
                try
                {
                    toReturn = books.Find(x => x.BookName.Contains(nameToFind));
                }
                catch
                {
                    // Unable to find the book exception to be implemented
                    return View("Unsuccessful");
                }
            }

            if (toReturn == null)
                return View("Unsuccessful");
            else
                return View(toReturn);
        }

        [HttpPost]
        public ActionResult Reserve(FormCollection values, String customerID)
        {
            // Reserve a book by id and customer id
            string bookID = values["BookID"];
            int bookingNumber = checkBookingNo();
            if (ModelState.IsValid)
            {
                List <Book> books = SampleData.Books;
                try
                {
                    // Increment the booking number
                    bookingNumber++;
                    books.Where(w => w.BookID == bookID).ToList().ForEach(s => {
                        s.CustomerID = customerID;
                        s.ReserveStatus = true;
                        s.BookingNo = bookingNumber;
                    });

                    // Use TempData to parse booking number to successful page
                    TempData["BookingNumber"] = bookingNumber;
                }
                catch
                {
                    // Reset booking number to previous number if issue is found
                    bookingNumber--;
                    return View("Unsuccessful");
                }
            }
            return View("Successful", SampleData.Books.Find(x => x.BookName.Contains(bookID)));
        }

        [HttpPost]
        public ActionResult Reset()
        {
            // Reset all the available book information to default
            if (ModelState.IsValid)
            {
                // This will only reset status and customerID within book object
                // This will not reset the booking counter, please re-run the project to reset booking counter
                SampleData.Books.Select(c => { c.ReserveStatus = false; c.CustomerID = "N/A"; return c; }).ToList();
            }

            return View("Index");
        }

        private int checkBookingNo()
        {
            // Return the latest booking number from the list
            return SampleData.Books.Max(t => t.BookingNo);
        }
    }
}