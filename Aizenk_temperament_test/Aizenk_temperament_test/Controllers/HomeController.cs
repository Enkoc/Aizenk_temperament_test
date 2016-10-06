using Aizenk_temperament_test.Models;
using Aizenk_temperament_test.Models.Entities;
using Aizenk_temperament_test.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aizenk_temperament_test.Controllers
{
    public class HomeController : Controller
    {
        TestDbContext db = new TestDbContext();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test()
        {
            return RedirectToAction("Question", new { qId = 1 });
        }

        [HttpGet]
        public ActionResult Question(int qId)
        {
            Question q = db.Questions.FirstOrDefault(qu => qu.Id == qId);

            return View(new QuestionViewModel(q));
        }

        [HttpPost]
        public ActionResult Question(QuestionViewModel viewModel)
        {
            db.Questions.FirstOrDefault(u => u.Id == viewModel.Question.Id).Answer = viewModel.Answer.Value;
            db.SaveChanges();

            if (viewModel.Question.Id==db.Questions.Count())
            {
                return RedirectToAction("Results");
            }

            int nextQuestionId = viewModel.Question.Id + 1;
            return RedirectToAction("Question", new { qId = nextQuestionId});
        }

        public ActionResult Results()
        {
            int AMark;
            int BMark;
            int CMark;

            AMark = db.Questions.Count(q => q.Category == "Atrue" && q.Answer == true);
            AMark += db.Questions.Count(q => q.Category == "AFalse" && q.Answer == false);

            BMark = db.Questions.Count(q => q.Category == "BTrue" && q.Answer == true);
            BMark += db.Questions.Count(q => q.Category == "BFalse" && q.Answer == false);

            CMark = db.Questions.Count(q => q.Category == "C" && q.Answer == true);

            if(AMark<5)
            {
                ResultViewModel rvm = new ResultViewModel();
                rvm.BMark = BMark;
                rvm.Cmark = CMark;

                if(BMark>12)
                {
                    if(CMark>12)
                    {
                        rvm.Temperament = "Холерик";
                    }
                    else
                    {
                        rvm.Temperament = "Сангвиник";
                    }
                }
                else
                {
                    if (CMark>12)
                    {
                        rvm.Temperament = "Меланхолик";
                    }
                    else
                    {
                        rvm.Temperament = "Флегматик";
                    }
                }
                return View("Results", rvm);
            }
            else
            {
                return View("Fail");
            }
        }

    }
}