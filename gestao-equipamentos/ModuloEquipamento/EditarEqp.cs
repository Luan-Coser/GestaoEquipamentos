using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestaoEquipamentos.WinFormsApp.ModuloEquipamento
{
    public partial class EditarEqp : Form
    {
        public Equipamento EquipamentoAtt { get; set; }

        int Line;
        public EditarEqp(bool Adicionar,int SelectedLine = 0, string Numero = "", string Nome = "", string Preco = "", 
                         string NumeroDeSerie = "", DateTime DataDeFabricacao = default(DateTime), 
                         string Fabricante = "", DateTime DataUltimaManutencao = default(DateTime))
        {

            InitializeComponent();

            if (Adicionar = false)
            {
                txtNome.Text = Nome;
                txtNumero.Text = Numero;
                txtPreco.Text = Preco;
                txtNumeroS.Text = NumeroDeSerie;
                txtFabricante.Text = Fabricante;
                DataFab.Value = DataDeFabricacao;
                DataManutencao.Value = DataUltimaManutencao;
                Line = SelectedLine;
                btnAtualizar.Text = "Atualizar";
            }
            else
            {
                btnAtualizar.Text = "Adicionar";
            }

            }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNome.Text) && !string.IsNullOrEmpty(txtNumero.Text) &&
                !string.IsNullOrEmpty(txtPreco.Text) && !string.IsNullOrEmpty(txtNumeroS.Text) &&
                !string.IsNullOrEmpty(txtFabricante.Text))
            {
                EquipamentoAtt = (new Equipamento()
                {
                    DataDeFabricacao = DataFab.Value,
                    DataUltimaManutencao = DataManutencao.Value,
                    Fabricante = txtFabricante.Text,
                    Nome = txtNome.Text,
                    Numero = Convert.ToInt32(txtNumero.Text),
                    NumeroDeSerie = txtNumeroS.Text,
                    Preco = Convert.ToDecimal(txtPreco.Text)
                });
            }
            else { return; }    
           
        }

    }
}
