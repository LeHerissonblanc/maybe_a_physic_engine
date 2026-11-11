using Raylib_cs;
using System.Numerics;

public class Physics
{
    private readonly int screenWidth;
    private readonly int screenHeight;
    public Vector2 positionJoueur = new(400, 300);
    public Vector2 positionSouris;

    public Physics(int screenWidth, int screenHeight)
    {
        this.screenWidth = screenWidth;
        this.screenHeight = screenHeight;
    }

    public void Update(float dt)
    {
        positionSouris = Raylib.GetMousePosition();
    }

    public void Draw(float dt, Color bgColor)
    {
        Raylib.BeginDrawing();

        Raylib.ClearBackground(bgColor);

        Raylib.DrawLineV(positionJoueur, positionSouris, Color.Black);

        Raylib.EndDrawing();
    }
}
