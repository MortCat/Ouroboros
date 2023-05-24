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


        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            int speed = 10;
            var (inertiaX, inertiaY) = gameBoard.GetInertia();

            switch (e.Key)
            {
                case Key.Left:
                    if(inertiaY != 0)
                    {
                        gameBoard.SetInertia(-speed, 0);
                    }
                    break;

                case Key.Right:
                    if (inertiaY != 0)
                    {
                        gameBoard.SetInertia(speed, 0);
                    }
                    break;

                case Key.Up:
                    if (inertiaX != 0)
                    {
                        gameBoard.SetInertia(0, -speed);
                    }
                    break;

                case Key.Down:
                    if (inertiaX != 0)
                    {
                        gameBoard.SetInertia(0, speed);
                    }
                    break;
            }
        }
 
        

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
            MaximumBoundary = new Point
            (
                (int)Canvas.ActualWidth,
                (int)Canvas.ActualHeight
            );
            //Snake Body
            gameBoard.Start(Canvas);
            KeyDown += Window_KeyDown;




        }


        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            gameBoard.Pause(Canvas);
            KeyDown += Window_KeyDown;
            

            //MessageBox.Show(Convert.ToString(MaximumBoundary.X) + "," + Convert.ToString(MaximumBoundary.Y));
        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            gameBoard.Exit();
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