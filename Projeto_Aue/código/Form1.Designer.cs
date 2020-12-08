
using System;
using System.Windows.Forms;

namespace AuE_Solucoes
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.btnBusca = new System.Windows.Forms.Button();
            this.btnExclui = new System.Windows.Forms.Button();
            this.btnInclui = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.lblCodContato = new System.Windows.Forms.Label();
            this.txtCodContato = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mkData = new System.Windows.Forms.MaskedTextBox();
            this.btnAltera = new System.Windows.Forms.Button();
            this.dgvContatosPorCidade = new System.Windows.Forms.DataGridView();
            this.Cidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contatos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvContatosPorMes = new System.Windows.Forms.DataGridView();
            this.Cidade2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meseano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContatosMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalContatos = new System.Windows.Forms.DataGridView();
            this.TotalContatos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpaFormulario = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatosPorCidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatosPorMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalContatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(110, 48);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(110, 128);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 1;
            this.lblCidade.Text = "Cidade";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(110, 86);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 3;
            this.lblSexo.Text = "Sexo";
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(29, 39);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(75, 23);
            this.btnBusca.TabIndex = 6;
            this.btnBusca.Text = "BUSCA";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.BtnBusca_Click);
            // 
            // btnExclui
            // 
            this.btnExclui.Location = new System.Drawing.Point(600, 35);
            this.btnExclui.Name = "btnExclui";
            this.btnExclui.Size = new System.Drawing.Size(75, 33);
            this.btnExclui.TabIndex = 7;
            this.btnExclui.Text = "EXCLUI";
            this.btnExclui.UseVisualStyleBackColor = true;
            this.btnExclui.Click += new System.EventHandler(this.BtnExclui_Click);
            // 
            // btnInclui
            // 
            this.btnInclui.Location = new System.Drawing.Point(695, 36);
            this.btnInclui.Name = "btnInclui";
            this.btnInclui.Size = new System.Drawing.Size(75, 30);
            this.btnInclui.TabIndex = 8;
            this.btnInclui.Text = "INCLUI";
            this.btnInclui.UseVisualStyleBackColor = true;
            this.btnInclui.Click += new System.EventHandler(this.BtnInclui_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(180, 48);
            this.txtNome.Name = "txtNome";
            this.txtNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNome.Size = new System.Drawing.Size(247, 20);
            this.txtNome.TabIndex = 9;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(180, 128);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCidade.Size = new System.Drawing.Size(247, 20);
            this.txtCidade.TabIndex = 10;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.cmbSexo.Location = new System.Drawing.Point(180, 86);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbSexo.Size = new System.Drawing.Size(247, 21);
            this.cmbSexo.TabIndex = 11;
            // 
            // lblCodContato
            // 
            this.lblCodContato.AutoSize = true;
            this.lblCodContato.Location = new System.Drawing.Point(600, 195);
            this.lblCodContato.Name = "lblCodContato";
            this.lblCodContato.Size = new System.Drawing.Size(63, 13);
            this.lblCodContato.TabIndex = 12;
            this.lblCodContato.Text = "CodContato";
            // 
            // txtCodContato
            // 
            this.txtCodContato.Location = new System.Drawing.Point(690, 192);
            this.txtCodContato.Name = "txtCodContato";
            this.txtCodContato.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCodContato.Size = new System.Drawing.Size(80, 20);
            this.txtCodContato.TabIndex = 13;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(110, 165);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 14;
            this.lblData.Text = "Data";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 49);
            this.button1.TabIndex = 16;
            this.button1.Text = "Contar Número de contatos por cidade";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // mkData
            // 
            this.mkData.Location = new System.Drawing.Point(180, 165);
            this.mkData.Mask = "00/00/0000";
            this.mkData.Name = "mkData";
            this.mkData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mkData.Size = new System.Drawing.Size(247, 20);
            this.mkData.TabIndex = 20;
            this.mkData.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mkData_MaskInputRejected);
            // 
            // btnAltera
            // 
            this.btnAltera.Location = new System.Drawing.Point(124, 39);
            this.btnAltera.Name = "btnAltera";
            this.btnAltera.Size = new System.Drawing.Size(75, 23);
            this.btnAltera.TabIndex = 21;
            this.btnAltera.Text = "ALTERA";
            this.btnAltera.UseVisualStyleBackColor = true;
            this.btnAltera.Click += new System.EventHandler(this.BtnAltera_Click);
            // 
            // dgvContatosPorCidade
            // 
            this.dgvContatosPorCidade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContatosPorCidade.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContatosPorCidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContatosPorCidade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cidades,
            this.Contatos});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContatosPorCidade.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContatosPorCidade.Location = new System.Drawing.Point(12, 346);
            this.dgvContatosPorCidade.Name = "dgvContatosPorCidade";
            this.dgvContatosPorCidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvContatosPorCidade.Size = new System.Drawing.Size(328, 249);
            this.dgvContatosPorCidade.TabIndex = 22;
            this.dgvContatosPorCidade.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContatosPorCidade_CellContentClick);
            // 
            // Cidades
            // 
            this.Cidades.HeaderText = "Cidade";
            this.Cidades.Name = "Cidades";
            // 
            // Contatos
            // 
            this.Contatos.HeaderText = "Contatos por cidade";
            this.Contatos.Name = "Contatos";
            // 
            // dgvContatosPorMes
            // 
            this.dgvContatosPorMes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContatosPorMes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContatosPorMes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContatosPorMes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cidade2,
            this.meseano,
            this.ContatosMes});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContatosPorMes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvContatosPorMes.Location = new System.Drawing.Point(372, 346);
            this.dgvContatosPorMes.Name = "dgvContatosPorMes";
            this.dgvContatosPorMes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvContatosPorMes.Size = new System.Drawing.Size(420, 249);
            this.dgvContatosPorMes.TabIndex = 23;
            // 
            // Cidade2
            // 
            this.Cidade2.HeaderText = "Cidade";
            this.Cidade2.Name = "Cidade2";
            // 
            // meseano
            // 
            this.meseano.HeaderText = "Mês e ano";
            this.meseano.Name = "meseano";
            // 
            // ContatosMes
            // 
            this.ContatosMes.HeaderText = "Contatos por mês";
            this.ContatosMes.Name = "ContatosMes";
            // 
            // dgvTotalContatos
            // 
            this.dgvTotalContatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTotalContatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTotalContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotalContatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TotalContatos});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTotalContatos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTotalContatos.Location = new System.Drawing.Point(471, 259);
            this.dgvTotalContatos.Name = "dgvTotalContatos";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTotalContatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTotalContatos.Size = new System.Drawing.Size(219, 70);
            this.dgvTotalContatos.TabIndex = 24;
            // 
            // TotalContatos
            // 
            this.TotalContatos.HeaderText = "Total de Contatos";
            this.TotalContatos.Name = "TotalContatos";
            // 
            // btnLimpaFormulario
            // 
            this.btnLimpaFormulario.Location = new System.Drawing.Point(110, 205);
            this.btnLimpaFormulario.Name = "btnLimpaFormulario";
            this.btnLimpaFormulario.Size = new System.Drawing.Size(174, 23);
            this.btnLimpaFormulario.TabIndex = 25;
            this.btnLimpaFormulario.Text = "LIMPA FORMULÁRIO";
            this.btnLimpaFormulario.UseVisualStyleBackColor = true;
            this.btnLimpaFormulario.Click += new System.EventHandler(this.btnLimpaFormulario_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAltera);
            this.groupBox1.Controls.Add(this.btnBusca);
            this.groupBox1.Location = new System.Drawing.Point(571, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 62);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 580);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimpaFormulario);
            this.Controls.Add(this.dgvTotalContatos);
            this.Controls.Add(this.dgvContatosPorMes);
            this.Controls.Add(this.dgvContatosPorCidade);
            this.Controls.Add(this.mkData);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtCodContato);
            this.Controls.Add(this.lblCodContato);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnInclui);
            this.Controls.Add(this.btnExclui);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TransparencyKey = System.Drawing.SystemColors.ControlLight;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatosPorCidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatosPorMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalContatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dgvContatosPorCidade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Button btnExclui;
        private System.Windows.Forms.Button btnInclui;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label lblCodContato;
        private System.Windows.Forms.TextBox txtCodContato;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mkData;
        private System.Windows.Forms.Button btnAltera;
        private System.Windows.Forms.DataGridView dgvContatosPorCidade;
        private System.Windows.Forms.DataGridView dgvContatosPorMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade2;
        private System.Windows.Forms.DataGridViewTextBoxColumn meseano;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContatosMes;
        private System.Windows.Forms.DataGridView dgvTotalContatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalContatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contatos;
        private Button btnLimpaFormulario;
        private GroupBox groupBox1;
        private ToolTip toolTip1;
    }
}

