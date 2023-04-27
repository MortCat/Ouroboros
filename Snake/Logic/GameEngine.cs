using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Snake
{
    class GameEngine
    {
        //hit event
        //check Collision
        //* Ouroboros Mechanism
        GameBoard GameObj = new GameBoard();
        private string CheckCollision()
        {
            
            
            if (snake.Head.Position == food.Position)
            {
                Canvas.Children.Remove(food);

                //fat snake
                SnakeBody newBody = new SnakeBody(snake.Body.Last().Position);
                snake.Body.Add(newSegment);
            }

        }

    }
}
