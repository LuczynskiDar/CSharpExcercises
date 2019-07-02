using System;

namespace ConsoleApp {

    // links
    // https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.process.start?view=netframework-4.8#System_Diagnostics_Process_Start_System_String_System_String_System_Security_SecureString_System_String_
    // https://stackoverflow.com/questions/8997880/opening-an-already-existing-txt-file-on-button-click-in-c-sharp-windows-form
    // https://stackoverflow.com/questions/4055266/open-a-file-with-notepad-in-c-sharp

    public class Process {
        public static Method {
            Process p = new Process ();
            ProcessStartInfo ps = new ProcessStartInfo ();
            ps.FileName = "NotePad.exe";
            ps.Arguments = "C:\\Users\\gaurav_joshi\\My Documents\\test.txt";
            p.StartInfo = ps;
            p.Start ();

            String file_name = "c:\\log.txt";
            Process.start ("notepad", file_name);
            System.Diagnostics.Process.Start ("notepad.exe", "text.txt");

            var fileToOpen = "SomeFilePathHere";
            var process = new Process ();
            process.StartInfo = new ProcessStartInfo () {
                UseShellExecute = true,
                FileName = fileToOpen
            };

            process.Start ();
            process.WaitForExit ();
        }
    }