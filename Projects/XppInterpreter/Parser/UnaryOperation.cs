﻿using System.Diagnostics;
using XppInterpreter.Interpreter;
using XppInterpreter.Lexer;

namespace XppInterpreter.Parser
{
    public class UnaryOperation : Expression
    {
        public Expression Expression { get; }

        public UnaryOperation(Token token, Expression expression, SourceCodeBinding sourceCodeBinding) : base(token, sourceCodeBinding)
        {
            Expression = expression;
        }

        [DebuggerHidden]
        public override void Accept(IAstVisitor interpreter)
        {
            interpreter.VisitUnaryOperation(this);
        }
    }
}
