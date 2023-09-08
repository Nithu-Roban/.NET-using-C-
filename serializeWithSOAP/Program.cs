using System;
using System.IO;
using System.Xml.Serialization;
[Serializable]
public class Student
{
    public int rno;
    public string name;
    public Student(){ }
     public Student(int rno, string name)
     { 
        this.rno = rno; 
        this.name = name;
     }
}
public class Program
{
    public static void Main(string[] args)
    {
        Student s = new Student(1,"Anna");
        //Student st = new Student(2, "Nithu");
        //serializing with SOAP
        XmlSerializer serializer = new XmlSerializer(typeof(Student));
        FileStream fs = new FileStream("E:\\nithu\\serialSOAP.txt", FileMode.OpenOrCreate);
        serializer.Serialize(fs, s);
        //serializer.Serialize(fs, st);
        //Deserialize
        fs.Position = 0;
        Student s1 = (Student)serializer.Deserialize(fs);
        Console.WriteLine("Deserialized object");
      
            Console.WriteLine($"Name : {s1.name}\n rollno : {s.rno}");
        
    }
}