#nullable disable

using System;
using FirstPokerTry.Logics.Objects;
using Newtonsoft.Json;

namespace FirstPokerTry.Data.Json
{
    public class JsonPlayersFileReader
    {
        public static List<PlayerObject> ReadJsonFile(string path)
        {
            try
            {
                var json = System.IO.File.ReadAllText(path);
                return JsonConvert.DeserializeObject<List<PlayerObject>>(json);
            }
            catch (JsonReaderException e)
            {
                Console.WriteLine("Error reading json file: " + e);
                throw;
            }
        }
        private static void SetJsonDirectory(string path)
        {
            var directory = new DirectoryInfo(path);
            if (!directory.Exists)
            {
                directory.Create();
            }
            Directory.SetCurrentDirectory(directory.FullName);
        }

        public static List<PlayerObject> GetJsonPlayers()
        {
            SetJsonDirectory(@"../../../Data/Json/");
            return ReadJsonFile("./players.json");
        }
    }
}

