using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._06._2017
{
    class Telebe
    {
        private string name;
        private string surname;
        private string group;
        private DateTime birthday;
        private int results;
        private Dictionary<string, double> exams = new Dictionary<string, double>();

        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public string Surname
        {
            get
            {
                return this.surname;
            }
        }
        public string Group
        {
            get
            {
                return this.group;
            }
        }
        public DateTime Birthday
        {
            get
            {
                return this.birthday;
            }
        }

        public int Results
        {
            get
            {
                return this.results;
            }
        }
        public Dictionary<string, double> Exams
        {
            get
            {
                return this.exams;
            }
        }


        public Telebe(string ad, string soyad, string qrub, int neticeler , DateTime dogumgunu)
        {
            this.name = ad;
            this.surname = soyad;
            this.group = qrub;
            this.results = neticeler;
            this.birthday = dogumgunu;
        }

        public string getFullName()
        {
            return this.name + "  " + this.surname;
        }

        public int getAge()
        {
            DateTime indi = DateTime.Now;
            TimeSpan ferq = indi.Subtract(this.birthday);
            return Convert.ToInt32(ferq.TotalDays / 365);
        }

        public void addExamResult(string examName, double examResult)
        {
            this.exams.Add(examName, examResult);
        }

        public bool updateExamResult(string examName, double newResult)
        {
            if (this.exams.ContainsKey(examName))
            {
                this.exams[examName] = newResult;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool deleteExamResult(string examName)
        {
            if (this.exams.ContainsKey(examName))
            {
                this.exams.Remove(examName);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}