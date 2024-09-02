namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string? _modelo;
        private string? _imei;
        private int _memoria;

        public string Modelo 
        { 
            get => _modelo;
            set => _modelo = value != null ? value : throw new ArgumentNullException(nameof(value), "Houve uma exceção, o Modelo não pode ser nulo.");
        }

        public string Imei 
        {
            get => _imei;
            set => _imei = value != null ? value : throw new ArgumentNullException(nameof(value), "Houve uma exceção, o IMEI não pode ser nulo.");
        }

        public int Memoria 
        {
            get => _memoria;
            set => _memoria = value >= 0 ? value : throw new ArgumentNullException(nameof(value), "Houve uma exceção, a memória não pode ser 0.");
        }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}