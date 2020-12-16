using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Classes
{
    /// <summary>
    /// Должность
    /// </summary>
    class Post : IComparable<Post>
    {
        public Post(string name, string company)
        {
            this.name = name;
            this.company = company;
        }


        string name;        // Название должности
        string company;     //Название компании

        public void SetCompany(string nameCompany)
        {
            this.company = nameCompany;
        }

        public override string ToString()
        {
            return ($"Работа на должности: {name}  в компании: {company} ");
        }

        public int CompareTo(Post other)
        {
            return (this.company.CompareTo(other.company));
        }

        
    }
}
