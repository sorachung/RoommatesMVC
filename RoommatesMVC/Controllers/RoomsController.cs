using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoommatesMVC.Repositories;
using RoommatesMVC.Models;
using System.Collections.Generic;

namespace RoommatesMVC.Controllers
{
    public class RoomsController : Controller
    {
        private readonly RoomRepository _roomRepo;

        public RoomsController(RoomRepository roomRepository)
        {
            _roomRepo = roomRepository;
        }
        // GET: RoomsController
        public ActionResult Index()
        {
            List<Room> rooms = _roomRepo.GetAll();
            return View(rooms);
        }

        // GET: RoomsController/Details/5
        public ActionResult Details(int id)
        {
            Room room = _roomRepo.GetById(id);
            return View(room);
        }

        // GET: RoomsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoomsController/Create
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

        // GET: RoomsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RoomsController/Edit/5
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

        // GET: RoomsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RoomsController/Delete/5
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
