﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XppInterpreter.Interpreter.Query;

namespace XppInterpreter.Interpreter.Bytecode
{
    class DeleteQuery : IInstruction
    {
        public string OperationCode => "UPDATE_QUERY";
        public Parser.DeleteFrom DeleteFrom { get; }

        public DeleteQuery(Parser.DeleteFrom deleteFrom)
        {
            DeleteFrom = deleteFrom;
        }

        public void Execute(RuntimeContext context)
        {
            new QueryGenerator(context).ExecuteDeleteFrom(DeleteFrom);
        }
    }
}
