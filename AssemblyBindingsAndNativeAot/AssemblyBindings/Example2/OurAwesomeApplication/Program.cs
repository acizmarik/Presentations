namespace OurAwesomeApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dependency_A.EntryPoint.Initialize();
            Dependency_B.EntryPoint.Initialize();
        }
    }
}