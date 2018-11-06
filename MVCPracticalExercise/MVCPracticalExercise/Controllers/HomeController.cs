using MVCPracticalExercise;
using MVCPracticalExercise.Models;
using MVCPracticalExercise.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPracticalExercise.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Quote(string firstName, string lastName, string emailAddress, DateTime DateOfBirth, string CarYear,
            string CarMake, string CarModel, bool DUI, string Tickets, bool Full)
        {
            
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (QuoteEntities db = new QuoteEntities())
                {
                    var quote = new Quote();
                    quote.FirstName = firstName;
                    quote.LastName = lastName;
                    quote.EmailAddress = emailAddress;
                    var today = DateTime.Today;
                    var age = today.Year - DateOfBirth.Year;
                    if (DateOfBirth > today.AddYears(-age)) --age;
                    quote.StartingTotal = 50;
                    if (age <= 18) quote.StartingTotal = quote.StartingTotal + 100;
                    if (age <= 25 && age >= 19) quote.StartingTotal = quote.StartingTotal + 25;
                    if (age >= 100) quote.StartingTotal = quote.StartingTotal + 25;
                    int carYear = Convert.ToInt32(CarYear);
                    if (carYear <= 1999) quote.StartingTotal = quote.StartingTotal + 25;
                    if (carYear >= 2015) quote.StartingTotal = quote.StartingTotal + 25;
                    if (CarMake == "Porsche") quote.StartingTotal = quote.StartingTotal + 25;
                    if (CarMake == "Porsche" && CarModel == "911 Carrera") quote.StartingTotal = quote.StartingTotal + 25;
                    int tickets = Convert.ToInt32(Tickets);
                    tickets = tickets * 10;
                    quote.FinalQuote = quote.StartingTotal + tickets;
                    int dui = Convert.ToInt32(1.25);
                    int coverage = Convert.ToInt32(1.5);
                    if (DUI == true) quote.FinalQuote = quote.FinalQuote * dui;
                    if (Full == true) quote.FinalQuote = quote.FinalQuote * coverage;
                    ViewBag.finalQuote = quote.FinalQuote;
                    int FinalQuote = quote.FinalQuote;

                    db.Quotes.Add(quote);
                    db.SaveChanges();
                }
                
                return View("Index");
            }
        }
        public ActionResult VmQuote()
        {
            using (QuoteEntities db = new QuoteEntities())
            {
                var quotes = db.Quotes;
                var VmQuotes = new List<VmQuote>
                ();
                foreach (var quote in quotes)
                {
                    var VmQuote = new VmQuote();
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