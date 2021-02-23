namespace ListaDinamica
{
    public class Telefone
    {
        public int Ddd { get; set; }
        public int Numero { get; set; }
        public string Tipo { get; set; }

        // IMPRESSAO
        public override string ToString()
        {
            if(Ddd != 0)
                return  "  " + Tipo + " (" + Ddd + ") " + Numero + "\n";
            return "";
        }
    }
}