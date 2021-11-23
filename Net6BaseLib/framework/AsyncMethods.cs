using System;
using System.Threading.Tasks;

namespace baseLib.framework;

public class AsyncMethods
{
    public async Task RunAsyncMethod()
    {
        _ = longTask1(1, 200);
        _ = longTask2();
        _ = longTask1(3, 300);
        await Task.Delay(200);
    }

    private async Task longTask1(int taskNumber, int time)
    {
        await Task.Delay(time);
        Console.WriteLine($"long task {taskNumber}");
        Console.WriteLine($"long task {taskNumber}");
        Console.WriteLine($"long task {taskNumber}");
        Console.WriteLine($"long task {taskNumber}");
    }

    private async Task longTask2()
    {
        await Task.Delay(400);
        Console.WriteLine("long task 2");
    }

}
