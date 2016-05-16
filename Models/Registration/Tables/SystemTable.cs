using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace Models.Registration.Tables
{
    [Table(Name = "Systems")]
    public class SystemTable
    {
        [Column(Name = "Id", IsPrimaryKey = true, IsDbGenerated = true, DbType = "int Not Null IDENTITY")]
        public int Id { get; set; }
        [Column(Name = "FirstId", DbType = "nvarchar(200) Not Null", CanBeNull = false)]
        public string FirstId { get; set; }
        [Column(Name = "SecondId", DbType = "nvarchar(200) Not Null", CanBeNull = false)]
        public string SecondId { get; set; }
        [Column(Name = "ThirdId", DbType = "nvarchar(200) Not Null", CanBeNull = false)]
        public string ThirdId { get; set; }
        [Column(Name = "User", DbType = "nvarchar(200) Not Null", CanBeNull = false)]
        public string User { get; set; }
        [Column(Name = "Anchor", DbType = "nvarchar(200) Not Null", CanBeNull = false)]
        public string Anchor { get; set; }
        [Column(Name = "Created")]
        public DateTime Created { get; set; }
    }
}
