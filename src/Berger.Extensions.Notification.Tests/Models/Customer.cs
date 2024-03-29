﻿using System;
using System.Collections.Generic;

namespace Berger.Extensions.Notification.Tests.Models
{
    public class Customer
    {
        #region Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Active { get; set; }
        public object AnyObject { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public int? Dependents { get; set; }
        public IList<Customer> CustomersIList { get; set; }
        public IEnumerable<Customer> CustomersIEnumerable { get; set; }
        public ICollection<Customer> CustomersICollection { get; set; }
        public Gender Gender { get; set; }
        #endregion
    }
    public enum Gender
    {
        Male = 1,
        Female = 2
    }
}