using Exampagin.Models;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Exampagin
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ListStudent : Page
    {
        private int status = 0;
        public ListStudent()
        {
            this.InitializeComponent();
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
           /* List<Student> list = new List<Student>();
            var conn = new SQLiteConnection("databaseStudent.db");
            var sqlCommadString = "select * from Students where status = ?";
            using (var statment = conn.Prepare(sqlCommadString))
            {
                while (statment.Step() == SQLiteResult.ROW)
                {
                    list.Add(new Student()
                    {   
                        id= Convert.ToInt32(statment["Id"]),
                        rollnumber = (string)statment["Rollnumber"],
                        name = (string)statment["Name"],
                        status = Convert.ToInt32(statment["Status"])

                    });*/
                //}
            //}

        }
    }
}
