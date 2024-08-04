namespace TestePratico1.Model
{
    public interface IPessoaFisicaRepository
    {
        void Add(PessoaFisica pessoa);

        List<PessoaFisica> get();
    }
}
