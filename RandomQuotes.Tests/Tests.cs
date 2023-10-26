using NUnit.Framework;
using RandomQuotes.Models;

namespace RandomQuotes.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Quote.Initialize();
        }

        [Test]
        public void Test1()
        {
            var randomQuote = Quote.GetRandomQuote();
            Assert.That(randomQuote.QuoteText, Is.Not.EqualTo("Something went wrong"));
        }
    }
}
