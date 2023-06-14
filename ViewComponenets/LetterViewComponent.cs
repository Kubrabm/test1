using BackProject.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackProject.ViewComponenets
{
    public class LetterViewComponent : ViewComponent 
    {
        private readonly AppDbContext _dbContext;

        public LetterViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public IViewComponentResult Invoke()
        {
            var letter=_dbContext.Letters.FirstOrDefault();

            return View(letter);
        }

    }
}
