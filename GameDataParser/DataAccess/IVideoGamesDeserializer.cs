using GameDataParser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataParser.DataAccess
{
    public interface IVideoGamesDeserializer
    {
        List<VideoGame> DeserializeFrom(string fileName, string fileContents);
    }
}