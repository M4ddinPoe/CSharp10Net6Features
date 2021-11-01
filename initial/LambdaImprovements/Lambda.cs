namespace CSharp10Features.LambdaImprovements
{
    public class Lambda
    {
        public void DoStuff()
        {
            Func<string> hello = () => "Hello!";
        }
    }
}