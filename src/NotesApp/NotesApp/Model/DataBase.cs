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
        private static string _directoryPath = Environment.ExpandEnvironmentVariables(@"%appdata%\NotesApps");
        
        /// <summary>
        /// Путь до файла.
        /// </summary>
        private static string _filePath = Path.Combine(_directoryPath, "Notes.json");

        /// <summary>
        /// Проверка на наличия папки и файла.
        /// </summary>
        public static void IsCreateFolderAndFile()
        {
            if (Directory.Exists(_directoryPath) == false)
            {
                Directory.CreateDirectory(_directoryPath);
            }

            if (File.Exists(_filePath) == false)
            {
                using (FileStream fstream = new FileStream(_filePath, FileMode.Create))
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
            using (FileStream fstream = new FileStream(_filePath, FileMode.OpenOrCreate))
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
            using (FileStream fstream = new FileStream(_filePath, FileMode.Create))
            {
                byte[] buffer = Encoding.Default.GetBytes(newDate);
                
                fstream.Write(buffer, 0, buffer.Length);
            }
        }
        
    }
}