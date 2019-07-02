using System;
using System.IO;
using System.Text;

class Test
{

    // https://docs.microsoft.com/en-us/dotnet/api/system.io.file.writealltext?view=netframework-4.8
    // https://stackoverflow.com/questions/43701338/create-and-write-on-txt-file-using-c-sharp
    // https://stackoverflow.com/questions/7569904/easiest-way-to-read-from-and-write-to-files

    // Process inf and file IO
    // https://stackoverflow.com/questions/2837020/open-existing-file-append-a-single-line

    public static void Main()
    {
        string path = @"c:\temp\MyTest.txt";

        // This text is added only once to the file.
        if (!File.Exists(path))
        {
            // Create a file to write to.
            string createText = "Hello and Welcome" + Environment.NewLine;
            File.WriteAllText(path, createText);
        }

        // This text is always added, making the file longer over time
        // if it is not deleted.
        string appendText = "This is extra text" + Environment.NewLine;
        File.AppendAllText(path, appendText);

        // Open the file to read from.
        string readText = File.ReadAllText(path);
        Console.WriteLine(readText);

        // Create the file.
        using (FileStream fs = File.Create(path))
        {
        System.IO.File.WriteAllText(path, "Text to add to the file\n");
        }
    }
}

