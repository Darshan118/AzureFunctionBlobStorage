using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace AzureFunctionAppBlobStorage
{
    public class blob
    {
        [FunctionName("blob")]
        public void Run([BlobTrigger("anchortransform/{name}", Connection = "BlobTrigger")]Stream myBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }
    }
}
