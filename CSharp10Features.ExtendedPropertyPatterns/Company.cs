namespace CSharp10Features.ExtendedPropertyPatterns
{
    public class Company
    {
        public Company(string name)
        {
            Name = name;
        }

        public Company(string name, Company subCompany)
        {
            Name = name;
            SubCompany = subCompany;
        }

        public string Name { get; set; }
        
        public Company? SubCompany { get; set; }

        public Department Department { get; set; }
    }

    public class Department
    {
        public Team Team { get; set; }
    }

    public class Team
    {
        public Employee TeamLead { get; set; }

        public List<Employee> Employees { get; set; }
    }

    public class Employee
    {
        public string Name { get; set; }
    }
}