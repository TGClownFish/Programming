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
        private static string Path { get; } = Environment.GetFolderPath(Environment.SpecialFolder.
            MyDocuments) + "\\Contacts\\contacts.json";

        /// <summary>
        /// Записывает объект класса <see cref="Contact"/> в файл.
        /// </summary>
        /// <param name="contact">Записываемый объект.</param>
        public static void Serialize(Contact contact)
        {
            File.Delete(Path);
            using (FileStream fileStream = new FileStream(Path, FileMode.Create))
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
            using (FileStream fileStream = new FileStream(Path, FileMode.OpenOrCreate))
            {
                return JsonSerializer.Deserialize<Contact>(fileStream);
            }
        }
    }
}
