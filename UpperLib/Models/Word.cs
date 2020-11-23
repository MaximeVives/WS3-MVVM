using System;
using System.Collections.Generic;
using System.Text;

namespace UpperLib.Models
{
    public class Word
    {
        private string mot;

        public string Mot { get => mot; set => mot = value; }

        public Word(string mot)
        {
            Mot = mot;
        }
    }
}
