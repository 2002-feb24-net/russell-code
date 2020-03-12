using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "../../../data.json";
            List<Person> data = null;
            if (!File.Exists(filePath))
            {
                data = GetInitialData();

                string json = ConvertToJson(data);

                WriteToFile(json, filePath);
            }
            else
            {
                // read JSON from the file + deserialize it
                string json3 = ReadFromFile(filePath);
                data = JsonSerializer.Deserialize<List<Person>>(json3);
            }
            ModifyPersons(data);

        }

        private static void ModifyPersons(List<Person> data)
        {
            foreach (var person in data)
            {
                person.Id++;
            }
        }

        private static void WriteToFile(string text, string path)
        {
            var file = new FileStream(path, FileMode.Create);
            byte[] data = Encoding.UTF8.GetBytes(text);
            file.Write(data);
            file.Close();
        }

        private static string ReadFromFile(string path)
        {   
            string data = File.ReadAllText(path);
            return data;
        }

        private static string ConvertToJson(List<Person> data)
        {
            return JsonSerializer.Serialize(data);
        }

        static List<Person> GetInitialData()
        {
            var list = new List<Person>();
            var mark = new Person { Id = 1, Name = "Mark", Children = {
                new Person{ Id = 2, Name = "Ethan" },
                new Person{ Id = 3, Name = "Hope" },
                new Person{ Id = 4, Name = "Maya" } } };
            var nick = new Person { Id = 5, Name = "Nick" };
            list.Add(new Person { Name = "Russell", Id = 6 });
            list.Add(nick);
            list.Add(mark);

            return list;
        }
    }
}
