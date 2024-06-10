using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UndoStringBuilder;

namespace UndoStringBuilder
{
    internal class AppendCommand : ICommand
    {

        private System.Text.StringBuilder stringBuilder;//почему-то без  System.Text. в этой строке не работало
        private string value;

        public AppendCommand(StringBuilder stringBuilder, string value)
        {
            this.stringBuilder = stringBuilder;
            this.value = value;
        }

        public void Execute()
        {
            stringBuilder.Append(value);
        }

        public void Undo()
        {
            stringBuilder.Remove(stringBuilder.Length - value.Length, value.Length);
        }
    }
}

