using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Group
    {
        private string name_group;
        private Student[] stud = new Student[30];
        private int count_students;

        public Group()
        {
            name_group = "";
            count_students = 0;
            for (int i = 0; i < stud.Length; i++)
            {
                stud[i] = new Student();
            }
        }

        public string getNameG()
        {
            return name_group;
        }

        public int getCountStudG()
        {
            return count_students;
        }
        public Student getStud(int index_stud)
        {
            return stud[index_stud];
        }

        public void setGroup(Group gr)
        {
            name_group = gr.name_group;
            count_students = gr.count_students;
            for (int i = 0; i < stud.Length; i++)
            {
                stud[i] = gr.stud[i];
            }
        }
        public void setNameG(string name_gr)
        {
            name_group = name_gr;
        }

        public void setCountStudG(int count)
        {
            count_students = count;
        }
        public void setStudG(Student stud, int index_stud)
        {
            //stud[index_stud].setStud(stud);
        }
    }
}
