using System;
using System.Collections.Generic;
using System.Text;

namespace SFSU_VeteranServices_Tracker.Model
{
    class StudentCheckIn
    {
        public string FullName { get; set; }
        public int StudentId { get; set; }
        public string Status { get; set; }
        public DateTime CheckInTime { get; set; }
    }
}
