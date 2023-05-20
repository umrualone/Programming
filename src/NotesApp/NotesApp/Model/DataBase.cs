using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace NotesApp.Model
{
    /// <summary>
    /// Реализует статическую сериализацию и десериализацию json файла.
    /// </summary>
    public static class DataBase
    {
        
        /// <summary>
        /// Путь до папки.
        /// </summary>
        private static string directoryPath = Environment.ExpandEnvironmentVariables(@"%appdata%\NotesApps");
        
        /// <summary>
        /// Путь до файла.
        /// </summary>
        private static string filePath = Path.Combine(directoryPath, "Notes.json");

        /// <summary>
        /// Проверка на наличия папки и файла.
        /// </summary>
        public static void IsCreateFolderAndFile()
        {
            if (Directory.Exists(directoryPath) == false)
            {
                Directory.CreateDirectory(directoryPath);
            }

            if (File.Exists(filePath) == false)
            {
                using (FileStream fstream = new FileStream(filePath, FileMode.Create))
                {
                    var text = "[]";
                    var buffer = Encoding.Default.GetBytes(text);
                    fstream.Write(buffer, 0, buffer.Length);
                }
            }
        }
        
        /// <summary>
        /// Считывает данные файла и возвращает их список. 
        /// </summary>
        /// <returns>Данные файла.</returns>
        public static List<Note> GetData()
        {
            using (FileStream fstream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                return JsonSerializer.Deserialize<List<Note>>(fstream);   
            }
        }

        /// <summary>
        /// Записывает новые данные в файл.
        /// </summary>
        /// <param name="notes">Новые данные.</param>
        public static void UpdateData(List<Note> notes)
        {
            string newDate = JsonSerializer.Serialize(notes);
            using (FileStream fstream = new FileStream(filePath, FileMode.Create))
            {
                byte[] buffer = Encoding.Default.GetBytes(newDate);
                
                fstream.Write(buffer, 0, buffer.Length);
            }
        }
        
    }
}