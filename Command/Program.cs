using Command;
using System;

class Program
{
    static void Main(string[] args)
    {
        TextEditor editor = new TextEditor();

        ICommand insertCommand = new InsertTextCommand(editor, "Command Patern, ");
        editor.ExecuteCommand(insertCommand);

        insertCommand = new InsertTextCommand(editor, "IS AWESOME!");
        editor.ExecuteCommand(insertCommand);

        editor.UndoLastCommand();
        editor.CurrentText();
        editor.UndoLastCommand();
        editor.CurrentText();

    }
}
