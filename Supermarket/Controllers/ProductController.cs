using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Supermarket.Data;
using Supermarket.Models;

namespace Supermarket.Controllers
{
    public class ProductController : Controller
    {
        private AppDbContext _db;
        public ProductController(AppDbContext db)
        {
            _db = db;
        }
       

        // GET: ItemController1
        public ActionResult Index()
        {

            IEnumerable<Product> ProductsList = _db.Products.ToList();
            return View(ProductsList);
        }

 

        // GET: ItemController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ItemController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product item)
        {
            if (ModelState.IsValid )
            {
                // Add the model to the DbContext and save changes
                _db.Products.Add(item);
                _db.SaveChanges();

                // Redirect to a success page or another action
                return RedirectToAction("Index");
            }


           
            // If the model is not valid, redisplay the form with validation errors
            return View(item);
        }
    }

       

        
    
}
