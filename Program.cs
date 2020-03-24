using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Note me = new Note();
            Note Toni = new Note(10);
            Note Marko = new Note("how", "Marko", 1);

            Console.WriteLine(me.getText());
            Console.WriteLine(me.getAuthor());
            Console.WriteLine(Toni.getText());
            Console.WriteLine(Toni.getAuthor());
            Console.WriteLine(Marko.getText());
            Console.WriteLine(Marko.getAuthor());

            TimeNote Antonio = new TimeNote(DateTime.Now, "who", "antonio", 1);
            Console.WriteLine(Antonio.ToString());
        }
    }
}
