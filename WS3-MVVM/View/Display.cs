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

    }
}
