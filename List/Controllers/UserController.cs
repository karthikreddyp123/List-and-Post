using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using List.Models;
namespace List.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            UserRegistrationEntities userRegistrationEntities = new UserRegistrationEntities();
            return View(userRegistrationEntities.Users.ToList());
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                //using (UserRegistrationEntities userRegistrationEntities = new UserRegistrationEntities()) {
                //    userRegistrationEntities.Users.Add(collection);
                //    userRegistrationEntities.SaveChanges();
                //}
                User user = new User();
              //  collection["FirstName"] = "Enter User Name";
                user.FirstName = collection["FirstName"];
                user.LastName = collection["LastName"];
                user.Location = collection["Location"];
                user.Gender = collection["Gender"];
                user.EmaiID = collection["EmaiID"];
                user.DOB = collection["DOB"];
                user.Stream = collection["Stream"];
                UserRegistrationEntities userRegistrationEntities = new UserRegistrationEntities();
                userRegistrationEntities.Users.Add(user);
                userRegistrationEntities.SaveChanges();
                    return RedirectToAction("Create");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                User user = new User();
                user.FirstName = collection["FirstName"];
                user.LastName = collection["LastName"];
                user.Location = collection["Location"];
                user.Gender = collection["Gender"];
                user.EmaiID = collection["EmaiID"];
                user.DOB = collection["DOB"];
                user.Stream = collection["Stream"];
                UserRegistrationEntities userRegistrationEntities = new UserRegistrationEntities();
                userRegistrationEntities.Users.Add(user);
                userRegistrationEntities.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                User user = new User();
                user.FirstName = collection["FirstName"];
                user.LastName = collection["LastName"];
                user.Location = collection["Location"];
                user.Gender = collection["Gender"];
                user.EmaiID = collection["EmaiID"];
                user.DOB = collection["DOB"];
                user.Stream = collection["Stream"];
                UserRegistrationEntities userRegistrationEntities = new UserRegistrationEntities();
                userRegistrationEntities.Users.Add(user);
                userRegistrationEntities.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult ModelBinding(User user)
        {
            user.FirstName = "Anand";
            user.LastName = "Uperpelli";
            user.DOB = "11/04/1997";
            user.EmaiID = "anand@gmail.com";

            return View("Create", user);
        }
    }
}
