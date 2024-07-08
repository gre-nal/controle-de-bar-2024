using ControleBar.WinApp.Compartilhado;
using ControleBar.Dominio.Mesa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.WinApp.Mesa
{
    public class ControladorMesa : ControladorBase
    {
        public override string TipoCadastro => "Mesa";

        public override string ToolTipAdicionar => "Cadastrar uma nova Mesa";

        public override string ToolTipEditar => "Editar uma Mesa";

        public override string ToolTipExcluir => "Excluir uma Mesa";

        TabelaMesaControl tabelaMesa;

        IRepositorioMesa repositorioMesa;

        public ControladorMesa(TabelaMesaControl tabelaMesa, IRepositorioMesa repositorioMesa)
        {
            this.tabelaMesa = tabelaMesa;
            this.repositorioMesa = repositorioMesa;
        } 

        public override void Adicionar()
        {
            throw new NotImplementedException();
        }

        public override void CarregarRegistros()
        {
            throw new NotImplementedException();
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
        }
    }
}
