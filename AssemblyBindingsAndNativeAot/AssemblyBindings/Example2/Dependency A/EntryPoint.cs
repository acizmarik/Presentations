using Newtonsoft.Json.Linq;

namespace Dependency_A
{
    public static class EntryPoint
    {
        public static void Initialize()
        {
            JToken.Parse("{\"property\": \"value\"}");
        }
    }
}