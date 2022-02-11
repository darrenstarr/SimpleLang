using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageGrammer.AST
{
    public class ParenthesisExpression : Expression
    {
        public Expression? Child;

        public override string TokenType => "Parenthesis";

        override public string ToString() => "( " + ((Child == null) ? "" : Child.ToString()) + " )";
    }
}
