using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class DeleteTextCommand : ICommand
    {
        private TextEditor _editor;
        private int _length;

        public DeleteTextCommand(TextEditor editor, int length)
        {
            _editor = editor;
            _length = length;
        }

        public void Execute()
        {
            _editor.DeleteText(_length);
        }

        public void Undo()
        {
            // Здесь нужно узнать, что было удалено, в реальной жизни может быть сложнее
            _editor.UndoDelete(_length);
        }
    }

}
