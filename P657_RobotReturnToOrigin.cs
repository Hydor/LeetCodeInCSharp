using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class P657_RobotReturnToOrigin
    {

    //There is a robot starting at position(0, 0), the origin, on a 2D plane.Given a sequence of its moves, 
    //judge if this robot ends up at(0, 0) after it completes its moves.

    //The move sequence is represented by a string, and the character moves[i] represents its ith move.Valid moves 
    //are R (right), L (left), U (up), and D (down). If the robot returns to the origin after it finishes all 
    //of its moves, return true. Otherwise, return false.


    //Note: The way that the robot is "facing" is irrelevant. "R" will always make the robot move to the right once, 
    //"L" will always make it move left, etc.Also, assume that the magnitude of the robot's movement is the same for each move.


    //Example 1:
    //Input: "UD"
    //Output: true 


        public static bool JudgeCircle(string moves)
        {
            var steps = System.Text.Encoding.UTF8.GetBytes(moves);
            var u = 0;
            var d = 0;
            var l = 0;
            var r = 0;

            foreach (var i in steps)
            {
                switch (i)
                {
                    case 85: u++; break;
                    case 82: r++; break;
                    case 68: d++; break;
                    case 76: l++; break;
                    default: break;
                }             
            }
            
            return u == d && l == r;
        }
    }
}
