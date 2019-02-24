﻿using System.Linq;
using GigHub.Models;
using System.Web.Mvc;
using GigHub.ViewModel;

namespace GigHub.Controllers
{
    public class GigsController : Controller
    {
       
        private readonly ApplicationDbContext _context;

        public GigsController()
        {
        _context = new ApplicationDbContext();
        }

        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres = _context.Genres.ToList()
            };
            return View(viewModel);
        }
    }
}