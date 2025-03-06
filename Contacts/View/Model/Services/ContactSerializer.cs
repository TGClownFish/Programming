using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace View.Model.Services
{
    public static class ContactSerializer
    {
        private static string _path = Environment.GetFolderPath(Environment.SpecialFolder.
            MyDocuments) + "\\Contacts\\contacts.json";
        public static void Serialize(Contact contact)
        {
            using (FileStream fileStream = new FileStream(_path, FileMode.OpenOrCreate))
            {
                JsonSerializer.SerializeAsync<Contact>(fileStream, contact);
            }
        }
        public static Contact Deserialize(string path)
        {
            using (FileStream fileStream = new FileStream(_path, FileMode.OpenOrCreate))
            {
               return JsonSerializer.Deserialize<Contact>(fileStream);
            }
        }
    }
}
