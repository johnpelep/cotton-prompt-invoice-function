using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace CottonPrompt.Invoice.Function
{
    public class InvoiceFunction
    {
        [FunctionName("InvoiceFunction")]
        public void Run([TimerTrigger("0 0 * * 1")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
