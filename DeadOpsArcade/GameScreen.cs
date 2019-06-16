using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DeadOpsArcade
{
    public partial class GameScreen : UserControl
    {
        public GameScreen()
        {
            InitializeComponent();
            OnStart();
            //start the game loop
            gameTimer.Enabled = true;
        }

        public void OnStart()
        {
            //Create Hero 
            int heroWidth = 20;
            int heroHeight = 20;
            int heroX = (this.Width / 2);
            int heroY = (this.Height / 2);
            int heroDamage = 50;
            heroX = ((this.Width / 2) - (heroWidth / 2));
            heroY = ((this.Height / 2) - (heroHeight / 2));

            //create the hero 
            hero = new Hero(heroX, heroY, heroWidth, heroHeight, heroSpeed, heroHealth, heroDamage);

            //set bullet values
            bulletSpeed = 5;
            bulletSize = 5;
        }

        #region Global Variables and Declarations
        //public hero values 
        public static string heroName;
        public static int heroHealth = 200;
        public static int heroSpeed = 4;

        //key press booleans 
        Boolean wKeyDown, aKeyDown, sKeyDown, dKeyDown, spaceKeyDown;

        //game objects
        Hero hero;
        
        //hero image 
        Image heroImage = Properties.Resources.HeroRight;

        //Game Lists
        List<Zombie> zombies = new List<Zombie>();
        List<Bullet> bullets = new List<Bullet>();
        List<PowerUp> powerUps = new List<PowerUp>();
        List<int> bulletsToRemove = new List<int>();

        //create bullet varibales 
        int bulletSize;
        int bulletSpeed;
        bool bulletTime;

        //create misc variables 
        bool spawnTime = false;
        public static string facing;      
        public static int score = 0;

        //zombie values
        int zombieX;
        int zombieY;
        int zombieWidth = 55;
        int zombieHeight = 55;
        int zombieHealth = 200;
        int zombieSpeed = 1;
        int zombieSpawn;
        int zTimer, bTimer;

        //rand number gen
        Random randGen = new Random();

        //create bullet brush 
        SolidBrush bulletBrush = new SolidBrush(Color.Yellow);
        #endregion

        #region Key Presses
        //code for all the key down actions 
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
            }
        }

        //code for all the Key up actions 
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
            }
        }
        #endregion

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            #region hero movement and direction
            //Move hero based on which key is being pessed down 
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
            //This facing variable is important so the image wont flip when you stop pressing the move button 
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

            //fire bullet in the direction the player is facing and if it is time for a new bullet

            if (spaceKeyDown && bulletTime && facing == "left")
            {
                Bullet b = new Bullet(hero.x, hero.y + 11, bulletSize, bulletSpeed, facing);
                bullets.Add(b);
                bulletTime = false;
            }
            if (spaceKeyDown && bulletTime && facing == "right")
            {
                Bullet b = new Bullet(hero.x + 70, hero.y + 37, bulletSize, bulletSpeed, facing);
                bullets.Add(b);
                bulletTime = false;
            }
            if (spaceKeyDown && bulletTime && facing == "up")
            {
                Bullet b = new Bullet(hero.x + 35, hero.y, bulletSize, bulletSpeed, facing);
                bullets.Add(b);
                bulletTime = false;
            }
            if (spaceKeyDown && bulletTime && facing == "down")
            {
                Bullet b = new Bullet(hero.x + 10, hero.y + 70, bulletSize, bulletSpeed, facing);
                bullets.Add(b);
                bulletTime = false;
            }
            #endregion

            #region spawn zombie

            //determine where the zombie will spawn then create the zombie if it is time and add it to the list;
            //add to the zombie spawn timer
            zTimer++;
            if (zTimer > 80)
            {
                score = (score + 100);
                scoreLabel.Text = (heroName + "'s  " + "Score: " + score);
                spawnTime = true;
                zTimer = 0;
            }

            //use the random number generator to decide where to spawn the zombie 
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

                //with the random cords create the zombie object and add it to the list 
                Zombie z = new Zombie(zombieX, zombieY, zombieWidth, zombieHeight, zombieSpeed, zombieHealth);
                zombies.Add(z);

                //reset the zombie spawn time 
                spawnTime = false;
            }
            #endregion

            #region Movement

            //Move each bullet on the screen 
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
                    hero.health = (hero.health - 50);
                    if (hero.health <= 0)
                    {
                        //run the game over method 
                        gameOver();
                    }
                }
            }

            //Add bullets that have went off screen to the bulletsToRemove list 
            OffScreen();

            //Check for bullets and zombies collision 
            BulletsZombiesCollision();
            #endregion

            //Check for hero and powerUp collision
            //probably won't have time for power ups :(
            Refresh();
        }

        //if the game ends then stop the game loop, reset the score and change the screen to the final screen
        public void gameOver()
        {
            gameTimer.Enabled = false;
            Form1.ChangeScreen(this, "FinalScreen");
            score = 0;
        }

        #region multiple list collision 

        public void BulletsZombiesCollision()
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

                        //remove zombies health 
                        z.health = (z.health - hero.damage);

                        //checks to make sure that the monster is not already in removal list and if the zombie is out of health 
                        if (!zombiesToRemove.Contains(zombies.IndexOf(z)) && z.health == 0)
                        {
                            //add the index value from monsters of the monster that collided 
                            zombiesToRemove.Add(zombies.IndexOf(z));
                        }
                    }
                }
            }
            //reverse lists so when removing you do so from the end of the list first 
            bulletsToRemove.Reverse();
            zombiesToRemove.Reverse();

            //remove the objects from the ToRemove lists 
            foreach (int i in bulletsToRemove)
            {
                bullets.RemoveAt(i);
            }
            foreach (int i in zombiesToRemove)
            {
                zombies.RemoveAt(i);
            }
        }
        #endregion

        #region remove bullets that were off screen
        public void OffScreen()
        {
            //create off screen list
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

            //remove all the objects in the list 
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
