using Algorithms.Greedy;

Console.WriteLine("----------------------Cashiers Problem---------------------");
Cashiers CashiersProblem = new Cashiers();

int[] Coins = new int[] { 1, 5, 10, 25, 50, 100 };
int nCoins = 77;

List<int> Solution = CashiersProblem.MakeChange(nCoins, Coins);
Console.WriteLine("Quantidade de moedas: " + Solution.Count);
foreach (int c in Solution)
{
    Console.WriteLine("Moeda selecionadas: " + c);
}


Console.WriteLine("----------------------Scheduler Problem---------------------");

Scheduler Scheduler = new Scheduler();

List<Request> Requests = new List<Request>
{
    new Request(0, 2,"R1"),
    new Request(0, 3, "R2"),
    new Request(2, 5, "R3"),
    new Request(4, 6, "R4"),
    new Request(7, 9, "R5"),
    new Request(0, 10, "R6"),
    new Request(8, 11, "R7"),
    new Request(13, 14, "R8"),
    new Request(12, 15, "R9"),
};

int nResquests = Requests.Count;
List<Request> ScheduledIntervals = Scheduler.ScheduleTask(nResquests, Requests);

Console.WriteLine("Quantidade de Requests atendidas: " + ScheduledIntervals.Count);
foreach (var interval in ScheduledIntervals)
{
    Console.WriteLine($"Process: {interval.ProcessName}, Start: {interval.Start}, End: {interval.End}");
}