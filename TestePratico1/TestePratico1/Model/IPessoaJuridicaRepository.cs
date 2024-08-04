namespace TestePratico1.Model
{
    public interface IPessoaJuridicaRepository
    {
        void Add(PessoaJuridica pessoa);

        List<PessoaJuridica> get();
    }
}
