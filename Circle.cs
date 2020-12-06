using System;
public class Circle
{
    public int X { get; set; } // circle centre x-coordinate
    public int Y { get; set; } // circle centre y-coordinate
    public int R { get; set; } // circle radius
    


    public Circle()
    {
        X = 100;
        Y = 100;
        R = 100;
    }

    public Circle(int x, int y, int r)
    {
        X = x;
        Y = y;
        R = r;
    }

    public string addCircle (int counter, int x, int y, int r, string stroke,int width, string colour)
    {
        string dispSVG =
            String.Format(
                @"<circle id = ""{0}"" cx=""{1}"" cy=""{2}"" r=""{3}"" stroke=""{4}"" stroke-width=""{5}"" fill=""{6}""/>", counter, x, y,
                r, stroke, width, colour);
        counter++;
        return "".PadLeft(3, ' ') + dispSVG; 
    }

   
}