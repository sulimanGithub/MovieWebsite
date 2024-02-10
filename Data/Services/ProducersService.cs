using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieWebsite.Data.Base;
using MovieWebsite.Models;

namespace MovieWebsite.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer> , IProducersService
    {
        public ProducersService(AppDbContext context) : base(context) { }
    }
}
