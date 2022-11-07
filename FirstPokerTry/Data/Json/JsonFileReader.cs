using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FirstPokerTry.Data
{
    public static class JsonFileReader
    {

        public static JObject GetJsonData() {

            SetJsonDirectory(@"../../../FirstPokerTry/Data/");

            const string jsonPath = "data.json";

            return JObject.Parse(File.ReadAllText(jsonPath));
        }

        /*public void LoadJson()
        {
            object o1 = JObject.Parse(File.ReadAllText(@"c:\data.json"));

            using (StreamReader file = File.OpenText(@"c:\data.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject o2 = (JObject)JToken.ReadFrom(reader);
            }
        }*/

        private static void SetJsonDirectory(string path)
        {
             if (Directory.Exists(path)) Directory.SetCurrentDirectory(path);
        }

    }
}