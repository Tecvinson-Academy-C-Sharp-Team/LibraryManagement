using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Entity
{
    public abstract class LibraryItem : BaseEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public abstract string GetDetails();
    }
}