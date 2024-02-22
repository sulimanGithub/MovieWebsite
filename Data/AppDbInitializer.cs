using Microsoft.AspNetCore.Identity;
using MovieWebsite.Data.Enum;
using MovieWebsite.Data.Static;
using MovieWebsite.Models;

namespace MovieWebsite.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "/images/cinemas/cinema-1.jpg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "/images/cinemas/cinema-2.jpg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "/images/cinemas/cinema-3.jpg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "/images/cinemas/cinema-4.jpg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "/images/cinemas/cinema-5.jpg",
                            Description = "This is the description of the first cinema"
                        },
                    });
                    context.SaveChanges();
                }

                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "/images/actors/actor-1.jpg"

                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "/images/actors/actor-2.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "/images/actors/actor-3.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "/images/actors/actor-4.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "/images/actors/actor-5.jpg"
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "/images/producers/producer-1.jpg"

                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "/images/producers/producer-2.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "/images/producers/producer-3.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "/images/producers/producer-4.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "/images/producers/producer-5.jpg"
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Life",
                            Description = "This is the Life movie description",
                            Price = 39.50,
                            ImageURL = "/images/movies/movie-3.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 13,
                            ProducerId = 13,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImageURL = "/images/movies/movie-1.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 11,
                            ProducerId = 11,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 39.50,
                            ImageURL = "/images/movies/movie-4.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 14,
                            ProducerId = 14,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Race",
                            Description = "This is the Race movie description",
                            Price = 39.50,
                            ImageURL = "/images/movies/movie-6.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 11,
                            ProducerId = 12,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            ImageURL = "/images/movies/movie-7.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 11,
                            ProducerId = 13,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            ImageURL = "/images/movies/movie-8.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 11,
                            ProducerId = 15,
                            MovieCategory = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }
               
                if (!context.Movies_Actors.Any())
                {
                    context.Movies_Actors.AddRange(new List<Movie_Actor>()
                    {
                        new Movie_Actor()
                        {
                            ActorId = 21,
                            MovieId = 12
                        },
                        new Movie_Actor()
                        {
                            ActorId = 23,
                            MovieId = 12
                        },

                         new Movie_Actor()
                        {
                            ActorId = 21,
                            MovieId = 12
                        },
                         new Movie_Actor()
                        {
                            ActorId = 22,
                            MovieId = 12
                        },

                        new Movie_Actor()
                        {
                            ActorId = 21,
                            MovieId = 13
                        },
                        new Movie_Actor()
                        {
                            ActorId = 20,
                            MovieId = 13
                        },
                        new Movie_Actor()
                        {
                            ActorId = 23,
                            MovieId = 13
                        },


                        new Movie_Actor()
                        {
                            ActorId = 20,
                            MovieId = 14
                        },
                        new Movie_Actor()
                        {
                            ActorId = 23,
                            MovieId = 14
                        },
                        new Movie_Actor()
                        {
                            ActorId = 20,
                            MovieId = 14
                        },


                        new Movie_Actor()
                        {
                            ActorId = 22,
                            MovieId = 15
                        },
                        new Movie_Actor()
                        {
                            ActorId = 23,
                            MovieId = 15
                        },
                        new Movie_Actor()
                        {
                            ActorId = 20,
                            MovieId = 15
                        },
                        new Movie_Actor()
                        {
                            ActorId = 23,
                            MovieId = 15
                        },


                        new Movie_Actor()
                        {
                            ActorId = 23,
                            MovieId = 16
                        },
                        new Movie_Actor()
                        {
                            ActorId = 22,
                            MovieId = 16
                        },
                        new Movie_Actor()
                        {
                            ActorId = 23,
                            MovieId = 16
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@movie.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@movie.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}