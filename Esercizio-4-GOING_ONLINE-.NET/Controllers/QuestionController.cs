using Esercizio_4_GOING_ONLINE_.NET.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Esercizio_4_GOING_ONLINE_.NET.Controllers
{
    public class QuestionController : Controller
    {
        // GET: QuestionController
        
        public ActionResult Index()
        {
            return View(new List<Question>()
            {
                new Question
                {
                    Id = 0,
                    Author = "Bob",
                    Title = "Bob Beuty",
                    Description = "Beuty",

                }
            });
        }

        // GET: QuestionController/Details/5
        [Route("Question/Details/{id}/{author}")]
        public ActionResult Details(int id,string author)
        {
            var question = new Question
            {
                Id = id,
                Author = author,
            };
            return View(question);
        }

        // GET: QuestionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuestionController/Create
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

        // GET: QuestionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QuestionController/Edit/5
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

        // GET: QuestionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QuestionController/Delete/5
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
