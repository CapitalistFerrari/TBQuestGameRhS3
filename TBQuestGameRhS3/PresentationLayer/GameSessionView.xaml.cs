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
using System.Windows.Shapes;
using TBQuestGameRH.BusinessLayer;
using TBQuestGameRH.Models;
using TBQuestGameRH;

namespace TBQuestGameRH.PresentationLayer
{
    /// <summary>
    /// Interaction logic for GameSessionView.xaml
    /// </summary>
    public partial class GameSessionView : Window
    {
        GameSessionViewModel _gameSessionViewModel;

        public GameSessionView(GameSessionViewModel gameSessionViewModel)
        {
            _gameSessionViewModel = gameSessionViewModel;

            InitializeComponent();
        }

        

        private void NorthTravelButton_Click(object sender, RoutedEventArgs e)
        {
           _gameSessionViewModel.MoveNorth();
        }

        private void BetaTravelButton_Click(object sender, RoutedEventArgs e)
        {
           _gameSessionViewModel.MoveEast();
        }

        private void GammaTravelButton_Click(object sender, RoutedEventArgs e)
        {
           _gameSessionViewModel.MoveSouth();
        }

        private void DeltaTravelButton_Click(object sender, RoutedEventArgs e)
        {
           _gameSessionViewModel.MoveWest();
        }

    }
}
