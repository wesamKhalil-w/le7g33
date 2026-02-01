using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic.Services
{
    internal class DataService
    {
        private string dataPath;

        public DataService()
        {
            dataPath = Path.Combine(Application.StartupPath, "Data");

            if (!Directory.Exists(dataPath))
            {

                Directory.CreateDirectory(dataPath);
            }
        }

        public void SaveData<T>(List<T> data, string fileName)
        {
            try
            {
                string json = JsonConvert.SerializeObject(data, Formatting.Indented);
                File.WriteAllText(Path.Combine(dataPath, fileName), json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}");

            }
        }

        public List<T> LoadData<T>(string fileName)
        {
            try
            {
                string filePath = Path.Combine(dataPath, fileName);
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    return JsonConvert.DeserializeObject<List<T>>(json);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error loading data: {ex.Message}");
            }
            return new List<T>();
        }
    }
}



