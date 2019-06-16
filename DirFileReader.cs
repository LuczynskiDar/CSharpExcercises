using System;
using System.IO;

namespace CSharpExcercises {
    public class DirFileReader {
        static public void methody () {
            var somes = Environment.SpecialFolder.Personal;
            // SpecialFolder.Personal
            var sth = Environment.GetFolderPath(somes);
            var di = new DirectoryInfo(sth);
            var fils = di.GetFiles();
            var fls  = di.GetFiles("*.ini"); // an array of file info
            var dirs = di.GetDirectories(); //an array of directoryinfos
            System.Console.WriteLine(somes);
        }

    }
}