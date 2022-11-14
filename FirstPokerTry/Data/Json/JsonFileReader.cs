#nullable disable

using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FirstPokerTry.Data
{
    public static class JsonFileReader
    {   
        public static JArray ReadJsonFile(string path)
        {
            try
            {
                var json = System.IO.File.ReadAllText(path);
                return JsonConvert.DeserializeObject<JArray>(json);
            }
            catch (JsonReaderException e)
            {
                Console.WriteLine("Error reading json file: " + e);
                throw;
            }
        }
        private static void SetJsonDirectory(string path) {
            var directory = new DirectoryInfo(path);
            if (!directory.Exists) {
                directory.Create();
            }
            Directory.SetCurrentDirectory(directory.FullName);
        }

        public static JArray GetJsonData()
        {
            SetJsonDirectory(@"../../../FirstPokerTry/Data/Json/");
            return ReadJsonFile("data.json");
        }

        /*public static JArray GetJsonArray()
        {
            return (JArray) GetJsonData()["data"];
        }*/

    }
}