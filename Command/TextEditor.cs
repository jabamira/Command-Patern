using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    using System.Collections.Generic;

    public class TextEditor
    {
        private string _text = "";
        private Stack<ICommand> _commandHistory = new Stack<ICommand>();

        public void CurrentText()
        {
            Console.WriteLine($"Текущий текст: {_text}");
        }
        public void InsertText(string text)
        {
            _text += text;
            Console.WriteLine($"Текущий текст: {_text}");
        }

        public void DeleteText(int length)
        {
            if (length > _text.Length)
                length = _text.Length;

            string deletedText = _text.Substring(_text.Length - length);
            _text = _text.Substring(0, _text.Length - length);
            Console.WriteLine($"Удалён текст: {deletedText}");
        }

        public void UndoDelete(int length)
        {
            Console.WriteLine($"Восстановлен текст длины {length} (это просто пример)");
        }

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commandHistory.Push(command);
        }

        public void UndoLastCommand()
        {
            if (_commandHistory.Count > 0)
            {
                ICommand command = _commandHistory.Pop();
                command.Undo();
            }
        }
    }
}
