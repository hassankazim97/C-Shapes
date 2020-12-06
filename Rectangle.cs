using System;
public class Rectangle
{
    
    public int Height { get; set; } 
    public int Width { get; set; } 
    public int RX { get; set; } 
    public int RY { get; set; }
    public string fill { get; set; }
    public string stroke { get; set; }
    public int StrokeWidth { get; set; }

    public Rectangle()
    {
        Height = 100;
        Width = 200;
        RX = 5;
        RY = 5;
        fill = "";
        stroke = "";
        StrokeWidth = 2; 
    }
public Rectangle(int height, int width, int rx, int ry, string fill, string stroke, int strokeWidth)
    {
        Height = height;
        Width = width;
        RX = rx;
        RY = ry;
        this.fill = fill;
        this.stroke = stroke;
        StrokeWidth = strokeWidth;
    }
    
public string addRectangle (int counter, int Height, int Width, int RX, int RY, string fill, string stroke, int StrokeWidth)
{
    string dispSVG =
        String.Format(
            @"<rect id = ""{0}"" width=""{1}"" height=""{2}"" rx=""{3}"" ry = ""{4}"" fill=""{5}"" stroke=""{6}"" stroke-width=""{7}""  />", counter, Height, Width,
            RX, RY, fill, stroke, StrokeWidth);
    counter++;
    return "".PadLeft(3, ' ') + dispSVG; 
}


}