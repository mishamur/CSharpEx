using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Classes
{
    /// <summary>
    /// HR - найм-профессии
    /// </summary>
    public enum HRs
    {
        HRменеджер = 0,
        Recruiter = 1,
        RecruiterResearcher = 2,

    }

    public enum NameF
    {
        Маша,
        Катя,
        Света,
        Диана,
        Рита,
        Аня,
        Ксюша,
        Женя
    }
    public enum SurnameF
    {
        Osipova,
        Urakova,
        Gagarina,
        Khramkova,
        Kotova,
        Rozhkova,
        Petuhova,
        Ishutina
    }

    /// <summary>
    /// Для рандома отчества
    /// </summary>
    public enum PatronymiceF
    {
        Valerievna,
        Sovkovna,
        Mihailovna,
        Andreevna,
        Sergeevna,
        Petrovna,
        Egorovna,
        Zaharovna
    }

    public enum JobF
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

    public enum CompanysF
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

    class HR : Human
    {
        public HR(Birthday birthday, bool russianCitizenship, FIO fio, Gen gen, Post currentJob) : base(birthday, russianCitizenship, fio, gen)
        {
            this.fio = fio;
            this.birthday = birthday;
            this.russianCitizenship = russianCitizenship;
            this.WorkBook = new SortedList<Post, Experience>();
            this.gen = gen;
            this.currentJob = currentJob;
            SetBackground();
        }

        public Post GetCurrentJob()
        {
            return this.currentJob;
        }

        
    }
}
