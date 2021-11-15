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
    }
}