﻿using System;
using DataAccessLayer;

namespace Foundation.Library.Entities
{
    public class Employee : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentificationNo { get; set; }
        public string Gender { get; set; }
        public string MobileNo { get; set; }
        public DateTime JoinOfDate { get; set; }
        public string Nationality { get; set; }
        public Address Address { get; set; }
        public Department Department { get; set; }
        public EmployeeImage Image { get; set; }
    }
}