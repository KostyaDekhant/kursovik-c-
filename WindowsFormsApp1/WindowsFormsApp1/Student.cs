using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Student
    {
        private string firstname;
        private string midname;
        private string lastname;
        private int gpa;
        private string phone_number;
        private bool social_scholarship = false;
        private int special_scholarship;

        public Student()
        {
            firstname = "";
            lastname = "";
            midname = "";
            gpa = 0;
            phone_number = "";
            social_scholarship = false;
            special_scholarship = 0;
        }
        public Student(Student student)
        {
            firstname = student.firstname;
            lastname = student.lastname;
            midname = student.midname;
            gpa = student.gpa;
            phone_number = student.phone_number;
            special_scholarship = student.special_scholarship;
            social_scholarship = student.social_scholarship;
        }
        public string getfirstname()
        {
            return firstname;
        }
        public string getmidname()
        {
            return midname;
        }
        public string getlastname()
        {
            return lastname;
        }
        public int getGPA()
        {
            return gpa;
        }
        public string getPhone_num()
        {
            return phone_number;
        }
        public int getSpecial()
        {
            return special_scholarship;
        }
        public bool getSocial()
        {
            return social_scholarship;
        }

        public void setStud(Student student)
        {
            this.firstname = student.firstname;
            this.lastname = student.lastname;
            this.midname = student.midname;
            this.gpa = student.gpa;
            this.phone_number = student.phone_number;
            this.special_scholarship = student.special_scholarship;
            this.social_scholarship = student.social_scholarship;
        }

	    public void setFIO(string lastname_s, string firstname_s, string midname_s)
        {
            this.lastname = lastname_s;
            this.firstname = firstname_s;
            this.midname = midname_s;
        }
        public void setGPA(int gpa)
        {
            this.gpa = gpa;
        }
        public void setPhone_num(string phone_number)
        {
            this.phone_number = phone_number;
        }
        public void setSpecial(int special)
        {
            special_scholarship = special;
        }
        public void setSocial(bool social)
        {
            social_scholarship = social; 
        }
    }
}
