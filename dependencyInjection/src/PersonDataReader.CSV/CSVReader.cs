using PeopleViewer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataReader.CSV
{
    public class CSVReader : IPersonReader
    {
        public ICSVFileLoader FileLoader { get; set; }
        public CSVReader()
        {
            string filePath = $"{AppDomain.CurrentDomain.BaseDirectory} People.txt";
            FileLoader = new CSVFileLoader(filePath);
        }
        public IEnumerable<Person> GetPeople()
        {
            var fileData = FileLoader.LoadFile();
            var people = ParseDataString(fileData);
            return people;
        }

        public Person GetPerson(int id)
        {
            throw new NotImplementedException();
        }
        private IEnumerable<Person> ParseDataString(string csvData)
        {

        }

        private Person ParsePersonString(string personData)
        {
            var elements = personData.Split(',');
            var person = new Person()
            {
                Id = int.Parse(elements[0]),
                GivenName = elements[1],
                FamilyName = elements[2],
                StartDate = DateTime.Parse(elements[3]),
                Rating = int.Parse(elements[4]),
                FormatString = elements[5]
            };
            return person;
        }
    }

    
}
