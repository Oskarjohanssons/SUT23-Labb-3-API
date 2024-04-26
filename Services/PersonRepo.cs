using Microsoft.EntityFrameworkCore;
using SUT23_Labb_3___API.Data;
using SUT23_Labb_3___API.Models;

namespace SUT23_Labb_3___API.Services
{
    public class PersonRepo : IPerson
    {
        private AppDbContext _DbContext;
        public PersonRepo(AppDbContext appDbContext)
        {
            _DbContext = appDbContext;
        }

        public async Task AddInterest(int personID, int interest)
        {
            var personInterestLink = new PersonInterest
            {
                PersonID = personID,
                InterestID = interest
            };
            _DbContext.PersonInterests.Add(personInterestLink);
            await _DbContext.SaveChangesAsync();
        }

        public async Task AddLink(int personID, int interestID, string url)
        {
            var result = new PersonInterest
            {
                PersonID = personID,
                InterestID = interestID,
                Links = new List<Link>() { new Link { Url = url } }
            };

            _DbContext.PersonInterests.Add(result);
            await _DbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            return await _DbContext.Persons.ToListAsync();
        }

        public async Task<IEnumerable<Interest>> GetInterests(int id)
        {
            var personInterest = await _DbContext.PersonInterests.Where(p => p.PersonID == id).Select(p => p.Interest).ToListAsync();

            return personInterest;
        }

        public async Task<IEnumerable<Link>> GetLinks(int id)
        {
            return await _DbContext.PersonInterests.Where(p => p.PersonID == id).SelectMany(u => u.Links).ToListAsync();
        }
    }
}
