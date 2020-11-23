using System;
using System.Collections.Generic;
using System.Text;
using WS3_MVVM.ViewModel;

namespace WS3_MVVM.View
{
    class Display
    {
        private Controller vm;

        public Display()
        {
            vm = new Controller();
        }

        public void DisplayWelcome()
        {
            string userName = Environment.UserName;
            Console.WriteLine("Welcome " + userName + ", ConvertToUppercase \n\n");
        }

        public void ReadWord()
        {
            Console.WriteLine("Entrer le mot à convertir : ");
            string word = "";
            while (word.Length == 0)
            {
                word = Console.ReadLine();
            }
            vm.SetWord(word);
        }

        public void DisplayNewWord()
        {
            vm.SetWord(vm.ModifyWord(vm.GetWord()));
            Console.WriteLine($"The new word is {vm.GetWord()}");
        }
    }
}
