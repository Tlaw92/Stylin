using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Stylin.Data;
using Stylin.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Stylin.UtilityClasses;

namespace Stylin.Controllers
{
    [Authorize(Roles = "Subscriber")]
    public class SubscribersController : Controller
    {
        //Why we need these? - 
        private readonly ApplicationDbContext _context;
        private IWebHostEnvironment _hostingEnvironment;

        public SubscribersController(ApplicationDbContext context, IWebHostEnvironment _webHostEnvironment)
        {
            _context = context;
            _hostingEnvironment = _webHostEnvironment;
        }

        // GET: Subscribers
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var shopper = _context.Subscriber.Where(c => c.IdentityUserId == userId).FirstOrDefault(); // Use First not Single
            if (shopper == null)
            {
                return RedirectToAction("Create");
            }
            var applicationDbContext = _context.Subscriber.Include(s => s.IdentityUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Subscribers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subscriber = await _context.Subscriber
                .Include(s => s.IdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subscriber == null)
            {
                return NotFound();
            }
            //below converts the pathing slash format by replacing backslashes with forward slashes
            string path = subscriber.Picture.Replace(@"\", "/");
            string localpath= "C:/Users/TLaw/Documents/DCC2/CapstoneWeek/Stylin/Stylin/wwwroot/";
            //Take the crap path and replace with local server to finally have the correct format
            subscriber.Picture = path.Replace(localpath, "https://localhost:44377/"); //the https local host will now be replacing everything in line 61 passes the = sign

            return View(subscriber);
        }

        // GET: Subscribers/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Subscribers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //Manipulate file to be able to save on server
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormFile file, Subscriber subscriber) //Bind was here before
        {
           
           
            if (ModelState.IsValid)
            {
                //Explain whats happening below
                SaveImage saveImg = new SaveImage(_hostingEnvironment);// !!! Why do I pass _hostingEnvironment? !!!
                string path = await saveImg.Save(file);
                subscriber.Picture = path;
                _context.Add(subscriber);
                await _context.SaveChangesAsync();

                //Sending message to subscriber
                SendMessage sendMessage = new SendMessage();
                //string MessageBody = "Hey" + subscriber.FullName + ", Thank you for creating profile. From Stylin".
                sendMessage.SendText("+18053193640", "Hey, "+subscriber.FullName+", Thank you for creating profile. Regards, STylin.");
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", subscriber.IdentityUserId);
            return View(subscriber);
        }



        // GET: Subscribers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subscriber = await _context.Subscriber.FindAsync(id);
            if (subscriber == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", subscriber.IdentityUserId);
            return View(subscriber);
        }

        // POST: Subscribers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,IdentityUserId")] Subscriber subscriber)
        {
            if (id != subscriber.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subscriber);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubscriberExists(subscriber.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", subscriber.IdentityUserId);
            return View(subscriber);
        }

        // GET: Subscribers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subscriber = await _context.Subscriber
                .Include(s => s.IdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subscriber == null)
            {
                return NotFound();
            }

            return View(subscriber);
        }

        // POST: Subscribers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subscriber = await _context.Subscriber.FindAsync(id);
            _context.Subscriber.Remove(subscriber);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubscriberExists(int id)
        {
            return _context.Subscriber.Any(e => e.Id == id);
        }
    }
}
