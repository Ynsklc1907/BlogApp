using BlogApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data.Concrete.EfCore
{
    public static class SeedData
    {
        public static void TestVerileriniDoldur(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<BlogContext>();

            if (context != null)
            {
                if (context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }
                if (!context.Tags.Any())
                {
                    context.Tags.AddRange(
                        new Tag { Text = "web programlama", Url = "web-programlama", Color = TagColors.warning },
                        new Tag { Text = "backend", Url = "backend", Color = TagColors.info },
                        new Tag { Text = "frontend", Url = "frontend", Color = TagColors.success },
                        new Tag { Text = "fullstack", Url = "fullstack", Color = TagColors.secondary },
                        new Tag { Text = "php", Url = "php", Color = TagColors.primary }
                    );
                    context.SaveChanges();
                }
                if (!context.Users.Any())
                {
                    context.Users.AddRange(
                        new User { UserName = "yunuskilic", Name = "Yunus Kılıç", Email = "info@yunuskilic.com", Password = "123456", Image = "p1.jpg" },
                        new User { UserName = "ahmetkilic", Name = "Ahmet Kılıç", Email = "info@ahmetkilic.com", Password = "123456", Image = "p2.jpg" }
                    );
                    context.SaveChanges();
                }
                if (!context.Posts.Any())
                {
                    context.Posts.AddRange(
                        new Post
                        {
                            Title = "Asp.net core",
                            Description = "Asp.net core dersleri",
                            Content = "Asp.net core dersleri",
                            Url = "aspnet-core",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-10),
                            Tags = context.Tags.Take(3).ToList(),
                            Image = "1.jpg",
                            UserId = 1,
                            Comments = new List<Comment>{
                                new Comment{Text="iyi bir kurs",PublishedOn=DateTime.Now.AddDays(-20),UserId=1},
                                new Comment{Text="çok faydalandığım bir kurs",PublishedOn=DateTime.Now.AddDays(-10),UserId=2}
                                }

                        },
                        new Post
                        {
                            Title = "Php core",
                            Description = "Php core dersleri",
                            Content = "Php core dersleri",
                            Url = "php",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-20),
                            Tags = context.Tags.Take(2).ToList(),
                            Image = "2.jpg",
                            UserId = 1

                        },
                        new Post
                        {
                            Title = "Django",
                            Description = "Django dersleri",
                            Content = "Django dersleri",
                            Url = "django",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-30),
                            Tags = context.Tags.Take(4).ToList(),
                            Image = "4.jpg",
                            UserId = 2

                        },
                        new Post
                        {
                            Title = "React Dersleri",
                            Description = "React dersleri",
                            Content = "React dersleri",
                            Url = "react-dersleri",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-40),
                            Tags = context.Tags.Take(4).ToList(),
                            Image = "4.jpg",
                            UserId = 2

                        },
                        new Post
                        {
                            Title = "Angular",
                            Description = "Angular dersleri",
                            Content = "Angular dersleri",
                            Url = "angular",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-50),
                            Tags = context.Tags.Take(4).ToList(),
                            Image = "4.jpg",
                            UserId = 2

                        },
                        new Post
                        {
                            Title = "Web Tasarım",
                            Description = "Web Tasarım dersleri",
                            Content = "Web Tasarım dersleri",
                            Url = "web-tasarim",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-60),
                            Tags = context.Tags.Take(4).ToList(),
                            Image = "4.jpg",
                            UserId = 2

                        }
                    );
                    context.SaveChanges();
                }




            }

        }
    }
}