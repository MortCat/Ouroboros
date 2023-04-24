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
        private readonly DispatcherTimer timer;
        private const int CELL_SIZE = 10; // size of each snake cell
        private const int GAME_WIDTH = 40; // number of cells in game width
        private const int GAME_HEIGHT = 30; // number of cells in game height
        private const int SNAKE_START_LENGTH = 3; // starting length of the snake
        private const int INITIAL_DELAY_MS = 200; // initial delay in milliseconds between moves
        private const int MIN_DELAY_MS = 50; // minimum delay in milliseconds between moves
        private const int SCORE_INCREMENT = 1; // score increment when snake eats a food



        public GameBoard()
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
