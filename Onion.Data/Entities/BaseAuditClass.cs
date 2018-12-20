using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Onion.Data.Entities
{
    public abstract class BaseAuditClass
    {
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
