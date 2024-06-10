using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UndoStringBuilder;

namespace UndoStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomStringBuilder customStringBuilder = new CustomStringBuilder();
            customStringBuilder.Append("new");
            customStringBuilder.Append("text");
            customStringBuilder.Append("is");
            customStringBuilder.Append("added");
            customStringBuilder.Remove(3, 5);



            //customStringBuilder.Undo();
           // customStringBuilder.Undo();


            customStringBuilder.ToString(); //test1
            Console.WriteLine(customStringBuilder);
            Console.ReadLine();
        }
    }
}
