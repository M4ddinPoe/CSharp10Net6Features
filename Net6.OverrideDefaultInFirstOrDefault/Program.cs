var companies = new List<Company> { new ("Prosoz"), new ("5Minds") };
var selected = companies.FirstOrDefault(company => company.Name == "Microsoft", Company.Empty);

Console.WriteLine(selected.Name);


class Company
{
    public Company(string name)
    {
        this.Name = name;
    }

    public string Name { get; init; }

    public static Company Empty => new Company("-- na --");
}