using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.WinFormsApp.ModuloEquipamento
{
    internal class EquipamentoRepositorio
    {
        private List<Equipamento> equipamento;

        public EquipamentoRepositorio() {
            equipamento = new List<Equipamento>();
            semear();
        }

        private void semear()
        {
            equipamento.Add(new Equipamento() {
                DataDeFabricacao = new DateTime(2020, 12, 09),
                DataUltimaManutencao = new DateTime(2020, 12, 09),
                Fabricante = "HP",
                Nome = "Laserjet J6545",
                Numero = 1,
                NumeroDeSerie = "123456789",
                Preco = 1000
            });

            equipamento.Add(new Equipamento()
            {
                DataDeFabricacao = new DateTime(2021, 12, 09),
                DataUltimaManutencao = new DateTime(2021, 12, 09),
                Fabricante = "SAMSUNG",
                Nome = "S21",
                Numero = 2,
                NumeroDeSerie = "987654321",//MEI
                Preco = 5000
            });
        }
        public List<Equipamento> Lista()
        {
            return equipamento;
        }

        public void Atualizar(Equipamento equipamentosAtualizados, int indice)
        {
            if (indice >= 0 && indice < equipamento.Count)
            {
                equipamento[indice] = equipamentosAtualizados; 
            }
            else
            {
                throw new IndexOutOfRangeException("Índice fora dos limites da lista de equipamentos.");
            }
        }
        public void Adicionar(Equipamento equipamentoNovo)
        {
            equipamento.Add(new Equipamento()
            {
                DataDeFabricacao = equipamentoNovo.DataDeFabricacao,
                DataUltimaManutencao = equipamentoNovo.DataUltimaManutencao,
                Fabricante = equipamentoNovo.Fabricante,
                Nome = equipamentoNovo.Nome,
                Numero = equipamentoNovo.Numero,
                NumeroDeSerie = equipamentoNovo.NumeroDeSerie,
                Preco = equipamentoNovo.Preco
            });
        }

        internal void Excluir(int selectedLine)
        {
            equipamento.RemoveAt(selectedLine);
        }
    }
}
