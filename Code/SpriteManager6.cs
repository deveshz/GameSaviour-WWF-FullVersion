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
    public class SpriteManager6 : Microsoft.Xna.Framework.DrawableGameComponent
    {
        SpriteBatch spriteBatch;
        public bool go = false;

        Texture2D background;
        Rectangle backgroundRect;
        SpriteFont front;
        //----------------Grid--------------
        Texture2D grid;
        Texture2D saviourBack;
        Texture2D basic;
        List<Brick> spriteList = new List<Brick>();
        SaviourBrick saviour;
        SpriteFont stepFont;
        public bool loose = false;
        public bool gstate = false;
        Texture2D lifeno;
        AudioEngine audioEngine;
        WaveBank waveBank;
        SoundBank soundBank;



        int steps = 0;


        bool a = false;
        bool b = false;
        bool c = false;
        bool d = false;
        bool e = false;
        bool isRetry = false;

        GoalBrick goal1;
        GoalBrick goal2;
        GoalBrick goal3;
        GoalBrick goal4;
        GoalBrick goal5;


        GoalBrick dest1;
        GoalBrick dest2;
        GoalBrick dest3;
        GoalBrick dest4;
        GoalBrick dest5;

        Texture2D final1;
        Texture2D final2;
        Texture2D final3;
        Texture2D final4;
        Texture2D final5;


        Texture2D arrow;
        Rectangle arrowRect;
        Texture2D stepImage;
        Texture2D homeImage;
        Rectangle homeRect;
        Texture2D retryImage;
        Rectangle retryRect;
        Texture2D mdg8;

        Vector2 arr_position;
        MouseState prevMouseState;


        Vector2 newPosition = new Vector2(450, 400);
        public SpriteManager6(Game game)
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


            base.Initialize();
        }
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(Game.GraphicsDevice);
            stepFont = Game.Content.Load<SpriteFont>(@"Fonts\Snap");
            mdg8 = Game.Content.Load<Texture2D>(@"Images\yeslife");
            lifeno = Game.Content.Load<Texture2D>(@"Images\nolife");
            audioEngine = new AudioEngine(@"Content\Audio\GameAudio.xgs");
            waveBank = new WaveBank(audioEngine, @"Content\Audio\Wave Bank.xwb");
            soundBank = new SoundBank(audioEngine, @"Content\Audio\Sound Bank.xsb");
            //---------------------------------------------------------
            saviour = new
