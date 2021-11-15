namespace CSharp10Features.LambdaImprovements
{
    public class Lambda
    {
        public void DoStuff()
        {
            Func<string> helloOldWorld = () => "Hello!";

            var helloNewWorld = () => "Hello!";
            var helloNull = string? () => null;
        }
    }
}