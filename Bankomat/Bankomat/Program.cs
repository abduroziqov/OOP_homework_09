using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Bankomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> listStudents = new List<Student>();

            listStudents.Add(new Student(1, "Abdulloh Halilov", "+998998153214"));
            listStudents.Add(new Student(2, "Abdumuxtorov Xojianvar", "+998946154212"));
            listStudents.Add(new Student(3, "Axrorbek Yo'ldoshov", "+998919793211"));
            listStudents.Add(new Student(4, "Asadbek Murodaliyev", "+998998153214"));
            listStudents.Add(new Student(5, "Asatov Ergash", "+998902021454"));
            listStudents.Add(new Student(6, "Avazbek Muqimjonov", "+998944562"));
            listStudents.Add(new Student(7, "Azamat G'iyosov", "+998977422336"));
            listStudents.Add(new Student(8, "Aziz Samadov", "+998931425425"));
            listStudents.Add(new Student(9, "Diyor Axmatov", "+998998153214"));
            listStudents.Add(new Student(10, "Humoyunmirzo", "+998 90 536 77 32"));
            listStudents.Add(new Student(11, "Dilshodbek", "+998 93 533 12 75"));
            listStudents.Add(new Student(12, "Nurbek", "+998 99 526 46 64"));
            listStudents.Add(new Student(13, "Quvonchbek", "+998 90 035 69 28"));
            listStudents.Add(new Student(14, "Sharafiddin", "+998 91 844 45 19"));
            listStudents.Add(new Student(15, "Muhammadali", "+998 94 933 24 35"));
            listStudents.Add(new Student(16, "Temurbek", "+998 91 319 85 26"));
            listStudents.Add(new Student(17, "Tursunboy", "+998 94 114 56 75"));
            listStudents.Add(new Student(18, "Chingizbek", "+998 93 375 25 52"));
            listStudents.Add(new Student(19, "Xusan", "+998 90 827 11 85"));
            listStudents.Add(new Student(20, "Zarina", "+998 99 452 12 24"));
            listStudents.Add(new Student(21, "Xojiakbar", "+998 94 555 44 33"));
            listStudents.Add(new Student(22, "Zikrillo", "+998 91 156 24 65"));
            listStudents.Add(new Student(23, "Mahmudjon", "+998 97 295 47 32"));

            Console.Write("Enter ID : ");
            int getId = Convert.ToInt32(Console.ReadLine());

            long startTime = Stopwatch.GetTimestamp();

            foreach (Student student in listStudents)
            {
                if (getId == student.Id)
                {                
                    Console.WriteLine($"Student ID : {student.Id}, Student Name : {student.FullName}, Student Phone number : {student.PhoneNumber}");                    
                }
                
            }
            TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
            Console.WriteLine(elapsedTime);
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        public Student(int id, string fullName, string phoneNumber)
        {
            Id = id;
            FullName = fullName;
            PhoneNumber = phoneNumber;
        }
    }
}