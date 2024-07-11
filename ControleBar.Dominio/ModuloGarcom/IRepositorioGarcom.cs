namespace ControleBar.Dominio.ModuloGarcom;

public interface IRepositorioGarcom
{
    void Cadastrar(Garcom novoGarcom);
    bool Editar(int id, Garcom garcomEditado);
    bool Excluir(int id);
    Garcom SelecionarPorId(int idSelecionado);
    List<Garcom> SelecionarTodos();
}