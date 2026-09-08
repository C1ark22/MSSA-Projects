using System;
using System.IO;
using System.Security.Cryptography;
using System.Text.Json;
using System.Xml.Serialization;

namespace Assignment_10._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JSONFormat();

            XMLFormat();

            BinaryFormat();

        }
        public static void JSONFormat()
        {
            Student student = new Student()
            {
                FirstName = "John",
                LastName = "Doe",
                StudentId = 12345
            };
            // Serialize
            // taking the student object and serializing it to JSON format
            string json = JsonSerializer.Serialize(student);

            File.WriteAllText("student.json", json);

            // Deserialize
            string jsonFromFile = File.ReadAllText("student.json");

            Student? studentFromJson =
                JsonSerializer.Deserialize<Student>(jsonFromFile);

            Console.WriteLine(studentFromJson?.FirstName);
            Console.WriteLine(studentFromJson?.LastName);
            Console.WriteLine(studentFromJson?.StudentId);
        }
        public static void XMLFormat()
        {
            Student student = new Student()
            {
                FirstName = "Karen",
                LastName = "Doe",
                StudentId = 67891
            };
            // Serialize
            // taking the student object and serializing it to XML format
            XmlSerializer serializer = new XmlSerializer(typeof(Student));

            using (FileStream file = new FileStream
                ("student.xml", FileMode.Create))
            {
                serializer.Serialize(file, student);
            }

            // Deserialize
            using (FileStream file = new FileStream
                ("student.xml", FileMode.Open))
            {
                Student? studentFromXml =
                    (Student?)serializer.Deserialize(file);

                Console.WriteLine(studentFromXml?.FirstName);
                Console.WriteLine(studentFromXml?.LastName);
                Console.WriteLine(studentFromXml?.StudentId);
            }

        }
        public static void BinaryFormat()
        {
            Student student = new Student()
            {
                FirstName = "Bob",
                LastName = "Doe",
                StudentId = 54321
            };
            // Serialize
            // taking the student object and serializing it to binary format
            using (FileStream file = new FileStream
                ("student.dat", FileMode.Create))
            {
                using (BinaryWriter writer = new BinaryWriter(file))
                {
                    writer.Write(student.FirstName);
                    writer.Write(student.LastName);
                    writer.Write(student.StudentId);
                }
            }
            // Deserialize
            using (FileStream file = new FileStream
                ("student.dat", FileMode.Open))
            {
                using (BinaryReader reader = new BinaryReader(file))
                {
                    Student studentFromBinary = new Student()
                    {
                        FirstName = reader.ReadString(),
                        LastName = reader.ReadString(),
                        StudentId = reader.ReadInt32()
                    };
                    Console.WriteLine(studentFromBinary.FirstName);
                    Console.WriteLine(studentFromBinary.LastName);
                    Console.WriteLine(studentFromBinary.StudentId);
                }
            }
        }
    }
}
