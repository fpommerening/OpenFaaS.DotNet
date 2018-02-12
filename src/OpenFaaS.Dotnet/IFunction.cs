namespace OpenFaaS.Dotnet
{
    public interface IFunction
    {
        void Handle(string input);
    }
}
