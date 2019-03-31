using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    class P134_GasStations
    {

        // Brute Force   5.36%  13.33% 
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            var tank = 0;
            for (var i = 0; i < gas.Count(); i++)
            {

                if (gas[i] < cost[i]) continue;
                else
                {
                    tank = 0;
                    for (var j = 0; j < gas.Count(); j++)
                    {
                        tank += gas[(i + j) % gas.Count()] - cost[(i + j) % gas.Count()];
                        if (tank < 0) { tank = -1; break; }
                    }
                    if (tank >= 0) return i;
                }
            }
            return -1;
        }


        // one time pass    77.38%    13.33%
        public int CanCompleteCircuit2(int[] gas, int[] cost)
        {
            var totalTank = 0;
            var curTank = 0;
            var startStation = 0;
            for (var i = 0; i < gas.Count(); i++)
            {
                totalTank += gas[i] - cost[i];
                curTank += gas[i] - cost[i];
                if (curTank < 0)
                {
                    startStation = i + 1;
                    curTank = 0;
                }
            }
            return totalTank >= 0 ? startStation : -1;
        }
    }
}
