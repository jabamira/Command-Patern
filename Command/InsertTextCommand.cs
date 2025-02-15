﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class InsertTextCommand : ICommand
    {
        private TextEditor _editor;
        private string _text;

        public InsertTextCommand(TextEditor editor, string text)
        {
            _editor = editor;
            _text = text;
        }

        public void Execute()
        {
            _editor.InsertText(_text);
        }

        public void Undo()
        {
            _editor.DeleteText(_text.Length);
        }
    }

}
