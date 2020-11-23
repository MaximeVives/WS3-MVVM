using System;
using System.Collections.Generic;
using System.Text;
using WS3_MVVM.ViewModels;
using WS3_MVVM.Models;

namespace WS3_MVVM.Views
{
    class Display
    {
        private ViewModel vm;
        private Word word;

        public Display()
        {
            vm = new ViewModel();
            word = new Word("defaut");
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
            word.Mot = userInput;
        }

        public void DisplayNewWord()
        {
            word.Mot = vm.ModifyWord(word.Mot);

            Console.WriteLine($"The new word is {word.Mot}");
        }
    }
}
