using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Models
{
    public class NewManagmentEvent
    {
        public int Id { get; set; }
        public int NewEventId { get; set; }
        public virtual NewEvent NewEvent { get; set; }
        public int NewManagmentBoardId { get; set; }
        public  virtual NewManagmentBoard NewManagmentBoard { get; set; }

    }
}
