using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BookStore.Dal.Domain
{
    public abstract class BaseEntity
    {
        public String CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int Id { get; set; }
        protected BaseEntity()
        {
            CreatedAt = DateTime.UtcNow;
        }
    }
}
