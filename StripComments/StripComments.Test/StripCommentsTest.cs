using System;
using Xunit;

namespace StripComments.Test
{
    public class StripCommentsTest
    {
        [Fact]
        public void BasicTest()
        {
            Assert.Equal(
                    "apples, pears\ngrapes\nbananas",
                    StripCommentsSolution.StripComments(
                        "apples, pears # and bananas\ngrapes\nbananas !apples", 
                        new string[] { "#", "!" }));

            Assert.Equal(
                "a\nc\nd", 
                StripCommentsSolution.StripComments("a #b\nc\nd $e f g", 
                new string[] { "#", "$" }));
        }

        [Fact]
        public void OnlyOneCommentSymbol()
        {
            Assert.Equal(
                    "",
                    StripCommentsSolution.StripComments(
                        "a", 
                        new string[] { "a"}));
        }

        [Fact]
        public void OnlyOneCommentedOutLine()
        {
            Assert.Equal(
                    "",
                    StripCommentsSolution.StripComments(
                        "# some text", 
                        new string[] { "#"}));
        }
    }
}
