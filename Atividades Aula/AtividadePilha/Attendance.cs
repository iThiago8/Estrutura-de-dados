﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePilha
{
    internal class Attendance
    {
        public int Id { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? Doctor { get; set; }
    }
}
