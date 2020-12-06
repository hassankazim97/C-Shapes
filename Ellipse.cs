using System;
public class Ellipse
{
    public int CX { get; set; } 
    public int CY { get; set; }
    public int RX { get; set; } 
    public int RY { get; set; }
    public string fill { get; set; }
    public string stroke { get; set; }
    public int StrokeWidth { get; set; }

    public Ellipse()
    {
        CX = 100;
        CY = 200;
        RX = 5;
        RY = 5;
        fill = "";
        stroke = "";
        StrokeWidth = 2; 
    }
public Ellipse(int cx, int cy, int rx, int ry, string fill, string stroke, int strokeWidth)
    {
        CX = cx;
        CY = cy;
        RX = rx;
        RY = ry;
        this.fill = fill;
        this.stroke = stroke;
        StrokeWidth = strokeWidth;
    }
    
public string addEllipse (int counter, int CX, int CY, int RX, int RY, string fill, string stroke, int StrokeWidth)
{
    string dispSVG =
        String.Format(
            @"<ellipse id = ""{0}"" cx=""{1}"" cy=""{2}"" rx=""{3}"" ry=""{4}"" fill=""{5}"" stroke=""{6}"" stroke-width=""{7}""/>", counter, CX, CY,
            RX, RY, fill, stroke, StrokeWidth);
    counter++;
    return "".PadLeft(3, ' ') + dispSVG; 
}



}