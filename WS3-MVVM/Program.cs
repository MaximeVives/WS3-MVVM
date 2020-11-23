using System;
using WS3_MVVM.Views;

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
