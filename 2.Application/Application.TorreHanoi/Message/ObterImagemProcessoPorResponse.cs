using System.Drawing;

namespace Application.TorreHanoi.Message
{
    public class ObterImagemProcessoPorResponse : Response
    {
        public Bitmap Imagem { get; set; }

        public ObterImagemProcessoPorResponse()
        {
            this.Imagem = new Bitmap(200, 100);
        }
    }
}
