using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeFitnessFinal.Data;
using HomeFitnessFinal.Models;

namespace HomeFitnessFinal.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var list = _context.Contacts.ToList();
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Contact record)
        {
            var contactUs = new Contact();
            contactUs.SenderName = record.SenderName;
            contactUs.Email = record.Email;
            contactUs.ContactNo = record.ContactNo;
            contactUs.Subject = record.Subject;
            contactUs.Message = record.Message;

            _context.Contacts.Add(contactUs);
            _context.SaveChanges();

            return RedirectToAction("Create");
        }
    }
}
