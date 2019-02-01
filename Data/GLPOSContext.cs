using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using POS.APIs.Data.Models;

namespace POS.APIs.Data
{
    public class GLPOSContext : IdentityDbContext<User>
    {
        // Migration command: Add-Migration [Migration Name] -p [Project Name] ,  then update-database -verbose
        public GLPOSContext(DbContextOptions<GLPOSContext> options)
            : base(options)
        { }

        #region Properties
        public DbSet<Token> Tokens { get; set; }
        public virtual DbSet<StateTax> StateTaxes { get; set; }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Client_CC> Client_CCs { get; set; }
        public virtual DbSet<Client_Phone> Client_Phones { get; set; }
        public virtual DbSet<Client_Type> Client_Types { get; set; }
        public virtual DbSet<Phone_Type> Phone_Types { get; set; }
        #endregion Properties

        #region Methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Token>().ToTable("Tokens");
            modelBuilder.Entity<Token>().Property(i => i.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Token>().HasOne(i => i.User).WithMany(u => u.Tokens);

            //modelBuilder.Entity<Client>().Property(i => i.cli_id).ValueGeneratedOnAdd();
            //modelBuilder.Entity<Client>().ToTable("Clients");
            //modelBuilder.Entity<Client>().HasMany(cp => cp.Client_Phones).WithOne(c => c.Client);

            //modelBuilder.Entity<Client_Phone>().ToTable("Client_Phones");
            //modelBuilder.Entity<Client_Phone>().HasOne(c => c.Client).WithMany(cp => cp.Client_Phones);
        }
        #endregion
        //seed some data
        public void SeedData()
        {
            //if (!Categories.Any())
            //{
            //    var appliances = new Category()
            //    {
            //        Name = "Appliances",
            //        Subcategories = new List<Category>()
            //        {
            //            new Category(){Name = "Microwaves"}
            //        }
            //    };
            //    Categories.Add(appliances);
            //    SaveChanges();
            //}

            //if (!StateTax.Any())
            //{
            //    StateTax.AddRange(
            //        new StateTax { StateTaxId = "CA", TaxAmount = 9/100 },
            //        new StateTax { StateTaxId = "NY", TaxAmount = 8/100 },
            //        new StateTax { StateTaxId = "IL", TaxAmount = 8/100 });
            //    SaveChanges();
            //}


            //if (!Users.Any())
            //{

            //    Users.AddRange(
            //        new User() { Id = "admin@pos.com",  },
            //        new User() { Id = "cashier@pos.com" });
            //    SaveChanges();

            //}
        }

        // seed Admin User
        public async Task SeedUsersAsync(UserManager<User> userManager)
        {
            
                var user_Admin = new User()
                {
                    Id = "admin@glpos.com",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = "admin@glpos.com",
                    Email = "admin@glpos.com"
                };

                //Insert "Admin" into database and assign the "Administrator" and "RegisteredUser" roles to him
                if (await userManager.FindByNameAsync(user_Admin.UserName) == null)
                {
                    await userManager.CreateAsync(user_Admin, "Pass4Admin!");
                    await userManager.AddToRoleAsync(user_Admin, "Admin");

                    //  remove lockout and email confirmation
                    user_Admin.EmailConfirmed = true;
                    user_Admin.LockoutEnabled = false;
                }

                var user_Cashier = new User()
                {
                    Id = "cashier@glpos.com",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = "cashier@glpos.com",
                    Email = "cashier@glpos.com"
                    
                };

                //Insert "Admin" into database and assign the "Administrator" and "RegisteredUser" roles to him
                if (await userManager.FindByNameAsync(user_Cashier.UserName) == null)
                {
                    await userManager.CreateAsync(user_Cashier, "Pass4Cashier!");
                    await userManager.AddToRoleAsync(user_Cashier, "Cashier");

                    //  remove lockout and email confirmation
                    user_Admin.EmailConfirmed = true;
                    user_Admin.LockoutEnabled = false;
                }

                await SaveChangesAsync();

        }

        // seed Admin Role
        public async Task SeedRolesAsync(RoleManager<IdentityRole> roleManager)
        {
            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                var admin = new IdentityRole("Admin");
                await roleManager.CreateAsync(admin);
            }
            if (!await roleManager.RoleExistsAsync("Cashier"))
            {
                var cashier = new IdentityRole("Cashier");
                await roleManager.CreateAsync(cashier);
            }

        }
    }
}
