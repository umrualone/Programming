using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Реализуют статическую запись и возврат данных JSON.
    /// </summary>
    public static class Serializer
    {

        /// <summary>
        /// Путь до папки с JSON файлами.
        /// </summary>
        private static string _directoryPath = Environment.ExpandEnvironmentVariables
            (@"%appdata%\ObjectOrientedPractics");

        /// <summary>
        /// Путь до JSON файла <see cref="Item"/>.
        /// </summary>
        private static string _filePathItems = Path.Combine(_directoryPath, "Items.json");

        /// <summary>
        /// Путь до JSON файла <see cref="Customer"/>.
        /// </summary>
        private static string _filePathCustomers = Path.Combine(_directoryPath, "Customers.json");

        /// <summary>
        /// Проверка на наличия папки и JSON файлов.
        /// </summary>
        public static void IsCreateFolderAndFile()
        {
            if (Directory.Exists(_directoryPath) == false)
            {
                Directory.CreateDirectory(_directoryPath);
            }

            if (File.Exists(_filePathItems) == false)
            {
                using (FileStream fstream = new FileStream(_filePathItems, FileMode.Create))
                {
                    var text = "[]";
                    var buffer = Encoding.Default.GetBytes(text);
                    fstream.Write(buffer, 0, buffer.Length);
                }
            }

            if (File.Exists(_filePathCustomers) == false)
            {
                using (FileStream fstream = new FileStream(_filePathCustomers, FileMode.Create))
                {
                    var text = "[]";
                    var buffer = Encoding.Default.GetBytes(text);
                    fstream.Write(buffer, 0, buffer.Length);
                }
            }
        }

        /// <summary>
        /// Возвращает данные <see cref="Item"/> из JSON файла.
        /// </summary>
        /// <returns>Список <see cref="Item"/>.</returns>
        public static List<Item> GetDataItems()
        {
            using (FileStream fstream = new FileStream(_filePathItems, FileMode.OpenOrCreate))
            {
                return JsonSerializer.Deserialize<List<Item>>(fstream);
            }
        }

        /// <summary>
        /// Возвращает данные <see cref="Customer"/> из JSON файла.
        /// </summary>
        /// <returns>Список <see cref="Customer"/>.</returns>
        public static List<Customer> GetDataCustomers()
        {
            using (FileStream fstream = new FileStream(_filePathCustomers, FileMode.OpenOrCreate))
            {
                return JsonSerializer.Deserialize<List<Customer>>(fstream);
            }
        }

        /// <summary>
        /// Обновляет данные JSON файла <see cref="Item"/>.
        /// </summary>
        /// <param name="items">Список <see cref="Item"/>.</param>
        public static void UpdateData(List<Item> items)
        {
            string newData = JsonSerializer.Serialize(items);
            using (FileStream fstream = new FileStream(_filePathItems, FileMode.Create))
            {
                byte[] buffer = Encoding.Default.GetBytes(newData);

                fstream.Write(buffer, 0, buffer.Length);
            }
        }

        /// <summary>
        /// Обновляет данные JSON файла <see cref="Customer"/>.
        /// </summary>
        /// <param name="customers">Список <see cref="Customer"/>.</param>
        public static void UpdateData(List<Customer> customers)
        {
            string newData = JsonSerializer.Serialize(customers);
            using (FileStream fstream = new FileStream(_filePathCustomers, FileMode.Create))
            {
                byte[] buffer = Encoding.Default.GetBytes(newData);

                fstream.Write(buffer, 0, buffer.Length);
            }
        }
    }
}
