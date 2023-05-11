using System.Diagnostics;

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
            listStudents.Add(new Student(10, "Humoyunmirzo", "+998905367732"));
            listStudents.Add(new Student(11, "Dilshodbek", "+998935331275"));
            listStudents.Add(new Student(12, "Nurbek", "+998995264664"));
            listStudents.Add(new Student(13, "Quvonchbek", "+998900356928"));
            listStudents.Add(new Student(14, "Sharafiddin", "+998918444519"));
            listStudents.Add(new Student(15, "Muhammadali", "+998949332435"));
            listStudents.Add(new Student(16, "Temurbek", "+998913198526"));
            listStudents.Add(new Student(17, "Tursunboy", "+998941145675"));
            listStudents.Add(new Student(18, "Chingizbek", "+998933752552"));
            listStudents.Add(new Student(19, "Xusan", "+998908271185"));
            listStudents.Add(new Student(20, "Zarina", "+998994521224"));
            listStudents.Add(new Student(21, "Xojiakbar", "+998945554433"));
            listStudents.Add(new Student(22, "Zikrillo", "+998911562465"));
            listStudents.Add(new Student(23, "Mahmudjon", "+998972954732"));

            Console.Write("Enter ID : ");

            int.TryParse(Console.ReadLine(), out int getId);

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