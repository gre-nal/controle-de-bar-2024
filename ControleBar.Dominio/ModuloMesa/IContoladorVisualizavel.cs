using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.Dominio.ModuloMesa
{
    public interface IContoladorVisualizavel
    {
        string ToolTipVisualizar { get; }

        void Visualizar();
    }
}
