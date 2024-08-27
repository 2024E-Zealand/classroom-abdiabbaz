using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Student
    {

        private int _birthMonth;

        public string? Name { get; private set; }


        public int BirthMonth
        {
            get { return _birthMonth; }
            private set 
            { 
                if (value > 12)
                {
                    throw new ArgumentException("Birthmonth can't be more than 12");
                }

                if (value < 1)
                {
                    throw new ArgumentException("Birthmonth can't be less than 1");
                }
                _birthMonth = value; 
            }
        }


        public int Birthday { get; private set; }

        public Student()
        {
            Name = "";
            BirthMonth = 0;
            Birthday = 0;
        }
        public Student(string? name, int birthday, int birthMonth)
        {
            Name = name;
            BirthMonth = birthMonth;
            Birthday = birthday;
        }

        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(BirthMonth)}={BirthMonth.ToString()}, {nameof(Birthday)}={Birthday.ToString()}}}";
        }

        public string Season()
        {
            switch (BirthMonth)
            {
                case 12:
                case 1:
                case 2:
                    return "Winter";
                case 3:
                case 4:
                case 5:
                    return "Spring";
                case 6:
                case 7:
                case 8:
                    return "Summer";
                case 9:
                case 10:
                case 11:
                    return "Autumn";
                default:
                   return "Invalid Month";
            }
        }

        //public void SetBirthMonth(int month)
        //{
        //    if (month > 12) 
        //    {
        //        throw new ArgumentException();
        //    }

        //    if (month < 1)
        //    {
        //        throw new ArgumentException();
        //    }

        //    BirthMonth = month;
        //}

    }

}

