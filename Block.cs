using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended;

class Block{
    Vector2 pos = Vector2.Zero, vel = Vector2.Zero;

    public void Update(float dt)
    {
        pos += vel;
    }

    public void Draw(SpriteBatch _spriteBatch)
    {
        _spriteBatch.DrawRectangle(pos.X, pos.Y, 30f, 30f, Color.Red, 10, 0);
    }
}