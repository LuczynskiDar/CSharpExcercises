using System;

namespace CSharpExcercises {
    public class ComConnect {

            public void OnSerdesed(Object obj, SerdesEventArgs e)
            {
                System.Console.WriteLine("Sending an email..." + e.Data.Name);
            }

    }
}