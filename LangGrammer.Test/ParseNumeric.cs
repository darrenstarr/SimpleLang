using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanguageGrammer.AST;
using LanguageGrammer.Grammar;
using Xunit;

namespace LangGrammer.Test
{
    public class ParseNumeric
    {
        [Fact]
        public void ParseInteger()
        {
            var ast = Parser.Parse("543");
            Assert.NotNull(ast);
            Assert.IsType<NumericExpression>(ast);
            Assert.Equal(543, ((NumericExpression)ast).Value);
        }
    }
}
