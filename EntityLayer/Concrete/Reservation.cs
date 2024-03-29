﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ReservationDto
    {
        public int ReservationId { get; set; }
        public int AppUserId { get; set; }
        public string RoomCount { get; set; }
        public string ChildrenCount { get; set; }
        public string AdultCount { get; set; }
        public int DestinationId { get; set; }
        public DestinationDto Destination { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Details { get; set; }
        public bool Status { get; set; }
    }
}
