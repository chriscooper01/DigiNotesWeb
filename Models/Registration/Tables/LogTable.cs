using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Registration.Tables
{
    [Table(Name = "Logs")]
    public class LogTable
    {
        [Column(Name = "Id", IsPrimaryKey = true, IsDbGenerated = true, DbType = "int Not Null IDENTITY")]
        public int Id { get; set; }
        [Column(Name = "RegistrationId")]
        public int RegistrationId { get; set; }
        [Column(Name = "Status", DbType = "ntext Not Null", CanBeNull = false, UpdateCheck = UpdateCheck.Never)]
        public string Status { get; set; }
        [Column(Name = "Created")]
        public DateTime Created { get; set; }
    }
}
