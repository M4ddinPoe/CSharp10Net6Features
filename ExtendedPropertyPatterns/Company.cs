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
            this.SubCompany = this.SubCompany;
        }
        
        public string Name { get; set; }
        public Company? SubCompany { get; set; }
    }
}