using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Cosmos.MimeTypeSniffer;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace IntegrationTests
{
    public class ExpectedTests
    {
        private IMimeSniffer Sniffer { get; set; }
        private string Local { get; set; }

        private const string DOC_MIME = "application/msword";
        private const string DOCX_MIME = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";

        public ExpectedTests()
        {
            var services = new ServiceCollection();
            services.AddFileTypeSniffer();
            services.AddMimeTypeSniffer();
            var provider = services.BuildServiceProvider();

            Sniffer = provider.GetRequiredService<IMimeSniffer>();
            Local = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "samples");
        }

        [Fact]
        public void WordDoc_Docx()
        {
            var path = Path.Combine(Local, "sniffer.doc");
            var results = Sniffer.Expect(new List<string> { "doc", "docx" }).Match(path, 20, true);
            var count = results.Count;
            var one = results.FirstOrDefault();
            Assert.Contains(DOC_MIME, results);
            Assert.Equal(1, count);
            Assert.Equal(DOC_MIME, one);
        }

        [Fact]
        public void WordDoc_Single()
        {
            var path = Path.Combine(Local, "sniffer.doc");
            var results = Sniffer.Expect(new List<string> { "doc", "docx" }).Match(path, 20, true);
            var result1 = Sniffer.Expect("doc").MatchSingle(path, 20);
            var count = results.Count;
            var one = results.FirstOrDefault();
            Assert.Contains(DOC_MIME, results);
            Assert.Equal(1, count);
            Assert.Equal(DOC_MIME, one);
            Assert.Equal(DOC_MIME, result1);
        }

        [Fact]
        public void WordDocx()
        {
            var path = Path.Combine(Local, "sniffer.docx");
            var results = Sniffer.Expect(new List<string> { "docx" }).Match(path, 20, true);
            var count = results.Count;
            var one = results.FirstOrDefault();
            Assert.Contains(DOCX_MIME, results);
            Assert.Equal(1, count);
            Assert.Equal(DOCX_MIME, one);
        }

        [Fact]
        public void WordDocx_Doc()
        {
            var path = Path.Combine(Local, "sniffer.docx");
            var results = Sniffer.Expect(new List<string> { "docx", "doc" }).Match(path, 20, true);
            var count = results.Count;
            var one = results.FirstOrDefault();
            Assert.Contains(DOCX_MIME, results);
            Assert.Equal(1, count);
            Assert.Equal(DOCX_MIME, one);
        }

        [Fact]
        public void WordDocx_Xlsx()
        {
            var path = Path.Combine(Local, "sniffer.docx");
            var results = Sniffer.Expect(new List<string> { "docx", "xlsx" }).Match(path, 20, true);
            var count = results.Count;
            var one = results.FirstOrDefault(x => x == DOCX_MIME);
            Assert.Contains(DOCX_MIME, results);
            Assert.Equal(2, count);
            Assert.Equal(DOCX_MIME, one);
        }
    }
}
