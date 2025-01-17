﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Entity
{
    public class Magazine : BaseEntity
    {
        public string Title { get; set; }
        public bool IsAvailable { get; set; } = true;
        public string Author { get; set; }
        public string ISBN { get; set; }

        public long LibraryItemId { get; set; }
        public LibraryItem LibraryItem { get; set; }

        public override string GetDetails()
        {
            throw new NotImplementedException();
        }
    }
}