using System.Linq;
using System.Web.Mvc;
using AnimeList.Models;

namespace AnimeList.Controllers
{
    [ValidateInput(false)]
    public class AnimeController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            //TODO: Implement me ...
            using (var database = new AnimeListDbContext()) //always use to prevent errors
            {
                var animes = database.Animes.ToList(); //ToList to know when to stop querry

                return View(animes);
            }

            //TODO: Implement me ... END
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            //TODO: Implement me ...
            return View();

            //TODO: Implement me ... END
        }

        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Anime anime)
        {
            //TODO: Implement me ...

            if (ModelState.IsValid)
            {
                using (var database = new AnimeListDbContext())
                {
                    database.Animes.Add(anime);

                    database.SaveChanges();
                }
            }

            return RedirectToAction("Index");

            //TODO: Implement me ... END
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int? id)
        {
            //TODO: Implement me ...

            if (id == null)
            {
                return HttpNotFound();
            }

            using (var database = new AnimeListDbContext())
            {
                Anime anime = database.Animes.Find(id);

                if (anime == null)
                {
                    return RedirectToAction("Index");
                }

                return View(anime);
            }

            //TODO: Implement me ... END
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int? id, Anime animeModel)
        {
            //TODO: Implement me ...

            if (id == null)
            {
                return HttpNotFound();
            }

            using (var database = new AnimeListDbContext())
            {
                Anime animeToBeDeleted = database.Animes.Find(id);

                if (animeToBeDeleted == null)
                {
                    RedirectToAction("Index");
                }

                database.Animes.Remove(animeToBeDeleted);

                database.SaveChanges();
            }
            //           }

            return RedirectToAction("Index");

            //TODO: Implement me ... END
        }
    }
}