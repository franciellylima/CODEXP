using System;
using Spire.Doc;
using Spire.Doc.Documents;
using System.Drawing;
using Spire.Doc.Formatting;



namespace NewDocument
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string nome;
            string endereco;
            double valor;
            DateTime data;

            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu endereço");
            endereco = Console.ReadLine();
            Console.WriteLine("Digite o valor da compra");
            valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a data da compra (dd/mm/aaaa)");
            data = DateTime.Parse(Console.ReadLine());
            Document doc = new Document();
            Section section = doc.AddSection();
            CharacterFormat format = new CharacterFormat(doc);
            format.Bold = true;
            Paragraph titulo = section.AddParagraph();
            titulo.AppendText("Nota Fiscal\n").ApplyCharacterFormat(format);
            Paragraph paragrafo = section.AddParagraph();
            paragrafo.AppendText($"Nome: ").ApplyCharacterFormat(format);
            paragrafo.AppendText(nome);
            paragrafo.AppendText("\n");
            paragrafo.AppendText($"Endereço: ").ApplyCharacterFormat(format);
            paragrafo.AppendText(endereco);
            paragrafo.AppendText("\n");
            paragrafo.AppendText($"Preço: ").ApplyCharacterFormat(format);
            paragrafo.AppendText(valor+"");
            paragrafo.AppendText("\n");
            paragrafo.AppendText($"Data: ").ApplyCharacterFormat(format);
            paragrafo.AppendText(data.ToShortDateString()+"");


            
            doc.SaveToFile("Dados do comprador.docx", FileFormat.Docx);

        }
    }
}
