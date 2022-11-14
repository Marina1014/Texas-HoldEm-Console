#nullable disable

using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using FirstPokerTry.Logics.Objects;

namespace FirstPokerTry.Data
{
    public static class JsonFileReader
    {   
        public static List<CardObject> ReadJsonFile(string path)
        {
            try
            {
                var json = System.IO.File.ReadAllText(path);
                return JsonConvert.DeserializeObject<List<CardObject>>(json);
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

        public static List<CardObject> GetJsonData()
        {
            SetJsonDirectory(@"../../../Data/Json/");
            return ReadJsonFile("data.json");
        }

        /*public static JArray GetJsonArray()
        {
            return (JArray) GetJsonData()["data"];
        }*/

    }
}