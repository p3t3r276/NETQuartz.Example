using System.Globalization;
using Quartz;

namespace QuartzTest.API.Jobs;

public class MyJob : IJob
{
    public Task Execute(IJobExecutionContext context)
    {
        var link = context.MergedJobDataMap.GetString("verificationLink");

        Console.WriteLine($"Job executed at {DateTime.Now} {CultureInfo.CurrentCulture} - Next run: {context.Trigger.GetNextFireTimeUtc()}, data: {link}");
        return Task.CompletedTask;
    }
}
