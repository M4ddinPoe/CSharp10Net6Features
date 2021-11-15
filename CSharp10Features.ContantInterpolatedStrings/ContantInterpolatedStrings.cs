namespace CSharp10Features.ContantInterpolatedStrings;

public class ContantInterpolatedStrings
{
    private const string BaseUrl = "https://www.5minds.de/";

    private const string CareerUrl = BaseUrl + "/karriere";

    // in C#10 sind constant interpolated strings erlaubt
    private const string TeamUrl = $"{BaseUrl}/team";
}