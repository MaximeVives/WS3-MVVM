using System;
using System.Collections.Generic;
using System.Text;
using WS3_MVVM.ViewModels;

namespace WS3_MVVM.Views
{
    class Display
    {
        private ViewModel vm;

        public Display()
        {
            vm = new ViewModel();
        }

        public void DisplayWelcome()
        {
            string userName = Environment.UserName;
            Console.WriteLine("Welcome " + userName + ", ConvertToUppercase \n\n");
        }

        public void ReadWord()
        {
            Console.WriteLine("Entrer le mot à convertir : ");
            string userInput = "";
            while (userInput.Length == 0)
            {
                userInput = Console.ReadLine();
            }
            vm.SetWord(userInput);
        }

        public void DisplayNewWord()
        {
            vm.ModifyWord();
            Console.WriteLine($"The new word is {vm.GetWord()}");
        }
    }
}
