using FirstPokerTry.Logics.CardFactory.Classes;
using Newtonsoft.Json;

namespace FirstPokerTry.Data.Json;

    public class JsonGameRecordFileWriter
    {
        public static void WriteJsonFile(string path, List<Game> games)
        {
            try
            {
                var json = JsonConvert.SerializeObject(games, Formatting.Indented);
                System.IO.File.WriteAllText(path, json);
            }
            catch (JsonWriterException e)
            {
                Console.WriteLine("Error writing json file: " + e);
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

        public static void WriteJsonGameRecord(List<Game> games)
        {
            SetJsonDirectory(@"../../../Data/Json/");
            WriteJsonFile("gamerecord.json", games);
        }
        
    }

