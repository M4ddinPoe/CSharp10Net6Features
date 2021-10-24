namespace ExtendedPropertyPatterns
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var subCompany = new Company("Google");
            var company = new Company("Alphabet", subCompany);

            if (company is { SubCompany: { Name: "Google" } })
            {
                // ...
            }
            
            if (company is { SubCompany.Name: "Google"  })
            {
                // ...
            }
        }
    }
}