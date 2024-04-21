using Microsoft.EntityFrameworkCore;

namespace IS413_FInal_App.Models
{
    public interface IEntertainmentRepository
    {


        public List<Entertainer> Entertainers { get;}
        public List<Entertainer> GetAllEntertainers();
        public void AddEntertainer(Entertainer entertainer);
        public void UpdateEntertainer(Entertainer entertainer);

        public void RemoveEntertainer(Entertainer entertainer);



        //public IQueryable<Agent> Agents { get; set;}
        //public IQueryable<Customer> Customers { get; set; }
        //public IQueryable<Engagement> Engagements { get; set; }
        //public IQueryable<EntertainerMember> EntertainerMembers { get; set; }

        //public IQueryable<EntertainerStyle> EntertainerStyles { get; set; }
        //public IQueryable<Member> Members { get; set; }

        //public IQueryable<MusicalPreference> MusicalPreferences { get; set; }

        //public IQueryable<MusicalStyle> MusicalStyles { get; set; }


        //public IQueryable<ZtblDay> ZtblDays { get; set; }
        //public IQueryable<ZtblSkipLabel> ZtblSkipLabels { get; set; }

        //public IQueryable<ZtblMonth> ZtblMonths { get; set; }

        //public IQueryable<ZtblWeek> ZtblWeeks { get; set; }
    }
}
