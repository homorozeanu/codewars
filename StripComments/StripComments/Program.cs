using System;

namespace StripComments
{
    class Program
    {
        static void Main(string[] args)
        {
            StripCommentsSolution.StripComments(
                        "apples, pears # and bananas\ngrapes\nbananas !apples", 
                        new string[] { "#", "!" });
        }
    }
}
