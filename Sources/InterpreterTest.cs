using System.IO;
using Xunit;

namespace Stele.Test
{
    public class InterpreterTest
    {
        [Fact]
        public void TestInterpret()
        {
            Interpreter interpreter = new Interpreter();
            string path = Path.Combine("..", "..", "..", "..", "Resources", "calculation.stele");
            using (FileStream reader = File.OpenRead(path))
            {
                interpreter.Interpret(reader);
            }
        }
    }
}
