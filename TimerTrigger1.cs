using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class TimerTrigger1
    {
        [FunctionName("TimerTrigger1")]
        public void Run([TimerTrigger("* * * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"Test5 C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
