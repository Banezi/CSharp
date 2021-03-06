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

namespace MaPremiereApplicationWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        delegate void MonPremierDelegate(string str);
        event MonPremierDelegate MonPremierEvenement;
        Button monSecondBouton;

        public MainWindow()
        {
            InitializeComponent();
            //MonPremierLabel.Content = "Contenu modifié";
            //MonSecondLabel.Content = "Contenu modifié encore une fois";
            monSecondBouton = new Button(); 
            monSecondBouton.Content = "Deuxième Bouton";
            monSecondBouton.Click += MonSecondBoutton_Click;
            MonPremierStackPanel.Children.Add(monSecondBouton);

            //MonPremierEvenement += CeciEstUneMethode;
            //Utilisation des lambda
            string toto = "Toto";
            MonPremierEvenement += (str) =>
            {
                MonPremierLabel.Content = str+toto;
            };
        }

        
        private void MonPremierBoutton_Click(object sender, RoutedEventArgs e)
        {
            //MonPremierLabel.Content = DateTime.Now;
            MonPremierEvenement("Premier Boutton");
        }
        private void MonSecondBoutton_Click(object sender, RoutedEventArgs e)
        {
            //MonPremierLabel.Content = DateTime.Now.Second;
            MonPremierEvenement("Deuxième Boutton");
        }

        private void CeciEstUneMethode(string str)
        {
            MonPremierLabel.Content = str;
        }
    }
}
