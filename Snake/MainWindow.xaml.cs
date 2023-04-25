using System;
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

namespace Snake
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameBoard gameBoard;


        public MainWindow()
        {
            InitializeComponent();
            gameBoard = new GameBoard();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            gameBoard.Start();

        }
        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            gameBoard.Pause();
        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
            Close();
        }
    }
}
