using SQLitePCL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Exampagin
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private int status = 0;
        public MainPage()
        {
            this.InitializeComponent();
            processSQLite();
        }

        private void processSQLite()
        {
            var conn = new SQLiteConnection("databaseStudent.db");
            var sqlCommadString = "CREATE TABLE IF NOT EXISTS Students (Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                "Rollnumber varchar(255) unique,Name VARCHAR( 255 ),Status interger)";
            var statment = conn.Prepare(sqlCommadString);
            statment.Step();
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var chooseStatus = (RadioButton)sender;
            if (chooseStatus == null)
            {
                return;
            }
            switch (chooseStatus.Tag)
            {
                case "Active":
                    status = 1;
                    break;
                case "Deactive":
                    status = 0;
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var rollnumber = StudentRoll.Text;
            var name = StudentName.Text;

            var conn = new SQLiteConnection("databaseStudent.db");
            var sqlCommadString = "INSERT INTO Students(Rollnumber,Name,Status) VALUES(?, ?, ?)";
            var statment = conn.Prepare(sqlCommadString);
            statment.Bind(1, rollnumber);
            statment.Bind(2, name);
            statment.Bind(3, status);
            statment.Step();

        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ListStudent));
        }
    }
}
