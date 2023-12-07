using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitBazzar1.Model
{
    public class Notifications
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageSource { get; set; }
        public DateTime? NotificationDateTime { get; set; } 
    }
}
