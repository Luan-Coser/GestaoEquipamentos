using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.WinFormsApp.ModuloEquipamento
{
    internal class EquipamentosController
    {
        public EquipamentoRepositorio _repositorioEquipamentos { get; set; }
        public EquipamentosController()
        {
            _repositorioEquipamentos = new EquipamentoRepositorio();
        }

        public List<Equipamento> ObterEquipamentos()
        {
            //Página
            //Entende o contexto do usuario

            return _repositorioEquipamentos.Lista();
        }

        internal void Editar(bool Adicionar, int selectedLine, string numero, string nome, string preco, 
                             string nSerie, DateTime dataFab, string fabricante, DateTime dataMan)
        {
            EditarEqp editar = new EditarEqp(Adicionar, selectedLine, numero, nome, preco,
                                              nSerie, dataFab, fabricante, dataMan);
           
            editar.ShowDialog();
            if (Adicionar = false)
            {
                _repositorioEquipamentos.Atualizar(editar.EquipamentoAtt, selectedLine);

            }
            else
            {
                _repositorioEquipamentos.Adicionar(editar.EquipamentoAtt);
            }
        }

        internal void Excluir(int selectedLine)
        {
            _repositorioEquipamentos.Excluir(selectedLine);    
        }
    }
}
