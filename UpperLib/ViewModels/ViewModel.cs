﻿using System;
using System.Collections.Generic;
using System.Text;
using UpperLib.Models;

namespace UpperLib.ViewModels
{
    public class ViewModel
    {
        public Word model;
        public ViewModel()
        {
            model = new Word("Defaut");
        }

        public void ModifyWord()
        {
            char[] motDecomp = new char[model.Mot.Length];

            for (int i = 0; i < model.Mot.Length; i++)
            {
                motDecomp[i] = model.Mot[i];

                if (Char.IsLower(model.Mot[i]))
                {
                    motDecomp[i] = Char.ToUpper(motDecomp[i]);
                }
            }
            model.Mot = new string(motDecomp);

        }
    }
}
