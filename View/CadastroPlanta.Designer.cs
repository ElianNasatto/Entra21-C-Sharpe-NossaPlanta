namespace View
{
    partial class CadastroPlanta
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroPlanta));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtxtPeso = new System.Windows.Forms.MaskedTextBox();
            this.mtxtAltura = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Peso = new System.Windows.Forms.Label();
            this.Altura = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSalvar.FlatAppearance.BorderSize = 5;
            this.btnSalvar.Font = new System.Drawing.Font("Stencil", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(12, 345);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(164, 68);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.groupBox1.Controls.Add(this.rbNao);
            this.groupBox1.Controls.Add(this.rbSim);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 72);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carnivora";
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNao.Location = new System.Drawing.Point(86, 28);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(63, 28);
            this.rbNao.TabIndex = 11;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSim.Location = new System.Drawing.Point(20, 28);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(60, 28);
            this.rbSim.TabIndex = 10;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Green;
            this.groupBox2.Controls.Add(this.lblId);
            this.groupBox2.Controls.Add(this.mtxtPeso);
            this.groupBox2.Controls.Add(this.mtxtAltura);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Peso);
            this.groupBox2.Controls.Add(this.Altura);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 240);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações Planta";
            // 
            // mtxtPeso
            // 
            this.mtxtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtPeso.Location = new System.Drawing.Point(34, 193);
            this.mtxtPeso.Mask = "000.00";
            this.mtxtPeso.Name = "mtxtPeso";
            this.mtxtPeso.Size = new System.Drawing.Size(100, 29);
            this.mtxtPeso.TabIndex = 18;
            // 
            // mtxtAltura
            // 
            this.mtxtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtAltura.Location = new System.Drawing.Point(34, 122);
            this.mtxtAltura.Mask = "0.00";
            this.mtxtAltura.Name = "mtxtAltura";
            this.mtxtAltura.Size = new System.Drawing.Size(100, 29);
            this.mtxtAltura.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nome";
            // 
            // Peso
            // 
            this.Peso.AutoSize = true;
            this.Peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Peso.Location = new System.Drawing.Point(30, 166);
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(53, 24);
            this.Peso.TabIndex = 15;
            this.Peso.Text = "Peso";
            // 
            // Altura
            // 
            this.Altura.AutoSize = true;
            this.Altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Altura.Location = new System.Drawing.Point(30, 95);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(58, 24);
            this.Altura.TabIndex = 14;
            this.Altura.Text = "Altura";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(30, 52);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(347, 29);
            this.txtNome.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome});
            this.dataGridView1.Location = new System.Drawing.Point(410, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(409, 213);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(406, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Lista";
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(486, 266);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(333, 29);
            this.txtBusca.TabIndex = 18;
            this.txtBusca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(412, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Buscar";
            // 
            // btnApagar
            // 
            this.btnApagar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnApagar.FlatAppearance.BorderSize = 5;
            this.btnApagar.Font = new System.Drawing.Font("Stencil", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(352, 345);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(148, 68);
            this.btnApagar.TabIndex = 20;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnEditar.FlatAppearance.BorderSize = 5;
            this.btnEditar.Font = new System.Drawing.Font("Stencil", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(182, 345);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(164, 68);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(291, 12);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 24);
            this.lblId.TabIndex = 19;
            this.lblId.Visible = false;
            // 
            // CadastroPlanta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(831, 416);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroPlanta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Planta";
            this.Load += new System.EventHandler(this.CadastroPlanta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mtxtPeso;
        private System.Windows.Forms.MaskedTextBox mtxtAltura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Peso;
        private System.Windows.Forms.Label Altura;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblId;
    }
}

