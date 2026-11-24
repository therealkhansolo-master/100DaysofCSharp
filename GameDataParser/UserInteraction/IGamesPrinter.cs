using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDataParser.Model;

namespace GameDataParser.UserInteraction;

public interface IGamesPrinter
{
    void Print(List<VideoGame> videoGames);
}