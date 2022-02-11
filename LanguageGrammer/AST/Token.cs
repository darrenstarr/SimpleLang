namespace LanguageGrammer.AST
{
    public class Token
    {
        public int Length { get; set; } = -1;

        public virtual string TokenType => "Token";
    }
}
