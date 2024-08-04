using System.ComponentModel.DataAnnotations.Schema;

namespace TestePratico1.Model
{
    [Table("pessoafisica")]
    public class PessoaFisica : Pessoa
    {
        public string cpf { get; private set; }

        // Construtor
        public PessoaFisica(string nome, string data_nascimento, string endereco, string telefone, string cpf)
            : base(nome, data_nascimento, endereco, telefone)
        {
            this.cpf = cpf ?? throw new ArgumentNullException(nameof(cpf));
        }

        // Método específico para alterar o CPF, se necessário
        public void AlterarCPF(string novoCpf)
        {
            cpf = novoCpf ?? throw new ArgumentNullException(nameof(novoCpf));
        }
    }

}

