using System;
public class Line
{
    
    public int X1 { get; set; } 
    public int Y1 { get; set; } 
    public int X2 { get; set; } 
    public int Y2 { get; set; }
    public string stroke { get; set; }
    public int StrokeWidth { get; set; }

    public Line()
    {
        X1 = 100;
        Y1 = 200;
        X2 = 5;
        Y2 = 5;
        stroke = "";
        StrokeWidth = 2; 
    }
public Line(int x1, int y1, int x2, int y2, string stroke, int strokeWidth)
    {
        X1 = x1;
        Y1 = y1;
        X2 = x2;
        Y2 = y2;
        this.stroke = stroke;
        StrokeWidth = strokeWidth;
    }
    
public string addLine (int counter, int X1, int Y1, int X2, int Y2, string stroke, int StrokeWidth)
{
    string dispSVG =
        String.Format(
            @"<line id = ""{0}"" x1=""{1}"" y1=""{2}"" x2=""{3}"" y2 = ""{4}"" stroke=""{5}"" stroke-width=""{6}""/>", counter, X1, Y1,
            X2, Y2, stroke, StrokeWidth);
    counter++;
    return "".PadLeft(3, ' ') + dispSVG; 
}


}