using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class YearsOfUni
    {
        private string year;
        private Group[] group = new Group[10];
        private int year_of_start;
        private int count_groups;

        public YearsOfUni()
        {
            year = "";
            year_of_start = 0;
            count_groups = 0;
            for (int i = 0; i < group.Length; i++)
            {
                group[i] = new Group();
            }
        }
        public YearsOfUni(YearsOfUni years)
        {
            year = years.year;
            year_of_start = years.year_of_start;
            count_groups = years.count_groups;
            for (int i = 0; i < years.count_groups; i++)
            {
                group[i] = new Group();
                group[i].setGroup(years.getGroups(i));
            }
        }

        public string getNameY()
        {
            return year; 
        }
        public int getYearOfStartY()
        {
            return year_of_start;
        }

        public Group getGroups(int index_gr)
        {
            return group[index_gr];
        }
        public int getCountGroupsY()
        {
            return count_groups;
        }
        public string getGroupNameY(int index_gr)
        {
            Group gr = new Group();
            gr = getGroups(index_gr);
            return gr.getNameG();
        }

        public void clearYear()
        {
            year = "";
            count_groups = 0;
            year_of_start = 0;
        }

        public void setYearY(YearsOfUni years)
        {
            year = years.year;
            year_of_start = years.year_of_start;
            count_groups = years.count_groups;
            for (int i = 0; i < years.count_groups; i++)
            {
                group[i] = new Group();
                group[i].setGroup(years.getGroups(i));
            }
        }
        public void setYearOfStartY(int year)
        {
            year_of_start = year;
        }
        public void setGroupsY(Group gr, int index_gr)
        {
            group[index_gr] = new Group();
            group[index_gr].setGroup(gr);
        }
        public void setCountGroupsY(int count)
        {
            count_groups = count;
        }
        public void setNameY(string name_you)
        {
            year = name_you;
        }
}
}
