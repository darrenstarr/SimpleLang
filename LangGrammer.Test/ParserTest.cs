using Xunit;
using LanguageGrammer.AST;
using LanguageGrammer.Grammar;

namespace LangGrammer.Test
{
    public class ParserTest
    {
        [Fact]
        public void ParseBasicSum()
        {
            var ast = Parser.Parse("5+4");
            Assert.NotNull(ast);
            Assert.IsType<ArithmeticExpression>(ast);
            var aeRoot = ast as ArithmeticExpression;
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            Assert.NotNull(aeRoot.Terms);
            Assert.NotEmpty(aeRoot.Terms);
            Assert.Equal(2, aeRoot.Terms.Count);
            Assert.NotNull(aeRoot.Terms[0]);
            Assert.NotNull(aeRoot.Terms[1]);

            Assert.Equal(BinaryExpressionType.Additive, aeRoot.Terms[0].ExpressionType);
            Assert.Equal(BinaryExpressionType.Additive, aeRoot.Terms[1].ExpressionType);

            Assert.NotNull(aeRoot.Terms[0].Right);
            Assert.IsType<NumericExpression>(aeRoot.Terms[0].Right);
            Assert.Equal(5.0, (aeRoot.Terms[0].Right as NumericExpression).Value);

            Assert.NotNull(aeRoot.Terms[1].Right);
            Assert.IsType<NumericExpression>(aeRoot.Terms[1].Right);
            Assert.Equal(4.0, (aeRoot.Terms[1].Right as NumericExpression).Value);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
    }
}