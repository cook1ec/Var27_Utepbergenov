using System;

class Rectangle
{
    public float height;
    public float width;

    public void Show()
    {
        Console.WriteLine($"Прямоугольник: высота = {height}, ширина = {width}");
    }

    public float Perimetr()
    {
        return 2 * height + 2 * width;
    }
}

class Program
{
    static void Main()
    {
        Rectangle rect = new Rectangle();
        rect.height = 2;
        rect.width = 3;

        rect.Show();
        Console.WriteLine($"Периметр = {rect.Perimetr()}");
        Console.ReadKey();
    }
}