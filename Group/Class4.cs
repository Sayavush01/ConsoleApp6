using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group
{ 
class Program
    {
        static void Main()
        {
            Student st = new Student("Abbas Quliyev", "P216", 20);

            Console.WriteLine(st.Fullname);
            Console.WriteLine(st.GroupNo);
            Console.WriteLine(st.Age);
        }
    }
}
