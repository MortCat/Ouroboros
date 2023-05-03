using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Snake
{
    class Physics
    {
        GameBoard gameBoard = new GameBoard();
        //Inertia
        public static int InertiaX = 1;
        public static int InertiaY = 0;
        public static int speed = 10;

        /*
        public void Timer()
        {
            DispatcherTimer time = new DispatcherTimer();
            time.Interval = TimeSpan.FromMilliseconds(100); //FPS
            time.Tick += (s, e) =>
            {
                int x = Canvas.GetRight(InertiaX) + SnakeX * speed;
                int y = Canvas.GetTop(InertiaY) + SnakeY * speed;
                Canvas.SetRight(snakeBody, x);
                Canvas.SetTop(snakeBody, y);
            };
            time.Start();
        }
        */
    }

    class FatSnake
    {
        GameBoard gameBoard = new GameBoard();
        public Stack<Point> SnakeCoordinate;
        
        //putlic void GetSnakePosition(out int x , out int y)

        public static int InertiaX = 1;
        public static int InertiaY = 0;
        public static int speed = 10;
        public void SetSnakeCoordinate()
        {
            
        }
        public Rectangle Body
        {
            get
            {
                return new Rectangle
                {
                    Width = 10,
                    Height = 10,
                    Fill = Brushes.Gold,
                    Stroke = Brushes.Black,
                    StrokeThickness = 1
                };
            }
        }

        public Rectangle Head
        {
            get 
            {
                return new Rectangle
                {
                    Width = 10,
                    Height = 10,
                    Fill = Brushes.Black,
                    Stroke = Brushes.Gold,
                    StrokeThickness = 1
                };
                
            }
        }


        /*
        public FatSnake()
        {

            //(Point startPosition)
            //Head = new SnakeBody(startPosition);
            Body = new List<SnakeBody>();
            Body.Add(Head);



            //Position of the snake is initialized.
            gameBoard.GetRNDCoordinate(out snakeX, out snakeY);

            Rectangle snakeBody = new Rectangle
            {
                Width = 10,
                Height = 10,
                Fill = Brushes.Gold,
                Stroke = Brushes.Black,
                StrokeThickness = 1
            };
            MainWindow mainWindow = new MainWindow();
            // Add object to canvas.
            mainWindow.Canvas.Children.Add(snakeBody);
            // Set Position
            Canvas.SetRight(snakeBody, snakeX);
            Canvas.SetTop(snakeBody, snakeY);

            //Snake Coordinate Update


            DispatcherTimer time = new DispatcherTimer();
            time.Interval = TimeSpan.FromMilliseconds(2000); //FPS
            time.Tick += (s, e) =>
            {
                int x = snakeX + speed;
                int y = snakeY + speed;
                Canvas.SetRight(snakeBody, x);
                Canvas.SetTop(snakeBody, y);
            };
            time.Start();
        }
        */


    }
    class SnakeBody
    {
        public Point Position { get; set; }
        public SnakeBody(Point Position)
        {
            this.Position = Position;
        }
    }

    class Food
    {
        Rectangle food = new Rectangle
        {
            Width = 10,
            Height = 10,
            Fill = Brushes.Red,
            //Stroke = Brushes.Black,
            StrokeThickness = 1
        };
    }


    class GameBoard
    {
        
        

        /*
        private const int CELL_SIZE = 10; // size of each snake cell
        private const int GAME_WIDTH = 40; // number of cells in game width
        private const int GAME_HEIGHT = 30; // number of cells in game height
        private const int SNAKE_START_LENGTH = 3; // starting length of the snake
        private const int INITIAL_DELAY_MS = 200; // initial delay in milliseconds between moves
        private const int MIN_DELAY_MS = 50; // minimum delay in milliseconds between moves
        private const int SCORE_INCREMENT = 1; // score increment when snake eats a food
        */
        public void GetRNDCoordinate(out int X, out int Y)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            var rnd = new Random();
            X = rnd.Next(0, Convert.ToInt32(mainWindow.Canvas.ActualWidth));
            Y = rnd.Next(0, Convert.ToInt32(mainWindow.Canvas.ActualHeight));
        }





        public GameBoard()
        {

        }

        public void Initialize(Canvas canvas)
        {

            
            /*
            Canvas.SetRight(fatSnake.Head, 100); //fatSnake.SnakeX);
            Canvas.SetTop(fatSnake.Head, 100); //fatSnake.SnakeY);
            canvas.Children.Add(fatSnake.Head);
            */


        }

        public void Start(Canvas canvas)
        {
            FatSnake fatSnake = new FatSnake();
            // Timer
            GetRNDCoordinate(out int x, out int y);
            //MessageBox.Show($"{x},{y}");


            Rectangle snakeBody = new Rectangle
            {
                Width = 10,
                Height = 10,
                Fill = Brushes.Gold,
                Stroke = Brushes.Black,
                StrokeThickness = 1
            };
            // Add object to canvas.

            // Set Position
            Canvas.SetRight(snakeBody, x);
            Canvas.SetTop(snakeBody, y);
            canvas.Children.Add(snakeBody);


        }

        public void Pause()
        {
            // Stop timer



        }

        public void Exit()
        {
            //Game Exit

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Snake Move


            // eat or not eat?


            // Hit yourself or boundaries

            //Game Over


        }

        private void Draw()
        {

        }

        private void DrawRectangle(Point p, Color color)
        {

        }
    }
}
