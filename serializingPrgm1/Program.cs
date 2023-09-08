using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
[Serializable]

    public class Student
    {
        public int rollno;
        public string name;
        public Student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }

    }
    public class SerializeExample
    {
        public static void Main(string[] args)
        {
            FileStream fs = new FileStream("E:\\nithu\\serialDeserialFile.txt", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            Student s = new Student(101, "Nithu");
            // serialization
            bf.Serialize(fs, s);
            Console.WriteLine("Object is stored in the file");

            //deserializing

            deserializing.disp();
            fs.Close();
        }
    }
    public class deserializing
    {
        public static void disp()
        {
            FileStream fs = new FileStream("E:\\nithu\\SerializedFile.txt", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();

            Student S = (Student)bf.Deserialize(fs);
            Console.WriteLine("RollNo: " + S.rollno);
            Console.WriteLine("Name: " + S.name);
        }
    }
