using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Greedy
{
    public class Request
    {
        public int Start { get; set; }
        public int End { get; set; }
        public string ProcessName { get; set; } = "";

        public Request(int start, int end, string processName)
        {
            this.Start = start;
            this.End = end;
            this.ProcessName = processName;
        }
    }
    public class Scheduler
    {

        public Scheduler() { }

        public List<Request> ScheduleTask(int n, List<Request> intervals)
        {
            List<Request> solution = new List<Request>();
            //Ordenando a lista de processos pelo valor de termino (quem termina antes fica primeiro)
            intervals.Sort((a, b) => a.End.CompareTo(b.End));

            int currentEndTime = 0;
            //Para cada processo na lista já ordenada
            for (int i = 0; i < n; i++)
            {
                //Pulando processos conflitantes com os já existente no conjunto solução
                if (intervals[i].Start >= currentEndTime)
                {
                    solution.Add(intervals[i]);
                    currentEndTime = intervals[i].End;
                }
            }
            return solution;
        }

    }
}