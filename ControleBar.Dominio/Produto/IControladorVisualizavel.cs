using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.Dominio.Produto
{
    public interface IControladorVisualizavel
    {
        string ToolTipVisualizar { get; }

        void Visualizar();
    }
}
