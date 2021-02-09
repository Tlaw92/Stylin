using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Stylin.Data;
using Stylin.Models;

namespace Stylin.Controllers
{
    public class StylesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StylesController(ApplicationDbContext context)
        {
            _context = context;
        }

        //GET/POST
        //public async Task<>

        // GET: Styles
        public async Task<IActionResult> Index()
        {
            return View();
        }

        //Get Survey Answers from client here


        [HttpPost]

        //[FromBody] attribute is an update in .NET Core to get JSON Data from client
        public  Subscriber Answers([FromBody] Answer answer)
        {
            //set today equal to the current day 
            DateTime today = DateTime.Now;
            //instantiate a deliveryDate variable
            DateTime deliveryDate = new DateTime();
            //set deliverydate to two days after 'today's value
            deliveryDate = today.AddDays(2);
            //Convert DeliveryDate to specified format
            string DeliveryDate = today.ToString("YYYY-MM-dd");
            //set date equal to DeliveryDate variable and use .ToLongDateString() to return string that contains the long date string representation
            string date = deliveryDate.ToLongDateString();
            //1. Who is logged in
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var subscriber = _context.Subscriber.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            /// Subscriber subscriber = new Subscriber();
            subscriber.PackagePrice = 0;
            if (answer.answer0 != null)
            {
                subscriber.PackagePrice += 10;
            }

            if (answer.answer1 != null)
            {
                subscriber.PackagePrice += 10;
            }

            if (answer.answer2 != null)
            {
                subscriber.PackagePrice += 10;
            }

            if (answer.answer3 != null)
            {
                subscriber.PackagePrice += 10;
            }

            if (answer.answer4 != null)
            {
                subscriber.PackagePrice += 10;
            }

            if (answer.answer5 != null)
            {
                subscriber.PackagePrice += 10;
            }

            if (answer.answer6 != null)
            {
                subscriber.PackagePrice += 10;
            }

            subscriber.DeliveryFreq = "Once a Month";
            subscriber.DeliveryDate = date;


            //Maybe get rid of comas to fix weird format issue
            subscriber.StyleName = answer.answer0 + ',' + answer.answer1 + ',' + answer.answer2 + ',' + answer.answer3 + ',' + answer.answer4 + ',' + answer.answer5 + ',' + answer.answer6;
            _context.Subscriber.Update(subscriber);
            _context.SaveChanges();
            
            //return object(subscriber);
            return subscriber;
        }

        // GET: Styles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var style = await _context.Style
                .FirstOrDefaultAsync(m => m.Id == id);
            if (style == null)
            {
                return NotFound();
            }

            return View(style);
        }

        // GET: Styles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Styles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StyleName")] Style style)
        {
            if (ModelState.IsValid)
            {
                _context.Add(style);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(style);
        }

        // GET: Styles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var style = await _context.Style.FindAsync(id);
            if (style == null)
            {
                return NotFound();
            }
            return View(style);
        }

        // POST: Styles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,StyleName")] Style style)
        //{
        //    if (id != style.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(style);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!StyleExists(style.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(style);
        //}

        //// GET: Styles/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var style = await _context.Style
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (style == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(style);
        //}

        // POST: Styles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var style = await _context.Style.FindAsync(id);
            _context.Style.Remove(style);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StyleExists(int id)
        {
            return _context.Style.Any(e => e.Id == id);
        }

        public IActionResult ConfirmPackage()
        {

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var subscriber = _context.Subscriber.Where(c => c.IdentityUserId == userId).FirstOrDefault(); // Use First not Single

            UtilityClasses.SendMessage sendMessage = new UtilityClasses.SendMessage();
            sendMessage.SendText("+18053193640","Hey" + subscriber.FullName + ", Your Subscription Package <" + subscriber.StyleName + "> is expected to be delivered on" + subscriber.DeliveryDate);
            return View();

        }
    }
}
