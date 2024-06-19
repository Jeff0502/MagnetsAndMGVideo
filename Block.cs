using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended;

class Block{
    Vector2 pos = new Vector2(40, 0), vel = new Vector2(20f, 0);

    public void Update(float dt)
    {
        pos += vel;

        if(pos.X >= 800 - 30)
            vel *= -1;
        else if (pos.X <= 0 + 30)
            vel *= -1;
    }

    public void Draw(SpriteBatch _spriteBatch)
    {
        _spriteBatch.DrawRectangle(pos.X, pos.Y, 30f, 30f, Color.Red, 10, 0);
    }
}