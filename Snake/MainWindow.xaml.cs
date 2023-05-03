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
using System.Windows.Threading;

namespace Snake
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>

    //Timer
    //private readonly DispatcherTimer timer;
    //Move
    //Body
    //Length
    //Score
    //food
    // Direction
    //Observer
    public partial class MainWindow : Window
    {
        private GameBoard gameBoard = new GameBoard();
        public static Point MaximumBoundary;




        public MainWindow()
        {
            InitializeComponent();

            /*
            MaximumBoundary = new Point
            (
                (int)Canvas.ActualWidth,
                (int)Canvas.ActualHeight
            );
            */
     
            gameBoard.Initialize(Canvas);
        }

        public void Timer()
        {

        }
        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            //Snake Body
            gameBoard.Start(Canvas);

            //Canvas.Children.Add(food);

        }
        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            gameBoard.Pause();
            MaximumBoundary = new Point
                (
                    (int)Canvas.ActualWidth,
                    (int)Canvas.ActualHeight
                );
            MessageBox.Show(Convert.ToString(MaximumBoundary.X) + "," + Convert.ToString(MaximumBoundary.Y));
        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
            Close();
        }
        private void MainWindowKey(object sender, RoutedEventArgs e)
        {
            /*
            switch ()
            {
                case Left:
                case Right:
                case Up:
                case Down:
            }
            */
        }
    }
}