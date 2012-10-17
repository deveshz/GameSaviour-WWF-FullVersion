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
    public class TitleMenu : Microsoft.Xna.Framework.DrawableGameComponent
    {
        SpriteBatch spriteBatch;
        //------------------Zephyr-------
        Texture2D zephyr;
        Texture2D underline;
        Texture2D presents;
        Texture2D background;

        int mAlphaValue = 1;
        int mFadeIncrement = 20;
        double mFadeDelay = .35;
        public bool g1state = false;
        //-------------------------------
        Texture2D saviourback;
        byte redIntensity = 0;
        bool redCountingUp = true;
        byte greenIntensity = 0;
        bool greenCountingUp = true;
        byte blueIntensity = 0;
        bool blueCountingUp = true;

        public TitleMenu(Game game)
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

            zephyr =   Game.Content.Load<Texture2D>(@"Images\zephyr");
            underline = Game.Content.Load<Texture2D>(@"Images\underline");
            presents = Game.Content.Load<Texture2D>(@"Images\presents");
            saviourback = Game.Content.Load<Texture2D>(@"Images\saviourback");
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
            
            if (redIntensity == 255) redCountingUp = false;
            if (redIntensity == 0) redCountingUp = true;
            if (redCountingUp) redIntensity +=5; else redIntensity-=5;
            if (greenIntensity == 255) greenCountingUp = false;
            if (greenIntensity == 0) greenCountingUp = true;
            if (greenCountingUp) greenIntensity +=5; else greenIntensity -= 5;
            if (blueIntensity == 255) blueCountingUp = false;
            if (blueIntensity == 0) blueCountingUp = true;
            if (blueCountingUp) blueIntensity += 5; else blueIntensity -= 5;
            mFadeDelay -= gameTime.ElapsedGameTime.TotalSeconds;
            if (mFadeDelay <= 0)
            {
               
                mFadeDelay = .035;

                mAlphaValue += mFadeIncrement;

                if (mAlphaValue >= 255)
                {
                    mFadeIncrement *= -1;
                }
               
            }

            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.MidnightBlue);
            spriteBatch.Begin();
            spriteBatch.Draw(background, new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height), Color.White);
            spriteBatch.Draw(zephyr, new Rectangle(100, 40, zephyr.Width, zephyr.Height),
        new Color(255, 255, 255, (byte)MathHelper.Clamp(mAlphaValue, 0, 255)));
            if (mAlphaValue >= 80)
            {
                spriteBatch.Draw(underline, new Rectangle(120, 220, underline.Width, underline.Height),
                   new Color(255, 255, 255, (byte)MathHelper.Clamp(mAlphaValue, 0, 255)));
            }

            if (mAlphaValue >= 100)
            {
                spriteBatch.Draw(presents, new Rectangle(270, 240, presents.Width, presents.Height),
               new Color(255, 255, 255, (byte)MathHelper.Clamp(mAlphaValue, 0, 255)));
            }
            if (mAlphaValue < 0)
                spriteBatch.Draw(saviourback, new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height), new Color(redIntensity, greenIntensity, blueIntensity));
            if (redIntensity == 255 && blueIntensity == 255 && greenIntensity == 255)
            {
                g1state = true;
            }
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}