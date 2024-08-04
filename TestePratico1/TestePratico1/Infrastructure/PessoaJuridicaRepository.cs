using TestePratico1.Model;

namespace TestePratico1.Infrastructure
{
    public class PessoaJuridicaRepository : IPessoaJuridicaRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();
        public void Add(PessoaJuridica pessoa)
        {
            _context.PessoasJuridicas.Add(pessoa);
            _context.SaveChanges();
        }

        public List<PessoaJuridica> get()
        {
            return _context.PessoasJuridicas.ToList();
        }
    }
}
