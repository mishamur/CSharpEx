using System;
using System.Collections.Generic;
using Exam.MyExceptions;

namespace Exam.Classes
{
    class Company
    {
        List<HR> hrs;       //HR    
        List<Employee> employees; //Работяги(не HR)
        string name;           //Название компании
        
        public Company(string name, Random rnd)
        {
            this.hrs = new List<HR>();
            this.employees = new List<Employee>();
            this.name = name;
            CreateHR(rnd);
            
        }

        //Принять человека на работу
        public void AcceptEmployees(Employee employ, string post)
        {

            try {
                if (CheckedEmploy(employ))
                {
                    Random rnd = new Random();


                    employ.currentJob = new Post(post, this.name);
                    employ.WhoTook = hrs[rnd.Next(8)];
                    employees.Add(employ);

                }
            }catch(EmployeeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        //Показать рабочий персонал(без найма);
        public void SeeEmployee()
        {
            Console.WriteLine("-----------------Список Работников Компании-------------------------------------");
            
            foreach(var i in employees)
            {
                Console.WriteLine(i + "\n");
                Console.WriteLine($"Принят на работу:  {i.WhoTook.GetFIO()} \n Должность: {i.WhoTook.GetCurrentJob()}\n");
                Console.WriteLine("--------------------------------------------------------------------------------");
            }
            
        }

        public void CreateHR(Random rnd)
        {

            
            for (int i = 0; i < 8; i++)
            {

                
                System.Threading.Thread.Sleep(5);

                hrs.Add(new HR(
                    new Birthday
                    {
                        Day = rnd.Next(1, 28),
                        Month = rnd.Next(1, 12),
                        Year = rnd.Next(1980, 2010)
                    },
                    true,
                    new FIO
                    {
                        Name = ((NameF)rnd.Next(8)).ToString(),
                        Surname = ((SurnameF)rnd.Next(0, 8)).ToString(),
                        Patronymice = ((PatronymiceF)rnd.Next(0, 8)).ToString()
                    },
                    0,
                     new Post(((HRs)rnd.Next(0, 3)).ToString(), this.name)
                    ));

            }



        }
        
        bool CheckedEmploy(Human employ)
        {
            if(!employ.GetCitizenship())
            {
                throw new EmployeeException($"У {employ.GetFIO()} " +
                    $"Отсутствует Российское гражданство, нельзя принять на работу! ");
            }


            if ((DateTime.Now.Year - employ.GetBirthday().Year) > 18)
            {
                return true;
            }
            else if ((DateTime.Now.Year - employ.GetBirthday().Year) == 18)
            {
                
                if ((DateTime.Now.Month > employ.GetBirthday().Month))
                {
                    return true;
                }
                else if ((DateTime.Now.Month == employ.GetBirthday().Month))
                {

                    if ((DateTime.Now.Day >= employ.GetBirthday().Day))
                    {
                        return true;
                    }
                    else
                    {
                        throw new EmployeeException($"{employ.GetFIO()} нет 18 лет, нельзя принять на работу! ");
                        
                    }

                }
                else
                {
                    throw new EmployeeException($"{employ.GetFIO()} нет 18 лет, нельзя принять на работу! ");
                }

            }
            else
            {
                throw new EmployeeException($"{employ.GetFIO()} нет 18 лет, нельзя принять на работу! ");
            }
        }


    }
}
