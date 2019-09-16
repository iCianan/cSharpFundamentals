using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Core
{
    public class Generics<T>
    {
        public static string[] GenerateNamesArray()
        {
            string[] names = new string[4];
            names[0] = "Gamma";
            names[1] = "Vlissides";
            names[2] = "Johnson";
            names[3] = "Helm";
            return names;
        }
        public static ArrayList GenerateNamesArrayList()
        {
            ArrayList names = new ArrayList();
            names.Add("Gamma");
            names.Add("Vlissides");
            names.Add("Johnson");
            names.Add("Helm");
            return names;
        }
        public static StringCollection GenerateNameStringCollection()
        {
            StringCollection names = new StringCollection();
            names.Add("Gamma");
            names.Add("Vlissides");
            names.Add("Johnson");
            names.Add("Helm");
            return names;
        }
        //public static List<T> GenerateNames()
        //{
        //    List<T> names = new List<T>();
        //    names.Add("Gamma");
        //    names.Add("Vlissides");
        //    names.Add("Johnson");
        //    names.Add("Helm");
        //    return names;
        //}
        public static void PrintNames(List<string> names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

    }
}
