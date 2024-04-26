using Microsoft.EntityFrameworkCore;
using SUT23_Labb_3___API.Models;

namespace SUT23_Labb_3___API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 

        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<PersonInterest> PersonInterests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>().HasData(new Person { PersonID = 1, FirstName = "Ermin", LastName = "Husic", PhoneNumber = "0725978237" });
            modelBuilder.Entity<Person>().HasData(new Person { PersonID = 2, FirstName = "Pär", LastName = "Nilsson", PhoneNumber = "0724596073" });
            modelBuilder.Entity<Person>().HasData(new Person { PersonID = 3, FirstName = "Oskar", LastName = "Johansson", PhoneNumber = "0727921237" });
            modelBuilder.Entity<Person>().HasData(new Person { PersonID = 4, FirstName = "Emilia", LastName = "Millesson Nilsson", PhoneNumber = "0726098751" });




            modelBuilder.Entity<Interest>().HasData(new Interest
            {
                InterestID = 100,
                Title = "Programming",
                Description = "Programming a big website"

            });
            modelBuilder.Entity<Interest>().HasData(new Interest
            {
                InterestID = 101,
                Title = "Wrestling",
                Description = "throwing around people"

            });
            modelBuilder.Entity<Interest>().HasData(new Interest
            {
                InterestID = 102,
                Title = "Football",
                Description = "Kicking a ball"

            });
            modelBuilder.Entity<Interest>().HasData(new Interest
            {
                InterestID = 103,
                Title = "Dancing",
                Description = "Dancing in the moonlight"

            });


            modelBuilder.Entity<Link>().HasData(new Link { LinkID = 10, Url = "www.youtube.com", PersonInterestID = 1 });
            modelBuilder.Entity<Link>().HasData(new Link { LinkID = 11, Url = "www.stackoverflow.com", PersonInterestID = 1 });
            modelBuilder.Entity<Link>().HasData(new Link { LinkID = 12, Url = "www.football.com", PersonInterestID = 2 });
            modelBuilder.Entity<Link>().HasData(new Link { LinkID = 13, Url = "www.dancing.com", PersonInterestID = 2 });




            modelBuilder.Entity<PersonInterest>().HasData(new PersonInterest
            {
                PersonInterestID = 1,
                PersonID = 1,
                InterestID = 100,
            });

            modelBuilder.Entity<PersonInterest>().HasData(new PersonInterest
            {
                PersonInterestID = 2,
                PersonID = 3,
                InterestID = 101,
            });
            modelBuilder.Entity<PersonInterest>().HasData(new PersonInterest
            {
                PersonInterestID = 1,
                PersonID = 2,
                InterestID = 102,
            });
            modelBuilder.Entity<PersonInterest>().HasData(new PersonInterest
            {
                PersonInterestID = 2,
                PersonID = 4,
                InterestID = 103,
            });
        }
    }
}
