using Newtonsoft.Json.Linq;

namespace Dependency_B
{
    public static class EntryPoint
    {
        public static void Initialize()
        {
            JToken.Parse("{\"property\": \"value\"}");
        }
    }
}