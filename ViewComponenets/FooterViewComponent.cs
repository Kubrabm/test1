using BackProject.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHome.ViewComponenets
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly AppDbContext _dbContext;

        public FooterViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footer = await _dbContext.Footers.Include(x => x.Informations).Include(x => x.usefulLinks).Include(x => x.GetInTouches).FirstOrDefaultAsync();

            return View(footer);
        }
    }
}
