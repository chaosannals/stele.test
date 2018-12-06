using System;
using Xunit;

namespace Stele.Test
{
    public class InterpreterTest
    {
        [Fact]
        public void TestInterpret()
        {
            Interpreter interpreter = new Interpreter();
            interpreter.Interpret();
        }
    }
}
