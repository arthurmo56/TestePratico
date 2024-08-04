using System.ComponentModel.DataAnnotations.Schema;

namespace TestePratico1.Model
{
    [Table("pessoajuridica")]
    public class PessoaJuridica : Pessoa
    {
        public string cnpj { get; private set; }
        public string razao_social { get; private set; }

        // Construtor
        public PessoaJuridica(string nome, string data_nascimento, string endereco, string telefone, string cnpj, string razao_social)
            : base(nome, data_nascimento, endereco, telefone)
        {
            this.cnpj = cnpj ?? throw new ArgumentNullException(nameof(cnpj));

            this.razao_social = razao_social ?? throw new ArgumentNullException(nameof(razao_social));
        }

        // Método específico para alterar o CNPJ, se necessário
        public void AlterarCPF(string novoCnpj)
        {
            cnpj = novoCnpj ?? throw new ArgumentNullException(nameof(novoCnpj));
        }

        public void AlterarRazaosocial(string novarazaosocial)
        {
            razao_social = novarazaosocial ?? throw new ArgumentNullException(nameof(novarazaosocial));
        }
    }
}
