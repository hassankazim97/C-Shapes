using System;
public class Polyline
{
    public string fill { get; set; }
    public string stroke { get; set; }
    public int StrokeWidth { get; set; }

    public Polyline()
    {
        fill = "";
        stroke = "";
        StrokeWidth = 2; 
    }
    public Polyline(string fill, string stroke, int strokeWidth)
    {
        this.fill = fill;
        this.stroke = stroke;
        StrokeWidth = strokeWidth;
    }
    
    public string addPolyline (int counter, int point1x, int point1y, int point2x, int RY, string fill, string stroke, int StrokeWidth)
    {
        return "";
    }
}