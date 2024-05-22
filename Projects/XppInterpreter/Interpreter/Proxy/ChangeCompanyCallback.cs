﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XppInterpreter.Parser;

namespace XppInterpreter.Interpreter.Proxy
{
    public class ChangeCompanyCallback
    {
        public IAstVisitor Interpreter { get; }
        public Block Block { get; }

        public ChangeCompanyCallback(IAstVisitor interpreter, Block block)
        {
            Interpreter = interpreter;
            Block = block;
        }

        public object Run()
        {
            return null;
        }
    }
}
