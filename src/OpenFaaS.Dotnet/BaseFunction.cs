namespace OpenFaaS.Dotnet
{
    public abstract class BaseFunction : IFunction
    {
        protected BaseFunction(IFunctionContext functionContext)
        {
            Context = functionContext;
        }

        public IFunctionContext Context { get; }

        public abstract string Handle(string input);
    }
}
