using System.Globalization;
using Quartz;

namespace QuartzTest.API.Jobs;

public class MyJob : IJob
{
    public Task Execute(IJobExecutionContext context)
    {
        System.Console.WriteLine($"MyJob is executing! - {DateTime.Now.ToLongTimeString()} {CultureInfo.CurrentCulture}");
        return Task.CompletedTask;
    }
}