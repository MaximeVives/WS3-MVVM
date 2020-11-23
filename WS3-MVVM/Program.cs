using System;
using WS3_MVVM.View;

namespace WS3_MVVM
{
    class Program
    {
        static void Main(string[] args)
        {
            Display view = new Display();
            view.DisplayWelcome();
            view.ReadWord();
            view.DisplayNewWord();
        }
    }
}
