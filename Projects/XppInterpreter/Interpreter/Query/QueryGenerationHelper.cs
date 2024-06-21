﻿using XppInterpreter.Interpreter.Bytecode;

namespace XppInterpreter.Interpreter.Query
{
    internal class QueryGenerationHelper
    {
        private readonly RuntimeContext _context;
        internal QueryGenerationHelper(RuntimeContext context)
        {
            _context = context;
        }

        private object Interpret(ByteCode byteCode)
        {
            XppInterpreter interpreter = new XppInterpreter(_context.Proxy);
            interpreter.Interpret(byteCode, _context, false);

            return _context.Stack.Pop();
        }

        internal object ComputeVariable(Parser.Variable variable)
        {
            // Compile
            var generator = new Bytecode.ByteCodeGenerator();
            generator.VisitVariable(variable);
            ByteCode bytecode = generator.GetProgram();

            return Interpret(bytecode);
        }

        internal object ComputeFunctionCall(Parser.FunctionCall functionCall)
        {
            // Compile
            var generator = new Bytecode.ByteCodeGenerator();
            generator.VisitFunctionCall(functionCall);
            ByteCode bytecode = generator.GetProgram();

            return Interpret(bytecode);
        }

        internal object ComputeConstant(Parser.Constant constant)
        {
            // Compile
            var generator = new Bytecode.ByteCodeGenerator();
            generator.VisitConstant(constant);
            ByteCode bytecode = generator.GetProgram();

            return Interpret(bytecode);
        }
    }
}