SaviourBrick(Game.Content.Load<Texture2D>(@"Images/saviours"), new
Vector2(450, 350), 0, new Point(50, 50), new Point(0, 0), new Point(4, 4), 0);
            //-----------------------ROW  1 -----------------------------------------------
            spriteList.Add(new FixedBrick(
       Game.Content.Load<Texture2D>(@"Images/brick"),
       new Vector2(350, 150), 0, new Point(50, 50), new Point(0,
0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
    Game.Content.Load<Texture2D>(@"Images/brick"),
    new Vector2(400, 150), 0, new Point(50, 50), new Point(0,
0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(450, 150), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(500, 150), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(550, 150), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
           Game.Content.Load<Texture2D>(@"Images/brick"),
           new Vector2(600, 150), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(650, 150), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(700, 150), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(750, 150), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            //-----------------------ROW  2 -----------------------------------------------
            spriteList.Add(new FixedBrick(
       Game.Content.Load<Texture2D>(@"Images/brick"),
       new Vector2(350, 200), 0, new Point(50, 50), new Point(0,
0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
    Game.Content.Load<Texture2D>(@"Images/brick"),
    new Vector2(400, 200), 0, new Point(50, 50), new Point(0,
0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(450, 200), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(500, 200), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(550, 200), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
           Game.Content.Load<Texture2D>(@"Images/brick"),
           new Vector2(600, 200), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(650, 200), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(700, 200), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(750, 200), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            //-----------------------ROW  SECOND LAST -----------------------------------------------
            spriteList.Add(new FixedBrick(
       Game.Content.Load<Texture2D>(@"Images/brick"),
       new Vector2(350, 500), 0, new Point(50, 50), new Point(0,
0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
    Game.Content.Load<Texture2D>(@"Images/brick"),
    new Vector2(400, 500), 0, new Point(50, 50), new Point(0,
0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(450, 500), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(500, 500), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(550, 500), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
           Game.Content.Load<Texture2D>(@"Images/brick"),
           new Vector2(600, 500), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(650, 500), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(700, 500), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(750, 500), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            //-----------------------ROW  LAST -----------------------------------------------
            spriteList.Add(new FixedBrick(
       Game.Content.Load<Texture2D>(@"Images/brick"),
       new Vector2(350, 550), 0, new Point(50, 50), new Point(0,
0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
    Game.Content.Load<Texture2D>(@"Images/brick"),
    new Vector2(400, 550), 0, new Point(50, 50), new Point(0,
0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(450, 550), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(500, 550), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(550, 550), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
           Game.Content.Load<Texture2D>(@"Images/brick"),
           new Vector2(600, 550), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(650, 550), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(700, 550), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(750, 550), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            //--------------------------------------COLUMN 1 -------------
            spriteList.Add(new FixedBrick(
      Game.Content.Load<Texture2D>(@"Images/brick"),
      new Vector2(350, 250), 0, new Point(50, 50), new Point(0,
0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
    Game.Content.Load<Texture2D>(@"Images/brick"),
    new Vector2(350, 300), 0, new Point(50, 50), new Point(0,
0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(350, 350), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(350, 400), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(350, 450), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));

            //--------------------------------------COLUMN 2 -------------
            spriteList.Add(new FixedBrick(
      Game.Content.Load<Texture2D>(@"Images/brick"),
      new Vector2(400, 250), 0, new Point(50, 50), new Point(0,
0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
    Game.Content.Load<Texture2D>(@"Images/brick"),
    new Vector2(400, 300), 0, new Point(50, 50), new Point(0,
0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(400, 350), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(400, 400), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(400, 450), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            //--------------------------------------COLUMN LAST -------------
            spriteList.Add(new FixedBrick(
      Game.Content.Load<Texture2D>(@"Images/brick"),
      new Vector2(750, 250), 0, new Point(50, 50), new Point(0,
0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
    Game.Content.Load<Texture2D>(@"Images/brick"),
    new Vector2(750, 300), 0, new Point(50, 50), new Point(0,
0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(750, 350), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(750, 400), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(750, 450), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            //-----------------------OTHER FIXED BLOCKS -----------------------------------------------
            spriteList.Add(new FixedBrick(
       Game.Content.Load<Texture2D>(@"Images/brick"),
       new Vector2(450, 250), 0, new Point(50, 50), new Point(0,
0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
    Game.Content.Load<Texture2D>(@"Images/brick"),
    new Vector2(500, 250), 0, new Point(50, 50), new Point(0,
0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(450, 300), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(500, 300), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(450, 450), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
           Game.Content.Load<Texture2D>(@"Images/brick"),
           new Vector2(500, 450), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(550, 450), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(700, 400), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));
            spriteList.Add(new FixedBrick(
            Game.Content.Load<Texture2D>(@"Images/brick"),
            new Vector2(700, 450), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1)));

            //-----------------------------------------------------
            goal1 = new GoalBrick(
             Game.Content.Load<Texture2D>(@"Images/mdg5"),
             new Vector2(500, 400), 0, new Point(50, 50), new
Point(0, 0), new Point(1, 1));
            goal2 = new GoalBrick(
            Game.Content.Load<Texture2D>(@"Images/mdg5"),
            new Vector2(550, 300), 0, new Point(50, 50), new Point(0,
 0), new Point(1, 1));
            goal3 = new GoalBrick(
             Game.Content.Load<Texture2D>(@"Images/mdg5"),
             new Vector2(550, 350), 0, new Point(50, 50), new
Point(0, 0), new Point(1, 1));
            goal4 = new GoalBrick(
           Game.Content.Load<Texture2D>(@"Images/mdg5"),
           new Vector2(600, 300), 0, new Point(50, 50), new Point(0,
0), new Point(1, 1));
            goal5 = new GoalBrick(
        Game.Content.Load<Texture2D>(@"Images/mdg5"),
        new Vector2(650, 300), 0, new Point(50, 50), new Point(0,
0), new Point(1, 1));
            //-----------------------------------------------------------
            dest1 = new GoalBrick(
         Game.Content.Load<Texture2D>(@"Images/death"),
         new Vector2(550,400), 50, new Point(50, 50), new
Point(0, 0), new Point(1, 1));
            dest2 = new GoalBrick(
            Game.Content.Load<Texture2D>(@"Images/death"),
            new Vector2(600, 400), 50, new Point(50, 50), new Point(0,
 0), new Point(1, 1));
            dest3 = new GoalBrick(
                Game.Content.Load<Texture2D>(@"Images/death"),
                new Vector2(650, 400), 50, new Point(50, 50), new
  Point(0, 0), new Point(1, 1));
            dest4 = new GoalBrick(
            Game.Content.Load<Texture2D>(@"Images/death"),
            new Vector2(600,350), 50, new Point(50, 50), new Point(0,
 0), new Point(1, 1));
            dest5 = new GoalBrick(
           Game.Content.Load<Texture2D>(@"Images/death"),
           new Vector2(650, 350), 50, new Point(50, 50), new Point(0,
 0), new Point(1, 1));
            //--------------------------------------------------
            final1 = Game.Content.Load<Texture2D>(@"Images/mdg5");
            final2 = Game.Content.Load<Texture2D>(@"Images/mdg5");
            final3 = Game.Content.Load<Texture2D>(@"Images/mdg5");
            final4 = Game.Content.Load<Texture2D>(@"Images/mdg5");
            final5 = Game.Content.Load<Texture2D>(@"Images/mdg5");


            arrow = Game.Content.Load<Texture2D>(@"Images/arrow");
            stepImage = Game.Content.Load<Texture2D>(@"Images/steps");
            homeImage = Game.Content.Load<Texture2D>(@"Images/home");
            retryImage = Game.Content.Load<Texture2D>(@"Images/retry");


            background = Game.Content.Load<Texture2D>(@"Images\bg7");

            grid = Game.Content.Load<Texture2D>(@"Images\grid");
            front = Game.Content.Load<SpriteFont>(@"Fonts\Snap");
            saviourBack = Game.Content.Load<Texture2D>(@"Images\saviourback");
            basic = Game.Content.Load<Texture2D>(@"Images\basic");



            base.LoadContent();
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            // TODO: Add your update code here

            backgroundRect = new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height);
            saviour.Update(gameTime, Game.Window.ClientBounds);


            if (((Game1)Game).chances4 > 0)
                loose = false;
            else if (((Game1)Game).chances4 <= 0 && steps == -1)
                loose = true;
            if (((Game1)Game).avataar == 1)
            {
                saviour.currentFrame.Y = 1;
            }
            else if (((Game1)Game).avataar == 2)
            {
                saviour.currentFrame.Y = 2;
            }
            else if (((Game1)Game).avataar == 3)
            {
                saviour.currentFrame.Y = 3;
            }
            else if (((Game1)Game).avataar == 3)
            {
                saviour.currentFrame.Y = 3;
            }
            MouseState mouseState = Mouse.GetState();
            if (mouseState.X != prevMouseState.X ||
            mouseState.Y != prevMouseState.Y)
            {
                arr_position = new Vector2(mouseState.X, mouseState.Y);
                prevMouseState = mouseState;
            }



            arrowRect = new Rectangle((int)arr_position.X, (int)arr_position.Y, 32, 32);
            homeRect = new Rectangle(900, 150, 250, 150);
            retryRect = new Rectangle(50, 150, 250, 150);
            if (arrowRect.Intersects(homeRect) && mouseState.LeftButton == ButtonState.Pressed)
            {
                homeRect.Inflate(10, 10);
                Game.Exit();

            }
            else if (arrowRect.Intersects(homeRect))
            {
                homeRect.Inflate(10, 10);
            }

            foreach (Brick s in spriteList)
            {
                s.Update(gameTime, Game.Window.ClientBounds);
                if (s.collisionRect.Intersects(saviour.collisionRect) && (saviour.currentFrame.X == 0))
                    saviour.position.X = s.position.X + 50;
                if (s.collisionRect.Intersects(saviour.collisionRect) && (saviour.currentFrame.X == 1))
                    saviour.position.Y = s.position.Y + 50;
                if (s.collisionRect.Intersects(saviour.collisionRect) && (saviour.currentFrame.X == 2))
                    saviour.position.Y = s.position.Y - 50;
                if (s.collisionRect.Intersects(saviour.collisionRect) && (saviour.currentFrame.X == 3))
                    saviour.position.X = s.position.X - 50;
            }
            KeyboardState keyboardState = Keyboard.GetState();

            if (arrowRect.Intersects(retryRect) && mouseState.LeftButton == ButtonState.Pressed)
            {
                retryRect.Inflate(10, 10);
                isRetry = true;




            }
            else if (arrowRect.Intersects(retryRect))
            {
                retryRect.Inflate(10, 10);

            }

            dest1.Update(gameTime, Game.Window.ClientBounds);
            dest2.Update(gameTime, Game.Window.ClientBounds);
            dest3.Update(gameTime, Game.Window.ClientBounds);
            dest4.Update(gameTime, Game.Window.ClientBounds);
            dest5.Update(gameTime, Game.Window.ClientBounds);

            goal1.Update(gameTime, Game.Window.ClientBounds);
            goal2.Update(gameTime, Game.Window.ClientBounds);
            goal3.Update(gameTime, Game.Window.ClientBounds);
            goal4.Update(gameTime, Game.Window.ClientBounds);
            goal5.Update(gameTime, Game.Window.ClientBounds);
            if (goal1.collisionRect.Intersects(saviour.collisionRect) && (saviour.currentFrame.X == 0) && (keyboardState.IsKeyDown(Keys.Left)))
            {
                if ((goal1.position.Y == goal5.position.Y) && ((goal5.position.X == goal1.position.X - 50)))
                {
                    goal1.position.X = goal1.position.X;
                    saviour.position.X = goal1.position.X + 50;
                }
                else if ((goal1.position.Y == goal2.position.Y) && ((goal2.position.X == goal1.position.X - 50)))
                {
                    goal1.position.X = goal1.position.X;
                    saviour.position.X = goal1.position.X + 50;
                }
                else if ((goal1.position.Y == goal3.position.Y) && ((goal3.position.X == goal1.position.X - 50)))
                {
                    goal1.position.X = goal1.position.X;
                    saviour.position.X = goal1.position.X + 50;
                }
                else if ((goal1.position.Y == goal4.position.Y) && ((goal4.position.X == goal1.position.X - 50)))
                {
                    goal1.position.X = goal1.position.X;
                    saviour.position.X = goal1.position.X + 50;
                }
                else
                {
                    goal1.position.X = goal1.position.X - 50;
                    saviour.position.X = saviour.position.X;
                }

                if (saviour.position.X <= 400)
                    saviour.position.X = 400;
                if (goal1.position.X <= 350)
                    goal1.position.X = 350;

            }
            if (goal1.collisionRect.Intersects(saviour.collisionRect) && (saviour.currentFrame.X == 2) && (keyboardState.IsKeyDown(Keys.Down)))
            {
                if ((goal1.position.X == goal5.position.X) && ((goal1.position.Y == goal5.position.Y - 50)))
                {
                    goal1.position.Y = goal1.position.Y;
                    saviour.position.Y = goal1.position.Y - 50;
                }
                else if ((goal1.position.X == goal2.position.X) && ((goal1.position.Y == goal2.position.Y - 50)))
                {
                    goal1.position.Y = goal1.position.Y;
                    saviour.position.Y = goal1.position.Y - 50;
                }
                else if ((goal1.position.X == goal3.position.X) && ((goal1.position.Y == goal3.position.Y - 50)))
                {
                    goal1.position.Y = goal1.position.Y;
                    saviour.position.Y = goal1.position.Y - 50;
                }
                else if ((goal1.position.X == goal4.position.X) && ((goal1.position.Y == goal4.position.Y - 50)))
                {
                    goal1.position.Y = goal1.position.Y;
                    saviour.position.Y = goal1.position.Y - 50;
                }
                else
                {
                    goal1.position.Y = goal1.position.Y + 50;
                    saviour.position.Y = saviour.position.Y;
                }


                if (saviour.position.Y >= 500)
                    saviour.position.Y = 500;
                if (goal1.position.Y >= 550)
                    goal1.position.Y = 550;

            }
            if (goal1.collisionRect.Intersects(saviour.collisionRect) && (saviour.currentFrame.X == 1) && (keyboardState.IsKeyDown(Keys.Up)))
            {
                if ((goal1.position.X == goal5.position.X) && ((goal1.position.Y == goal5.position.Y + 50)))
                {
                    goal1.position.Y = goal1.position.Y;
                    saviour.position.Y = goal1.position.Y + 50;
                }
                else if ((goal1.position.X == goal2.position.X) && ((goal1.position.Y == goal2.position.Y + 50)))
                {
                    goal1.position.Y = goal1.position.Y;
                    saviour.position.Y = goal1.position.Y + 50;
                }
                else if ((goal1.position.X == goal3.position.X) && ((goal1.position.Y == goal3.position.Y + 50)))
                {
                    goal1.position.Y = goal1.position.Y;
                    saviour.position.Y = goal1.position.Y + 50;
                }
                else if ((goal1.position.X == goal4.position.X) && ((goal1.position.Y == goal4.position.Y + 50)))
                {
                    goal1.position.Y = goal1.position.Y;
                    saviour.position.Y = goal1.position.Y + 50;
                }
                else
                {
                    goal1.position.Y = goal1.position.Y - 50;
                    saviour.position.Y = saviour.position.Y;
                }


                if (saviour.position.Y <= 200)
                    saviour.position.Y = 200;
                if (goal1.position.Y <= 150)
                    goal1.position.Y = 150;

            }
            if (goal1.collisionRect.Intersects(saviour.collisionRect) && (saviour.currentFrame.X == 3) && (keyboardState.IsKeyDown(Keys.Right)))
            {
                if ((goal1.position.Y == goal5.position.Y) && ((goal1.position.X == goal5.position.X - 50)))
                {
                    goal1.position.X = goal1.position.X;
                    saviour.position.X = goal1.position.X - 50;
                }
                else if ((goal1.position.Y == goal2.position.Y) && ((goal1.position.X == goal2.position.X - 50)))
                {
                    goal1.position.X = goal1.position.X;
                    saviour.position.X = goal1.position.X - 50;
                }
                else if ((goal1.position.Y == goal3.position.Y) && ((goal1.position.X == goal3.position.X - 50)))
                {
                    goal1.position.X = goal1.position.X;
                    saviour.position.X = goal1.position.X - 50;
                }
                else if ((goal1.position.Y == goal4.position.Y) && ((goal1.position.X == goal4.position.X - 50)))
                {
                    goal1.position.X = goal1.position.X;
                    saviour.position.X = goal1.position.X - 50;
                }
                else
                {
                    goal1.position.X = goal1.position.X + 50;
                    saviour.position.X = saviour.position.X;
                }

                if (saviour.position.X >= 700)
                    saviour.position.X = 700;
                if (goal1.position.X >= 750)
                    goal1.position.X = 750;

            }



            if (goal5.collisionRect.Intersects(saviour.collisionRect) && (saviour.currentFrame.X == 0) && (keyboardState.IsKeyDown(Keys.Left)))
            {

                if ((goal1.position.Y == goal5.position.Y) && ((goal1.position.X == goal5.position.X - 50)))
                {
                    goal5.position.X = goal5.position.X;
                    saviour.position.X = goal5.position.X + 50;
                }
                else if ((goal2.position.Y == goal5.position.Y) && ((goal2.position.X == goal5.position.X - 50)))
                {
                    goal5.position.X = goal5.position.X;
                    saviour.position.X = goal5.position.X + 50;
                }
                else if ((goal3.position.Y == goal5.position.Y) && ((goal3.position.X == goal5.position.X - 50)))
                {
                    goal5.position.X = goal5.position.X;
                    saviour.position.X = goal5.position.X + 50;
                }
                else if ((goal4.position.Y == goal5.position.Y) && ((goal4.position.X == goal5.position.X - 50)))
                {
                    goal5.position.X = goal5.position.X;
                    saviour.position.X = goal5.position.X + 50;
                }
                else
                {
                    goal5.position.X = goal5.position.X - 50;
                    saviour.position.X = saviour.position.X;
                }


                if (saviour.position.X <= 400)
                    saviour.position.X = 400;
                if (goal5.position.X <= 350)
                    goal5.position.X = 350;

            }
            if (goal5.collisionRect.Intersects(saviour.collisionRect) && (saviour.currentFrame.X == 2) && (keyboardState.IsKeyDown(Keys.Down)))
            {
                if ((goal1.position.X == goal5.position.X) && ((goal5.position.Y == goal1.position.Y - 50)))
                {
                    goal5.position.Y = goal5.position.Y;
                    saviour.position.Y = goal5.position.Y - 50;
                }
                else if ((goal2.position.X == goal5.position.X) && ((goal5.position.Y == goal2.position.Y - 50)))
                {
                    goal5.position.Y = goal5.position.Y;
                    saviour.position.Y = goal5.position.Y - 50;
                }
                else if ((goal3.position.X == goal5.position.X) && ((goal5.position.Y == goal3.position.Y - 50)))
                {
                    goal5.position.Y = goal5.position.Y;
                    saviour.position.Y = goal5.position.Y - 50;
                }
                else if ((goal4.position.X == goal5.position.X) && ((goal5.position.Y == goal4.position.Y - 50)))
                {
                    goal5.position.Y = goal5.position.Y;
                    saviour.position.Y = goal5.position.Y - 50;
                }
                else
                {
                    goal5.position.Y = goal5.position.Y + 50;
                    saviour.position.Y = saviour.position.Y;
                }

                if (saviour.position.Y >= 500)
                    saviour.position.Y = 500;
                if (goal5.position.Y >= 550)
                    goal5.position.Y = 550;

            }
            if (goal5.collisionRect.Intersects(saviour.collisionRect) && (saviour.currentFrame.X == 1) && (keyboardState.IsKeyDown(Keys.Up)))
            {
                if ((goal1.position.X == goal5.position.X) && ((goal5.position.Y == goal1.position.Y + 50)))
                {
                    goal5.position.Y = goal5.position.Y;
                    saviour.position.Y = goal5.position.Y + 50;
                }
                else if ((goal2.position.X == goal5.position.X) && ((goal5.position.Y == goal2.position.Y + 50)))
                {
                    goal5.position.Y = goal5.position.Y;
                    saviour.position.Y = goal5.position.Y + 50;
                }
                else if ((goal3.position.X == goal5.position.X) && ((goal5.position.Y == goal3.position.Y + 50)))
                {
                    goal5.position.Y = goal5.position.Y;
                    saviour.position.Y = goal5.position.Y + 50;
                }
                else if ((goal4.position.X == goal5.position.X) && ((goal5.position.Y == goal4.position.Y + 50)))
                {
                    goal5.position.Y = goal5.position.Y;
                    saviour.position.Y = goal5.position.Y + 50;
                }
                else
                {
                    goal5.position.Y = goal5.position.Y - 50;
                    saviour.position.Y = saviour.position.Y;
                }

                if (saviour.position.Y <= 200)
                    saviour.position.Y = 200;
                if (goal5.position.Y <= 150)
                    goal5.position.Y = 150;

            }
            if (goal5.collisionRect.Intersects(saviour.collisionRect) && (saviour.currentFrame.X == 3) && (keyboardState.IsKeyDown(Keys.Right)))
            {
                if ((goal1.position.Y == goal5.position.Y) && ((goal1.position.X == goal5.position.X + 50)))
                {
                    goal5.position.X = goal5.position.X;
                    saviour.position.X = goal5.position.X - 50;
                }
                else if ((goal2.position.Y == goal5.position.Y) && ((goal2.position.X == goal5.position.X + 50)))
                {
                    goal5.position.X = goal5.position.X;
                    saviour.position.X = goal5.position.X - 50;
                }
                else if ((goal3.position.Y == goal5.position.Y) && ((goal3.position.X == goal5.position.X + 50)))
                {
                    goal5.position.X = goal5.position.X;
                    saviour.position.X = goal5.position.X - 50;
                }
                else if ((goal4.position.Y == goal5.position.Y) && ((goal4.position.X == goal5.position.X + 50)))
                {
                    goal5.position.X = goal5.position.X;
                    saviour.position.X = goal5.position.X - 50;
                }
                else
                {
                    goal5.position.X = goal5.position.X + 50;
                    saviour.position.X = saviour.position.X;
                }

                if (saviour.position.X >= 700)
                    saviour.position.X = 700;
                if (goal5.position.X >= 750)
                    goal5.position.X = 750;

            }
            if (goal2.collisionRect.Intersects(saviour.collisionRect) && (saviour.currentFrame.X == 0) && (keyboardState.IsKeyDown(Keys.Left)))
            {
                if ((goal2.position.Y == goal5.position.Y) && ((goal5.position.X == goal2.position.X - 50)))
                {
                    goal2.position.X = goal2.position.X;
                    saviour.position.X = goal2.position.X + 50;
                }
                else if ((goal2.position.Y == goal1.position.Y) && ((goal1.position.X == goal2.position.X - 50)))
                {
                    goal2.position.X = goal2.position.X;
                    saviour.position.X = goal2.position.X + 50;
                }
                else if ((goal2.position.Y == goal3.position.Y) && ((goal3.position.X == goal2.position.X - 50)))
                {
                    goal2.position.X = goal2.position.X;
                    saviour.position.X = goal2.position.X + 50;
                }
                else if ((goal2.position.Y == goal4.position.Y) && ((goal4.position.X == goal2.position.X - 50)))
                {
                    goal2.position.X = goal2.position.X;
                    saviour.position.X = goal2.position.X + 50;
                }
                else
                {
                    goal2.position.X = goal2.position.X - 50;
                    saviour.position.X = saviour.position.X;
                }

                if (saviour.position.X <= 400)
                    saviour.position.X = 400;
                if (goal2.position.X <= 350)
                    goal2.position.X = 350;

            }
            if (goal2.collisionRect.Intersects(saviour.collisionRect) && (saviour.currentFrame.X == 2) && (keyboardState.IsKeyDown(Keys.Down)))
            {
                if ((goal2.position.X == goal5.position.X) && ((goal2.position.Y == goal5.position.Y - 50)))
                {
                    goal2.position.Y = goal2.position.Y;
                    saviour.position.Y = goal2.position.Y - 50;
                }
                else if ((goal2.position.X == goal1.position.X) && ((goal2.position.Y == goal1.position.Y - 50)))
                {
                    goal2.position.Y = goal2.position.Y;
                    saviour.position.Y = goal2.position.Y - 50;
                }
                else if ((goal2.position.X == goal3.position.X) && ((goal2.position.Y == goal3.position.Y - 50)))
                {
                    goal2.position.Y = goal2.position.Y;
                    saviour.position.Y = goal2.position.Y - 50;
                }
                else if ((goal2.position.X == goal4.position.X) && ((goal2.position.Y == goal4.position.Y - 50)))
                {
                    goal2.position.Y = goal2.position.Y;
                    saviour.position.Y = goal2.position.Y - 50;
                }
                else
                {
                    goal2.position.Y = goal2.position.Y + 50;
                    saviour.position.Y = saviour.position.Y;
                }


                if (saviour.position.Y >= 500)
                    saviour.position.Y = 500;
                if (goal2.position.Y >= 550)
                    goal2.position.Y = 550;

            }
            if (goal2.collisionRect.Intersects(saviour.collisionRect) && (saviour.currentFrame.X == 1) && (keyboardState.IsKeyDown(Keys.Up)))
            {
                if ((goal2.position.X == goal5.position.X) && ((goal2.position.Y == goal5.position.Y + 50)))
                {
                    goal2.position.Y = goal2.position.Y;
                    saviour.position.Y = goal2.position.Y + 50;
                }
                else if ((goal2.position.X == goal1.position.X) && ((goal2.position.Y == goal1.position.Y + 50)))
                {
                    goal2.position.Y = goal2.position.Y;
                    saviour.position.Y = goal2.position.Y + 50;
                }
                else if ((goal2.position.X == goal3.position.X) && ((goal2.position.Y == goal3.position.Y + 50)))
                {
                    goal2.position.Y = goal2.position.Y;
                    saviour.position.Y = goal2.position.Y + 50;
                }
                else if ((goal2.position.X == goal4.position.X) && ((goal2.position.Y == goal4.position.Y + 50)))
                {
                    goal2.position.Y = goal2.position.Y;
                    saviour.position.Y = goal2.position.Y + 50;
                }

                else
                {
                    goal2.position.Y = goal2.position.Y - 50;
                    saviour.position.Y = saviour.position.Y;
                }


                if (saviour.position.Y <= 200)
                    saviour.position.Y = 200;
                if (goal2.position.Y <= 150)
                    goal2.position.Y = 150;

            }
            if (goal2.collisionRect.Intersects(saviour.collisionRect) && (saviour.currentFrame.X == 3) && (keyboardState.IsKeyDown(Keys.Right)))
            {
                if ((goal2.position.Y == goal5.position.Y) && ((goal2.position.X == goal5.position.X - 50)))
                {
                    goal2.position.X = goal2.position.X;
                    saviour.position.X = goal2.position.X - 50;
                }
                else if ((goal2.position.Y == goal1.position.Y) && ((goal2.position.X == goal1.position.X - 50)))
                {
                    goal2.position.X = goal2.position.X;
                    saviour.position.X = goal2.position.X - 50;
                }
                else if ((goal2.position.Y == goal3.position.Y) && ((goal2.position.X == goal3.position.X - 50)))
                {
                    goal2.position.X = goal2.position.X;
                    saviour.position.X = goal2.position.X - 50;
                }
                else if ((goal2.position.Y == goal4.position.Y) && ((goal2.position.X == goal4.position.X - 50)))
                {
                    goal2.position.X = goal2.position.X;
                    saviour.position.X = goal2.position.X - 50;
                }
                else
                {
                    goal2.position.X = goal2.position.X + 50;
                    saviour.position.X = saviour.position.X;
                }

                if (saviour.position.X >= 700)
                    saviour.position.X = 700;
                if (goal2.position.X >= 750)
                    goal2.position.X = 750;

            }
            if (goal3.collisionRect.Intersects(saviour.collisionRect) && (saviour.currentFrame.X == 0) && (keyboardState.IsKeyDown(Keys.Left)))
            {
                if ((goal3.position.Y == goal5.position.Y) && ((goal5.position.X == goal3.position.X - 50)))
                {
                    goal3.position.X = goal3.position.X;
                    saviour.position.X = goal3.position.X + 50;
                }
                else if ((goal3.position.Y == goal1.position.Y) && ((goal1.position.X == goal3.position.X - 50)))
                {
                    goal3.position.X = goal3.position.X;
                    saviour.position.X = goal3.position.X + 50;
                }
                else if ((goal3.position.Y == goal2.position.Y) && ((goal2.position.X == goal3.position.X - 50)))
                {
                    goal3.position.X = goal3.position.X;
                    saviour.position.X = goal3.position.X + 50;
                }
                else if ((goal3.position.Y == goal4.position.Y) && ((goal4.position.X == goal3.position.X - 50)))
                {
                    goal3.position.X = goal3.position.X;
                    saviour.position.X = goal3.position.X + 50;
                }
                else
                {
                    goal3.position.X = goal3.position.X - 50;
                    saviour.position.X = saviour.position.X;
                }

                if (saviour.position.X <= 400)
                    saviour.position.X = 400;
                if (goal3.position.X <= 350)
                    goal3.position.X = 350;

            }
            if (goal3.collisionRect.Intersects(saviour.collisionRect) && (saviour.currentFrame.X == 2) && (keyboardState.IsKeyDown(Keys.Down)))
            {
                if ((goal3.position.X == goal5.position.X) && ((goal3.position.Y == goal5.position.Y - 50)))
                {
                    goal3.position.Y = goal3.position.Y;
                    saviour.position.Y = goal3.position.Y - 50;
                }
                else if ((goal3.position.X == goal1.position.X) && ((goal3.position.Y == goal1.position.Y - 50)))
                {
                    goal3.position.Y = goal3.position.Y;
                    saviour.position.Y = goal3.position.Y - 50;
                }
                else if ((goal3.position.X == goal2.position.X) && ((goal3.position.Y == goal2.position.Y - 50)))
                {
                    goal3.position.Y = goal3.position.Y;
                    saviour.position.Y = goal3.position.Y - 50;
                }
                else if ((goal3.position.X == goal4.position.X) && ((goal3.position.Y == goal4.position.Y - 50)))
                {
                    goal3.position.Y = goal3.position.Y;
                    saviour.position.Y = goal3.position.Y - 50;
                }
                else
                {
                    goal3.position.Y = goal3.position.Y + 50;
                    saviour.position.Y = saviour.position.Y;
                }


                if (saviour.position.Y >= 500)
                    saviour.position.Y = 500;
                if (goal3.position.Y >= 450)
                    goal3.position.Y = 450;

            }
            if (goal3.collisionRect.Intersects(saviour.collisionRect) && (saviour.currentFrame.X == 1) && (keyboardState.IsKeyDown(Keys.Up)))
            {
                if ((goal3.position.X == goal5.position.X) && ((goal3.position.Y == goal5.position.Y + 50)))
                {
                    goal3.position.Y = goal3.position.Y;
                    saviour.position.Y = goal3.position.Y + 50;
                }
                else if ((goal3.position.X == goal1.position.X) && ((goal3.position.Y == goal1.position.Y + 50)))
                {
                    goal3.position.Y = goal3.position.Y;
                    saviour.position.Y = goal3.position.Y + 50;
                }
                else if ((goal3.position.X == goal2.position.X) && ((goal3.position.Y == goal2.position.Y + 50)))
                {
                    goal3.position.Y = goal3.position.Y;
                    saviour.position.Y = goal3.position.Y + 50;
                }
                else if ((goal3.position.X == goal4.position.X) && ((goal3.position.Y == goal4.position.Y + 50)))
                {
                    goal3.position.Y = goal3.position.Y;
                    saviour.position.Y = goal3.position.Y + 50;
                }

                else
                {
                    goal3.position.Y = goal3.position.Y - 50;
                    saviour.position.Y = saviour.position.Y;
                }


                if (saviour.position.Y <= 200)
                    saviour.position.Y = 200;
                if (goal3.position.Y <= 150)
                    goal3.position.Y = 150;

            }
            if (goal3.collisionRect.Intersects(saviour.collisionRect) && (saviour.currentFrame.X == 3) && (keyboardState.IsKeyDown(Keys.Right)))
            {
                if ((goal3.position.Y == goal5.position.Y) && ((goal3.position.X == goal5.position.X - 50)))
                {
                    goal3.position.X = goal3.position.X;
                    saviour.position.X = goal3.position.X - 50;
                }
                else if ((goal3.position.Y == goal1.position.Y) && ((goal3.position.X == goal1.position.X - 50)))
                {
                    goal3.position.X = goal3.position.X;
                    saviour.position.X = goal3.position.X - 50;
                }
                else if ((goal3.position.Y == goal2.position.Y) && ((goal3.position.X == goal2.position.X - 50)))
                {
                    goal3.position.X = goal3.position.X;
                    saviour.position.X = goal3.position.X - 50;
                }
                else if ((goal3.position.Y == goal4.position.Y) && ((goal3.position.X == goal4.position.X - 50)))
                {
                    goal3.position.X = goal3.position.X;
                    saviour.position.X = goal3.position.X - 50;
                }
                else
                {
                    goal3.position.X = goal3.position.X + 50;
                    saviour.position.X = saviour.position.X;
                }

                if (saviour.position.X >= 700)
                    saviour.position.X = 700;
                if (goal3.position.X >= 750)
                    goal3.position.X = 750;

            }
            if (goal4.collisionRect.Intersects(saviour.collisionRect) && (saviour.currentFrame.X == 0) && (keyboardState.IsKeyDown(Keys.Left)))
            {
                if ((goal4.position.Y == goal5.position.Y) && ((goal5.position.X == goal4.position.X - 50)))
                {
                    goal4.position.X = goal4.position.X;
                    saviour.position.X = goal4.position.X + 50;
                }
                else if ((goal4.position.Y == goal1.position.Y) && ((goal1.position.X == goal4.position.X - 50)))
                {
                    goal4.position.X = goal4.position.X;
                    saviour.position.X = goal4.position.X + 50;
                }
                else if ((goal4.position.Y == goal2.position.Y) && ((goal2.position.X == goal4.position.X - 50)))
                {
                    goal4.position.X = goal4.position.X;
                    saviour.position.X = goal4.position.X + 50;
                }
                else if ((goal4.position.Y == goal3.position.Y) && ((goal3.position.X == goal4.position.X - 50)))
                {
                    goal4.position.X = goal4.position.X;
                    saviour.position.X = goal4.position.X + 50;
                }
                else
                {
                    goal4.position.X = goal4.position.X - 50;
                    saviour.position.X = saviour.position.X;
                }

                if (saviour.position.X <= 400)
                    saviour.position.X = 400;
                if (goal4.position.X <= 350)
                    goal4.position.X = 350;

            }
            if (goal4.collisionRect.Intersects(saviour.collisionRect) && (saviour.currentFrame.X == 2) && (keyboardState.IsKeyDown(Keys.Down)))
            {
                if ((goal4.position.X == goal5.position.X) && ((goal4.position.Y == goal5.position.Y - 50)))
                {
                    goal4.position.Y = goal4.position.Y;
                    saviour.position.Y = goal4.position.Y - 50;
                }
                else if ((goal4.position.X == goal1.position.X) && ((goal4.position.Y == goal1.position.Y - 50)))
                {
                    goal4.position.Y = goal4.position.Y;
                    saviour.position.Y = goal4.position.Y - 50;
                }
                else if ((goal4.position.X == goal2.position.X) && ((goal4.position.Y == goal2.position.Y - 50)))
                {
                    goal4.position.Y = goal4.position.Y;
                    saviour.position.Y = goal4.position.Y - 50;
                }
                else if ((goal4.position.X == goal3.position.X) && ((goal4.position.Y == goal3.position.Y - 50)))
                {
                    goal4.position.Y = goal4.position.Y;
                    saviour.position.Y = goal4.position.Y - 50;
                }
                else
                {
                    goal4.position.Y = goal4.position.Y + 50;
                    saviour.position.Y = saviour.position.Y;
                }


                if (saviour.position.Y >= 500)
                    saviour.position.Y = 500;
                if (goal4.position.Y >= 550)
                    goal4.position.Y = 550;

            }
            if (goal4.collisionRect.Intersects(saviour.collisionRect) && (saviour.currentFrame.X == 1) && (keyboardState.IsKeyDown(Keys.Up)))
            {
                if ((goal4.position.X == goal5.position.X) && ((goal4.position.Y == goal5.position.Y + 50)))
                {
                    goal4.position.Y = goal4.position.Y;
                    saviour.position.Y = goal4.position.Y + 50;
                }
                else if ((goal4.position.X == goal1.position.X) && ((goal4.position.Y == goal1.position.Y + 50)))
                {
                    goal4.position.Y = goal4.position.Y;
                    saviour.position.Y = goal4.position.Y + 50;
                }
                else if ((goal4.position.X == goal2.position.X) && ((goal4.position.Y == goal2.position.Y + 50)))
                {
                    goal4.position.Y = goal4.position.Y;
                    saviour.position.Y = goal4.position.Y + 50;
                }
                else if ((goal4.position.X == goal3.position.X) && ((goal4.position.Y == goal3.position.Y + 50)))
                {
                    goal4.position.Y = goal4.position.Y;
                    saviour.position.Y = goal4.position.Y + 50;
                }

                else
                {
                    goal4.position.Y = goal4.position.Y - 50;
                    saviour.position.Y = saviour.position.Y;
                }


                if (saviour.position.Y <= 200)
                    saviour.position.Y = 200;
                if (goal4.position.Y <= 150)
                    goal4.position.Y = 150;

            }
            if (goal4.collisionRect.Intersects(saviour.collisionRect) && (saviour.currentFrame.X == 3) && (keyboardState.IsKeyDown(Keys.Right)))
            {
                if ((goal4.position.Y == goal5.position.Y) && ((goal4.position.X == goal5.position.X - 50)))
                {
                    goal4.position.X = goal4.position.X;
                    saviour.position.X = goal4.position.X - 50;
                }
                else if ((goal4.position.Y == goal1.position.Y) && ((goal4.position.X == goal1.position.X - 50)))
                {
                    goal4.position.X = goal4.position.X;
                    saviour.position.X = goal4.position.X - 50;
                }
                else if ((goal4.position.Y == goal2.position.Y) && ((goal4.position.X == goal2.position.X - 50)))
                {
                    goal4.position.X = goal4.position.X;
                    saviour.position.X = goal4.position.X - 50;
                }
                else if ((goal4.position.Y == goal3.position.Y) && ((goal4.position.X == goal3.position.X - 50)))
                {
                    goal4.position.X = goal4.position.X;
                    saviour.position.X = goal4.position.X - 50;
                }
                else
                {
                    goal4.position.X = goal4.position.X + 50;
                    saviour.position.X = saviour.position.X;
                }

                if (saviour.position.X >= 700)
                    saviour.position.X = 700;
                if (goal4.position.X >= 750)
                    goal4.position.X = 750;

            }

            foreach (Brick s in spriteList)
            {

                if (s.collisionRect.Intersects(goal5.collisionRect) && (keyboardState.IsKeyDown(Keys.Left)))
                {
                    goal5.position.X = s.position.X + 50;
                    saviour.position.X = goal5.position.X + 50;
                }
                if (s.collisionRect.Intersects(goal5.collisionRect) && (keyboardState.IsKeyDown(Keys.Right)))
                {
                    goal5.position.X = s.position.X - 50;
                    saviour.position.X = goal5.position.X - 50;
                }
                if (s.collisionRect.Intersects(goal5.collisionRect) && (keyboardState.IsKeyDown(Keys.Up)))
                {
                    goal5.position.Y = s.position.Y + 50;
                    saviour.position.Y = goal5.position.Y + 50;
                }
                if (s.collisionRect.Intersects(goal5.collisionRect) && (keyboardState.IsKeyDown(Keys.Down)))
                {
                    goal5.position.Y = s.position.Y - 50;
                    saviour.position.Y = goal5.position.Y - 50;
                }

            }
            foreach (Brick s in spriteList)
            {

                if (s.collisionRect.Intersects(goal1.collisionRect) && (keyboardState.IsKeyDown(Keys.Left)))
                {
                    goal1.position.X = s.position.X + 50;
                    saviour.position.X = goal1.position.X + 50;
                }
                if (s.collisionRect.Intersects(goal1.collisionRect) && (keyboardState.IsKeyDown(Keys.Right)))
                {
                    goal1.position.X = s.position.X - 50;
                    saviour.position.X = goal1.position.X - 50;
                }
                if (s.collisionRect.Intersects(goal1.collisionRect) && (keyboardState.IsKeyDown(Keys.Up)))
                {
                    goal1.position.Y = s.position.Y + 50;
                    saviour.position.Y = goal1.position.Y + 50;
                }
                if (s.collisionRect.Intersects(goal1.collisionRect) && (keyboardState.IsKeyDown(Keys.Down)))
                {
                    goal1.position.Y = s.position.Y - 50;
                    saviour.position.Y = goal1.position.Y - 50;
                }

            }
            foreach (Brick s in spriteList)
            {

                if (s.collisionRect.Intersects(goal2.collisionRect) && (keyboardState.IsKeyDown(Keys.Left)))
                {
                    goal2.position.X = s.position.X + 50;
                    saviour.position.X = goal2.position.X + 50;
                }
                if (s.collisionRect.Intersects(goal2.collisionRect) && (keyboardState.IsKeyDown(Keys.Right)))
                {
                    goal2.position.X = s.position.X - 50;
                    saviour.position.X = goal2.position.X - 50;
                }
                if (s.collisionRect.Intersects(goal2.collisionRect) && (keyboardState.IsKeyDown(Keys.Up)))
                {
                    goal2.position.Y = s.position.Y + 50;
                    saviour.position.Y = goal2.position.Y + 50;
                }
                if (s.collisionRect.Intersects(goal2.collisionRect) && (keyboardState.IsKeyDown(Keys.Down)))
                {
                    goal2.position.Y = s.position.Y - 50;
                    saviour.position.Y = goal2.position.Y - 50;
                }

            }
            foreach (Brick s in spriteList)
            {

                if (s.collisionRect.Intersects(goal3.collisionRect) && (keyboardState.IsKeyDown(Keys.Left)))
                {
                    goal3.position.X = s.position.X + 50;
                    saviour.position.X = goal3.position.X + 50;
                }
                if (s.collisionRect.Intersects(goal3.collisionRect) && (keyboardState.IsKeyDown(Keys.Right)))
                {
                    goal3.position.X = s.position.X - 50;
                    saviour.position.X = goal3.position.X - 50;
                }
                if (s.collisionRect.Intersects(goal3.collisionRect) && (keyboardState.IsKeyDown(Keys.Up)))
                {
                    goal3.position.Y = s.position.Y + 50;
                    saviour.position.Y = goal3.position.Y + 50;
                }
                if (s.collisionRect.Intersects(goal3.collisionRect) && (keyboardState.IsKeyDown(Keys.Down)))
                {
                    goal3.position.Y = s.position.Y - 50;
                    saviour.position.Y = goal3.position.Y - 50;
                }

            }
            foreach (Brick s in spriteList)
            {

                if (s.collisionRect.Intersects(goal4.collisionRect) && (keyboardState.IsKeyDown(Keys.Left)))
                {
                    goal4.position.X = s.position.X + 50;
                    saviour.position.X = goal4.position.X + 50;
                }
                if (s.collisionRect.Intersects(goal4.collisionRect) && (keyboardState.IsKeyDown(Keys.Right)))
                {
                    goal4.position.X = s.position.X - 50;
                    saviour.position.X = goal4.position.X - 50;
                }
                if (s.collisionRect.Intersects(goal4.collisionRect) && (keyboardState.IsKeyDown(Keys.Up)))
                {
                    goal4.position.Y = s.position.Y + 50;
                    saviour.position.Y = goal4.position.Y + 50;
                }
                if (s.collisionRect.Intersects(goal4.collisionRect) && (keyboardState.IsKeyDown(Keys.Down)))
                {
                    goal4.position.Y = s.position.Y - 50;
                    saviour.position.Y = goal4.position.Y - 50;
                }

            }

            if (newPosition.X != saviour.position.X || newPosition.Y != saviour.position.Y)
            {
                steps += 1;
                newPosition.X = saviour.position.X;
                newPosition.Y = saviour.position.Y;
            }


            base.Update(gameTime);

        }
        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend);
            spriteBatch.Draw(basic, backgroundRect, Color.LightCyan);
            spriteBatch.Draw(background, backgroundRect, Color.White);
            spriteBatch.Draw(grid, new Vector2(350, 150), Color.White);
            foreach (Brick s in spriteList)
                s.Draw(gameTime, spriteBatch);
            dest1.Draw(gameTime, spriteBatch);
            dest2.Draw(gameTime, spriteBatch);
            dest3.Draw(gameTime, spriteBatch);
            dest4.Draw(gameTime, spriteBatch);
            dest5.Draw(gameTime, spriteBatch);
            saviour.Draw(gameTime, spriteBatch);
            goal1.Draw(gameTime, spriteBatch);
            goal2.Draw(gameTime, spriteBatch);
            goal3.Draw(gameTime, spriteBatch);
            goal4.Draw(gameTime, spriteBatch);
            goal5.Draw(gameTime, spriteBatch);
            if (goal1.collisionRect.Equals(dest1.collisionRect) || goal1.collisionRect.Equals(dest2.collisionRect) || goal1.collisionRect.Equals(dest3.collisionRect) || goal1.collisionRect.Equals(dest4.collisionRect) || goal1.collisionRect.Equals(dest5.collisionRect))
            {
                spriteBatch.Draw(final1, goal1.collisionRect, Color.Red);

                a = true;

            }
            if (goal2.collisionRect.Equals(dest1.collisionRect) || goal2.collisionRect.Equals(dest2.collisionRect) || goal2.collisionRect.Equals(dest3.collisionRect) || goal2.collisionRect.Equals(dest4.collisionRect) || goal2.collisionRect.Equals(dest5.collisionRect))
            {
                spriteBatch.Draw(final2, goal2.collisionRect, Color.Red);
                b = true;


            }
            if (goal3.collisionRect.Equals(dest1.collisionRect) || goal3.collisionRect.Equals(dest2.collisionRect) || goal3.collisionRect.Equals(dest3.collisionRect) || goal3.collisionRect.Equals(dest4.collisionRect) || goal3.collisionRect.Equals(dest5.collisionRect))
            {
                spriteBatch.Draw(final3, goal3.collisionRect, Color.Red);
                c = true;


            }
            if (goal4.collisionRect.Equals(dest1.collisionRect) || goal4.collisionRect.Equals(dest2.collisionRect) || goal4.collisionRect.Equals(dest3.collisionRect) || goal4.collisionRect.Equals(dest4.collisionRect) || goal4.collisionRect.Equals(dest5.collisionRect))
            {
                spriteBatch.Draw(final4, goal4.collisionRect, Color.Red);

                d = true;

            }
            if (goal5.collisionRect.Equals(dest1.collisionRect) || goal5.collisionRect.Equals(dest2.collisionRect) || goal5.collisionRect.Equals(dest3.collisionRect) || goal5.collisionRect.Equals(dest4.collisionRect) || goal5.collisionRect.Equals(dest5.collisionRect))
            {
                spriteBatch.Draw(final5, goal5.collisionRect, Color.Red);

                e = true;

            }
            if (a && b && c && d && e)
                go = true;


            spriteBatch.Draw(stepImage, new Vector2(900, 400), Color.White);
            spriteBatch.Draw(homeImage, homeRect, Color.White);
            spriteBatch.Draw(retryImage, retryRect, Color.White);
            spriteBatch.Draw(arrow, arr_position, Color.White);
            if (((Game1)Game).chances4 > 0)
            {
                spriteBatch.Draw(mdg8, new Vector2(50, 400), Color.White);
            }
            else if (((Game1)Game).chances4 <= 0)
            {
                spriteBatch.Draw(lifeno, new Vector2(50, 400), Color.White);
            }
            spriteBatch.DrawString(stepFont, "Steps: " + steps,
new Vector2(1025, 500), Color.Brown, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);

            if (isRetry)
            {
                saviour = new
SaviourBrick(Game.Content.Load<Texture2D>(@"Images/saviours"), new
Vector2(450, 350), 0, new Point(50, 50), new Point(0, 0), new Point(4, 4), 0);
                goal1 = new GoalBrick(
             Game.Content.Load<Texture2D>(@"Images/mdg5"),
             new Vector2(500,400), 0, new Point(50, 50), new
Point(0, 0), new Point(1, 1));
                goal2 = new GoalBrick(
                Game.Content.Load<Texture2D>(@"Images/mdg5"),
                new Vector2(550, 300), 0, new Point(50, 50), new Point(0,
     0), new Point(1, 1));
                goal3 = new GoalBrick(
                 Game.Content.Load<Texture2D>(@"Images/mdg5"),
                 new Vector2(550, 350), 0, new Point(50, 50), new
    Point(0, 0), new Point(1, 1));
                goal4 = new GoalBrick(
               Game.Content.Load<Texture2D>(@"Images/mdg5"),
               new Vector2(600, 300), 0, new Point(50, 50), new Point(0,
    0), new Point(1, 1));
                goal5 = new GoalBrick(
            Game.Content.Load<Texture2D>(@"Images/mdg5"),
            new Vector2(650, 300), 0, new Point(50, 50), new Point(0,
    0), new Point(1, 1));

                steps = -1;

                isRetry = false;
            }


            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}

