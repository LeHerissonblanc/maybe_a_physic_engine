using Raylib_cs;

public class Physics
{
    private readonly int screenWidth;
    private readonly int screenHeight;

    public Physics(int screenWidth, int screenHeight)
    {
        this.screenWidth = screenWidth;
        this.screenHeight = screenHeight;
    }

    public void Update(float dt)
    {
        
    }

    public void Draw(float dt, Color bgColor)
    {
        Raylib.BeginDrawing();

        Raylib.ClearBackground(bgColor);

        Raylib.EndDrawing();
    }
}
