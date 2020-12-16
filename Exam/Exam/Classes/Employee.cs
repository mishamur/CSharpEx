using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Classes
{
    public enum Name
    {
        Misha,
        Vasya,
        Danil,
        Petya,
        ZHora,
        Boris,
        Kostya,
        Vadim,
        Alexandr
    }


    /// <summary>
    /// Для рандома фамилили
    /// </summary>
    public enum Surname
    {
        Osipov,
        Urakov,
        Gagarin,
        Khramkov,
        Kotov,
        Rozhkov,
        Petuhov,
        Ishutin
    }

    /// <summary>
    /// Для рандома отчества
    /// </summary>
    public enum Patronymice
    {
        Valerievich,
        Sovkovich,
        Mihailovich,
        Andreevich,
        Sergeevich,
        Petrovich,
        Egorovich,
        Zaharovich
    }

    public enum Job
    {
        Уборщик,
        Охранник,
        Бухгалетр,
        Администратор,
        Тестировщик,
        Курьер,
        Водитель,
        Разработчик
    }

    public enum Companys
    {
        Лукойл,
        Газпром,
        Сбербанк,
        УдГу,
        ЦВТ,
        РИТ,
        Тинькофф,
        ДомРу
    }

    class Employee : Human
    {
        public Employee(Birthday birthday, bool russianCitizenship, FIO fio, Gen gen) : base(birthday, russianCitizenship, fio, gen)
        {
            this.fio = fio;
            this.birthday = birthday;
            this.russianCitizenship = russianCitizenship;
            this.WorkBook = new SortedList<Post, Experience>();
            this.gen = gen;
            this.currentJob = new Post("None", "None");
            SetBackground();
        }

        public HR WhoTook;
        

    }


}
