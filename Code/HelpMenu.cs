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
    public class HelpMenu : Microsoft.Xna.Framework.DrawableGameComponent
    {
        SpriteBatch spriteBatch;
        SpriteFont text;
        Texture2D controls;
        Texture2D pushit;
        Texture2D keyidea;
        Texture2D rocknroll;
        Texture2D arrow;
        Texture2D helpback;
        Texture2D helpback1;
        Texture2D forward;
        Texture2D backward;
         public bool back = false;
         public int number = 0;
        public HelpMenu(Game game)
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
            keyidea = Game.Content.Load<Texture2D>(@"Images\keyidea");
           pushit = Game.Content.Load<Texture2D>(@"Images\pushit");
           controls = Game.Content.Load<Texture2D>(@"Images\controls12");
            rocknroll = Game.Content.Load<Texture2D>(@"Images\rocknroll");
            helpback = Game.Content.Load<Texture2D>(@"Images\background1");
            helpback1 = Game.Content.Load<Texture2D>(@"Images\helpback");
           forward = Game.Content.Load<Texture2D>(@"Images\forward");
           backward = Game.Content.Load<Texture2D>(@"Images\backward");
            text = Game.Content.Load<SpriteFont>(@"Fonts\Snap");
            
            arrow = Game.Content.Load<Texture2D>(@"Images\arrow");
            
            base.LoadContent();
        }
        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            // TODO: Add your update code here
            KeyboardState ks = Keyboard.GetState();
             if (ks.IsKeyDown(Keys.Left) && number> 0)
                 number = number - 1;
            if (ks.IsKeyDown(Keys.Right) && number<4)
                number = number + 1;
            if (ks.IsKeyDown(Keys.B) || ks.IsKeyDown(Keys.Escape))
            {
                number = 0;
                back= true;
                
            }
            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Gray);
            spriteBatch.Begin();
            spriteBatch.Draw(helpback, Vector2.Zero, Color.White);
            if (number == 0)
            {
                spriteBatch.DrawString(text, " Welcome to Help. Use Left & Right Arrow Keys to move",
new Vector2(300, 50), Color.Black, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
                  spriteBatch.DrawString(text, "Press Escape or B to move to Main menu",
new Vector2(350, 100), Color.Black, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
                  spriteBatch.Draw(helpback1, new Vector2(100, 150), Color.White);
                  spriteBatch.Draw(forward, new Vector2(1100, 50), Color.White);
        }
            else if (number == 1)
            {
                spriteBatch.Draw(keyidea, new Vector2(0, 0), Color.White);
                spriteBatch.Draw(backward, new Vector2(1030, 50), Color.White);
                spriteBatch.Draw(forward, new Vector2(1100, 50), Color.White);
            }
            else if (number == 2)
            {
                spriteBatch.Draw(rocknroll, new Vector2(0, 0), Color.White);
                spriteBatch.Draw(backward, new Vector2(1030, 50), Color.White);
                spriteBatch.Draw(forward, new Vector2(1100, 50), Color.White);
            }
            else if (number == 3)
            {
                spriteBatch.Draw(pushit, new Vector2(0, 0), Color.White);
                spriteBatch.Draw(backward, new Vector2(1030, 50), Color.White);
                spriteBatch.Draw(forward, new Vector2(1100, 50), Color.White);
            }
            else if (number == 4)
            {
                spriteBatch.Draw(controls, new Vector2(0, 0), Color.White);
                spriteBatch.Draw(backward, new Vector2(1030, 50), Color.White);
            }
            spriteBatch.End();
        }
    }
}