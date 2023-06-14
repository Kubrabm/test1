using BackProject.DAL;
using BackProject.iewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {

            var slider = await _dbContext.Sliders.ToListAsync();


            var model = new HomeViewModel
            {
                Sliders = slider,

            };

            //HttpContext.Session.SetJson("visitors", visitor);

            return View(model);
        }



        //public IActionResult Search(string searchedProduct)
        //{
        //    var products = _dbContext.Products.Where(x => x.Name.Contains(searchedProduct)).ToList();

        //    return PartialView("_SearchedProductPartial", products);
        //}

    }
}
