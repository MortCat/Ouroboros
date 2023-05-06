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


        public Rectangle Body = new Rectangle
        {
            Width = 10,
            Height = 10,
            Fill = Brushes.Gold,
            Stroke = Brushes.Black,
            StrokeThickness = 1
        };


        public Rectangle Head = new Rectangle
        {
            Width = 10,
            Height = 10,
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
        Rectangle apple = new Rectangle
        {
            Width = 10,
            Height = 10,
            Fill = Brushes.Red,
            StrokeThickness = 1
        };
    }


    class GameBoard
    {
        private Stack<Point> SnakeCoordinate = new Stack<Point>();


        public void SetSnakeCoordinate(Point coordinate)
        {
            this.SnakeCoordinate.Push(coordinate);
            //MessageBox.Show(Convert.ToString(SnakeCoordinate.Peek()));
        }
        public Point GetSnakeCoordinate()
        {
            //MessageBox.Show(Convert.ToString(SnakeCoordinate.Peek()));
            var x = SnakeCoordinate.Peek().X;
            var y = SnakeCoordinate.Peek().Y;


            return new Point(x,y);
        }



        //putlic void GetSnakePosition(out int x , out int y)

        public static int InertiaX = 1;
        public static int InertiaY = 0;
        public static int speed = 10;

        public void SetInertia(int x, int y)
        {
            InertiaX = x;
            InertiaY = y;
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

            
            /*
            Canvas.SetRight(fatSnake.Head, 100); //fatSnake.SnakeX);
            Canvas.SetTop(fatSnake.Head, 100); //fatSnake.SnakeY);
            canvas.Children.Add(fatSnake.Head);
            */


        }

        public void Start(Canvas canvas)
        {
            /*
            FatSnake fatSnake = new FatSnake();
            GetRNDCoordinate(out int x, out int y);

            Canvas.SetRight(fatSnake.Body, x);
            Canvas.SetTop(fatSnake.Body, y);
            canvas.Children.Add(fatSnake.Body);

            
            Canvas.SetRight(apple,x-100);
            Canvas.SetTop(apple,y);
            canvas.Children.Add(apple);


            SetSnakeCoordinate(new Point(x, y));
            */

            //int tx = (int)GetSnakeCoordinate().Peek().X;

            //int ty = (int)GetSnakeCoordinate().Peek().Y;
            Timer_Tick(canvas);



        }

        public void Pause(Canvas canvas)
        {
            
            // Stop timer
            
            /*
            DispatcherTimer time = new DispatcherTimer();
            time.Interval = TimeSpan.FromMilliseconds(10); //FPS
            int a = 10;
            time.Tick += (s, e) =>
            {
                a++;
                GetRNDCoordinate(out int x, out int y);
                canvas.Children.Remove(fatSnake.Body);
                Canvas.SetRight(fatSnake.Body, a);
                Canvas.SetTop(fatSnake.Body, 50);
                canvas.Children.Add(fatSnake.Body);
            };
            time.Start();
            */


        }

        public void Exit()
        {
            //Game Exit

        }

        private void Timer_Tick(Canvas canvas)
        {
            // Snake Move


            // eat or not eat?


            // Hit yourself or boundaries

            //Game Over

            FatSnake fatSnake = new FatSnake();
            // Stop timer

            DispatcherTimer time = new DispatcherTimer();
            time.Interval = TimeSpan.FromMilliseconds(speed); //FPS
            int a = 10;
            GetRNDCoordinate(out int x, out int y);
            SetSnakeCoordinate(new Point(x, y));

            time.Tick += (s, e) =>
            {
                a++;

                x = (int)GetSnakeCoordinate().X;
                y = (int)GetSnakeCoordinate().Y;
                
                canvas.Children.Remove(fatSnake.Body);
                Canvas.SetRight(fatSnake.Body, x);
                Canvas.SetTop(fatSnake.Body, y);
                canvas.Children.Add(fatSnake.Body);



                SetSnakeCoordinate(new Point(x + InertiaX, y + InertiaY));

            };
            time.Start();

            
      
        }


        private void Draw()
        {

        }

        private void DrawRectangle(Point p, Color color)
        {

        }
    }
}
