using MovieWebsite.Data.Base;
using MovieWebsite.Models;

namespace MovieWebsite.Data.Services
{
    public class CinemasService:EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context) { }
    }
}
