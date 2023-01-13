using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Faculty
    {
        private string name_facult;
        public Direction[] dir = new Direction[8];
        private static int count_facult;
        private int count_dir = 0;


        public Faculty()
        {
            name_facult = "";
            count_dir = 0;
            count_facult = 0;
            for (int i = 0; i < dir.Length; i++)
            {
                dir[i] = new Direction();
            }
        }

        //public void setFaculty(Faculty faculty)
        //{
        //    name_facult = faculty.name_facult;
        //    //count_facult = faculty.count_facult;
        //    count_dir = faculty.count_dir;
        //    for (int i = 0; i < count_dir; i++)
        //    {
        //        dir[i] = faculty.dir[i];
        //    }
        //}
	    public string getNameF()
        {
            return name_facult;
        }
        public int getCountF()
        {
            return count_facult;
        }
        public string getDirNameF(int index_dir)
        {
            return this.dir[index_dir].getNameD();
        }
        public int getCountInDirF()
        {
            return count_dir;
        }
        public int getCountInYearsF(int index_dir)
        {
            return this.dir[index_dir].getYearsOfEdD();
        }
        public int getCountInGroupsF(int index_dir, int index_you)
        {
            YearsOfUni you = new YearsOfUni();
            you.setYearY(this.dir[index_dir].getYearsD(index_you));
            return you.getCountGroupsY();
        }

        public void CreateDir(int dir_index)
        {
            dir[dir_index] = new Direction();
        }
        public Direction getDirF(int index_dir)
        {
            return dir[index_dir];
        }
        public YearsOfUni getYearsF(int index_dir, int index_you)
        {
            Direction direction = new Direction();
            direction.setDir(dir[index_dir]);
            return direction.getYearsD(index_you);
        }
        public Group getGroupF(int index_dir, int index_you, int index_gr)
        {
            YearsOfUni you = new YearsOfUni();
            you.setYearY(dir[index_dir].getYearsD(index_you));
            return you.getGroups(index_gr);
        }
        public Student getStudF(int index_dir, int index_you, int index_gr, int index_stud)
        {
            Group group = new Group();
            group.setGroup(this.getGroupF(index_dir, index_you, index_gr));
            return group.getStud(index_stud);
        }

        public void setCountInDirF(int dir_count)
        {
            count_dir = dir_count;
        }
        public void setDirF(Direction direct, int index_dir)
        {
            dir[index_dir].setDir(direct);
        }
        public void setYearsF(YearsOfUni you, int index_dir, int index_you)
        {
            Direction direct = new Direction();
            direct.setDir(this.getDirF(index_dir));
            direct.setYearsD(you, index_you);
            this.setDirF(direct, index_dir);
        }
        public void setGroupsF(Group gr, int index_dir, int index_you, int index_gr)
        {
            YearsOfUni you = new YearsOfUni();
            you.setYearY(this.getYearsF(index_dir,index_you));
            //you.setCountGroupsY(index_gr+1);
            you.setGroupsY(gr, index_gr);
            this.setYearsF(you, index_dir, index_you);
        }
        public void setStudF(Student stud, int index_dir, int index_you, int index_gr, int index_stud)
        {
            Group gr = new Group();
            gr.setGroup(this.getGroupF(index_dir, index_you, index_gr));
            gr.setCountStudG(index_stud + 1);
            gr.setStudG(stud, index_stud);
            this.setGroupsF(gr, index_dir, index_you, index_gr);

        }
        public void setCountF(int count)
        {
            count_facult = count;
        }
        public void setNameF(string name_faculty)
        {
            name_facult = name_faculty;
        }
    }
}
