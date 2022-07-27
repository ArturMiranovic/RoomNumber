using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomNumber
{
    public class Class1
    {


        public void Vvod()
        {
            var a = new List<int>();

            for(int i = 0; i < 10; i++)
            {
                a.Add(i);
            }

            TaTa(a);

        }

        public void TaTa(IEnumerable<int> a)
        {

            foreach (int resul in a)
            {
                Console.WriteLine(resul);
            }    

        }
    }
}
