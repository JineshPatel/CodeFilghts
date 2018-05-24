using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveKFromList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkList<int> l = new LinkList<int>();

            l.add(3);
            l.add(1);
            l.add(2);
            l.add(3);
            l.add(4);
            l.add(5);

            Console.WriteLine("Linklist");
            l.printAllNode();
           l.head = l.removeKFromList(l.head, 3);

            Console.WriteLine("after delete");
            l.printAllNode();

            Console.ReadKey();
        }
    }
}
