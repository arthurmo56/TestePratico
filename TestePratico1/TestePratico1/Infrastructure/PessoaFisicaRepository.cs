using TestePratico1.Model;

namespace TestePratico1.Infrastructure
{
    public class PessoaFisicaRepository : IPessoaFisicaRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();
        public void Add(PessoaFisica pessoa)
        {
            _context.PessoasFisicas.Add(pessoa);
            _context.SaveChanges();
        }

        public List<PessoaFisica> get()
        {
            return _context.PessoasFisicas.ToList();
        }
    }
}
