using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camra_game
{
    class Camera
    {
        //objeckts
        public Matrix transform;
        Viewport view;
        Vector2 center;
        //kamrans konstruktor
        public Camera(Viewport newView)
        {
            view = newView;
        }

        public void Update(GameTime gameTime, Game1 ship)
        {
            // ?? dont fully know
            center = new Vector2(ship.posistion.X + (ship.body.Width/2) - 400, 0);
            transform = Matrix.CreateScale(new Vector3(1, 1, 0)) * Matrix.CreateTranslation(-center.X, -center.Y,0);
        }

    }
}
