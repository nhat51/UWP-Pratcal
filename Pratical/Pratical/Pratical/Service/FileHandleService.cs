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
        public static async void WriteFile(string fileName, string content)
        {
            var storage = ApplicationData.Current.LocalFolder;
            var Jsonfile = await storage.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(Jsonfile, content);
        }
        public async Task<models.Employee> ReadJson(string fileName)
        {
            var storage = ApplicationData.Current.LocalFolder;
            var EmpJson = await storage.CreateFileAsync(fileName, CreationCollisionOption.OpenIfExists);
            var Jsontext = await FileIO.ReadTextAsync(EmpJson);
            models.Employee employee = JsonConvert.DeserializeObject<models.Employee>(Jsontext);
            return employee;
        }
    }
}
