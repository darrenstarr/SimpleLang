namespace LanguageGrammer.Grammar
{
    public static partial class Parser
    {
        public static string ParseDigits(string text, int index)
        {
            var start = index;
            while (index < text.Length && text[index] >= '0' && text[index] <= '9')
                index++;

            return text[start..index];
        }

        public static int SkipWhiteSpace(string text, int index)
        {
            while (
                index < text.Length &&
                (
                    text[index] == ' ' ||
                    text[index] == '\t' ||
                    text[index] == '\n' ||
                    text[index] == '\r'
                )
            )
                index++;

            return index;
        }
    }
}
