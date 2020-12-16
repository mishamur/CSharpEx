using System;
using System.Collections.Generic;


/// <summary>
/// Пол
/// </summary>
public enum Gen{
    female,
    male
}

/// <summary>
/// Дата рождения
/// </summary>
public struct Birthday
{
    public int Year;
    public int Month;
    public int Day;
    public override string ToString()
    {
        return ($"День рождения: {Day} - {Month} - {Year}");
    }

}


/// <summary>
/// Фамилия Имя Отчество
/// </summary>
public struct FIO
{
    public string Name;
    public string Surname;
    public string Patronymice;

    public override string ToString()
    {
        return ($"Имя:  {Name}   Фамилия:  {Surname}  Отчество:  {Patronymice} ");
    }

}


/// <summary>
/// Стаж работы
/// </summary>
public struct Experience
{
    public int year;
    public int month;

    public override string ToString()
    {
        return ($"{year} год, {month} месяцев");
    }
}

namespace Exam.Classes
{
    class Human
    {
        protected Birthday birthday;
        protected bool russianCitizenship; //Российское гражданство (да/нет)
        protected FIO fio;
        protected SortedList<Post, Experience> WorkBook; //трудовая книжка
        protected Gen gen;
        public Post currentJob { get; set; }

        public Human(Birthday birthday, bool russianCitizenship, FIO fio, Gen gen)
        {
            
            this.fio = fio;
            this.birthday = birthday;
            this.russianCitizenship = russianCitizenship;
            this.WorkBook = new SortedList<Post, Experience>();
            this.gen = gen;
            this.currentJob = new Post("None","None");
            SetBackground();

        }

        public Human()
        {

        }

        public override string ToString()
        {
            return (

               $" {this.birthday.ToString()} \n {this.fio.ToString()} \n Пол: {this.gen} \n {this.LookWorkBook()} \n Текущая занятость: " +
               $"{this.currentJob}"
                
                );
        }


        public bool GetCitizenship()
        {
            return this.russianCitizenship;
        }
        public Birthday GetBirthday()
        {
            return this.birthday;
        }

        public FIO GetFIO()
        {
            return this.fio;
        }

        public string LookWorkBook()
        {
            string result = "";
            foreach(var i in this.WorkBook)
            {
               result +=($" {i.Key} {i.Value} \n");
            }
            return result;
        }

        public void AddToWorkBook(Post post, Experience exp)
        {
            if (this.WorkBook.IndexOfKey(post) == -1)
            {
                this.WorkBook.Add(post, exp);
            }
            
        }

        public void SetBackground()
        {

            int age = DateTime.Now.Year - this.birthday.Year;
            int count = 0;
            if(age < 20)
            {
                return;
            }
            else if(age > 19 && age < 25)
            {
                count = 3;
            }
            else
            {
                count = 5;
            }

            for(int i = 0; i < count; i++)
            {
                Random tempRand = new Random();
                Random rand = new Random(i * tempRand.Next(i) - tempRand.Next(i & i));

                AddToWorkBook(new Post(((Job)rand.Next(0, 8)).ToString(), ((Companys)rand.Next(0, 8)).ToString()),
                new Experience { month = rand.Next(0, 11), year = rand.Next(0, 2)});
                
            }
        }

    }
}
