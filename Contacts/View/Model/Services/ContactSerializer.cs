using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;

namespace View.Model.Services
{
    /// <summary>
    /// Хранит функции для серилизации.
    /// </summary>
    public static class ContactSerializer
    {
        /// <summary>
        /// Хранит путь до файла.
        /// </summary>
        private static string _path = Environment.GetFolderPath(Environment.SpecialFolder.
            MyDocuments) + "\\Contacts\\contacts.json";

        /// <summary>
        /// Записывает объект класса <see cref="Contact"/> в файл.
        /// </summary>
        /// <param name="contact">Записываемый объект.</param>
        public static void Serialize(Contact contact)
        {
            using (FileStream fileStream = new FileStream(_path, FileMode.OpenOrCreate))
            {
                JsonSerializer.SerializeAsync<Contact>(fileStream, contact);
            }
        }
        /// <summary>
        /// Читает объект класса <see cref="Contact"/> из файла.
        /// </summary>
        /// <returns>Прочитанный объект.</returns>
        public static Contact Deserialize()
        {
            using (FileStream fileStream = new FileStream(_path, FileMode.OpenOrCreate))
            {
               return JsonSerializer.Deserialize<Contact>(fileStream);
            }
        }
    }
}
