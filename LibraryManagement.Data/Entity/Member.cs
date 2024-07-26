using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Entity
{
    public class Member : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }

        public List<LibraryItem> BorrowedItems { get; set; } = new List<LibraryItem>();

        public override string GetDetails()
        {
            throw new NotImplementedException();

        }
    }
}