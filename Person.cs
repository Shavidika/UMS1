using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace UMS1
{
    public class Person
    {
        public string ?FirstName { get; set; }
        public string ?LastName { get; set; }
        public string ?DOB { get; set; }
        public BitmapImage ?Image { get; set; }
        public double ?GPA { get; set; }
        public string ?FullName { get { return $"{FirstName} {LastName}"; } }
        public string ?Mail { get; set; }
        public string ?Other { get; set; }

        public String ImagePath
        {
            get { return $"/Model/Images/{Image}"; }
        }

        public Person(string firstName, string lastName, string dOB, BitmapImage image, double gPA, string mail, string other)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DOB = dOB;
            Image = image;
            this.GPA = gPA;
            Mail = mail;
            Other= other;
        }


        public Person()
        {

        }
    }
}
