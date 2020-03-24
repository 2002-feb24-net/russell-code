using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EfDemo
{
    public class Address
    {
        // regular simple properties like these are always loaded by EF
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // this attr tells SQL Server to let US decide the ID in C#.
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
