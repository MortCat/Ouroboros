using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Snake
{
    class Physics
    {
        //GameBoard gameBoard = new GameBoard();
        //Inertia
        /*
        public static int InertiaX = 1;
        public static int InertiaY = 0;
        public static int speed = 10;
        */

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
        /*
        public Point Position { get; set; }
        public FatSnake(Point Position)
        {
            this.Position = Position;

        }
        */

        private const int unit = 10;
        public int GetUnit
        {
            get
            {
                return unit;
            }
        }

        public void DrawBody(Canvas canvas, int X, int Y)
        {
            Rectangle Body = new Rectangle
            {
                Width = unit,
                Height = unit,
                Fill = Brushes.Gold,
                Stroke = Brushes.Black,
                StrokeThickness = 1
            };

            Canvas.SetLeft(Body, X);
            Canvas.SetTop(Body, Y);
            canvas.Children.Add(Body);
        }

        public  void DrawHead(Canvas canvas, int X, int Y)
        {
            Rectangle Head = new Rectangle
            {
                Width = unit,
                Height = unit,
                Fill = Brushes.Black,
                Stroke = Brushes.Gold,
                StrokeThickness = 1
            };

            Canvas.SetLeft(Head, X);
            Canvas.SetTop(Head, Y);
            canvas.Children.Add(Head);
        }





        public Rectangle Head = new Rectangle
        {
            Width = unit,
            Height = unit,
            Fill = Brushes.Black,
            Stroke = Brushes.Gold,
            StrokeThickness = 1
        };

        /*
        public FatSnake()
        {

            //(Point startPosition)
            //Head = new SnakeBody(startPosition);
            Body = new List<SnakeBody>();
            Body.Add(Head);
        */


    }
 
    class Food
    {
        public void DrawApple(Canvas canvas, int X, int Y)
        {
            Rectangle apple = new Rectangle
            {
                Width = 10,
                Height = 10,
                Fill = Brushes.Red,
                StrokeThickness = 1
            };
            Canvas.SetLeft(apple, X);
            Canvas.SetTop(apple, Y);
            canvas.Children.Add(apple);

        }

    }


    class GameBoard
    {
        private Stack<Point> SnakeCoordinate = new Stack<Point>();


        public void SetSnakeCoordinate(Point coordinate)
        {
            this.SnakeCoordinate.Push(coordinate);
        }
        public Point GetSnakeCoordinate()
        {
            var x = SnakeCoordinate.Peek().X;
            var y = SnakeCoordinate.Peek().Y;


            return new Point(x,y);
        }



        //putlic void GetSnakePosition(out int x , out int y)

        public static int InertiaX = 1;
        public static int InertiaY = 0;
        public static int speed = 30;

        public void SetInertia(int x, int y)
        {
            InertiaX = x;
            InertiaY = y;
        }
        public static (int,int)GetInertia()
        {
            return (InertiaX,InertiaY);
        }




        private readonly Rectangle apple = new Rectangle
        {
            Width = 10,
            Height = 10,
            Fill = Brushes.Red,
            //Stroke = Brushes.Black,
            StrokeThickness = 1
        };


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

        }

        public void Start(Canvas canvas)
        {

            Timer_Tick(canvas);



        }

        public void Pause(Canvas canvas)
        {


        }

        public void Exit()
        {

        }

        private void Timer_Tick(Canvas canvas)
        {
            // eat or not eat?


            // Hit yourself or boundaries


            FatSnake fatSnake = new FatSnake();
            int unit = fatSnake.GetUnit;

            DispatcherTimer time = new DispatcherTimer();
            time.Interval = TimeSpan.FromMilliseconds(speed); //FPS

            GetRNDCoordinate(out int x, out int y);
            SetSnakeCoordinate(new Point(x, y));





            time.Tick += (s, e) =>
            {
                x = (int)GetSnakeCoordinate().X;
                y = (int)GetSnakeCoordinate().Y;
                fatSnake.DrawBody(canvas, x, y);

                SetSnakeCoordinate(new Point(x + InertiaX, y + InertiaY));

            };
            time.Start();
        }

        private void DrawRectangle(Point p, Color color)
        {

        }
    }
}
