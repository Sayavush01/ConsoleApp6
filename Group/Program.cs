namespace Group
{
    public class Student
    {
        public string Fullname;
        public string GroupNo;
        public int Age;

        public Student(string fullname, string groupNo, int age)
        {
            if (!CheckFullname(fullname))
            {
                Console.WriteLine("Fullname duzgun deyil!");
                return;
            }

            if (!CheckGroupNo(groupNo))
            {
                Console.WriteLine("GroupNo duzgun deyil!");
                return;
            }

            Fullname = fullname;
            GroupNo = groupNo;
            Age = age;
        }
        public static bool CheckGroupNo(string groupNo)
        {
           
            if (groupNo.Length != 4)
                return false;

            char first = groupNo[0];
            if (!(first >= 'A' && first <= 'Z'))
                return false;
            if (!(groupNo[1] >= '0' && groupNo[1] <= '9'))
                return false;

            if (!(groupNo[2] >= '0' && groupNo[2] <= '9'))
                return false;

            if (!(groupNo[3] >= '0' && groupNo[3] <= '9'))
                return false;

            return true;
        }
        public static bool CheckFullname(string fullname)
        {
            int spaceIndex = -1;

            for (int i = 0; i < fullname.Length; i++)
            {
                if (fullname[i] == ' ')
                {
                    if (spaceIndex != -1)
                        return false;

                    spaceIndex = i;
                }
            }
            if (spaceIndex == -1)
                return false;

            if (spaceIndex == 0 || spaceIndex == fullname.Length - 1)
                return false;

            return true;
        }
    }
}
