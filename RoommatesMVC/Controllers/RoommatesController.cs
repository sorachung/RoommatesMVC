using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoommatesMVC.Controllers
{
    public class RoommatesController : Controller
    {
        // GET: RoommatesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RoommatesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RoommatesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoommatesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: RoommatesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RoommatesController/Edit/5
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

        // GET: RoommatesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RoommatesController/Delete/5
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
    }
}
