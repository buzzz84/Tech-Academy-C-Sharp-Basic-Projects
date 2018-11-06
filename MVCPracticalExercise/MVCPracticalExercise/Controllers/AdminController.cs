using MVCPracticalExercise.Models;
using MVCPracticalExercise.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPracticalExercise.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (QuoteEntities db = new QuoteEntities())
            {
                
                var quotes = (from c in db.Quotes
                              select c).ToList();
                var VmQuotes = new List<VmQuote>();
                foreach (var quote in quotes)
                {
                    var VmQuote = new VmQuote();
                    VmQuote.Id = quote.Id;
                    VmQuote.FirstName = quote.FirstName;
                    VmQuote.LastName = quote.LastName;
                    VmQuote.EmailAddress = quote.EmailAddress;
                    VmQuote.FinalQuote = quote.FinalQuote;
                    VmQuotes.Add(VmQuote);
                }
                return View(VmQuotes);
            }
        }
    }
}