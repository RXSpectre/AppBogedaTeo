using System.ComponentModel;


namespace AppBogedaTeo.Entidades
{
    public class Parametro
    {
        [DisplayName("Código Parametro")]
        public string CodPrm { get; set; }

        [DisplayName("Código Identificador")]
        public int Codigo { get; set; }

        public string Descripcion { get; set; }
      
        public string Habilitado { get; set; }

       
        public int Fmod { get; set; }

        public Parametro()
        {
            CodPrm = "";
            Codigo = 0;
            Descripcion = "";
            Habilitado = "1";
        }

        public override string ToString()
        {
            return $"{Codigo}-{Descripcion}";
        }

    }
}
