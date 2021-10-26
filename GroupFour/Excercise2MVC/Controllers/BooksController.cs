using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Excercise2MVC.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;

namespace Excercise2MVC.Controllers {
    public class BooksController : ApiController {

        [HttpGet]
        public HttpResponseMessage Get(DataSourceLoadOptions loadOptions) {
            return Request.CreateResponse(DataSourceLoader.Load(SampleData.Books, loadOptions));
        }

        public string Index()
        {
            return "This is Index action method of BookController";
        }

        [NonAction]
        public Book GetBookByName (string name)
        {
            return SampleData.Books.Where(s => s.BookName.Contains(name)).FirstOrDefault();
        }

        [NonAction]
        public Book GetBookByID(string id)
        {
            return SampleData.Books.Where(s => s.BookID.Contains(id)).FirstOrDefault();
        }

    }
}