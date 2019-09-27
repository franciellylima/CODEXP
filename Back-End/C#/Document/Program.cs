using System;
using Spire.Doc;
using Spire.Doc.Documents;
using System.Drawing;

namespace Repositorio_word_pdf
{
    class Program
    {
        static void Main(string[] args)
        {

            // Criando um novo documento com o nome documento
            Document documento = new Document();

            // Criando uma seção dentro do documento
            // A cada seção criada uma nova página é criada
            Section secaoCapa = documento.AddSection();

            Console.WriteLine("Hello World");

            // Insere um título na primeira página
            Paragraph titulo = secaoCapa.AddParagraph();

            // Insiro na minha variável título o valor da string "Título muito bonito"
            // O meu documento aparecerá "Título muito bonito"
            titulo.AppendText("Título muito bonito\n\n");
            

            titulo.Format.HorizontalAlignment = HorizontalAlignment.Center;

            // Instanciando a classe ParagraphStyle dentro do nosso documento
            ParagraphStyle estilo01 = new ParagraphStyle(documento);

            // Define o nome da classe estilo 01
            estilo01.Name = "Cor do título";

            // Transforma a propriedade TextColor de Azul escuro
            estilo01.CharacterFormat.TextColor = Color.DarkBlue;

            // Transformar a propriedade Bold em True
            estilo01.CharacterFormat.Bold = true;

            // Adicionar o estilo e colocar como usável no nosso documento
            documento.Styles.Add(estilo01);
            
            titulo.ApplyStyle(estilo01.Name);

            documento.SaveToFile(@"exemploWord.docx", FileFormat.Docx);


        }
    }
}
