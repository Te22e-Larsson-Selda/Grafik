using System.Numerics;
using Raylib_cs;

Raylib.InitWindow(800 ,600 ,"Hello");
Raylib.SetTargetFPS(75);

int x = 200;
int floorY= 550;
int floorSpeedY = -1;
Vector2 position = new Vector2(0, 0);
Vector2 movment = new Vector2(2,1);

Color hotPink = new Color(255, 105, 180,255);

Texture2D characterImage = Raylib.LoadTexture("");

Rectangle characterRect = new Rectangle(10,10,32,32);

while (!Raylib.WindowShouldClose())
{
    characterRect.x += movment.X;
    characterRect.y += movment.Y;

    x++;
    floorY += floorSpeedY;
    if(floorSpeedY < 0){
        floorSpeedY = 1;
    }
    else if(floorY > 550){
        floorSpeedY = -1;
    }
    
    position += movment;
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.GREEN);
    Raylib.DrawRectangleRec(characterRect, Color.RAYWHITE);

    //Raylib.DrawCircle(x, 300, 10, Color.DARKGREEN);
    //Raylib.DrawCircleV(position, 20, hotPink);

    Raylib.DrawRectangle(0, 550, 800, 30, Color.DARKGREEN);

    Raylib.DrawTexture(characterImage,(int) characterRect.x, (int) characterRect.y, Color.DARKBLUE);

    Raylib.EndDrawing();
}