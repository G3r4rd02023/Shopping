using Microsoft.AspNetCore.Identity;
using Shopping.Data.Entities;
using Shopping.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Data
{
    public class SeedDb
    {
        private readonly DataContext context;
        private readonly IUserHelper userHelper;
        private readonly UserManager<User> userManager;
        private Random random;

        public SeedDb(DataContext context, UserManager<User> userManager, IUserHelper userHelper)
        {
            this.context = context;
            this.userManager = userManager;
            this.userHelper = userHelper;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            var user = await this.userHelper.GetUserByEmailAsync("glanza007@gmail.com");
            if (user == null)
            {
                user = new User
                {
                    FirstName = "Gerardo",
                    LastName = "Lanza",
                    Email = "glanza007@gmail.com",
                    UserName = "glanza007@gmail.com"
                };

                var result = await this.userManager.CreateAsync(user, "123456");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeder");
                }
            }

                      

        if(!this.context.Products.Any())
            {
                this.AddProduct("iPhone X","001",user);
                this.AddProduct("iPad series","002",user);
                this.AddProduct("MacBook Pro","003",user);
                await this.context.SaveChangesAsync();
            }
        }

        private void AddProduct(string name,string code,User user)
        {
            this.context.Products.Add(new Product
            {
                Name = name,
                Code = code,
                Price = this.random.Next(100),
                IsAvailabe = true,
                Stock = this.random.Next(100),
                User = user
            });
        }
    }

}
