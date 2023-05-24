using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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


    }

    class FatSnake
    {
        private Stack<Point> SnakeCoordinate = new Stack<Point>();
        public static List<Rectangle> SnakeSegment = new List<Rectangle>();
        private Rectangle Body;
        private Rectangle Head;
        public static int SnackLen = 8;
        private const int unit = 9;
        public int GetUnit
        {
            get
            {
                return unit;
            }
        }
        public Boolean AsyncSnackLen()
        {
            if (SnackLen == SnakeSegment.Count())
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void SetSnakeCoordinate(Point coordinate)
        {
            SnakeSegment.Add(Body);
            this.SnakeCoordinate.Push(coordinate);
        }
        public Point GetSnakeCoordinate()
        {
            var x = SnakeCoordinate.Peek().X;
            var y = SnakeCoordinate.Peek().Y;

            return new Point(x, y);
        }
        public void RemoveLastSnack(Canvas canvas)
        {
            
            int ExtraLen = SnakeSegment.Count - SnackLen;
            //MessageBox.Show(Convert.ToString(ExtraLen));
            //MessageBox.Show(Convert.ToString(SnakeSegment.Count()));

            for (int i = 0; i <= ExtraLen; i++)
            {
                Rectangle lastbody = SnakeSegment[0];
                canvas.Children.Remove(lastbody);
                SnakeSegment.RemoveAt(0);
            }
            

            //MessageBox.Show(Convert.ToString(SnakeSegment.Count()));
            //MessageBox.Show(Convert.ToString(SnakeSegment.Count()));
        }


        public void DrawBody(Canvas canvas, int X, int Y)
        {
            Body = new Rectangle
            {
                Width = unit,
                Height = unit,
                Fill = Brushes.Gold,
                Stroke = Brushes.Black,
                StrokeThickness = 0.5
            };
            SnakeSegment.Add(Body);
            Canvas.SetLeft(Body, X);
            Canvas.SetTop(Body, Y);
            canvas.Children.Add(Body);
            //MessageBox.Show(Convert.ToString(SnakeSegment.Count()));

        }

        public  void DrawHead(Canvas canvas, int X, int Y)
        {
            Head = new Rectangle
            {
                Width = unit,
                Height = unit,
                Fill = Brushes.Black,
                Stroke = Brushes.Gold,
                StrokeThickness = 0.5
            };
            Canvas.SetLeft(Head, X);
            Canvas.SetTop(Head, Y);
            canvas.Children.Add(Head);
        }
        public void SnackLenUp()
        {
            SnackLen += 50;
        }

    }
 
    class Food
    {
        private static Point AppleCoordinate = new Point();

        public static Rectangle apple;
        public void BestowApple(Canvas canvas, int X, int Y)
        {
            apple = new Rectangle
            {
                Width = 10,
                Height = 10,
                Fill = Brushes.Red,
                Stroke = Brushes.Gold,
                StrokeThickness = 1
            };
            Canvas.SetLeft(apple, X);
            Canvas.SetTop(apple, Y);
            canvas.Children.Add(apple);
        }
        public void Rebestow(Canvas canvas)
        {
            canvas.Children.Remove(apple);
        }


        public void SetAppleCoordinate(Point coordinate)
        {
            AppleCoordinate = coordinate;
        }
        public Point GetAppleCoordinate()
        {
            return new Point(AppleCoordinate.X, AppleCoordinate.Y);
        }
    }
    class Time
    {
        public void TimeFlow()
        {

        }
        public void TimeStop()
        {

        }
    }


    class GameBoard
    {

        Food apple = new Food();

        //putlic void GetSnakePosition(out int x , out int y)

        public static int InertiaX = 10;
        public static int InertiaY = 0;
        public static int speed = 150;
        DispatcherTimer time = new DispatcherTimer();
        Boolean timeStatus = false;

        public void SetInertia(int x, int y)
        {
            InertiaX = x;
            InertiaY = y;
        }
        public (int X,int Y) GetInertia()
        {
            return (InertiaX,InertiaY);
        }
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



        public void Initialize(Canvas canvas)
        {

        }

        public void Start(Canvas canvas)
        {
            GetRNDCoordinate(out int x, out int y);
            apple.BestowApple(canvas,x ,y);
            apple.SetAppleCoordinate(new Point(x,y));

            Timer_Tick(canvas);



        }

        public void Pause(Canvas canvas)
        {
            if (timeStatus == false)
            {
                timeStatus = true;
                time.Stop();
            }
                
            else
            {
                timeStatus = false;
                time.Start();
            }
                
        }

        public void Exit()
        {
            Environment.Exit(0);
        }

        private void Timer_Tick(Canvas canvas)
        {
            // eat or not eat?


            // Hit yourself or boundaries

            FatSnake fatSnake = new FatSnake();
            int unit = fatSnake.GetUnit;
            
            
            

            
            time.Interval = TimeSpan.FromMilliseconds(speed); //FPS

            GetRNDCoordinate(out int x, out int y);
            fatSnake.SetSnakeCoordinate(new Point(x, y));
            


            time.Tick += (s, e) =>
            {
                
                x = (int)fatSnake.GetSnakeCoordinate().X;
                y = (int)fatSnake.GetSnakeCoordinate().Y;
                int Ax = (int)apple.GetAppleCoordinate().X;
                int Ay = (int)apple.GetAppleCoordinate().Y;
                if (Math.Abs(x-Ax) < 8 && Math.Abs(y-Ay) < 8)
                {
                    //MessageBox.Show(Convert.ToString(speed));
                    fatSnake.SnackLenUp();
                    speed -= 10;
                    time.Interval = TimeSpan.FromMilliseconds(speed); //FPS

                    
                    GetRNDCoordinate(out int rx, out int ry);
                    apple.Rebestow(canvas);
                    apple.BestowApple(canvas, rx, ry);
                    apple.SetAppleCoordinate(new Point(rx, ry));
                    
                }

                fatSnake.DrawBody(canvas, x, y);
                fatSnake.SetSnakeCoordinate(new Point(x + InertiaX, y + InertiaY));
                fatSnake.RemoveLastSnack(canvas);



            };
            time.Start();
            
            

        }
        private void EatEvent()
        {

        }
    }
}
