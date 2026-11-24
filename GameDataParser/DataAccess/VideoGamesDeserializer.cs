using GameDataParser.Model;
using GameDataParser.UserInteraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GameDataParser.DataAccess
{
    public class VideoGamesDeserializer : IVideoGamesDeserializer
    {
        private readonly IUserInteractor _userInteractor;

        public VideoGamesDeserializer(IUserInteractor userInteractor)
        {
            _userInteractor = userInteractor;
        }

        public List<VideoGame> DeserializeFrom(string fileName, string fileContents)
        {
            try
            {
                return JsonSerializer.Deserialize<List<VideoGame>>(fileContents)
                       ?? new List<VideoGame>();
            }
            catch (JsonException ex)
            {
                _userInteractor.PrintError(
                    $"JSON in the {fileName} was not in a valid format. JSON body: {fileContents}");
                //_userInteractor.PrintError(fileContents);

                throw new JsonException($"{ex.Message} The file is: {fileName}", ex);
            }
        }
    }
}