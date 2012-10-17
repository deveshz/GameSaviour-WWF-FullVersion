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
    public class SelectMenu : Microsoft.Xna.Framework.DrawableGameComponent
    {
        SpriteBatch spriteBatch;
       
        Texture2D newgame;
        Texture2D help;
        Texture2D credits;
        Texture2D quit;


        Texture2D newgame1;
        Texture2D help1;
        Texture2D credits1;
        Texture2D quit1;

        Texture2D background;
        Rectangle newgameRect;
        Rectangle helpRect;
        Rectangle creditsRect;
        Rectangle quitRect;

        Rectangle newgameRect1;
        Rectangle helpRect1;
        Rectangle creditsRect1;
        Rectangle quitRect1;

        Texture2D arrow;
        Rectangle arrowRect;

        Vector2 arr_position;
        MouseState prevMouseState;

         public bool g2state = false;
         public bool g3state = false;
         public bool g4state = false;

       public  bool helpstate = false;
        public SelectMenu(Game game)
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
            newgame = Game.Content.Load<Texture2D>(@"Images\Start1");
            help = Game.Content.Load<Texture2D>(@"Images\Help1");
            credits = Game.Content.Load<Texture2D>(@"Images\Develop1");
            quit = Game.Content.Load<Texture2D>(@"Images\Quit1");
            arrow = Game.Content.Load<Texture2D>(@"Images\arrow");

            newgame1 = Game.Content.Load<Texture2D>(@"Images\Start2");
            help1 = Game.Content.Load<Texture2D>(@"Images\Help2");
            credits1 = Game.Content.Load<Texture2D>(@"Images\Develop2");
            quit1 = Game.Content.Load<Texture2D>(@"Images\Quit2");
            arrow = Game.Content.Load<Texture2D>(@"Images\arrow");
            
            background = Game.Content.Load<Texture2D>(@"Images\background1");
            base.LoadContent();
        }
        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            // TODO: Add your update code here
            newgameRect = new Rectangle(150,20, 150,150);
            helpRect = new Rectangle(150,190, 150,150);
            creditsRect = new Rectangle(150, 360, 150, 150);
            quitRect = new Rectangle(150, 530, 150, 150);

            newgameRect1 = new Rectangle(450, 20, 450, 170);
            helpRect1 = new Rectangle(450, 190, 450, 170);
            creditsRect1 = new Rectangle(450, 360, 450, 170);
            quitRect1 = new Rectangle(450, 530, 450, 170);
            arrowRect = new Rectangle((int)arr_position.X, (int)arr_position.Y, 32, 32);
           
            MouseState mouseState = Mouse.GetState();
            if (mouseState.X != prevMouseState.X ||
            mouseState.Y != prevMouseState.Y)
            {
                arr_position = new Vector2(mouseState.X, mouseState.Y);
                prevMouseState = mouseState;
            }
            arrowRect = new Rectangle((int)arr_position.X, (int)arr_position.Y, 32, 32);
 
            if (arrowRect.Intersects(newgameRect) && mouseState.LeftButton == ButtonState.Pressed)
            {
                newgameRect.Inflate(10, 10);
                newgameRect1.Offset(50, 0); 
                g2state = true;

            }
             else if (arrowRect.Intersects(newgameRect))
            {
                newgameRect.Inflate(10, 10);
                newgameRect1.Offset(50, 0); 
            }
            if (arrowRect.Intersects(helpRect) && mouseState.LeftButton == ButtonState.Pressed)
            {
                helpRect.Inflate(10, 10);
                helpRect1.Offset(50,0);
                helpstate = true;

            }
            else  if (arrowRect.Intersects(helpRect))
            {
                helpRect.Inflate(10, 10);
                helpRect1.Offset(50, 0);
            }
            if (arrowRect.Intersects(creditsRect) && mouseState.LeftButton == ButtonState.Pressed)
            {
                creditsRect.Inflate(10, 10);
                creditsRect1.Offset(50, 0);
                g4state = true;
            }

             else if (arrowRect.Intersects(creditsRect))
            {
               creditsRect.Inflate(10, 10);
               creditsRect1.Offset(50, 0);
            }

            if (arrowRect.Intersects(quitRect) && mouseState.LeftButton == ButtonState.Pressed)
            {

                g3state = true;

            } 
            else if (arrowRect.Intersects(quitRect))
            {
                quitRect.Inflate(10, 10);
                quitRect1.Offset(50, 0);
            }

            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.MidnightBlue);
            spriteBatch.Begin();
            spriteBatch.Draw(background, new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height), Color.White);
            spriteBatch.Draw(newgame, newgameRect, Color.White);
            spriteBatch.Draw(help, helpRect, Color.White);
            spriteBatch.Draw(credits, creditsRect, Color.White);
            spriteBatch.Draw(quit, quitRect, Color.White);
            spriteBatch.Draw(arrow, arrowRect, Color.White);
            spriteBatch.Draw(newgame1, newgameRect1, Color.White);
            spriteBatch.Draw(help1, helpRect1, Color.White);
            spriteBatch.Draw(credits1, creditsRect1, Color.White);
            spriteBatch.Draw(quit1, quitRect1, Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}