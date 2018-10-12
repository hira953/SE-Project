using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab4.Models;

namespace Lab4.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/
        public ActionResult Index()
        {
            PhoneBookDbEntities db = new PhoneBookDbEntities(); 
            List<Contact> list = db.Contacts.ToList();
            List<ContactViewModel> viewList = new List<ContactViewModel>();
            foreach (Contact s in list)
            {
                ContactViewModel obj = new ContactViewModel();
                obj.ContactId = s.ContactId;
                obj.ContactNumber = s.ContactNumber;
                obj.Type = s.Type;
                obj.PersonId = s.PersonId;
                viewList.Add(obj);
            }
            return View();
        }

        //
        // GET: /Contact/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Contact/Create
        public ActionResult Create()
        {
            String user = User.Identity.Name;
            return View();
        }

        //
        // POST: /Contact/Create
        [HttpPost]
        public ActionResult Create(ContactViewModel obj)
        {
            try
            {
                // TODO: Add insert logic here
                Contact s = new Contact();
                s.ContactId = obj.ContactId;
                s.ContactNumber = obj.ContactNumber;
                s.Type = obj.Type;
                s.PersonId = obj.PersonId;

                PhoneBookDbEntities db = new PhoneBookDbEntities();
                db.Contacts.Add(s);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Contact/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Contact/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Contact/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Contact/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
