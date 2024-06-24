namespace GestaoEquipamentos.WinFormsApp.ModuloEquipamento
{
    partial class EditarEqp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNome = new Label();
            lblNumero = new Label();
            lblPreco = new Label();
            lblNs = new Label();
            lblfabricantes = new Label();
            lblData = new Label();
            lblDataM = new Label();
            DataFab = new DateTimePicker();
            DataManutencao = new DateTimePicker();
            txtNome = new TextBox();
            txtNumero = new TextBox();
            txtPreco = new TextBox();
            txtNumeroS = new TextBox();
            txtFabricante = new TextBox();
            btnAtualizar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(24, 27);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(24, 65);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(54, 15);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Numero:";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(24, 108);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(40, 15);
            lblPreco.TabIndex = 2;
            lblPreco.Text = "Preço:";
            // 
            // lblNs
            // 
            lblNs.AutoSize = true;
            lblNs.Location = new Point(24, 148);
            lblNs.Name = "lblNs";
            lblNs.Size = new Size(97, 15);
            lblNs.TabIndex = 3;
            lblNs.Text = "Numero de serie:";
            // 
            // lblfabricantes
            // 
            lblfabricantes.AutoSize = true;
            lblfabricantes.Location = new Point(24, 194);
            lblfabricantes.Name = "lblfabricantes";
            lblfabricantes.Size = new Size(65, 15);
            lblfabricantes.TabIndex = 4;
            lblfabricantes.Text = "Fabricante:";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(24, 235);
            lblData.Name = "lblData";
            lblData.Size = new Size(108, 15);
            lblData.TabIndex = 5;
            lblData.Text = "Data de fabricação:";
            // 
            // lblDataM
            // 
            lblDataM.AutoSize = true;
            lblDataM.Location = new Point(24, 272);
            lblDataM.Name = "lblDataM";
            lblDataM.Size = new Size(120, 15);
            lblDataM.TabIndex = 6;
            lblDataM.Text = "Data de manutenção:";
            // 
            // DataFab
            // 
            DataFab.Location = new Point(138, 235);
            DataFab.Name = "DataFab";
            DataFab.Size = new Size(234, 23);
            DataFab.TabIndex = 11;
            // 
            // DataManutencao
            // 
            DataManutencao.Location = new Point(150, 272);
            DataManutencao.Name = "DataManutencao";
            DataManutencao.Size = new Size(234, 23);
            DataManutencao.TabIndex = 12;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(84, 27);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 13;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(84, 65);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 14;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(84, 108);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 15;
            // 
            // txtNumeroS
            // 
            txtNumeroS.Location = new Point(138, 145);
            txtNumeroS.Name = "txtNumeroS";
            txtNumeroS.Size = new Size(100, 23);
            txtNumeroS.TabIndex = 16;
            // 
            // txtFabricante
            // 
            txtFabricante.Location = new Point(95, 191);
            txtFabricante.Name = "txtFabricante";
            txtFabricante.Size = new Size(100, 23);
            txtFabricante.TabIndex = 17;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(118, 311);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(155, 31);
            btnAtualizar.TabIndex = 18;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // EditarEqp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 354);
            Controls.Add(btnAtualizar);
            Controls.Add(txtFabricante);
            Controls.Add(txtNumeroS);
            Controls.Add(txtPreco);
            Controls.Add(txtNumero);
            Controls.Add(txtNome);
            Controls.Add(DataManutencao);
            Controls.Add(DataFab);
            Controls.Add(lblDataM);
            Controls.Add(lblData);
            Controls.Add(lblfabricantes);
            Controls.Add(lblNs);
            Controls.Add(lblPreco);
            Controls.Add(lblNumero);
            Controls.Add(lblNome);
            Name = "EditarEqp";
            Text = "EditarEqp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblNumero;
        private Label lblPreco;
        private Label lblNs;
        private Label lblfabricantes;
        private Label lblData;
        private Label lblDataM;
        private DateTimePicker DataFab;
        private DateTimePicker DataManutencao;
        private TextBox txtNome;
        private TextBox txtNumero;
        private TextBox txtPreco;
        private TextBox txtNumeroS;
        private TextBox txtFabricante;
        private Button btnAtualizar;
    }
}