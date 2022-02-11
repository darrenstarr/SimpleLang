namespace LanguageGrammer.AST
{
    public class ArithmeticExpression : Expression
    {
        public List<BinaryExpression>? Terms;

        public override string TokenType => "Arithmetic";

        public override string ToString()
        {
            return Terms == null ? "<null>" : Terms.Select(x => x.ToString()).Aggregate((a, b) => a + b);
        }
    }
}
