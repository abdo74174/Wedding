using Microsoft.AspNetCore.Mvc;
using Wedding.Models;
using Wedding.Data;

namespace Wedding.Controllers
{
    public class WeddingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WeddingController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Wedding/BookWedding
        public IActionResult BookWedding()
        {
            return View(); // Show the booking form
        }

        // POST: Wedding/BookWedding
        [HttpPost]
        public async Task<IActionResult> BookWedding(WeddingBooking model)
        {
            if (ModelState.IsValid)
            {
                // Save the booking to the database
                _context.WeddingBookings.Add(model);
                await _context.SaveChangesAsync();

                // Redirect to the confirmation page
                return RedirectToAction("Confirmation");
            }

            return View(model); // If the form is invalid, show the form again
        }

        // GET: Wedding/Confirmation
        public IActionResult Confirmation()
        {
            return View(); // Show the confirmation page
        }
    }
}
