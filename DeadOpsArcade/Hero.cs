using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DeadOpsArcade
{
    class Hero
    {
        public int x, y, width, height, speed, health, damage, angle;
  
        public Hero(int _x, int _y, int _width, int _height, int _speed, int _health, int _damage, int _angle)
        {
            x = _x;
            y = _y;
            width = _width;
            height = _height;
            speed = _speed;
            health = _health;
            damage = _damage;
            angle = _angle;
        }

        //move the hero
        public void Move(string direction)
        {
            if (direction == "left")
            {
                x -= speed;
                GameScreen.facing = "left";
            }
            if (direction == "right")
            {
                x += speed;
                GameScreen.facing = "right";
            }
            if (direction == "up")
            {
                y -= speed;
                GameScreen.facing = "up";
            }
            if (direction == "down")
            {
                y += speed;
                GameScreen.facing = "down";
            }
        }

        //turn the hero maybe if I ever do this 
        public void Turn(string direction)
        {
            if (direction == "left")
            {
                angle -= speed;
            }
            else if (direction == "right")
            {
                angle += speed;
            }
        }

        public Boolean Collision(Zombie z)
        {
            Rectangle zombieRec = new Rectangle(z.x, z.y, z.width, z.height);
            Rectangle heroRec = new Rectangle(x, y, width, height);
            return zombieRec.IntersectsWith(heroRec);
        }
    }
}
