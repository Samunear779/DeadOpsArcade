using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeadOpsArcade
{
    public partial class GameScreen : UserControl
    {
        public GameScreen()
        {
            InitializeComponent();
            OnStart();
            gameTimer.Enabled = true;

        }

        public void OnStart()
        {
            //Create Hero 
            int heroWidth = 30;
            int heroHeight = 30;
            int heroX = (this.Width / 2);
            int heroY = (this.Height / 2);
            int heroDamage = 50;
            int heroAngle = 0;


            heroX = ((this.Width / 2) - (heroWidth / 2));
            heroY = ((this.Height / 2) - (heroHeight / 2));

            hero = new Hero(heroX, heroY, heroWidth, heroHeight, heroSpeed, heroHealth, heroDamage, heroAngle);

            bulletSpeed = 5;
            bulletSize = 5;

        }

        #region Global Variables and Declarations
        public static string heroName;
        public static int lives;
        public static int heroHealth;
        public static int heroSpeed = 4;

        Boolean wKeyDown, aKeyDown, sKeyDown, dKeyDown, spaceKeyDown, upKeyDown, leftKeyDown, downKeyDown, rightKeyDown;

        //game objects 
        Zombie zombie;
        Hero hero;
        Bullet bullet;

        Image heroImage = Properties.Resources.HeroRight;


        //Game Lists
        List<Zombie> zombies = new List<Zombie>();
        List<Bullet> bullets = new List<Bullet>();
        List<PowerUp> powerUps = new List<PowerUp>();
        List<int> bulletsToRemove = new List<int>();

        int bulletSize;
        int bulletSpeed;
        bool spawnTime = false;
        bool bulletTime;
        public static string facing;
        int zombieSpawn;

        //zombie values
        int zombieX;
        int zombieY;

        int zombieWidth = 30;
        int zombieHeight = 30;
        int zombieHealth = 100;
        int zombieSpeed = 1;
        int zTimer, bTimer;


        //rand number gen
        Random randGen = new Random();
        SolidBrush bulletBrush = new SolidBrush(Color.Yellow);
        #endregion

        #region Key Presses
        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                //player movements 
                case Keys.W:
                    wKeyDown = true;
                    break;
                case Keys.A:
                    aKeyDown = true;
                    break;
                case Keys.S:
                    sKeyDown = true;
                    break;
                case Keys.D:
                    dKeyDown = true;
                    break;
                case Keys.Space:
                    spaceKeyDown = true;
                    break;

                //shooting direction 
                case Keys.Up:
                    upKeyDown = true;
                    break;
                case Keys.Left:
                    leftKeyDown = true;
                    break;
                case Keys.Down:
                    downKeyDown = true;
                    break;
                case Keys.Right:
                    rightKeyDown = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //player movements 
                case Keys.W:
                    wKeyDown = false;
                    break;
                case Keys.A:
                    aKeyDown = false;
                    break;
                case Keys.S:
                    sKeyDown = false;
                    break;
                case Keys.D:
                    dKeyDown = false;
                    break;
                case Keys.Space:
                    spaceKeyDown = false;
                    break;

                //shooting direction 
                case Keys.Up:
                    upKeyDown = false;
                    break;
                case Keys.Left:
                    leftKeyDown = false;
                    break;
                case Keys.Down:
                    downKeyDown = false;
                    break;
                case Keys.Right:
                    rightKeyDown = false;
                    break;
            }
        }
        #endregion

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            #region hero movement and direction
            //Move hero
            if (aKeyDown && hero.x > 0)
            {
                hero.Move("left");
            }
            if (dKeyDown && hero.x < (this.Width - hero.width))
            {
                hero.Move("right");
            }
            if (wKeyDown && hero.y > 0)
            {
                hero.Move("up");
            }
            if (sKeyDown && hero.y < (this.Height - hero.height))
            {
                hero.Move("down");
            }

            //rotate the hero depending which direction they moved
            if (facing == "left")
            {
                heroImage = Properties.Resources.HeroLeft;
            }
            if (facing == "right")
            {
                heroImage = Properties.Resources.HeroRight;
            }
            if (facing == "up")
            {
                heroImage = Properties.Resources.HeroUp;
            }
            if (facing == "down")
            {
                heroImage = Properties.Resources.HeroDown;
            }
            #endregion

            #region fire or "spawn bullet"
            bTimer++;
            if (bTimer == 10)
            {
                bulletTime = true;
                bTimer = 0;
            }
            //fire bullet
            if (spaceKeyDown && bulletTime)
            {
                Bullet b = new Bullet(hero.x, hero.y, bulletSize, bulletSpeed, facing);
                bullets.Add(b);
                bulletTime = false;
            }
            #endregion

            #region spawn zombie
            //determine where the zombie will spawn then create the zombie if it is time and add it to the list;
            zTimer++;
            if (zTimer > 100)
            {
                spawnTime = true;
                zTimer = 0;
            }

            if (spawnTime)
            {
                zombieSpawn = randGen.Next(1, 5);
                switch (zombieSpawn)
                {
                    case 1:
                        zombieX = 0;
                        zombieY = (this.Height / 2);
                        break;
                    case 2:
                        zombieX = (this.Width / 2);
                        zombieY = 0;
                        break;
                    case 3:
                        zombieX = this.Width;
                        zombieY = (this.Height / 2);
                        break;
                    case 4:
                        zombieX = (this.Width / 2);
                        zombieY = this.Height;
                        break;
                }

                Zombie z = new Zombie(zombieX, zombieY, zombieWidth, zombieHeight, zombieSpeed, zombieHealth);
                zombies.Add(z);
                spawnTime = false;
            }
            #endregion

            #region Movement
            //Move Bullets
            foreach (Bullet b in bullets)
            {
                b.Move();
            }

            //Move Zombies
            foreach (Zombie z in zombies)
            {
                z.Move(hero.x, hero.y);
            }
            #endregion

            #region Collision
            //Check for hero and zombie collision
            foreach (Zombie z in zombies)
            {
                if (hero.Collision(z))
                {
                    hero.health = (hero.health - 1);
                    if (hero.health <= 0)
                    {
                        gameTimer.Enabled = false;
                        //show highscores then close game 
                    }
                }
            }

            //Add bullets that have went off screen to the bulletsToRemove list 
            OffScreen();

            //Check for bullet and zombie collision 
           
            #endregion

            //Check for hero and powerUp collision
            Refresh();

        }

        #region multiple list collision 

        public void BulletsMonstersCollision()
        {
            //will contain index values of all bullets that have collided with a monster 
            List<int> bulletsToRemove = new List<int>();

            //will contain index values of all monsters that have collided with a bullet 
            List<int> zombiesToRemove = new List<int>();

            foreach (Bullet b in bullets)
            {
                foreach (Zombie z in zombies)
                {
                    //uses collision method in zombie class and returns true 
                    //if zombie 'z' has collided with bullet 'b' 
                    if (z.Collision(b))
                    {
                        //checks to make sure that the bullet is not already in removal list 
                        if (!bulletsToRemove.Contains(bullets.IndexOf(b)))
                        {
                            //add the index value from bullets of the bullet that collided  
                            bulletsToRemove.Add(bullets.IndexOf(b));
                        }

                        //checks to make sure that the monster is not already in removal list 
                        if (!zombiesToRemove.Contains(zombies.IndexOf(z)))

                        {
                            //add the index value from monsters of the monster that collided 
                            zombiesToRemove.Add(zombies.IndexOf(z));
                        }
                    }
                }
            }
        }
        #endregion

        #region remove bullets that were off screen
        public void OffScreen()
        {
            List<int> toRemove = new List<int>();

            //gets the index value of the bullets that have gone off screen and places them in
            //the toRemove list
            foreach (Bullet b in bullets)
            {
                if (b.x < 0 + 100 || b.x > this.Width || b.y < 0 - b.size || b.y > this.Height)
                {
                    toRemove.Add(bullets.IndexOf(b));
                }
            }

            //reverse list so when removing you do so from the end of the list first
            toRemove.Reverse();

            foreach (int i in toRemove)
            {
                bullets.RemoveAt(i);
            }
        }
        #endregion

        #region Draw the screen
        //draw the screen
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //draw hero
            e.Graphics.DrawImage(heroImage, hero.x, hero.y);

            //draw bullets
            foreach (Bullet b in bullets)
            {
                e.Graphics.FillRectangle(bulletBrush, b.x, b.y, b.size, b.size);
            }

            //draw zombies 
            foreach (Zombie z in zombies)
            {
                e.Graphics.DrawImage(Properties.Resources.zombie, z.x, z.y);
            }
        }
        #endregion
    }
}
