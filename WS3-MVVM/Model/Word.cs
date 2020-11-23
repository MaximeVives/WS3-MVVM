using System;
using System.Collections.Generic;
using System.Text;

namespace WS3_MVVM.Model
{
    class Word
    {
        private string mot;

        public string Mot { get => mot; set => mot = value; }

        public Word(string mot)
        {
            Mot = mot;
        }
    }
}
