using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TopoSorting
{
    class P210_Course_ScheduleII
    {
        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            var result = new int[numCourses];
            if (prerequisites == null)
            {
                return result;
            }

            // put graph into map< node , indegree >
            var map = new Dictionary<int, List<int>>();
            int[] indegree = new int[numCourses];
            foreach (var item in prerequisites)
            {
                var course = item[0];
                var prerequiest = item[1];
                if (map.ContainsKey(prerequiest))
                {
                    map[prerequiest].Add(course);
                }
                else
                {
                    var list = new List<int>();
                    list.Add(course);
                    map.Add(prerequiest, list);
                }
                indegree[course] += 1;
            }

            // add indegree = 0 into q
            var queue = new Queue<int>();
            for (int i = 0; i < numCourses; i++)
            {
                if (indegree[i] == 0)
                {
                    queue.Enqueue(i);
                }
            }

            var index = 0;
            while (queue.Any())
            {
                var node = queue.Dequeue();
                result[index++] = node;

                if (map.ContainsKey(node))
                {
                    foreach (var n in map[node])
                    {
                        indegree[n]--;
                        if (indegree[n] == 0)
                        {
                            queue.Enqueue(n);
                        }
                    }
                }
            }

            if (index == numCourses)
            {
                return result;
            }

            return new int[0];
        }
    }
}
