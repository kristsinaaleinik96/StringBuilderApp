using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UndoStringBuilder;

namespace UndoStringBuilder
{
    public class RemoveCommand(StringBuilder stringBuilder, int index, int length) : ICommand
    {
        private System.Text.StringBuilder stringBuilder = stringBuilder;
        private string removedText;
        private int length = length;
        private int index = index;

        public void Execute()
        {
            removedText = stringBuilder.ToString().Substring(index, length);
            stringBuilder.Remove(index, removedText.Length);
        }
        public void Undo()
        {
            stringBuilder.Insert(index, removedText);
        }
    }

}
