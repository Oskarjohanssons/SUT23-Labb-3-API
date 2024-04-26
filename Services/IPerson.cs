using SUT23_Labb_3___API.Models;

namespace SUT23_Labb_3___API.Services
{
    public interface IPerson
    {
        Task<IEnumerable<Person>> GetAll();
        Task<IEnumerable<Interest>> GetInterests(int id);
        Task<IEnumerable<Link>> GetLinks(int id);
        Task AddInterest(int personID, int interest);
        Task AddLink(int personID, int interestID, string url);
    }
}
