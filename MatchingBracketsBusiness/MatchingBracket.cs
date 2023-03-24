namespace MatchingBrackets
{
    public class MatchingBracket : IMatchingBracket
    {
        public bool HasMatchingBrackets(string text)
        {
            // return true if empty or null or has no brackets
            if (string.IsNullOrEmpty(text) || (!text.Contains("}") && !text.Contains("{")))
                return true;

            // return false if only contains closing bracket(s) and vice versa
            if ((text.Contains("}") && !text.Contains("{"))
                || (text.Contains("{") && !text.Contains("}")))
                return false;

            var arrayOfText = text.ToArray();

            // return false if closing bracket encountered first
            // but if opening bracket is encountered first get out of the loop
            foreach (var item in arrayOfText)
            {
                if (item.Equals('}'))
                {
                    return false;
                }
                if (item.Equals('{'))
                {
                    break;
                }
            }

            var openingBrackets = 0;
            var closingBrackets = 0;

            // get the number of all opening and closing brackets
            foreach (var item in arrayOfText)
            {
                if (item.Equals('{'))
                {
                    openingBrackets++;
                }
                else if (item.Equals('}'))
                {
                    closingBrackets++;
                }
            }

            // if the number of all opening and closing brackets are equal return true
            if (openingBrackets == closingBrackets)
                return true;

            return false;
        }
    }
}
