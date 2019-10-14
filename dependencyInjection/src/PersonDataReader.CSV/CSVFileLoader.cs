using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataReader.CSV
{
    public class CSVFileLoader
    {
        private string _filePath;
        public CSVFileLoader(string filePath)
        {
            _filePath = filePath;
        }
        public string LoadFile()
        {
            using (var reader = new StreamReader(_filePath))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
