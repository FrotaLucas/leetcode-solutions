using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Codibility
{
    // Exercise:
    // A string S receives commands to move forward, move backward,
    // turn right, and turn left. Develop a function that receives
    // a set of commands and determines whether these commands
    // will form a rectangle or not (true/false).
    // Rules: there are no diagonal movements.
    // I am assuming that the rectangle always starts at point (0,0)

    public class DrawRetangle
    {
        public bool Solve(string commands)
        {
            string[] s = commands.Split(' ');
            var points = new List<int[]>();

            if(s.Length < 4) 
                return false;

            //start point
            int x = 0;
            int y = 0;  
            points.Add([x, y]); 

            foreach(var command in s)
            {
                switch (command) {

                    case ("u"):
                        y++;
                        points.Add([x, y]);
                        break;

                    case ("d"):
                        y--;
                        points.Add([x, y]);
                        break;

                    case ("r"):
                        x++;
                        points.Add([x, y]); 
                        break;

                    case ("l"):
                        x--;
                        points.Add([x, y]);
                        break;

                }
            }

            //check final stop
            var finalPoint = points[points.Count - 1];
            if (finalPoint[0] != 0 && finalPoint[1] != 0)
                return false;


            //checking turns

            var turns = new List<int[]>();

            return true;
        }
    }
}
