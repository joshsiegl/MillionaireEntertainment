using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MenuSystem;
using MenuSystem.Screens;

using MonoGameSample.MillionaireEntertainment; 

namespace MonoGameSample
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        ScreenManager manager; 

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            manager = new ScreenManager(this, 1600, 960);
            //manager.AddScreen(new SplashScreen(new SplashScreen()), PlayerIndex.One);
            Components.Add(manager); 

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            MillionaireEntertainment.User.SetCoins();
            MillionaireEntertainment.User.SetLevel();
            MillionaireEntertainment.User.SetSpinsRemaining();

            MillionaireEntertainment.User.FBClicked = IO.LoadFBClicked();
            MillionaireEntertainment.User.RateClicked = IO.LoadRateClicked(); 

            base.LoadContent();
        }

        protected override void UnloadContent()
        {
            base.UnloadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            base.Draw(gameTime);
        }
    }
}