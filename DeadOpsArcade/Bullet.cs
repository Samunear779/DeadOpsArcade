using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeadOpsArcade
{
    class Bullet
    {
        public int x, y, size, speed;
        public string direction;
        
        //bullet constructor
        public Bullet(int _x, int _y, int _size, int _speed, string _direction)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
            direction = _direction;
        }

        //move the bullet the same direction the hero is facing when they fire it 
        public void Move()
        {
           if(direction == "left")
            {
                x = (x - speed);
            }
            if (direction == "right")
            {
                x = (x + speed);
            }
            if (direction == "up")
            {
                y = (y - speed);
            }
            if (direction == "down")
            {
                y = (y + speed);
            }
        }
    }
}
