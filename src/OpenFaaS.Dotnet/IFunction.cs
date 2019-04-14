namespace OpenFaaS.Dotnet
{
    public interface IFunction
    {
        string Handle(string input);
    }
}
