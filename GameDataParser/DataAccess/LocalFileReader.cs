using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataParser.DataAccess
{
    public class LocalFileReader : IFileReader
    {
        public string Read(string fileName) => File.ReadAllText(fileName);
    }
}