using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ArticlesCRUD.Models;

namespace ArticlesCRUD.Controllers
{
    public class ArticleController : Controller
    {
        List<Article> articles = new List<Article>()
        {
            new Article(1, "titre1", "contenu1"),
            new Article(2, "titre2", "contenu2"),
        };
        // GET: ArticleController
        public ActionResult Index()
        {
            return View(articles);
        }

        // GET: ArticleController/Details/5
        public ActionResult Details(int id)
        {
            Article article = articles.First(a => a.Id == id);
            return View(article);
        }

        // GET: ArticleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArticleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                //articles.Add(new Article(id, titre, contenu));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ArticleController/Edit/5
        public ActionResult Edit(int id)
        {
            Article article = articles.First(a => a.Id == id);
            return View(article);
        }

        // POST: ArticleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                articles.Insert(id, new Article(id, "bla", "content"));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ArticleController/Delete/5
        public ActionResult Delete()
        {
            //Article article = articles.Find(a => a.Id == id);
            return View();
        }

        // POST: ArticleController/Delete/5
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
