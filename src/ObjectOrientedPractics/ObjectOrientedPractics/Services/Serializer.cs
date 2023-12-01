using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

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
            return JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(_filePathItems), new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.All,
                TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple,
            });
        }

        /// <summary>
        /// Возвращает данные <see cref="Customer"/> из JSON файла.
        /// </summary>
        /// <returns>Список <see cref="Customer"/>.</returns>
        public static List<Customer> GetDataCustomers()
        {
            return JsonConvert.DeserializeObject<List<Customer>>(File.ReadAllText(_filePathCustomers), new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.All,
                TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple,
            });
        }

        /// <summary>
        /// Возвращает последний id товара.
        /// </summary>
        /// <returns>Id <see cref="Model.Item"/>.</returns>
        public static int DeserializeIdItem()
        {
            try
            {
                var liat = GetDataItems();
                return liat[liat.Count - 1].Id;
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Возвращает последний id покупателя.
        /// </summary>
        /// <returns>Id <see cref="Model.Customer"/>.</returns>
        public static int DeserializeIdCustomer()
        {
            try
            {
                var liat = GetDataCustomers();
                return liat[liat.Count - 1].Id;
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Возвращает последний id заказа.
        /// </summary>
        /// <returns>Id <see cref="Model.Order"/>.</returns>
        public static int DeserializeIdOrder()
        {
            try
            {
                var s = 0;
                var li = GetDataCustomers();
                foreach (var item in li)
                {
                    foreach (var c in item.Orders)
                    {
                        if (s < c.Id)
                        {
                            s = c.Id;
                        }
                    }
                }
                return s;
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Обновляет данные JSON файла <see cref="Item"/>.
        /// </summary>
        /// <param name="items">Список <see cref="Item"/>.</param>
        public static void UpdateData(List<Item> items)
        {
            string newData = JsonConvert.SerializeObject(items, Formatting.Indented, new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.All,
            });
            File.WriteAllText(_filePathItems, newData);
        }

        /// <summary>
        /// Обновляет данные JSON файла <see cref="Customer"/>.
        /// </summary>
        /// <param name="customers">Список <see cref="Customer"/>.</param>
        public static void UpdateData(List<Customer> customers)
        {
            string newData = JsonConvert.SerializeObject(customers, Formatting.Indented, new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.All,
            });
            File.WriteAllText(_filePathCustomers, newData);
        
        }
    }
}
