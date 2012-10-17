using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;


namespace Zephyr
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class TrackManager6 : Microsoft.Xna.Framework.DrawableGameComponent
    {
        SpriteBatch spriteBatch;
        List<Sprite> spriteList = new List<Sprite>();
        List<Sprite> spriteList2 = new List<Sprite>();
        List<Sprite> spriteList3 = new List<Sprite>();
        public bool loose = false;
        public bool pause = true;


        AudioEngine audioEngine;
        WaveBank waveBank;
        SoundBank soundBank;
        public bool callcue = false;


        int anger_rep = 0;
        int hunger_rep = 0;
        int mdg1_rep = 0;
        public int mdg8_rep = 0;
        int power_rep = 0;
        Vector2 anger_pos = new Vector2(160, 540);
        Vector2 hunger_pos = new Vector2(410, 540);
        Vector2 mdg1_pos = new Vector2(680, 540);
        Vector2 mdg8_pos = new Vector2(940, 540);
        Vector2 power_pos = new Vector2(1150, 540);


        Texture2D track;
        Texture2D trackoverlay;
        SpriteFont text;
        Texture2D arrow;
        Rectangle arrowRect;
        Vector2 arr_position;

        Vector2 rep_position;


        Texture2D car;
        RenderTarget2D trackRender;

        RenderTarget2D trackRenderRotated;





        Vector2 carPosition = new Vector2(120, 75);

        int carHeight;

        int carWidth;

        float carRotation = 0;

        double carScale = .2;


        Texture2D mdg1;
        Texture2D mdg11;
        Texture2D mdg12;
        Texture2D mdg13;
        Texture2D mdg14;
        Texture2D mdg15;
        Texture2D mdg8;
        Texture2D mdg81;
        Texture2D mdg1rep;
        Texture2D mhealthbar;


        Texture2D obstacle;

        Texture2D obstaclerep;
        Texture2D report;

        Rectangle obstacleRect;
        Rectangle carRect;

        Rectangle mdg1Rect;
        Rectangle mdg11Rect;
        Rectangle mdg12Rect;
        Rectangle mdg13Rect;
        Rectangle mdg14Rect;
        Rectangle mdg15Rect;
        Rectangle mdg8Rect;
        Rectangle mdg81Rect;

        bool a = false;
        bool b = false;
        bool c = false;

        MouseState prevMouseState;

        int enemySpawnMinMilliseconds = 500;
        int enemySpawnMaxMilliseconds = 2000;
        int enemyMinSpeed = 10;
        int enemyMaxSpeed = 30;
        int nextSpawnTime = 0;

        bool power = false;
        bool power1 = false;
        bool power2 = false;
        bool power3 = false;
        bool power4 = false;
        bool power5 = false;
        bool power6 = false;
        bool power7 = false;
        public bool isOver = false;
        int health = 100;
        bool moveup = false;
        bool movedown = false;
        public TrackManager6(Game game)
            : base(game)
        {
            // TODO: Construct any child components here
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
        public override void Initialize()
        {
            // TODO: Add your initialization code here
            rep_position = new Vector2(0, 500);

            ResetSpawnTime();

            base.Initialize();
        }
        protected override void LoadContent()
        {

            spriteBatch = new SpriteBatch(Game.GraphicsDevice);

            track = Game.Content.Load<Texture2D>(@"Images/P");

            car = Game.Content.Load<Texture2D>(@"Images/Car");

            carWidth = (int)(car.Width * carScale);

            carHeight = (int)(car.Height * carScale);

            trackRender = new RenderTarget2D(GraphicsDevice, carWidth + 100,

       carHeight + 100, true, SurfaceFormat.Color, DepthFormat.Depth24Stencil8);

            trackRenderRotated = new RenderTarget2D(GraphicsDevice, carWidth + 100,

                   carHeight + 100, true, SurfaceFormat.Color, DepthFormat.Depth24Stencil8);

            mdg1 = Game.Content.Load<Texture2D>(@"Images/mdg5");
            mdg11 = Game.Content.Load<Texture2D>(@"Images/mdg5");

            mdg12 = Game.Content.Load<Texture2D>(@"Images/mdg5");

            mdg13 = Game.Content.Load<Texture2D>(@"Images/mdg5");

            mdg14 = Game.Content.Load<Texture2D>(@"Images/mdg5");
            mdg15 = Game.Content.Load<Texture2D>(@"Images/mdg5");
            mdg8 = Game.Content.Load<Texture2D>(@"Images/mdg8");
            mdg81 = Game.Content.Load<Texture2D>(@"Images/mdg8");
            audioEngine = new AudioEngine(@"Content\Audio\GameAudio.xgs");
            waveBank = new WaveBank(audioEngine, @"Content\Audio\Wave Bank.xwb");
            soundBank = new SoundBank(audioEngine, @"Content\Audio\Sound Bank.xsb");


            mdg1rep = Game.Content.Load<Texture2D>(@"Images/mdg5rep");
            obstacle = Game.Content.Load<Texture2D>(@"Images/obstacle");
            obstaclerep = Game.Content.Load<Texture2D>(@"Images/obstaclerep");
            trackoverlay = Game.Content.Load<Texture2D>(@"Images/overlayP");
            text = Game.Content.Load<SpriteFont>(@"Fonts\Snap");
            report = Game.Content.Load<Texture2D>(@"Images/reportg");
            arrow = Game.Content.Load<Texture2D>(@"Images/arrow");
            mhealthbar = Game.Content.Load<Texture2D>(@"Images/healthbar");




            base.LoadContent();
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            if (health <= 0)
                loose = true;
            nextSpawnTime -= gameTime.ElapsedGameTime.Milliseconds;
            if (nextSpawnTime < 0)
            {
                SpawnEnemy();
                // Reset spawn timer
                ResetSpawnTime();
            }
            // TODO: Add your update code here
            KeyboardState aKeyboard = Keyboard.GetState();
            if (aKeyboard.IsKeyDown(Keys.Space))
                pause = true;
            if (aKeyboard.IsKeyDown(Keys.Left) || aKeyboard.IsKeyDown(Keys.Right) || aKeyboard.IsKeyDown(Keys.Up) || aKeyboard.IsKeyDown(Keys.Down))
                pause = false;
            //Rotate the Car sprite with  the up and down arrows


            MouseState mouseState = Mouse.GetState();
            if (mouseState.X != prevMouseState.X ||
            mouseState.Y != prevMouseState.Y)
            {
                arr_position = new Vector2(mouseState.X, mouseState.Y);
                prevMouseState = mouseState;
            }
            arrowRect = new Rectangle((int)arr_position.X, (int)arr_position.Y, 32, 32);

            if ((aKeyboard.IsKeyDown(Keys.Up) == true || aKeyboard.IsKeyDown(Keys.Left) == true) && (pause == false))
            {

                carRotation -= (float)(1 * 3.0f * gameTime.ElapsedGameTime.TotalSeconds);

            }

            else if ((aKeyboard.IsKeyDown(Keys.Down) == true || aKeyboard.IsKeyDown(Keys.Right) == true) && (pause == false))
            {

                carRotation += (float)(1 * 3.0f * gameTime.ElapsedGameTime.TotalSeconds);

            }



            //Setup the Movement increment.

            int aMove = (int)(200 * gameTime.ElapsedGameTime.TotalSeconds);



            //Move the sprite
            if ((CollisionOccurred(aMove) == false) && (pause == false))
            {
                carPosition.X += (float)(aMove * Math.Cos(carRotation));

                carPosition.Y += (float)(aMove * Math.Sin(carRotation));
            }


            // TODO: Add your update logic here
            obstacleRect = new Rectangle(5, 40, obstacle.Width, obstacle.Height);
            carRect = new Rectangle((int)carPosition.X, (int)carPosition.Y, carWidth, carHeight);
            if (power)
                mdg1Rect = new Rectangle(2000, 2000, 50, 50);
            else
                mdg1Rect = new Rectangle(76, 472, 50, 50);
            if (power1)
                mdg11Rect = new Rectangle(2000, 2000, 50, 50);
            else
                mdg11Rect = new Rectangle(246, 325, 50, 50);
            if (power2)
                mdg12Rect = new Rectangle(2000, 2000, 50, 50);
            else
                mdg12Rect = new Rectangle(78, 184, 50, 50);
            if (power3)
                mdg13Rect = new Rectangle(2000, 2000, 50, 50);
            else
                mdg13Rect = new Rectangle(333, 194, 50, 50);
            if (power4)
                mdg14Rect = new Rectangle(2000, 2000, 50, 50);
            else
                mdg14Rect = new Rectangle(259, 62, 50, 50);
            if (power5)
                mdg15Rect = new Rectangle(2000, 2000, 50, 50);
            else
                mdg15Rect = new Rectangle(82,316, 50, 50);
            if (power6)
                mdg8Rect = new Rectangle(2000, 2000, 50, 50);
            else
                mdg8Rect = new Rectangle(324,328, 50, 50);
            if (power7)
                mdg81Rect = new Rectangle(2000, 2000, 50, 50);
            else
                mdg81Rect = new Rectangle(79, 247, 50, 50);
            if (carPosition.X <= 55)
                isOver = true;
            foreach (Sprite s in spriteList)
            {
                s.Update(gameTime, Game.Window.ClientBounds);
            }

            for (int i = 0; i < spriteList.Count; ++i)
            {
                Sprite s = spriteList[i];
                s.Update(gameTime, Game.Window.ClientBounds);
                // Check for collisions
                if (s.collisionRect.Intersects(carRect))
                {

                    spriteList.RemoveAt(i);
                    --i;
                    if (pause == false)
                    {
                        health = health - 2;
                        soundBank.PlayCue("angercollision");
                        anger_rep += 1;
                    }

                }
                if (s.IsOutOfBounds(Game.Window.ClientBounds))
                {
                    spriteList.RemoveAt(i);
                    --i;
                }

            }

            foreach (Sprite s2 in spriteList2)
            {
                s2.Update(gameTime, Game.Window.ClientBounds);
            }
            for (int i = 0; i < spriteList2.Count; ++i)
            {
                Sprite s2 = spriteList2[i];
                s2.Update(gameTime, Game.Window.ClientBounds);
                // Check for collisions
                if (s2.collisionRect.Intersects(carRect))
                {

                    spriteList2.RemoveAt(i);
                    --i;
                    if (pause == false)
                    {
                        health = health - 3;
                        soundBank.PlayCue("hungercollision");
                        hunger_rep += 1;
                    }

                }
                if (s2.IsOutOfBounds(Game.Window.ClientBounds))
                {
                    spriteList2.RemoveAt(i);
                    --i;
                }

            }
            foreach (Sprite s3 in spriteList3)
            {
                s3.Update(gameTime, Game.Window.ClientBounds);
            }
            for (int i = 0; i < spriteList3.Count; ++i)
            {
                Sprite s3 = spriteList3[i];
                s3.Update(gameTime, Game.Window.ClientBounds);
                // Check for collisions
                if (s3.collisionRect.Intersects(carRect))
                {

                    spriteList3.RemoveAt(i);
                    --i;
                    if (pause == false)
                    {
                        health = health + 5;
                        power_rep += 1;
                    }

                }
                if (s3.IsOutOfBounds(Game.Window.ClientBounds))
                {
                    spriteList3.RemoveAt(i);
                    --i;
                }

            }
            if (arr_position.Y >= 650)
            {

                moveup = true;

            }
            if (rep_position.Y <= 500)
            {

                moveup = false;
                movedown = true;

            }


            if (moveup)
            {
                rep_position.Y = rep_position.Y - 20;
                hunger_pos.Y = hunger_pos.Y - 20;
                anger_pos.Y = anger_pos.Y - 20;
                mdg1_pos.Y = mdg1_pos.Y - 20;
                mdg8_pos.Y = mdg8_pos.Y - 20;
                power_pos.Y = power_pos.Y - 20;
            }
            if (movedown)
            {
                rep_position.Y = rep_position.Y + 5;
                hunger_pos.Y = hunger_pos.Y + 5;
                anger_pos.Y = anger_pos.Y + 5;
                mdg1_pos.Y = mdg1_pos.Y + 5;
                mdg8_pos.Y = mdg8_pos.Y + 5;
                power_pos.Y = power_pos.Y + 5;
            }

            if (rep_position.Y >= 700)
            {
                rep_position.Y = 700;
                hunger_pos.Y = 740;
                anger_pos.Y = 740;
                mdg1_pos.Y = 740;
                mdg8_pos.Y = 740;
                power_pos.Y = 740;
            }
            if (arr_position.Y >= 650 && rep_position.Y <= 520)
            {
                rep_position.Y = 500;
                hunger_pos.Y = 540;
                anger_pos.Y = 540;
                mdg1_pos.Y = 540;
                mdg8_pos.Y = 540;
                power_pos.Y = 540;
            }
            health = (int)MathHelper.Clamp(health, 0, 100);

            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();

            spriteBatch.Draw(track, new Rectangle(0, 0, track.Width, track.Height), Color.White);
            spriteBatch.Draw(trackoverlay, new Rectangle(0, 0, 1200, 700), Color.White);

            spriteBatch.Draw(mdg1, mdg1Rect, Color.White);

            spriteBatch.Draw(mdg11, mdg11Rect, Color.White);

            if (power && power1 && power3 && power4 && power5)
            {
                spriteBatch.Draw(mdg12, mdg12Rect, Color.White);
                b = true;
            }
            else
                power2 = false;

            spriteBatch.Draw(mdg13, mdg13Rect, Color.White);

            spriteBatch.Draw(mdg14, mdg14Rect, Color.White);

            if (power && power1 && power3 && power4)
            {
                spriteBatch.Draw(mdg15, mdg15Rect, Color.White);
                a = true;
            }
            else
                power5 = false;

            if (power && power1 && power2 && power3 && power4 && power5)
            {
                spriteBatch.Draw(mdg8, new Vector2(324,328), Color.White);
                b = true;
            }
            else
                power6 = false;

            if (power && power1 && power2 && power3 && power4 && power5 && power6)
            {
                spriteBatch.Draw(mdg81, new Vector2(79,247), Color.White);
                c = true;
            }
            else
                power7 = false;

            spriteBatch.Draw(obstacle, obstacleRect, Color.White);
            if (power)
            {

                spriteBatch.Draw(mdg1rep, new Rectangle(76,472, 50, 50), Color.White);

            }

            if (power1)
            {

                spriteBatch.Draw(mdg1rep, new Rectangle(246,325, 50, 50), Color.White);

            }
            if (power2)
            {

                spriteBatch.Draw(mdg1rep, new Rectangle(2000, 2000, 50, 50), Color.White);
                spriteBatch.Draw(obstaclerep, obstacleRect, Color.White);
            }
            if (power3)
            {

                spriteBatch.Draw(mdg1rep, new Rectangle(333,194, 50, 50), Color.White);

            }
            if (power4)
            {

                spriteBatch.Draw(mdg1rep, new Rectangle(259,62, 50, 50), Color.White);

            }
            if (power5)
            {

                spriteBatch.Draw(mdg1rep, new Rectangle(2000, 2000, 50, 50), Color.White);


            }
            if (power6)
            {
                spriteBatch.Draw(mdg1rep, new Rectangle(324, 328, 50, 50), Color.White);


            }
            if (power7)
            {
                spriteBatch.Draw(mdg1rep, new Rectangle(79,247, 50, 50), Color.White);


            }
            spriteBatch.Draw(car, new Rectangle((int)carPosition.X, (int)carPosition.Y, carWidth, carHeight),

   new Rectangle(0, 0, car.Width, car.Height), Color.White, carRotation,

   new Vector2(car.Width / 2, car.Height / 2), SpriteEffects.None, 0);
            foreach (Sprite s in spriteList)
                s.Draw(gameTime, spriteBatch);

            foreach (Sprite s2 in spriteList2)
                s2.Draw(gameTime, spriteBatch);
            foreach (Sprite s3 in spriteList3)
                s3.Draw(gameTime, spriteBatch);

            spriteBatch.Draw(report, rep_position, Color.White);
            spriteBatch.DrawString(text, "" + anger_rep,
anger_pos, Color.Brown, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
            spriteBatch.DrawString(text, "" + hunger_rep,
hunger_pos, Color.Brown, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
            spriteBatch.DrawString(text, "" + mdg1_rep + "/6",
mdg1_pos, Color.Brown, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
            spriteBatch.DrawString(text, "" + mdg8_rep,
mdg8_pos, Color.Brown, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
            spriteBatch.DrawString(text, "" + power_rep,
power_pos, Color.Brown, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
            spriteBatch.Draw(arrow, arr_position, Color.White);
            spriteBatch.Draw(mhealthbar, new Rectangle(1200 / 2 - mhealthbar.Width / 2 + 150, 0, mhealthbar.Width, 44), new Rectangle(0, 45, mhealthbar.Width, 44), Color.Gray);

            //Draw the current health level based on the current Health
            spriteBatch.Draw(mhealthbar, new Rectangle(1200 / 2 - mhealthbar.Width / 2 + 150, 0, (int)(mhealthbar.Width * ((double)health / 100)), 44), new Rectangle(0, 45, mhealthbar.Width, 44), Color.Yellow);

            //Draw the box around the health bar
            spriteBatch.Draw(mhealthbar, new Rectangle(1200 / 2 - mhealthbar.Width / 2 + 150, 0, mhealthbar.Width, 44), new Rectangle(0, 0, mhealthbar.Width, 44), Color.White);

            spriteBatch.DrawString(text, "Power " + health,
new Vector2(650, 3), Color.Black, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);




            spriteBatch.End();
            base.Draw(gameTime);
        }
        private bool CollisionOccurred(int aMove)
        {

            //Calculate the Position of the Car and create the collision Texture. This texture will contain

            //all of the pixels that are directly underneath the sprite currently on the Track image.

            float aXPosition = (float)(-carWidth / 2 + carPosition.X + aMove * Math.Cos(carRotation));

            float aYPosition = (float)(-carHeight / 2 + carPosition.Y + aMove * Math.Sin(carRotation));

            Texture2D aCollisionCheck = CreateCollisionTexture(aXPosition, aYPosition);



            //Use GetData to fill in an array with all of the Colors of the Pixels in the area of the Collision Texture

            int aPixels = carWidth * carHeight;

            Color[] myColors = new Color[aPixels];

            aCollisionCheck.GetData<Color>(0, new Rectangle((int)(aCollisionCheck.Width / 2 - carWidth / 2),

                (int)(aCollisionCheck.Height / 2 - carHeight / 2), carWidth, carHeight), myColors, 0, aPixels);



            //Cycle through all of the colors in the Array and see if any of them

            //are not Gray. If one of them isn't Gray, then the Car is heading off the road

            //and a Collision has occurred

            bool aCollision = false;
            if (carRect.Intersects(mdg1Rect))
            {
                power = true;
                soundBank.PlayCue("snare");
                mdg1_rep += 1;

            }

            if (carRect.Intersects(mdg11Rect))
            {
                power1 = true;
                soundBank.PlayCue("snare");
                mdg1_rep += 1;

            }
            if (carRect.Intersects(mdg12Rect) && b)
            {
                power2 = true;
                soundBank.PlayCue("snare");
                mdg1_rep += 1;

            }
            if (carRect.Intersects(mdg13Rect))
            {
                power3 = true;
                soundBank.PlayCue("snare");
                mdg1_rep += 1;

            }
            if (carRect.Intersects(mdg14Rect))
            {
                power4 = true;
                soundBank.PlayCue("snare");
                mdg1_rep += 1;

            }
            if (carRect.Intersects(mdg15Rect) && a)
            {
                power5 = true;
                soundBank.PlayCue("snare");
                mdg1_rep += 1;

            }
            if (carRect.Intersects(mdg8Rect) && b)
            {
                power6 = true;
                mdg8_rep += 1;
            }
            if (carRect.Intersects(mdg81Rect) && c)
            {
                power7 = true;
                mdg8_rep += 1;
            }

            foreach (Color aColor in myColors)
            {

                //If one of the pixels in that area is not Gray, then the sprite is moving

                //off the allowed movement area

                if (aColor != Color.Gray)
                {

                    aCollision = true;
                    health = health - 3;
                    soundBank.PlayCue("carcollision");

                    break;

                }
                if (carRect.Intersects(obstacleRect))
                {
                    if (power && power1 && power2 && power3 && power4 && power5)
                        aCollision = false;
                    else
                    {

                        aCollision = true;
                        carPosition.X = carPosition.X  +40;
                        health = health - 3;

                        break;
                    }


                }

            }



            return aCollision;


        }
        private Texture2D CreateCollisionTexture(float theXPosition, float theYPosition)
        {

            //Grab a square of the Track image that is around the Car

            GraphicsDevice.SetRenderTarget(trackRender);

            GraphicsDevice.Clear(ClearOptions.Target, Color.Red, 0, 0);



            spriteBatch.Begin();


            spriteBatch.Draw(track, new Rectangle(0, 0, carWidth + 100, carHeight + 100),

                new Rectangle((int)(theXPosition - 50),

                (int)(theYPosition - 50), carWidth + 100, carHeight + 100), Color.White);


            spriteBatch.End();

            GraphicsDevice.SetRenderTarget(null);



            Texture2D aPicture = trackRender;





            //Rotate the snapshot of the area Around the car sprite and return that 
            GraphicsDevice.SetRenderTarget(trackRenderRotated);

            GraphicsDevice.Clear(ClearOptions.Target, Color.Red, 0, 0);



            spriteBatch.Begin();

            spriteBatch.Draw(aPicture, new Rectangle((int)(aPicture.Width / 2), (int)(aPicture.Height / 2),

                aPicture.Width, aPicture.Height), new Rectangle(0, 0, aPicture.Width, aPicture.Width),

                Color.White, -carRotation, new Vector2((int)(aPicture.Width / 2), (int)(aPicture.Height / 2)),

                SpriteEffects.None, 0);

            spriteBatch.End();


            GraphicsDevice.SetRenderTarget(null);



            return trackRenderRotated;

        }
        private void ResetSpawnTime()
        {
            nextSpawnTime = ((Game1)Game).rnd.Next(
            enemySpawnMinMilliseconds,
            enemySpawnMaxMilliseconds);
        }
        private void SpawnEnemy()
        {
            Vector2 speed = Vector2.Zero;
            Vector2 position = Vector2.Zero;
            // Default frame size
            Point frameSize = new Point(75, 75);
            // Randomly choose which side of the screen to place enemy,
            // then randomly create a position along that side of the screen
            // and randomly choose a speed for the enemy
            switch (((Game1)Game).rnd.Next(4))
            {
                case 0: // LEFT to RIGHT
                    position = new Vector2(
                    -frameSize.X, ((Game1)Game).rnd.Next(0,
                    Game.GraphicsDevice.PresentationParameters.BackBufferHeight
                    - frameSize.Y));
                    speed = new Vector2(((Game1)Game).rnd.Next(
                    enemyMinSpeed,
                    enemyMaxSpeed), 0);
                    break;
                case 1: // RIGHT to LEFT
                    position = new
                    Vector2(
                    Game.GraphicsDevice.PresentationParameters.BackBufferWidth,
                    ((Game1)Game).rnd.Next(0,
                    Game.GraphicsDevice.PresentationParameters.BackBufferHeight
                    - frameSize.Y));
                    speed = new Vector2(-((Game1)Game).rnd.Next(
                    enemyMinSpeed, enemyMaxSpeed), 0);
                    break;
                case 2: // BOTTOM to TOP
                    position = new Vector2(((Game1)Game).rnd.Next(0,
                    Game.GraphicsDevice.PresentationParameters.BackBufferWidth
                    - frameSize.X),
                    Game.GraphicsDevice.PresentationParameters.BackBufferHeight);
                    speed = new Vector2(0,
                    -((Game1)Game).rnd.Next(enemyMinSpeed,
                    enemyMaxSpeed));
                    break;
                case 3: // TOP to BOTTOM
                    position = new Vector2(((Game1)Game).rnd.Next(0,
                    Game.GraphicsDevice.PresentationParameters.BackBufferWidth
                    - frameSize.X), -frameSize.Y);
                    speed = new Vector2(0,
                    ((Game1)Game).rnd.Next(enemyMinSpeed, enemyMaxSpeed));
                    break;
            }
            // Create the sprite
            spriteList.Add(
                 new ChasingSprite6(Game.Content.Load<Texture2D>(@"Images\death"),
                 position + new Vector2(-120, 80), new Point(60, 60), 10, new Point(0, 0),
                 new Point(1, 1), speed, this));
            spriteList2.Add(
           new ChasingSprite6(Game.Content.Load<Texture2D>(@"Images\weakness"),
           position + new Vector2(20, 20), new Point(60, 60), 10, new Point(0, 0),
           new Point(1, 1), speed, this));
            spriteList3.Add(
  new AutomatedSprite(Game.Content.Load<Texture2D>(@"Images\power"),
  position, new Point(60, 50), 10, new Point(0, 0),
  new Point(1, 1), speed));


        }
        public Vector2 GetPlayerPosition()
        {
            return carPosition;
        }

    }
}