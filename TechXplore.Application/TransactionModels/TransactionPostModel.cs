﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechXplore.Application.TransactionModels
{
    public class TransactionPostModel
    {
        public int CompanyId { get; set; }
        public decimal MoneySpent { get; set; }
    }
}
