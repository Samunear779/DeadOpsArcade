using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DeadOpsArcade
{
    class Zombie
    {
        public int x, y, width, height, speed, health;

        public Zombie (int _x, int _y, int _width, int _height, int _speed, int _health)
        {
            x = _x;
            y = _y;
            width = _width;
            height = _height;
            speed = _speed;
            health = _health;
        }

        public void Move (int heroX,int heroY)
        {
            if(x < heroX)
            {
                x = (x + speed);
            }
            else
            {
                x = (x - speed);
            }

            if (y < heroY)
            {
                y = (y + speed);
            }
            else
            {
                y = (y - speed);
            }
        }

        public Boolean Collision(Bullet b)
        {
            Rectangle bulletRec = new Rectangle(b.x, b.y, b.size, b.size);
            Rectangle zombieRec = new Rectangle(x, y, width, height);
            return bulletRec.IntersectsWith(zombieRec);
        }
    }
}
