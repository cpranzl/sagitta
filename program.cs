using System;

namespace sagitta
{
    class program
    {
        static void Main(string[] args)
        {
            double radius = 0;
            double chord = 0;
            int steps = 1;

            // Parse commandline-parameter
            for(int i = 0; i < args.Length; i++)
            {
                switch (args[i])
                {
                    case "--radius":
                    {
                        if(double.TryParse(args[i+1], out radius)){}
                        else
                        {
                            Console.WriteLine("ERROR 01: Argument of parameter --radius has to be a number!");
                        }// if(double.TryParse(args[i+1], out radius))
                    }// case "--radius":
                    break;
                    case "--chord":
                    {
                        if(double.TryParse(args[i+1], out chord)){}
                        else
                        {
                            Console.WriteLine("ERROR 02: Argument of parameter --chord has to be a number!");
                        }// if(double.TryParse(args[i+1], out chord))
                    }//  case "--chord":
                    break;
                    case "--steps":
                    {
                        if(int.TryParse(args[i+1], out steps)){}
                        else
                        {
                            Console.WriteLine("ERROR 03: Argument of parameter --steps has to be a number!");
                        }// if(double.TryParse(args[i+1], out steps))
                    }// case "--steps"
                    break;
                    default:
                        break;
                }// switch
            }// for(int i = 0; i < args.Length; i++)

            // Calculate Sagitta for n steps
            if(radius > 0 && chord > 0)
            {
                // Calculate angle in radians
                double alpha = 2 * Math.Asin(chord / (2 * radius));
                for(int i = 1; i <= steps; i++)
                {
                    // Calculate sagitta
                    double sagitta = radius * (1 - Math.Cos(alpha / 2));
                    Console.WriteLine("Step {0}: {1} cm", i, Math.Round(sagitta, 4).ToString());
                    // Bisect angle
                    alpha = alpha / 2;
                }// for(int i = 1; i <= steps; i++)
            }// if(radius > 0 && chord > 0)
            else
            {
                Console.WriteLine("ERROR 04: Radius and chord have to be greater than zero!");
            }// if(radius > 0 && chord > 0)
        }// Main()
    }// class Program
}// namespace segment

