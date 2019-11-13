using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLSLQueueingApp
{
    class ServiceClass
    {
        public int queue_no { get; set; }
        public int cashier_number { get; set; }
        public String student_number { get; set; }
        public String type_of_queue { get; set; }
        public String queueing_status { get; set; }
        public String service_lane { get; set; }
        public String date_column { get; set; }
        public String time_column { get; set; }
    }
}
