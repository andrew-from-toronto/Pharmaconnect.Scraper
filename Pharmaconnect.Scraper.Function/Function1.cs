using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;

namespace Pharmaconnect.Scraper.Function
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static void Run(
            [TimerTrigger("0 */30 * * * *", RunOnStartup = true)] TimerInfo myTimer,
            ILogger log
        )
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
