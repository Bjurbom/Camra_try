using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Camra_game
{
    class Player
    {

        Texture2D texture;
        Vector2 posistion, velocity;
        Rectangle body;

        //Spelarens Konstuktor
        public Player(Texture2D texture, Vector2 posistion, Rectangle body)
        {
            // Sätter värderna i spelaren
            this.texture = texture;
            this.posistion = posistion;


        }

        //Spelarens Update
        public void Update()
        {
            //Rörelse
            //LEFT
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                velocity.X--;
            }
            //RIGHT
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                velocity.X++;
            }
            //UP
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                velocity.Y--;
            }
            //DOWN
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                velocity.Y++;
            }

            posistion += velocity;

            body.Location = posistion.ToPoint();

            velocity *= (float)0.95;
        }
        //Spelarens Draw
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, body, Color.White);
        }
    }
}
