using System.ComponentModel.DataAnnotations;

namespace TestePratico1.Model
{
    public class Pessoa
    {
        [Key]
        public int id { get; private set; }
        public string nome { get; private set; }
        public string data_nascimento { get; private set; }
        public string endereco { get; private set; } 
        public string telefone { get; private set; }

        //Construtor
        public Pessoa(string nome, string data_nascimento, string endereco, string telefone) 
        {
            this.nome = nome ?? throw new ArgumentNullException(nameof(nome));
            this.data_nascimento = data_nascimento;
            this.endereco = endereco;
            this.telefone = telefone;

        }

    }
}
