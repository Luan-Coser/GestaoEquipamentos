using GestaoEquipamentos.WinFormsApp.ModuloEquipamento;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public partial class GestaoEquipamentosForm : Form
    {
        private EquipamentosController equipamentosController;

        public GestaoEquipamentosForm()
        {
            InitializeComponent();
            equipamentosController = new EquipamentosController();

            this.dataGridView1.DataSource = equipamentosController.ObterEquipamentos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int selectedLine = dataGridView1.CurrentRow.Index;

                string Numero = dataGridView1.Rows[selectedLine].Cells[0].Value.ToString();
                string Nome = dataGridView1.Rows[selectedLine].Cells[1].Value.ToString();
                string Preco = dataGridView1.Rows[selectedLine].Cells[2].Value.ToString();
                string NSerie = dataGridView1.Rows[selectedLine].Cells[3].Value.ToString();
                string Fabricante = dataGridView1.Rows[selectedLine].Cells[5].Value.ToString();
                DateTime DataFab;
                if (!DateTime.TryParse(dataGridView1.Rows[selectedLine].Cells[4].Value.ToString(), out DataFab))
                {
                    MessageBox.Show("Formato de data de fabricação inválido.");
                    return;
                }
                DateTime DataMan;
                if (!DateTime.TryParse(dataGridView1.Rows[selectedLine].Cells[6].Value.ToString(), out DataMan))
                {
                    MessageBox.Show("Formato de data de fabricação inválido.");
                    return;
                }

                equipamentosController.Editar(false, selectedLine, Numero, Nome, Preco, NSerie, DataFab, Fabricante, DataMan);

                AtualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Nenhuma linha está selecionada.");
            }
        }
        private void AtualizarDataGridView()
        {
            // Atualiza o DataSource do DataGridView com os dados atualizados
            this.dataGridView1.DataSource = null; // Limpa o DataSource atual
            this.dataGridView1.DataSource = equipamentosController.ObterEquipamentos(); // Obtém os novos dados do controller
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            equipamentosController.Editar(true, 0, "", "", "", "", default(DateTime), "", default(DateTime));

            AtualizarDataGridView();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                int selectedLine = dataGridView1.CurrentRow.Index;
                if (selectedLine > -1)
                {
                    equipamentosController.Excluir(selectedLine);

                    AtualizarDataGridView();

                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }

           

        }
    }
}
