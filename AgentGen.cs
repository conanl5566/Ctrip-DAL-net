using System;
using System.Data;
using Arch.Data.Orm;

namespace DLPT.Entity.DataModel
{
    /// <summary>
    /// agent
    /// </summary>
    [Serializable]
    [Table(Name = "AgentGen_{0}")]
    public partial class AgentGen
    {
        /// <summary>
        /// </summary>
        [Column(Name = "Id",ColumnType=DbType.Int32),ID,PK]
        public int Id { get; set; }
        /// <summary>
        /// </summary>
        [Column(Name = "Name",ColumnType=DbType.AnsiString,Length=100)]
        public string Name { get; set; }
    }
}