using System;
using Datory;
using Datory.Annotations;


namespace SSCMS.Abstractions
{
    [DataTable("siteserver_ErrorLog")]
    public class ErrorLog : Entity
    {
        [DataColumn]
        public string Category { get; set; }

        [DataColumn]
        public string PluginId { get; set; }

        [DataColumn]
        public string Message { get; set; }

        [DataColumn(Text = true)]
        public string StackTrace { get; set; }

        [DataColumn(Text = true)]
        public string Summary { get; set; }
    }
}
