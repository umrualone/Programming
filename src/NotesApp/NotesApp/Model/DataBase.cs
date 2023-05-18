using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace NotesApp.Model
{
    /// <summary>
    /// Реализует чтение данных и их запись.
    /// </summary>
    public class DataBase
    {
        /// <summary>
        /// Возвращает путь файла.
        /// </summary>
        public string Path { get; private set; }
        
        /// <summary>
        /// Создает экземпляр класса DataBase.
        /// </summary>
        /// <param name="path">Путь файла.</param>
        public DataBase(string path)
        {
            Path = path;
            
            // Проверка на существования файла. Если его нет, создать новый. 
            if (File.Exists(Path) == false)
            {
                using (FileStream fstream = new FileStream(Path, FileMode.Create))
                {
                    var text = "[]";
                    var buffer = Encoding.Default.GetBytes(text);
                    fstream.Write(buffer, 0, buffer.Length);
                }
            }
        }

        /// <summary>
        /// Считывает данные файла и возвращает их List<Note>. 
        /// </summary>
        /// <returns>Данные файла.</returns>
        public List<Note> GetData()
        {
            using (FileStream fstream = new FileStream(Path, FileMode.OpenOrCreate))
            {
                return JsonSerializer.Deserialize<List<Note>>(fstream);   
            }
        }

        /// <summary>
        /// Записывает новые данные в файл.
        /// </summary>
        /// <param name="notes">Новые данные.</param>
        public void UpdateData(List<Note> notes)
        {
            string newDate = JsonSerializer.Serialize(notes);
            using (FileStream fstream = new FileStream(Path, FileMode.Create))
            {
                byte[] buffer = Encoding.Default.GetBytes(newDate);
                
                fstream.Write(buffer, 0, buffer.Length);
            }
        }
        
    }
}