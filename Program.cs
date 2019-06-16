using System;
using System.Collections.Generic;

namespace CSharpExcercises {
    class Program {
        static void Main (string[] args) {
            string filePath = @"D:\Workspace\CSharpExcercises\Data\data.xml";
            var data = new DataXML () {
                Name = "Daro",
                Surname = "Luczynski",
                Ocuppation = "Software Test Engineer",
                Company = "Aptiv",
                Books = new List<string> () {
                "Mr Thadeus",
                "The art of electrincs"
                }

            };
            var serdes = new SerdesXML ();
            serdes.serialize (data, filePath);
            desPrinter(serdes.deserialize(filePath));
            System.Console.WriteLine("Done");

        }

        public static void desPrinter (DataXML data) {
            System.Console.WriteLine ("Deserialization printing");
            System.Console.WriteLine ($"Name: {data.Name}, Surname: {data.Surname}");
            System.Console.WriteLine ($"Occupation: {data.Ocuppation}, Company: {data.Company}");
            data.Books.ForEach (book => System.Console.WriteLine ($"Book: {book}"));

        }
    }
}