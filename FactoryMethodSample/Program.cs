using FactoryMethodSample.Creators;
using FactoryMethodSample.Products.Implements;

var pdfDocumentCreator = new DocumentCreator<PDFDocument>();

var pdf = pdfDocumentCreator.CreateDocument();
pdf.Open();

var wordDocumentCreator = new DocumentCreator<WordDocument>();

var word = wordDocumentCreator.CreateDocument();
word.Open();