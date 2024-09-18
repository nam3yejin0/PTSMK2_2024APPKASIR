namespace Lat2Tambahan_541231155
{
    partial class FormKasir
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
            btncl = new Button();
            btnp = new Button();
            groupBox1 = new GroupBox();
            txtdrinkp = new TextBox();
            txtfudp = new TextBox();
            cbdrink = new ComboBox();
            lbldrink = new Label();
            cbfud = new ComboBox();
            lblfud = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtSubTotalMinuman = new TextBox();
            txtSubTotalMakanan = new TextBox();
            label2 = new Label();
            txtkasir = new TextBox();
            TOTAL = new Label();
            BAYAR = new Label();
            KEMBALI = new Label();
            txtpay = new TextBox();
            txtsisa = new TextBox();
            txtsum = new TextBox();
            groupBox3 = new GroupBox();
            txtSatuanMinuman = new NumericUpDown();
            txtSatuanMakanan = new NumericUpDown();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtSatuanMinuman).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSatuanMakanan).BeginInit();
            SuspendLayout();
            // 
            // btncl
            // 
            btncl.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btncl.Location = new Point(310, 449);
            btncl.Name = "btncl";
            btncl.Size = new Size(166, 84);
            btncl.TabIndex = 0;
            btncl.Text = "Clear";
            btncl.UseVisualStyleBackColor = true;
            btncl.UseWaitCursor = true;
            btncl.Click += btncl_Click;
            // 
            // btnp
            // 
            btnp.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnp.Location = new Point(494, 449);
            btnp.Name = "btnp";
            btnp.Size = new Size(166, 84);
            btnp.TabIndex = 1;
            btnp.Text = "Proses";
            btnp.UseVisualStyleBackColor = true;
            btnp.UseWaitCursor = true;
            btnp.Click += btnp_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MediumAquamarine;
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(txtdrinkp);
            groupBox1.Controls.Add(txtfudp);
            groupBox1.Controls.Add(cbdrink);
            groupBox1.Controls.Add(lbldrink);
            groupBox1.Controls.Add(cbfud);
            groupBox1.Controls.Add(lblfud);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(29, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(411, 140);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pesan";
            groupBox1.UseWaitCursor = true;
            // 
            // txtdrinkp
            // 
            txtdrinkp.ForeColor = SystemColors.ScrollBar;
            txtdrinkp.Location = new Point(243, 89);
            txtdrinkp.Name = "txtdrinkp";
            txtdrinkp.Size = new Size(139, 28);
            txtdrinkp.TabIndex = 1;
            txtdrinkp.Text = "0";
            txtdrinkp.UseWaitCursor = true;
            // 
            // txtfudp
            // 
            txtfudp.ForeColor = SystemColors.ScrollBar;
            txtfudp.Location = new Point(243, 35);
            txtfudp.Name = "txtfudp";
            txtfudp.Size = new Size(139, 28);
            txtfudp.TabIndex = 0;
            txtfudp.Text = "0";
            txtfudp.UseWaitCursor = true;
            txtfudp.TextChanged += txtfudp_TextChanged;
            // 
            // cbdrink
            // 
            cbdrink.FormattingEnabled = true;
            cbdrink.Location = new Point(95, 90);
            cbdrink.Name = "cbdrink";
            cbdrink.Size = new Size(116, 29);
            cbdrink.TabIndex = 3;
            cbdrink.UseWaitCursor = true;
            cbdrink.SelectedIndexChanged += cbdrink_SelectedIndexChanged;
            // 
            // lbldrink
            // 
            lbldrink.AutoSize = true;
            lbldrink.Location = new Point(6, 93);
            lbldrink.Name = "lbldrink";
            lbldrink.Size = new Size(83, 21);
            lbldrink.TabIndex = 2;
            lbldrink.Text = "Minuman";
            lbldrink.UseWaitCursor = true;
            // 
            // cbfud
            // 
            cbfud.FormattingEnabled = true;
            cbfud.Location = new Point(95, 34);
            cbfud.Name = "cbfud";
            cbfud.Size = new Size(116, 29);
            cbfud.TabIndex = 1;
            cbfud.UseWaitCursor = true;
            cbfud.SelectedIndexChanged += cbfud_SelectedIndexChanged;
            // 
            // lblfud
            // 
            lblfud.AutoSize = true;
            lblfud.Location = new Point(6, 37);
            lblfud.Name = "lblfud";
            lblfud.Size = new Size(84, 21);
            lblfud.TabIndex = 0;
            lblfud.Text = "Makanan";
            lblfud.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 32);
            label1.Name = "label1";
            label1.Size = new Size(497, 62);
            label1.TabIndex = 3;
            label1.Text = "WARUNG APACOBA";
            label1.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.MediumAquamarine;
            groupBox2.BackgroundImageLayout = ImageLayout.None;
            groupBox2.Controls.Add(txtSubTotalMinuman);
            groupBox2.Controls.Add(txtSubTotalMakanan);
            groupBox2.FlatStyle = FlatStyle.Popup;
            groupBox2.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(634, 116);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(287, 140);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sub Total";
            groupBox2.UseWaitCursor = true;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // txtSubTotalMinuman
            // 
            txtSubTotalMinuman.ForeColor = SystemColors.ScrollBar;
            txtSubTotalMinuman.Location = new Point(15, 89);
            txtSubTotalMinuman.Name = "txtSubTotalMinuman";
            txtSubTotalMinuman.Size = new Size(251, 28);
            txtSubTotalMinuman.TabIndex = 5;
            txtSubTotalMinuman.Text = "0";
            txtSubTotalMinuman.UseWaitCursor = true;
            txtSubTotalMinuman.TextChanged += txtSubTotalMinuman_TextChanged;
            // 
            // txtSubTotalMakanan
            // 
            txtSubTotalMakanan.ForeColor = SystemColors.ScrollBar;
            txtSubTotalMakanan.Location = new Point(15, 35);
            txtSubTotalMakanan.Name = "txtSubTotalMakanan";
            txtSubTotalMakanan.Size = new Size(251, 28);
            txtSubTotalMakanan.TabIndex = 4;
            txtSubTotalMakanan.Text = "0";
            txtSubTotalMakanan.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(35, 303);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 4;
            label2.Text = "Nama Kasir";
            label2.UseWaitCursor = true;
            // 
            // txtkasir
            // 
            txtkasir.Location = new Point(35, 339);
            txtkasir.Name = "txtkasir";
            txtkasir.Size = new Size(183, 27);
            txtkasir.TabIndex = 5;
            txtkasir.UseWaitCursor = true;
            // 
            // TOTAL
            // 
            TOTAL.AutoSize = true;
            TOTAL.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TOTAL.Location = new Point(662, 305);
            TOTAL.Name = "TOTAL";
            TOTAL.Size = new Size(68, 21);
            TOTAL.TabIndex = 6;
            TOTAL.Text = "TOTAL";
            TOTAL.UseWaitCursor = true;
            // 
            // BAYAR
            // 
            BAYAR.AutoSize = true;
            BAYAR.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BAYAR.Location = new Point(662, 343);
            BAYAR.Name = "BAYAR";
            BAYAR.Size = new Size(67, 21);
            BAYAR.TabIndex = 7;
            BAYAR.Text = "BAYAR";
            BAYAR.UseWaitCursor = true;
            // 
            // KEMBALI
            // 
            KEMBALI.AutoSize = true;
            KEMBALI.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            KEMBALI.Location = new Point(661, 382);
            KEMBALI.Name = "KEMBALI";
            KEMBALI.Size = new Size(86, 21);
            KEMBALI.TabIndex = 8;
            KEMBALI.Text = "KEMBALI";
            KEMBALI.UseWaitCursor = true;
            // 
            // txtpay
            // 
            txtpay.ForeColor = SystemColors.InfoText;
            txtpay.Location = new Point(755, 337);
            txtpay.Name = "txtpay";
            txtpay.Size = new Size(166, 27);
            txtpay.TabIndex = 9;
            txtpay.Text = "0";
            txtpay.UseWaitCursor = true;
            txtpay.TextChanged += txtpay_TextChanged;
            // 
            // txtsisa
            // 
            txtsisa.ForeColor = SystemColors.ScrollBar;
            txtsisa.Location = new Point(755, 376);
            txtsisa.Name = "txtsisa";
            txtsisa.Size = new Size(166, 27);
            txtsisa.TabIndex = 10;
            txtsisa.Text = "0";
            txtsisa.UseWaitCursor = true;
            // 
            // txtsum
            // 
            txtsum.ForeColor = SystemColors.ScrollBar;
            txtsum.Location = new Point(755, 299);
            txtsum.Name = "txtsum";
            txtsum.Size = new Size(166, 27);
            txtsum.TabIndex = 11;
            txtsum.Text = "0";
            txtsum.UseWaitCursor = true;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.MediumAquamarine;
            groupBox3.BackgroundImageLayout = ImageLayout.None;
            groupBox3.Controls.Add(txtSatuanMinuman);
            groupBox3.Controls.Add(txtSatuanMakanan);
            groupBox3.Controls.Add(label4);
            groupBox3.FlatStyle = FlatStyle.Popup;
            groupBox3.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.ForeColor = SystemColors.ActiveCaptionText;
            groupBox3.Location = new Point(460, 116);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(155, 140);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Satuan";
            groupBox3.UseWaitCursor = true;
            groupBox3.Enter += groupBox3_Enter;
            // 
            // txtSatuanMinuman
            // 
            txtSatuanMinuman.Location = new Point(14, 90);
            txtSatuanMinuman.Name = "txtSatuanMinuman";
            txtSatuanMinuman.Size = new Size(126, 28);
            txtSatuanMinuman.TabIndex = 2;
            txtSatuanMinuman.UseWaitCursor = true;
            txtSatuanMinuman.ValueChanged += txtSatuanMinuman_ValueChanged;
            // 
            // txtSatuanMakanan
            // 
            txtSatuanMakanan.Location = new Point(14, 35);
            txtSatuanMakanan.Name = "txtSatuanMakanan";
            txtSatuanMakanan.Size = new Size(126, 28);
            txtSatuanMakanan.TabIndex = 0;
            txtSatuanMakanan.UseWaitCursor = true;
            txtSatuanMakanan.ValueChanged += txtSatuanMakanan_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 37);
            label4.Name = "label4";
            label4.Size = new Size(0, 21);
            label4.TabIndex = 0;
            label4.UseWaitCursor = true;
            // 
            // FormKasir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(933, 545);
            Controls.Add(groupBox3);
            Controls.Add(txtsum);
            Controls.Add(txtsisa);
            Controls.Add(txtpay);
            Controls.Add(KEMBALI);
            Controls.Add(BAYAR);
            Controls.Add(TOTAL);
            Controls.Add(txtkasir);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(btnp);
            Controls.Add(btncl);
            Name = "FormKasir";
            Text = "FormKasir";
            UseWaitCursor = true;
            Load += FormKasir_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtSatuanMinuman).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSatuanMakanan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncl;
        private Button btnp;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cbdrink;
        private Label lbldrink;
        private ComboBox cbfud;
        private Label lblfud;
        private GroupBox groupBox2;
        private TextBox txtdrinkp;
        private TextBox txtfudp;
        private Label label2;
        private TextBox txtkasir;
        private Label TOTAL;
        private Label BAYAR;
        private Label KEMBALI;
        private TextBox txtpay;
        private TextBox txtsisa;
        private TextBox txtsum;
        private GroupBox groupBox3;
        private Label label4;
        private NumericUpDown txtSatuanMinuman;
        private NumericUpDown txtSatuanMakanan;
        private TextBox txtSubTotalMinuman;
        private TextBox txtSubTotalMakanan;
    }
}