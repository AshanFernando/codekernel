﻿using Codekernel.Data.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codekernel.Data.Seed
{
    interface ISeed
    {
        void Seed(DatabaseContext context);
    }
}
