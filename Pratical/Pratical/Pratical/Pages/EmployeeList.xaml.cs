using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Newtonsoft.Json;
using Pratical.models;
using Pratical.Service;



// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Pratical.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class EmployeeList : Page
    {
        public EmployeeList()
        {
            this.InitializeComponent();
            Write_file();
        }
        private async void getEMP(object sender, RoutedEventArgs e)
        {
            FileHandleService readFile = new FileHandleService();
            Employee employee = await readFile.ReadJson("employee.json");
            if (employee != null)
            {
                List_employee.ItemsSource = employee.employee_list;
            }

        }
        private void Write_file()
        {
            string json = @"{
            'employee_list': [
        {
          'name': 'Peter Parker',
          'role': 'Developer',
          'birthyear': 1990
         },
        {
          'name': 'Tom Hank',
          'role': 'Tester',
          'birthyear': 1991
        },
        {
          'name': 'Mary Jane',
          'role': 'QA',
          'birthyear': 1994
    }
  ]
}";
            FileHandleService.WriteFile("employee.json", json);
        }




    }

}
