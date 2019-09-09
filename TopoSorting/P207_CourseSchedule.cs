
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.TopoSorting
{
    class P207_CourseSchedule
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            if (numCourses == 0 || prerequisites == null)
            {
                return true;
            }
            // 1.store graph into map<courseID, nextCourseList>
            // 2.record indegree
            var map = new Dictionary<int, List<int>>();
            var indegree = new int[numCourses];
            foreach (var pr in prerequisites)
            {
                var course = pr[0];
                var prerequisite = pr[1];
                if (map.ContainsKey(prerequisite))
                {
                    map[prerequisite].Add(course);
                }
                else
                {
                    var l = new List<int>();
                    l.Add(course);
                    map.Add(prerequisite, l);
                }
                indegree[course]++;
            }


            // 3.BFS  
            //      put indegree == 0 into queue
            //      nextCourseList indegree -1
            //      redo 3 until queue is empty
            var completedCoursesNum = 0;
            var queue = new Queue<int>();
            for (var i = 0; i < numCourses; i++)
            {
                if (indegree[i] == 0)
                {

                    queue.Enqueue(i);
                }
            }
            while (queue.Any())
            {
                var currCourse = queue.Dequeue();
                completedCoursesNum++;
                if (map.ContainsKey(currCourse))
                {
                    foreach (var next in map[currCourse])
                    {
                        indegree[next]--;
                        if (indegree[next] == 0)
                        {
                            queue.Enqueue(next);
                        }
                    }
                }
            }


            // 4.completedCourses == numCourses >> true        
            return (completedCoursesNum == numCourses);

        }
    }
}
