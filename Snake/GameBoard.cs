using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Snake
{
    public class GameBoard
    {
        private const int CELL_SIZE = 10; // 每格大小
        private const int GAME_SPEED = 100; // 速度/毫秒



        public GameBoard(Canvas canvas, MainWindow mainWindow)
        {

        }

        public void Initialize()
        {
            //Initialize game status
            Draw();
        }

        public void Start()
        {
            // Timer

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
