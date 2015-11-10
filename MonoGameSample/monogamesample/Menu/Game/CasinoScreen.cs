using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics; 

using MenuSystem;
using MenuSystem.Screens; 

namespace Casino.Menu.Game
{
    public class CasinoScreen : MenuScreen
    {
        private Texture2D background; 

        public CasinoScreen() : base("")
        {

        }

        public override void LoadContent()
        {
            ContentManager Content = ScreenManager.Game.Content;

            background = Content.Load<Texture2D>("Casino/background"); 

            base.LoadContent();
        }

        public override void Draw(GameTime gameTime)
        {
            ScreenManager.SpriteBatch.Begin(SpriteSortMode.Immediate, null, null, null, null, null, ScreenManager.Scale);

            ScreenManager.SpriteBatch.Draw(background, Vector2.Zero, Color.White);

            ScreenManager.SpriteBatch.End(); 

            base.Draw(gameTime);
        }
    }
}
