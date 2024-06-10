using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UndoStringBuilder;

namespace UndoStringBuilder
{
    public class RemoveCommand : ICommand
    {
        private StringBuilder stringBuilder;
        private string? removedText;
        private int length;
        private int index;
        public RemoveCommand(StringBuilder stringBuilder, int index, int length)
        { 
            this.stringBuilder = stringBuilder;
            this.index = index;
            this.length = length;
            this.removedText = null;
        }
        

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
