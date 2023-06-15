using System.Diagnostics;

namespace ToObj // Note: actual namespace depends on the project name.
{
    internal static class Program
    {
        class ProcessData
        {
            public int Id { get; set; }

            public long Memory { get; set; }

            public string Name { get; set; }
        }

        static void DisplayProcesses(Func<Process, bool> match)
        {
            var processes = new List<ProcessData>();

            foreach (var process in Process.GetProcesses().Take(10))
            {
                if (match(process))
                {
                    processes.Add(new ProcessData()
                    {
                        Id = process.Id,
                        Name = process.ProcessName,
                        Memory = process.WorkingSet64
                    });
                }
            }

            Console.WriteLine($"Total memory: {processes.TotalMemory() / 1024 / 1024} MB");

            var top2Memory = processes
                .OrderByDescending(process => process.Memory)
                .Take(2)
                .Sum(process => process.Memory) / 1024 / 1024;
            Console.WriteLine($"Top 2 memory: {top2Memory} MB");

            var result = new
            {
                TotalMemory = processes.TotalMemory() / 1024 / 1024,
                Top2Memory = top2Memory,
                Processes = processes
            };

            Console.WriteLine(ObjectDumper.Dump(result));
        }
        
        static void Main(string[] args)
        {
            DisplayProcesses(process => process.WorkingSet64 >= 20 * 1024 * 1024);
        }

        static long TotalMemory(this IEnumerable<ProcessData> processes)
        {
            long result = 0;
            foreach (var process in processes)
            {
                result += process.Memory;
            }

            return result;
        }
    }
}