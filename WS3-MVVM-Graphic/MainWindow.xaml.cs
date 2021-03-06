﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UpperLib.ViewModels;

namespace WS3_MVVM_Graphic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel vm = new ViewModel();
        public MainWindow()
        {
            string userName = Environment.UserName;

            InitializeComponent();
            Title.Content = "Bonjour " + userName + ", Convert2Up";
        }

        private void motInitialChanged(object sender, TextChangedEventArgs e)
        {
            vm.model.Mot = InitialWord.Text;
            vm.ModifyWord();
            FinalWord.Content = "Votre Nouveau Mot est : " + vm.model.Mot;
        }

    }
}
