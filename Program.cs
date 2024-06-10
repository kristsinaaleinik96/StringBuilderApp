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
            customStringBuilder.Append("0");
            customStringBuilder.Append("2");
            customStringBuilder.Append("6");

            customStringBuilder.Undo();
            customStringBuilder.Undo();

            customStringBuilder.ToString(); //test1
            Console.Write(customStringBuilder);
        }
    }
}
