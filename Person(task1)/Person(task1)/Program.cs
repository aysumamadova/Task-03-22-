using System;
using Person_task1_.Models;

namespace Person_task1_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string surname = "";
            int age = 0;
            double workingHour = 0;
            double salaryOfHoure = 0;
            double salary = 0;
            double IQRank = 0;
            double LanguageRank = 0;
            double Exam = 0;
            int Key;
            do
            {
                Console.WriteLine("Reqem daxil edin");
                    Console.WriteLine("1.Maaşın hesablanması");
                Console.WriteLine("2.Imtahan balinin hesablanması"); 
               Key= Convert.ToInt32(Console.ReadLine());

                switch (Key)
                {
                    case 1:
                        InputEmployee(name, surname, age,ref workingHour,ref salaryOfHoure);
                        Employee emp = new Employee(name, surname, age, workingHour, salaryOfHoure);
                        emp.CalculateSalary(salaryOfHoure,workingHour,salary);
                       break;
                    case 2:
                        InputStudent(name, surname, age, ref IQRank, ref LanguageRank);
                        Student stu = new Student(name, surname, age, IQRank, LanguageRank);
                        stu.ExamResult(LanguageRank,IQRank,Exam);
                        break;
                    default:
                        Console.WriteLine("Yanlis daxil etdiniz");
                        break;
                }

            } while (Key!=3);

            static void InputEmployee( string name, string surname, int age,ref double workingHour,ref double salaryOfHour)
            {
                EmpName(name);
                EmpSurname(surname);
                EmpAge(age);
                EmpWorkingHour(ref workingHour);
                EmpSalaryOfHour(ref salaryOfHour);

            }

            static void EmpName(string name)
            {
                Console.WriteLine("Iscinin adini daxil edin");
               name = Convert.ToString(Console.ReadLine());

            }

            static void EmpSurname(string surname)
            {
                Console.WriteLine("Iscinin soyadini daxil edin");
                surname = Convert.ToString(Console.ReadLine());
            }

            static void EmpAge(int age)
            {
                do
                {
                    Console.WriteLine("Iscinin yasini daxil edinn");
                    age = Convert.ToInt32(Console.ReadLine());
                    if (age < 18 || age >= 70)
                    {
                        Console.WriteLine("Islemek olmaz");
                    }

                } while (age < 18 || age >=70);
            }

            static void EmpWorkingHour(ref double workingHour)
            {
                do
                {
                    Console.WriteLine("Ayliq is saatini daxil edin");
                    workingHour = Convert.ToDouble(Console.ReadLine());
                    if (workingHour <= 0 || workingHour > 240)
                    {
                        Console.WriteLine("Duzgun is sati deyil");
                    }

                } while (workingHour <= 0 || workingHour > 240);
            }
            static void EmpSalaryOfHour( ref double salaryOfHour)
            {
                do
                {
                    Console.WriteLine("Saat basi qadanzigi maasi daxil edin");
                    salaryOfHour = Convert.ToDouble(Console.ReadLine());
                    if (salaryOfHour <= 0)
                    {
                        Console.WriteLine("Yanlis daxil edildi");
                    }

                } while (salaryOfHour <= 0);
                
            }


            static void InputStudent(string name, string surname, int age, ref double IQRank, ref double LanguageRank)
            {

                StuName(name);
                StuSurname(surname);
                StuAge(age);
                StuIQRank(ref IQRank);
                StuLanguageRank(ref LanguageRank);

            }
            static void StuName(string name)
            {
                Console.WriteLine("Sagirdin adini daxil edin");
                name = Convert.ToString(Console.ReadLine());

            }

            static void StuSurname(string surname)
            {
                Console.WriteLine("Sagirdin soyadini daxil edin");
                surname = Convert.ToString(Console.ReadLine());
            }

            static void StuAge(int age)
            {
                do
                {
                    Console.WriteLine("Sagirdin yasini daxil edin");
                    age = Convert.ToInt32(Console.ReadLine());
                    if (age < 6 || age >20)
                    {
                        Console.WriteLine("Sagird deyil");
                    }

                } while (age < 6 || age > 20);
            }

            static void StuIQRank(ref double IQRank)
            {
                do
                {
                    Console.WriteLine("IQ imtahan bali");
                  IQRank = Convert.ToDouble(Console.ReadLine());
                    if (IQRank < 0 || IQRank > 100)
                    {
                        Console.WriteLine("Duzgun  deyil");
                    }

                } while (IQRank< 0 || IQRank > 240);
            }
            
            static void StuLanguageRank(ref double LanguageRank)
            {
                do
                {
                    Console.WriteLine("Dil imtahan bali");
                    LanguageRank = Convert.ToDouble(Console.ReadLine());
                    if (LanguageRank < 0 || LanguageRank > 100)
                    {
                        Console.WriteLine("Duzgun  deyil");
                    }

                } while (LanguageRank < 0 || LanguageRank > 240);
            }
        }
    }
    
}
