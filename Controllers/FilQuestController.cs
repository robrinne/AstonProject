using AstonProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AstonProject.Controllers
{
    public class FilQuestController : Controller
    {
        // GET: FilQuest
        public ActionResult Index()
        {
            List<Question> questions = new List<Question>();

            questions.Add(new Question
            {
                Id = 1,
                Quest = "Quelle est la capitale de la Belgique ?",
                Answer = "Bruxelles",
                Note = 10.0,
                Category = new Category
                {
                    Id = 1,
                    Name = "Capitales",
                    Color = "green",
                    ColorTwo = "success"
                },
                NbComment = 18,
                NbNote = 75,
                NbUsing = 105
            });

            questions.Add(new Question
            {
                Id = 2,
                Quest = "Quel est l'année de la révolution française ?",
                Answer = "1789",
                Note = 15.0,
                Category = new Category
                {
                    Id = 3,
                    Name = "Histoire",
                    Color = "red",
                    ColorTwo = "danger"
                },
                NbComment = 1,
                NbNote = 10,
                NbUsing = 15
            });

            questions.Add(new Question
            {
                Id = 3,
                Quest = "Quelle est le nom de la chaine de montagnes qui sépare la France et l'Espagne ?",
                Answer = "Les pyrénées",
                Note = 11.0,
                Category = new Category
                {
                    Id = 2,
                    Name = "Géographie",
                    Color = "primary",
                    ColorTwo = "primary"
                },
                NbComment = 7,
                NbNote = 11,
                NbUsing = 65
            });

            questions.Add(new Question
            {
                Id = 4,
                Quest = "Qu’est-ce que la RAM (Random Access Memory) ?",
                Answer = "La mémoire vive d’un ordinateur, qui est perdue lorsque l’alimentation électrique est coupée",
                Note = 0.0,
                Category = new Category
                {
                    Id = 4,
                    Name = "Informatique",
                    Color = "yellow",
                    ColorTwo = "warning"
                },
                NbComment = 52,
                NbNote = 1085,
                NbUsing = 3502
            });

            return View(questions);
        }
    }
}