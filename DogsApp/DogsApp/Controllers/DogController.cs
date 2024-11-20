using DogsApp.Data;
using DogsApp.Infrastructure.Data.Domain;
using DogsApp.Models.Dog;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DogsApp.Controllers
{
    public class DogController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DogController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: DogController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DogController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DogController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DogController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DogCreateViewModelcs bindingModel)
        {
            if (ModelState.IsValid)
            {
                Dog dogFromDb = new Dog
                {
                    Name = bindingModel.Name,
                    Age = bindingModel.Age,
                    Breed = bindingModel.Breed,
                    Picture = bindingModel.Picture
                };

                _context.Dogs.Add(dogFromDb);
                _context.SaveChanges();

                return this.RedirectToAction("Success");
            }
            return this.View();
        }

        // GET: DogController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DogController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DogController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DogController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Success()
        {
            return this.View();
        }
    }
}
