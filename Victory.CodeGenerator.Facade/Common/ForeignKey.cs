﻿
using Victory.CodeGenerator.Facade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victory.CodeGenerator.Facade.Common
{
    public class ForeignKey : ConstraintKeyBase
    {
        public ITableSchema ForeignTable { get; set; }
    }
}
