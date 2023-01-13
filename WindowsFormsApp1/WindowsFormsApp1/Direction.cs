using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Direction
    {
        private string name_dir;
        private YearsOfUni[] you = new YearsOfUni[6];
        private int year_of_ed = 0;

        public Direction()
        {
            name_dir = "";
            year_of_ed = 0;
            for (int i = 0; i < you.Length; i++)
            {
                you[i] = new YearsOfUni();
            }
        }
        public string getNameD()
        {
            return name_dir;
        }
        public int getYearsOfEdD()
        {
            return year_of_ed;
        }
        public string getYearsNameD(int index_you)
        {
            return you[index_you].getNameY();
        }

        public void setDir(Direction direct)
        {
            name_dir = direct.name_dir;
            year_of_ed = direct.year_of_ed;
            for (int i = 0; i < year_of_ed; i++)
            {
                you[i] = new YearsOfUni();
                you[i].setYearY(direct.you[i]);
            }
        }
        public YearsOfUni getYearsD(int index_you)
        {
            return you[index_you];
        }

        public void setYearsOfEdD(int years)
        {
            year_of_ed = years;
        }
        public void setYearsOfStartD(int years, int index_you)
        {
            //you[index_you]
        }

        public void setYearsNameD(string name, int index_you)
        {
           //you[index_you].setName(name);
        }
        public void setYearsD(YearsOfUni years, int index_you)
        {
            //you[index_you] = new YearsOfUni();
            you[index_you].setYearY(years);
        }
        public void setNameD(string name_direct)
        {
            name_dir = name_direct;
        }
}
}
