using System;

namespace task_Ref
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("kamal","abishli","ap204",99,true);
            Student student1 = new Student("ferid", "aliyev", "ap204", 87,true);
            Student student2 = new Student("selim", "selimli", "ap204", 55,false);
            Student student3 = new Student("tural", "huseynov", "ap204", 75,false);
            Student student4 = new Student("kenan", "mehmanov", "ap204", 96,true);
            Console.WriteLine("1-ci hisse");
            student.Fullname();
            student1.Fullname();
            student2.Fullname();
            student3.Fullname();
            student4.Fullname();
            Console.WriteLine("2-ci hisse");
            student.All();
            student.IsGraduated();
            student.Point();
            student1.All();
            student1.IsGraduated();
            student1.Point();
            student2.All();
            student2.IsGraduated();
            student2.Point();
            student3.All();
            student3.IsGraduated();
            student3.Point();
            student4.All();
            student4.IsGraduated();
            student4.Point();

        }
    }
    class Student
    {
        public string name;
        public string surname;
        public string group;
        public byte point;
        public bool isGraduated;

        public Student(string name, string surname, string group, byte point,bool isGraduated)
        {
            this.name = name;
            this.surname = surname;
            this.group = group;
            this.point = point;
            this.isGraduated = isGraduated;
        }

        public void Fullname()
        {
            Console.WriteLine($"Name: {name} Surname: {surname}");
        }

        public void All()
        {
    
            Console.Write($"Name: {name} Surname: { surname} Group:{group} Point: {point} " );
          
        }

        public void IsGraduated()
        {
            if (isGraduated == true)
            {
                Console.WriteLine("Mezun olub");
            }
            else
            {
                Console.WriteLine("Mezun olmayıb");
            }
        }

        public void Point()
        {
            if (point > 80)
            {
                Console.WriteLine("imtahana gire biler");
            }
            else
            {
                Console.WriteLine("imtahana gire bilmez");
            }
        }


    }
}
