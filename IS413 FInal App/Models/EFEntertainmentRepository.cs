using Microsoft.EntityFrameworkCore;
namespace IS413_FInal_App.Models
{
    public class EFEntertainmentRepository : IEntertainmentRepository
    {
        private EntertainmentAgencyExampleContext _context;

        public  EFEntertainmentRepository(EntertainmentAgencyExampleContext temp)
        {
            _context = temp;
        }
  

        public List<Entertainer> Entertainers => _context.Entertainers.ToList();

        public List<Entertainer> GetAllEntertainers()
        {
            return _context.Entertainers.ToList();
        }


        public void AddEntertainer(Entertainer entertainer)
        {
            _context.Add(entertainer);
            _context.SaveChanges();
        }
        public void UpdateEntertainer(Entertainer entertainer)
        {
            _context.Update(entertainer);
            _context.SaveChanges();
        }

        public void RemoveEntertainer(Entertainer entertainer)
        {
            _context.Remove(entertainer);
            _context.SaveChanges();
        }


        //commented out tables not used 
        //public IQueryable<Agent> Agents => _context.Agents;
        //public IQueryable<Customer> Customers => _context.Customers;
        //public IQueryable<Engagement> Engagements => _context.Engagements;   
        //public IQueryable<Member> Members => _context.Members;
        //public IQueryable<EntertainerMember> EntertainerMembers => _context.EntertainerMembers;
        //public IQueryable<EntertainerStyle> EntertainerStyles => _context.EntertainerStyles;
    }
}
