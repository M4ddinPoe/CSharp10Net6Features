namespace ExtendedPropertyPatterns
{
    public class Company
    {
        public Company(string name)
        {
            this.Name = name;
        }

        public Company(string name, Company subCompany)
        {
            this.Name = name;
            this.SubCompany = subCompany;
        }
        
        public string Name { get; set; }
        public Company? SubCompany { get; set; }
    }
}