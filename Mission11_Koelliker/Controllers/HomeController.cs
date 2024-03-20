using Microsoft.AspNetCore.Mvc;
using Mission11_Koelliker.Models;
using Mission11_Koelliker.Models.ViewModels;
using System.Diagnostics;

namespace Mission11_Koelliker.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _repo;
        public HomeController(IBookRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;

            var stuff = new BooksListViewModel
            {
                Books = _repo.Books
                    .OrderBy(x => x.Title)
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize),

                Paginationinfo = new Paginationinfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()
                }

            };

            return View(stuff);
        }

    }
}
