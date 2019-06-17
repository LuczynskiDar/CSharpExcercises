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
            var flenu = di.EnumerateFiles("*.ini");
            var dirs = di.GetDirectories(); //an array of directoryinfos
            var dirs1 = di.GetDirectories(); //an array of directoryinfos
            var dirsenu = di.EnumerateDirectories();
            System.Console.WriteLine(somes);
        }

    }
}