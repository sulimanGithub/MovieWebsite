using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieWebsite.Data.Base;
using MovieWebsite.Models;

namespace MovieWebsite.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor> , IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
    }
}
