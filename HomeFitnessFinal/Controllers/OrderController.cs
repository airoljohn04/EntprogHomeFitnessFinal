using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeFitnessFinal.Models;
using HomeFitnessFinal.Data;

namespace HomeFitnessFinal.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var list = _context.Orders.ToList();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Order record)
        {
            var order = new Order();
            order.CustomerName = record.CustomerName;
            order.Address = record.Address;
            order.EquipmentOrder = record.EquipmentOrder;
            order.Quantity = order.Quantity;
            order.ContactNumber = record.ContactNumber;
            order.DateAdded = DateTime.Now;
            order.PaymentMethod = record.PaymentMethod;

            _context.Orders.Add(order);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var order = _context.Orders.Where(i => i.OrderId == id).SingleOrDefault();
            if (order == null)
            {
                return RedirectToAction("Index");
            }

            return View(order);
        }
        [HttpPost]
        public IActionResult Edit(int? id, Order record)
        {
            var order = _context.Orders.Where(i => i.OrderId == id).SingleOrDefault();
            order.CustomerName = record.CustomerName;
            order.Address = record.Address;
            order.EquipmentOrder = record.EquipmentOrder;
            order.Quantity = order.Quantity;
            order.ContactNumber = record.ContactNumber;
            order.PaymentMethod = record.PaymentMethod;

            _context.Orders.Update(order);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var order = _context.Orders.Where(i => i.OrderId == id).SingleOrDefault();
            if (order == null)
            {
                return RedirectToAction("Index");
            }

            _context.Orders.Remove(order);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
