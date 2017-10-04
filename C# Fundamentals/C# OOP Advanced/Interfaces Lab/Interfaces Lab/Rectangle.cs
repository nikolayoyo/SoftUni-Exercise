using System.Text;

public class Rectangle : IDrawable
{
    private int a;

    private int b;

    public Rectangle(int a , int b)
    {
        this.a = a;
        this.b = b;
    }

    public void Draw()
    {
        this.DrawLine(this.b, '*', '*');
        for (int i = 0; i <this.a-1; i++)
        {
            this.DrawLine(this.b, '*', ' ');
        }

        this.DrawLine(this.b, '*', '*');
    }

    private void DrawLine(int width, char end, char mid)
    {
        System.Console.Write(end);
        for (int i = 0; i < width-1; i++)
        {
            System.Console.Write(mid);
        }

        System.Console.WriteLine(end);
    }
}