using System;
using System.Collections.Generic;
using System.Text;
using WS3_MVVM.Model;

namespace WS3_MVVM.ViewModel
{
    class Controller
    {
        public Word model;
        public Controller()
        {
            model = new Word("Defaut");
        }

        public void SetWord(string message)
        {
            model.Mot = message;
        }

        public string GetWord()
        {
            return model.Mot;
        }

        public string ModifyWord(string word)
        {
            char[] motDecomp = new char[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
                motDecomp[i] = word[i];

                if (Char.IsLower(word[i]))
                {
                    motDecomp[i] = Char.ToUpper(motDecomp[i]);
                }
            }
            word = new string(motDecomp);
            return word;

        }
    }
}
