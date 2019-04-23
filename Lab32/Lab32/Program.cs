using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;

namespace Lab32
{
    class Program
    {
        static void Main(string[] args)
        {
            string fetchXml = 
            @"<fetch mapping='logical'>
                <entity name='contact'>
                <attribute name='fullname'/>
                <filter type='and'>
                    <condition attribute='jobtitle' operator='eq' value='Purchasing Assistant'/>
                </filter>
                </entity>
            </fetch>";

 
            EntityCollection contactlist = Service.Service.GetOrganization().RetrieveMultiple(new FetchExpression(fetchXml));
            foreach (var cnt in contactlist.Entities)
            {
                Console.WriteLine(cnt.Attributes["fullname"].ToString());
            }

            Console.Read();
        }
    }
}
