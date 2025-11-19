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

            //add first turn point
            turns.Add(points[0]);
            for (int i = 0; i < points.Count -2; i++) 
            {
                var point1 = points[i]; 
                var point2 = points[i + 1];
                var point3 = points[i + 2]; 

                var dx1 = point2[0] - point1[0];
                var dx2 = point3[0] - point2[0];

                var dy1 = point2[1] - point1[1];
                var dy2 = point3[1] - point2[1];


                //turn up & down 
                if (dx1 == 0 && dy2 != 0)
                    turns.Add(point2);

                //turn left & right
                if (dy1 == 0 && dx2 != 0)
                    turns.Add(point2);
            }
            

            //checking total vertices
            if( turns.Count !=4)
                return false;

            //check height and width
            int width1 = Math.Abs(turns[1][0] - turns[0][0]);
            int width2 = Math.Abs(turns[3][0] - turns[2][0]);

            int height1 = Math.Abs(turns[1][1] - turns[0][1]);
            int height2 = Math.Abs(turns[3][1] - turns[2][1]);

            if (width1 != width2 || height1 != height2)
                return false;

            return true;
        }
    }
}
