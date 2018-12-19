using System;
using System.IO;
using Xunit;

namespace Stele.Grammar.Test
{
    public class LexerTest
    {
        [Fact]
        public void TestPoll()
        {
            string path = Path.Combine("..", "..", "..", "..", "Resources", "calculation.stele");
            using (FileStream reader = File.OpenRead(path))
            {
                Lexer lexer = new Lexer(reader);
            }
        }
    }
}
