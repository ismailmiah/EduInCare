﻿using System;
using DataAccessLayer;

namespace Foundation.Library.Entities
{
    public class JobInfo : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public Guid DesignationId { get; set; }
        public Designation Designation { get; set; }
        public DateTime JoiningDate { get; set; }
        public decimal Salary { get; set; }
        public int TotalLeave { get; set; }
        public AppointmentImage Appointment { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}