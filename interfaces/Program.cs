using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public interface Itestable
    {
        string print();
    }
    class Program
    {
        static void Main(string[] args)
        {
            person person = new person();
            item item = new item();
            person.print();
            item.print();
            Console.ReadKey();
        }
    }
    class person : Itestable
    {

        public string print()
        {
            Console.WriteLine("person");
            return "person";
        }
    }
    class item : Itestable
    {

        public string print()
        {
            Console.WriteLine("Item");
            return "item";
        }
    }
}
