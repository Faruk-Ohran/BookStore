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
        protected BaseEntity(string createdBy)
        {
            CreatedBy = createdBy;
            CreatedAt = DateTime.UtcNow;
        }
    }
}
