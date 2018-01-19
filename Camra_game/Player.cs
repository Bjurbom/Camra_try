using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Camra_game
{
    class Player
    {

        Texture2D texture;
        Vector2 posistion;

        //Spelarens Konstuktor
        public Player(Texture2D texture, Vector2 posistion)
        {
            // Sätter värderna i spelaren
            this.texture = texture;
            this.posistion = posistion;

        }

        //Spelarens Update
        public void Update()
        {

        }
        //Spelarens Draw
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, posistion, Color.White);
        }
    }
}
