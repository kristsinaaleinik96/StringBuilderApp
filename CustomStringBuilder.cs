using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UndoStringBuilder;

namespace UndoStringBuilder
{
    internal class CustomStringBuilder
    {

        private StringBuilder stringBuilder;
        private Stack<ICommand> commandsList;

        public CustomStringBuilder()
        {
            this.stringBuilder = new StringBuilder();
            commandsList = new Stack<ICommand>();

        }

        public void Append(string value)
        {
            var command = new AppendCommand(stringBuilder, value);
            command.Execute();
            commandsList.Push(command);
        }

        public void Remove(int index, int length)
        {
            var command = new RemoveCommand(stringBuilder, index, length);
            command.Execute();
            commandsList.Pop();
        }

        public void Undo()
        {
            if (commandsList.Count > 0)
            {
                var command = commandsList.Pop();
                command.Undo();
            }
        }

        public override string ToString()
        {
            return stringBuilder.ToString();
        }

        public static implicit operator System.Text.StringBuilder(CustomStringBuilder v)
        {
            throw new NotImplementedException();
        }
    }
}
