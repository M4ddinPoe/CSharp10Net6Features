namespace CSharp10Features
{
    using PowerArgs;

    internal class GlobalUsingsArgs
    {
        [ArgRequired(PromptIfMissing = true)]    
        public string Host { get; set; }

        [ArgRequired(PromptIfMissing = true)]
        public string Speaker { get; set; }

        [ArgRequired(PromptIfMissing = true)]
        public string Researcher { get; set; }
    }
}
