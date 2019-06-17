using System;
using System.Collections.Generic;

namespace CSharpExcercises
{
    class Program
    {
        static void Main(string[] args)
        {
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

             var com = new ComConnect(); // subscriber
             serdes.Serdesed += com.OnSerdesed;


        }
    }
}
