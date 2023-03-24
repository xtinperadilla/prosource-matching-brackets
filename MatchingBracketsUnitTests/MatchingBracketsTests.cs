using MatchingBrackets;
using Xunit;

namespace MatchingBracketsUnitTests
{
    public class MatchingBracketsTests
    {
        private MatchingBracket _matchingBrackets = new MatchingBracket();

        [Fact]
        public void HasMatchingBrackets_SingleOpeningAndClosingBracket_ShouldReturnTrue()
        {
            var testText = "{}";
            var result = _matchingBrackets.HasMatchingBrackets(testText);
            Assert.True(result);
        }

        [Fact]
        public void HasMatchingBrackets_SingleOpeningAndClosingBracketWithOtherText_ShouldReturnTrue()
        {
            var testText = "{test}";
            var result = _matchingBrackets.HasMatchingBrackets(testText);
            Assert.True(result);
        }

        [Fact]
        public void HasMatchingBrackets_MultipleMatchingOpeningAndClosingBrackets_ShouldReturnTrue()
        {
            var testText = "{{{}}}";
            var result = _matchingBrackets.HasMatchingBrackets(testText);
            Assert.True(result);
        }

        [Fact]
        public void HasMatchingBrackets_MultipleMatchingOpeningAndClosingBracketsWithOtherText_ShouldReturnTrue()
        {
            var testText = "t{e{{}}st}";
            var result = _matchingBrackets.HasMatchingBrackets(testText);
            Assert.True(result);
        }

        [Fact]
        public void HasMatchingBrackets_OpeningBracketOnly_ShouldReturnFalse()
        {
            var testText = "{";
            var result = _matchingBrackets.HasMatchingBrackets(testText);
            Assert.False(result);
        }

        [Fact]
        public void HasMatchingBrackets_OpeningBracketWithOtherText_ShouldReturnFalse()
        {
            var testText = "te{st";
            var result = _matchingBrackets.HasMatchingBrackets(testText);
            Assert.False(result);
        }

        [Fact]
        public void HasMatchingBrackets_ClosingBracketOnly_ShouldReturnFalse()
        {
            var testText = "}";
            var result = _matchingBrackets.HasMatchingBrackets(testText);
            Assert.False(result);
        }

        [Fact]
        public void HasMatchingBrackets_ClosingBracketWithOtherText_ShouldReturnFalse()
        {
            var testText = "te}st";
            var result = _matchingBrackets.HasMatchingBrackets(testText);
            Assert.False(result);
        }

        [Fact]
        public void HasMatchingBrackets_ClosingBracketAtFirstEncounter_ShouldReturnFalse()
        {
            var testText = "}{";
            var result = _matchingBrackets.HasMatchingBrackets(testText);
            Assert.False(result);
        }

        [Fact]
        public void HasMatchingBrackets_ClosingBracketAtFirstEncounterWithOtherText_ShouldReturnFalse()
        {
            var testText = "te}{st";
            var result = _matchingBrackets.HasMatchingBrackets(testText);
            Assert.False(result);
        }

        [Fact]
        public void HasMatchingBrackets_OpeningBracketsButNoClosingBracket_ShouldReturnFalse()
        {
            var testText = "{{}";
            var result = _matchingBrackets.HasMatchingBrackets(testText);
            Assert.False(result);
        }

        [Fact]
        public void HasMatchingBrackets_EmptyText_ShouldReturnTrue()
        {
            var testText = "";
            var result = _matchingBrackets.HasMatchingBrackets(testText);
            Assert.True(result);
        }
    }
}