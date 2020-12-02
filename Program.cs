using System;
using System.IO;
using System.Collections;

namespace MyShapes
{
    class Program
    {

        static void Main(string[] args)
        {
            Circle c = new Circle();
            Rectangle rr = new Rectangle();
            Ellipse e = new Ellipse();
            Line l = new Line();
            bool stop = false;
            int count = 0;
            String path = "C:/Users/jaffe/Desktop/MyShapes/sample.svg";   
            Stack mainStack = new Stack(); //using Stacks to store strings for SVG
            Stack outStack = new Stack();
            Stack undoStack = new Stack();
                //using (StreamWriter sw = File.CreateText(path))
                    while(!stop) //While program is running
                    {
                        Console.WriteLine("Please type 'start' to Begin Program");
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("Type 'H' for further instructions");
                        Console.WriteLine("--------------------------");
                        string a = Console.ReadLine(); //What User will enter
                        Console.WriteLine("--------------------------");

                        if (a == "start") //sets beginning of SVG
                        {
                            //myStack.Push("</svg>");
                            mainStack.Push(String.Format(@"<svg height=""400"" width=""400"" xmlns=""http://www.w3.org/2000/svg"">"));
                            //sw.WriteLine(String.Format(@"<svg height=""400"" width=""400"" xmlns=""http://www.w3.org/2000/svg"">"));
                            Console.WriteLine("Program has started!");
                            Console.WriteLine("--------------------------");
                        }
                        else if (a == "A circle") //Creating Circle
                        {
                                Console.WriteLine("Enter Circle x =");
                                var x = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Circle y =");
                                var y = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Circle radius =");
                                var r = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Circle stroke colour =");
                                var stroke = Console.ReadLine();
                                Console.WriteLine("Enter Circle stroke width =");
                                var width = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Circle colour =");
                                var colour = Console.ReadLine();
                                mainStack.Push(c.addCircle(count, x, y, r,stroke, width, colour));
                                //sw.WriteLine(c.addCircle(count, x, y, r,stroke, width, colour));
                                count++;
                                Console.WriteLine("--------------------------");
                                Console.WriteLine("Circle (R="+r+",X="+x+",Y="+y+") added to canvas");
                                Console.WriteLine("--------------------------");
                        }
                        else if (a == "A square") //Creating Square
                        {
                                Console.WriteLine("Enter square Length =");
                                var height = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Enter square Width =");
                                var width = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Enter square rx =");
                                var rx = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Enter square ry = ");
                                var ry = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("square fill = ");
                                var colour = Console.ReadLine();
                                Console.WriteLine("square stroke = ");
                                var stroke = Console.ReadLine();
                                Console.WriteLine("square stroke-width = ");
                                var strokeWidth = Int32.Parse(Console.ReadLine());
                                mainStack.Push(rr.addRectangle(count, height, width, rx, ry, colour, stroke, strokeWidth));
                                count++;
                                Console.WriteLine("--------------------------");
                                Console.WriteLine("Square (L="+height+",X="+rx+",Y="+ry+") added to canvas");
                                Console.WriteLine("--------------------------");
                        }
                        else if (a == "A ellipse")
                        {
                            Console.WriteLine("Ellipse  cx=");
                                var cx = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Ellipse  cy=");
                                var cy = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Ellipse rx =");
                                var rx = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Ellipse ry = ");
                                var ry = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Ellipse fill = ");
                                var colour = Console.ReadLine();
                                Console.WriteLine("Ellipse stroke = ");
                                var stroke = Console.ReadLine();
                                Console.WriteLine("Ellipse stroke-width = ");
                                var strokeWidth = Int32.Parse(Console.ReadLine());
                                mainStack.Push(e.addEllipse(count, cx, cy, rx, ry, colour, stroke, strokeWidth));
                                count++;
                                Console.WriteLine("Ellipse added");
                                Console.WriteLine("--------------------------");
                        }
                        else if (a == "A line")
                        {
                            
                                Console.WriteLine("Line  x1=");
                                var x1 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Line  y1=");
                                var y1 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Line x2 =");
                                var x2 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Line y2 = ");
                                var y2 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Line stroke = ");
                                var stroke = Console.ReadLine();
                                Console.WriteLine("Line stroke-width = ");
                                var strokeWidth = Int32.Parse(Console.ReadLine());
                                mainStack.Push(l.addLine(count, x1, y1, x2, y2, stroke, strokeWidth));
                                count++;
                                Console.WriteLine("Line added");
                                Console.WriteLine("--------------------------");
                        }
                        else if(a=="H") //User Interface
                        {
                            Console.WriteLine("H            Help");
                            Console.WriteLine("A <shape>    Add <shape> to canvas");
                            Console.WriteLine("U            Undo last operation");
                            Console.WriteLine("R            Redo last operation");
                            Console.WriteLine("C            clear canvas");
                            Console.WriteLine("Q            Quit application");
                        }
                        else if(a=="R") //Redo Function
                        {
                            mainStack.Push(undoStack.Pop());
                            Console.WriteLine("Redo Function complete");
                        }
                        else if(a=="U")
                        {
                            undoStack.Push(mainStack.Pop());
                            Console.WriteLine("Undo Function Complete");
                        }
                        else if (a == "Q")
                        {
                            //myStack.Push(String.Format(@"<svg height=""400"" width=""400"" xmlns=""http://www.w3.org/2000/svg"">"));
                            mainStack.Push("</svg>");
                            //sw.WriteLine("</svg>");
                            Console.WriteLine("File has been created");
                            Console.WriteLine("Goodbye!");
                            stop = true;
                            //break;
                        }
                        else if(a=="C") //Clears Canvas by emptying stack and re-writing the First Line of SVG
                        {
                            while(mainStack.Count!=0)
                            {
                            mainStack.Pop();
                            }
                            mainStack.Push(String.Format(@"<svg height=""400"" width=""400"" xmlns=""http://www.w3.org/2000/svg"">"));
                            Console.WriteLine("Canvas has been cleared");
                        }
                        else
                        {
                            Console.WriteLine("Not an input. try again");
                        }

                    }
                    while(mainStack.Count != 0)
                    {
                        outStack.Push(mainStack.Pop());
                    }
                        using(StreamWriter sw = File.CreateText(path))
                            {
                                while(outStack.Count != 0)
                            {
                                sw.WriteLine("{0}", outStack.Pop());
                            }
                            }
            
            
        }
        }
    }