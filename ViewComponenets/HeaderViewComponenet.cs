using BackProject.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHome.ViewComponenets
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly AppDbContext _dbContext;

        public HeaderViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var header = await _dbContext.Headers.Include(x => x.Homes).Include(x => x.Abouts).Include(x => x.Courses).Include(x => x.Events).Include(x => x.Teachers).Include(x => x.Blogs).Include(x => x.Contacts).Include(x => x.BuyNowS).FirstOrDefaultAsync();

            return View(header);
        }
    }
}
