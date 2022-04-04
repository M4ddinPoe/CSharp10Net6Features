using CSharp10Features.ExtendedPropertyPatterns;

namespace ExtendedPropertyPatterns
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var subCompany = new Company("Google");
            var company = new Company("Alphabet", subCompany);

            // C#9
            if (company is { SubCompany: { Department: { Team: { TeamLead: {Name: "Leader"}}}}})
            {
                // ...
            }

            // C#10
            if (company is { SubCompany.Department.Team.TeamLead.Name: "Leader" })
            {
                // ...
            }
        }
    }
}