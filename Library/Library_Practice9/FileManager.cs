using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Practice9
{
    public class FileManager : IFileManager
    {
        private readonly string _path = Directory.GetCurrentDirectory()+"//Logs";
        public FileManager()
        {
            if (!Directory.Exists(_path))
            {
                Directory.CreateDirectory(_path);
            }
        }

        public async Task WriteFile(string ex)
        {
            var filePath = _path + @"\log" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            using (StreamWriter streamWriter = new StreamWriter(filePath, true))
            {
                await streamWriter.WriteLineAsync(DateTime.Now.ToString() + " " + ex.ToString());
                streamWriter.Close();
            }
        }
    }
}
