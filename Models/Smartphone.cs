namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string numero { get; set; }
        private string modelo; 
        private string imei;
        private int memoria;

        public Smartphone(
            string numero,
            string modelo,
            string imei,
            int memoria
        )
        {
            this.numero = numero;
            this.modelo = modelo;
            this.imei = imei;
            this.memoria = memoria;
            Console.WriteLine("Smartphone criado!");
            toString();
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void toString(){
            Console.WriteLine($"Número: {numero}");
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"IMEI: {imei}");
            Console.WriteLine($"Memória: {memoria} Gb\n");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public string IMEI 
        { 
            get { return imei; }
            set { imei = value; } 
        }

        public string Modelo 
        { 
            get { return modelo; }
            set { modelo = value; } 
        }

        public int Memoria 
        { 
            get { return memoria; }
            set { memoria = value; } 
        }
    }
}