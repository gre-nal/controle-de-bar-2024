using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleBar.Infraestrutura.Orm.Compartilhado;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer;

namespace ControleBar.Infraestrutura.Orm.ModuloMesa
{
    public class RepositorioMesaOrm : IRepositorioMesa
    {
        public void Cadastrar(Mesa mesa)
        {
            dbContext.Mesas.Add(mesa);
            dbContext.SaveChanges();
        }
        public bool Editar(int id, Mesa questaoAtualizada)
        {
            Mesa questao = dbContext.Mesas.Find(id)!;

            if (mesa == null)
                return false;

            mesa.AtualizarRegistro(mesaAtualizada);

            dbContext.Questoes.Update(mesa);
            dbContext.SaveChanges();
            return true;
        }
        public bool Excluir(int id)
        {
            Mesa mesa = dbContext.Mesas.Find(id)!;

            if (mesa == null)
                return false;

            dbContext.Mesas.Remove(mesa);
            dbContext.SaveChanges();

            return true;
        }

        public Mesa SelecionarPorId(int id)
        {
            return dbContext.Mesas.Include(m => m.Numero).FirstOrDefault(m => m.Id == id)!;
        }

        public List<Mesa> SelecionarTodos()
        {
            return dbContext.Mesas.Include(m => m.Numero).ToList();
        }
    }
}
