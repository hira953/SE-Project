using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab4.Models;

namespace Lab4.Controllers
{
    public class PersonController : Controller
    {
        //
        // GET: /Person/
        public ActionResult Index()
        {
            PhoneBookDbEntities db = new PhoneBookDbEntities();
            List<Person> list = db.People.ToList();
            List<PersonViewModel> viewList = new List<PersonViewModel>();
            foreach (Person s in list)
            {
                PersonViewModel obj = new PersonViewModel();
                obj.DateOfBirth = Convert.ToDateTime(s.DateOfBirth);
                obj.PersonId = s.PersonId;
                obj.EmailId = s.EmailId;
                obj.FirstName = s.FirstName;
                obj.MiddleName = s.MiddleName;
                obj.LastName = s.LastName;
                obj.AddedOn = s.AddedOn;
                obj.AddedBy = s.AddedBy;
                obj.HomeAddress = s.HomeAddress;
                obj.HomeCity = s.HomeCity;
                obj.FaceBookAccountId = s.FaceBookAccountId;
                obj.LinkedInId = s.LinkedInId;
                obj.UpdateOn = Convert.ToDateTime(s.UpdateOn);
                obj.ImagePath = s.ImagePath;
                obj.TwitterId = s.TwitterId;
                viewList.Add(obj);
            } 
            return View(viewList);
        }

        //
        // GET: /Person/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Person/Create
        public ActionResult Create()
        {
            String user = User.Identity.Name;
            return View();
        }

        //
        // POST: /Person/Create
        [HttpPost]
        public ActionResult Create(PersonViewModel obj)
        {
            try
            {
                // TODO: Add insert logic here
                Person s = new Person();
                s.DateOfBirth = obj.DateOfBirth;
                s.PersonId = obj.PersonId;
                s.FirstName = obj.FirstName;
                s.MiddleName = obj.MiddleName;
                s.LastName = obj.LastName;
                s.AddedOn = obj.AddedOn;
                s.AddedBy = obj.AddedBy;
                s.HomeAddress = obj.HomeAddress;
                s.HomeCity = obj.HomeCity;
                s.FaceBookAccountId = obj.FaceBookAccountId;
                s.LinkedInId = obj.LinkedInId;
                s.UpdateOn = obj.UpdateOn;
                s.ImagePath = obj.ImagePath;
                s.TwitterId = obj.TwitterId;
                s.EmailId = obj.EmailId;

                PhoneBookDbEntities db = new PhoneBookDbEntities();
                //db.People.Add(s);
                if (ModelState.IsValid)
                {
                    db.People.Add(s);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(obj);
                }
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Person/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Person/Edit/5
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
        // GET: /Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Person/Delete/5
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
