using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;

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
        private static string Path { get; } = Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments) + "\\Contacts\\contacts.json";

        /// <summary>
        /// Записывает объект класса <see cref="Contact"/> в файл.
        /// </summary>
        /// <param name="contact">Записываемый объект.</param>
        public static void Serialize(ObservableCollection<Contact> contacts)
        {
            File.Delete(Path);
            using (FileStream fileStream = new FileStream(Path, FileMode.Create))
            {
                JsonSerializer.Serialize<ObservableCollection<Contact>>(fileStream, contacts);
            }
        }
        /// <summary>
        /// Читает объект класса <see cref="Contact"/> из файла.
        /// </summary>
        /// <returns>Прочитанный объект.</returns>
        public static ObservableCollection<Contact> Deserialize()
        {
            using (FileStream fileStream = new FileStream(Path, FileMode.OpenOrCreate))
            {
                try
                {
                    return JsonSerializer.Deserialize<ObservableCollection<Contact>>(fileStream);
                }
                catch (Exception e)
                {
                    return new ObservableCollection<Contact>();
                }
            }
        }
    }
}