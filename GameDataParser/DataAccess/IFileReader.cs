using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataParser.DataAccess;

public interface IFileReader
{
    string Read(string fileName);
}