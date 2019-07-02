using System;

namespace ConsoleApp {

    // https://www.syncfusion.com/faq/813/how-to-determine-which-panel-in-the-windows-forms-statusbar-control-is-clicked
    // https://docs.microsoft.com/en-us/dotnet/framework/winforms/controls/how-to-add-panels-to-a-statusbar-control
    // https://www.c-sharpcorner.com/uploadfile/mahesh/statusbar-in-C-Sharp/
    
    public class Bar {
        public static Bar {
            private void statusBar1_PanelClick (object sender,
                System.Windows.Forms.StatusBarPanelClickEventArgs e) {
                switch (statusBar1.Panels.IndexOf (e.StatusBarPanel)) {
                    case 0:
                        MessageBox.Show ("You have clicked Panel One.");
                        break;
                    case 1:
                        MessageBox.Show ("You have clicked Panel Two.");
                        break;
                }
            }
            //Place the following code in the form’s constructor to register the event handler.

            this.statusBar1.PanelClick += new
            System.Windows.Forms.StatusBarPanelClickEventHandler (this.statusBar1_PanelClick);
        }
    }
}