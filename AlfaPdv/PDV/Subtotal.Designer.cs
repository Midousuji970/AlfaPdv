namespace AlfaPdv.PDV
{
    partial class Subtotal
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
            label1 = new Label();
            btnCanItem = new Button();
            button2 = new Button();
            btnFimVenda = new Button();
            button5 = new Button();
            btnFimSessao = new Button();
            button7 = new Button();
            button8 = new Button();
            picBox1 = new PictureBox();
            pnlSub = new Panel();
            tbPlEsquerdoPropa = new TableLayoutPanel();
            tbPlEsquerdaButons = new TableLayoutPanel();
            button6 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbTotal = new Label();
            mtxtPes = new MaskedTextBox();
            dgvPes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)picBox1).BeginInit();
            pnlSub.SuspendLayout();
            tbPlEsquerdoPropa.SuspendLayout();
            tbPlEsquerdaButons.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(46, 51, 73);
            label1.Location = new Point(616, 11);
            label1.Name = "label1";
            label1.Size = new Size(209, 29);
            label1.TabIndex = 7;
            label1.Text = "Digite o Produto:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnCanItem
            // 
            btnCanItem.Dock = DockStyle.Fill;
            btnCanItem.Location = new Point(3, 3);
            btnCanItem.Name = "btnCanItem";
            btnCanItem.Size = new Size(75, 59);
            btnCanItem.TabIndex = 10;
            btnCanItem.Text = "Cancelar Item\r\n(F1)";
            btnCanItem.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(84, 3);
            button2.Name = "button2";
            button2.Size = new Size(75, 59);
            button2.TabIndex = 11;
            button2.Text = "Consultar Produto\r\n(F2)";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnFimVenda
            // 
            btnFimVenda.Dock = DockStyle.Fill;
            btnFimVenda.Location = new Point(246, 3);
            btnFimVenda.Name = "btnFimVenda";
            btnFimVenda.Size = new Size(75, 59);
            btnFimVenda.TabIndex = 12;
            btnFimVenda.Text = "Finalizar Venda\r\n(F4)";
            btnFimVenda.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.Location = new Point(165, 3);
            button5.Name = "button5";
            button5.Size = new Size(75, 59);
            button5.TabIndex = 14;
            button5.Text = "Adicionar CPF\r\n(F3)";
            button5.UseVisualStyleBackColor = true;
            // 
            // btnFimSessao
            // 
            btnFimSessao.Dock = DockStyle.Fill;
            btnFimSessao.Location = new Point(246, 68);
            btnFimSessao.Name = "btnFimSessao";
            btnFimSessao.Size = new Size(75, 60);
            btnFimSessao.TabIndex = 20;
            btnFimSessao.Text = "Finalizar Sessão\r\n(F8)";
            btnFimSessao.UseVisualStyleBackColor = true;
            btnFimSessao.Click += btnFimSessao_Click;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Fill;
            button7.Location = new Point(165, 68);
            button7.Name = "button7";
            button7.Size = new Size(75, 60);
            button7.TabIndex = 22;
            button7.Text = "Resumo Diário(F7)";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Fill;
            button8.Location = new Point(84, 68);
            button8.Name = "button8";
            button8.Size = new Size(75, 60);
            button8.TabIndex = 23;
            button8.Text = "Troca de Operador\n(F6)";
            button8.UseVisualStyleBackColor = true;
            // 
            // picBox1
            // 
            picBox1.Dock = DockStyle.Fill;
            picBox1.Location = new Point(3, 3);
            picBox1.Name = "picBox1";
            picBox1.Size = new Size(324, 538);
            picBox1.TabIndex = 26;
            picBox1.TabStop = false;
            // 
            // pnlSub
            // 
            pnlSub.AutoSize = true;
            pnlSub.Controls.Add(label1);
            pnlSub.Controls.Add(tbPlEsquerdoPropa);
            pnlSub.Controls.Add(tableLayoutPanel1);
            pnlSub.Dock = DockStyle.Fill;
            pnlSub.Location = new Point(0, 0);
            pnlSub.Name = "pnlSub";
            pnlSub.Size = new Size(1264, 681);
            pnlSub.TabIndex = 28;
            // 
            // tbPlEsquerdoPropa
            // 
            tbPlEsquerdoPropa.BackColor = SystemColors.ActiveCaption;
            tbPlEsquerdoPropa.ColumnCount = 1;
            tbPlEsquerdoPropa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tbPlEsquerdoPropa.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tbPlEsquerdoPropa.Controls.Add(picBox1, 0, 0);
            tbPlEsquerdoPropa.Controls.Add(tbPlEsquerdaButons, 0, 1);
            tbPlEsquerdoPropa.Dock = DockStyle.Left;
            tbPlEsquerdoPropa.Location = new Point(0, 0);
            tbPlEsquerdoPropa.Name = "tbPlEsquerdoPropa";
            tbPlEsquerdoPropa.RowCount = 2;
            tbPlEsquerdoPropa.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tbPlEsquerdoPropa.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tbPlEsquerdoPropa.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tbPlEsquerdoPropa.Size = new Size(330, 681);
            tbPlEsquerdoPropa.TabIndex = 28;
            // 
            // tbPlEsquerdaButons
            // 
            tbPlEsquerdaButons.ColumnCount = 4;
            tbPlEsquerdaButons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbPlEsquerdaButons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbPlEsquerdaButons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbPlEsquerdaButons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbPlEsquerdaButons.Controls.Add(button6, 0, 1);
            tbPlEsquerdaButons.Controls.Add(button7, 2, 1);
            tbPlEsquerdaButons.Controls.Add(btnFimSessao, 3, 1);
            tbPlEsquerdaButons.Controls.Add(btnFimVenda, 3, 0);
            tbPlEsquerdaButons.Controls.Add(button8, 1, 1);
            tbPlEsquerdaButons.Controls.Add(btnCanItem, 0, 0);
            tbPlEsquerdaButons.Controls.Add(button2, 1, 0);
            tbPlEsquerdaButons.Controls.Add(button5, 2, 0);
            tbPlEsquerdaButons.Dock = DockStyle.Fill;
            tbPlEsquerdaButons.Location = new Point(3, 547);
            tbPlEsquerdaButons.Name = "tbPlEsquerdaButons";
            tbPlEsquerdaButons.RowCount = 2;
            tbPlEsquerdaButons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbPlEsquerdaButons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbPlEsquerdaButons.Size = new Size(324, 131);
            tbPlEsquerdaButons.TabIndex = 27;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.Location = new Point(3, 68);
            button6.Name = "button6";
            button6.Size = new Size(75, 60);
            button6.TabIndex = 21;
            button6.Text = "Consultar Pagamen(F4)";
            button6.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lbTotal, 0, 2);
            tableLayoutPanel1.Controls.Add(mtxtPes, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvPes, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Right;
            tableLayoutPanel1.Location = new Point(330, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.37878F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 74.45323F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1679859F));
            tableLayoutPanel1.Size = new Size(934, 681);
            tableLayoutPanel1.TabIndex = 29;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Dock = DockStyle.Right;
            lbTotal.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotal.Location = new Point(786, 604);
            lbTotal.Name = "lbTotal";
            lbTotal.RightToLeft = RightToLeft.Yes;
            lbTotal.Size = new Size(145, 77);
            lbTotal.TabIndex = 18;
            lbTotal.Text = "00.00";
            // 
            // mtxtPes
            // 
            mtxtPes.BackColor = SystemColors.Control;
            mtxtPes.Dock = DockStyle.Bottom;
            mtxtPes.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            mtxtPes.HidePromptOnLeave = true;
            mtxtPes.Location = new Point(3, 51);
            mtxtPes.Name = "mtxtPes";
            mtxtPes.Size = new Size(928, 43);
            mtxtPes.TabIndex = 10;
            mtxtPes.TextAlign = HorizontalAlignment.Right;
            // 
            // dgvPes
            // 
            dgvPes.AllowUserToAddRows = false;
            dgvPes.AllowUserToDeleteRows = false;
            dgvPes.AllowUserToResizeColumns = false;
            dgvPes.AllowUserToResizeRows = false;
            dgvPes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPes.BackgroundColor = SystemColors.ActiveCaption;
            dgvPes.BorderStyle = BorderStyle.None;
            dgvPes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPes.Dock = DockStyle.Fill;
            dgvPes.Enabled = false;
            dgvPes.Location = new Point(3, 100);
            dgvPes.Name = "dgvPes";
            dgvPes.ReadOnly = true;
            dgvPes.RowTemplate.Height = 25;
            dgvPes.Size = new Size(928, 501);
            dgvPes.TabIndex = 9;
            // 
            // Subtotal
            // 
            ClientSize = new Size(1264, 681);
            Controls.Add(pnlSub);
            Name = "Subtotal";
            ((System.ComponentModel.ISupportInitialize)picBox1).EndInit();
            pnlSub.ResumeLayout(false);
            pnlSub.PerformLayout();
            tbPlEsquerdoPropa.ResumeLayout(false);
            tbPlEsquerdaButons.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtPesq;
        private Button btnCanItem;
        private Button button2;
        private Button btnFimVenda;
        private Button button5;
        private Button btnFimSessao;
        private Button button7;
        private Button button8;
        private PictureBox picBox1;
        private Panel pnlSub;
        private TableLayoutPanel tbPlEsquerdoPropa;
        private Button button6;
        private TableLayoutPanel tbPlEsquerdaButons;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbTotal;
        private MaskedTextBox mtxtPes;
        private DataGridView dgvPes;
    }
}