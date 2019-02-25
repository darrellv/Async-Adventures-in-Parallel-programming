using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDev_ClientTemplate
{
    public class ReportProgressModel
    {
        public int PercentComplete { get; set; }
        public List<SubmitResult> AppsProcessed { get; set; } = new List<SubmitResult>();

    }
}
