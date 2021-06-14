using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Newtonsoft.Json;


namespace Pratical.Service
{
    class FileHandleService
    {
        public async Task<models.EmployeeModel> ReadJson()
        {
            var storage = ApplicationData.Current.LocalFolder;
            var EmpJson = await storage.CreateFileAsync("employee.json", CreationCollisionOption.OpenIfExists);
            var Jsontext = await FileIO.ReadTextAsync(EmpJson);
            models.EmployeeModel employee = JsonConvert.DeserializeObject<models.EmployeeModel>(Jsontext);
            return employee;
        }
    }
}
