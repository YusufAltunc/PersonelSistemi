namespace Personel_Kayıt
{
    partial class FrmAnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskmaas = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmeslek = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbsehir = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btngrafik = new System.Windows.Forms.Button();
            this.btnistatistik = new System.Windows.Forms.Button();
            this.btntemizlik = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perdurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.permeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bospersonelveritabaniDataSet = new Personel_Kayıt.bospersonelveritabaniDataSet();
            this.tbl_PersonelTableAdapter = new Personel_Kayıt.bospersonelveritabaniDataSetTableAdapters.Tbl_PersonelTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bospersonelveritabaniDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskmaas);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtmeslek);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbsehir);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(501, 431);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // mskmaas
            // 
            this.mskmaas.Location = new System.Drawing.Point(209, 220);
            this.mskmaas.Mask = "0000";
            this.mskmaas.Name = "mskmaas";
            this.mskmaas.Size = new System.Drawing.Size(129, 30);
            this.mskmaas.TabIndex = 4;
            this.mskmaas.ValidatingType = typeof(int);
            this.mskmaas.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 220);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Maaş:";
            // 
            // txtmeslek
            // 
            this.txtmeslek.Location = new System.Drawing.Point(209, 321);
            this.txtmeslek.Name = "txtmeslek";
            this.txtmeslek.Size = new System.Drawing.Size(129, 30);
            this.txtmeslek.TabIndex = 5;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(254, 277);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 29);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bekar";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(184, 277);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 29);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Evli";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 324);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Meslek:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 277);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Şehir:";
            // 
            // cmbsehir
            // 
            this.cmbsehir.FormattingEnabled = true;
            this.cmbsehir.Location = new System.Drawing.Point(209, 173);
            this.cmbsehir.Name = "cmbsehir";
            this.cmbsehir.Size = new System.Drawing.Size(129, 33);
            this.cmbsehir.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Şehir:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(209, 39);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(129, 30);
            this.txtid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel İd:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(209, 125);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(129, 30);
            this.txtsoyad.TabIndex = 2;
            this.txtsoyad.TextChanged += new System.EventHandler(this.txtsoyad_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Personel ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Soyad:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(209, 82);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(129, 30);
            this.txtad.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btngrafik);
            this.groupBox2.Controls.Add(this.btnistatistik);
            this.groupBox2.Controls.Add(this.btntemizlik);
            this.groupBox2.Controls.Add(this.btnguncelle);
            this.groupBox2.Controls.Add(this.btnsil);
            this.groupBox2.Controls.Add(this.btnkaydet);
            this.groupBox2.Controls.Add(this.btnlistele);
            this.groupBox2.Location = new System.Drawing.Point(545, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 431);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // btngrafik
            // 
            this.btngrafik.Location = new System.Drawing.Point(91, 368);
            this.btngrafik.Name = "btngrafik";
            this.btngrafik.Size = new System.Drawing.Size(144, 51);
            this.btngrafik.TabIndex = 8;
            this.btngrafik.Text = "Grafikler";
            this.btngrafik.UseVisualStyleBackColor = true;
            this.btngrafik.Click += new System.EventHandler(this.btngrafik_Click);
            // 
            // btnistatistik
            // 
            this.btnistatistik.Location = new System.Drawing.Point(91, 311);
            this.btnistatistik.Name = "btnistatistik";
            this.btnistatistik.Size = new System.Drawing.Size(144, 51);
            this.btnistatistik.TabIndex = 7;
            this.btnistatistik.Text = "İstatistik";
            this.btnistatistik.UseVisualStyleBackColor = true;
            this.btnistatistik.Click += new System.EventHandler(this.btnistatistik_Click);
            // 
            // btntemizlik
            // 
            this.btntemizlik.Location = new System.Drawing.Point(91, 258);
            this.btntemizlik.Name = "btntemizlik";
            this.btntemizlik.Size = new System.Drawing.Size(144, 51);
            this.btntemizlik.TabIndex = 6;
            this.btntemizlik.Text = "Temizlik";
            this.btntemizlik.UseVisualStyleBackColor = true;
            this.btntemizlik.Click += new System.EventHandler(this.btntemizlik_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(91, 201);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(144, 51);
            this.btnguncelle.TabIndex = 5;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(91, 144);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(144, 51);
            this.btnsil.TabIndex = 4;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(91, 87);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(144, 51);
            this.btnkaydet.TabIndex = 3;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(91, 30);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(144, 51);
            this.btnlistele.TabIndex = 2;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(16, 454);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1075, 233);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.peradDataGridViewTextBoxColumn,
            this.persoyadDataGridViewTextBoxColumn,
            this.persehirDataGridViewTextBoxColumn,
            this.permaasDataGridViewTextBoxColumn,
            this.perdurumDataGridViewCheckBoxColumn,
            this.permeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1069, 204);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "Perid";
            this.peridDataGridViewTextBoxColumn.HeaderText = "Perid";
            this.peridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            this.peridDataGridViewTextBoxColumn.ReadOnly = true;
            this.peridDataGridViewTextBoxColumn.Width = 125;
            // 
            // peradDataGridViewTextBoxColumn
            // 
            this.peradDataGridViewTextBoxColumn.DataPropertyName = "Perad";
            this.peradDataGridViewTextBoxColumn.HeaderText = "Perad";
            this.peradDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.peradDataGridViewTextBoxColumn.Name = "peradDataGridViewTextBoxColumn";
            this.peradDataGridViewTextBoxColumn.Width = 125;
            // 
            // persoyadDataGridViewTextBoxColumn
            // 
            this.persoyadDataGridViewTextBoxColumn.DataPropertyName = "Persoyad";
            this.persoyadDataGridViewTextBoxColumn.HeaderText = "Persoyad";
            this.persoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.persoyadDataGridViewTextBoxColumn.Name = "persoyadDataGridViewTextBoxColumn";
            this.persoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // persehirDataGridViewTextBoxColumn
            // 
            this.persehirDataGridViewTextBoxColumn.DataPropertyName = "Persehir";
            this.persehirDataGridViewTextBoxColumn.HeaderText = "Persehir";
            this.persehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.persehirDataGridViewTextBoxColumn.Name = "persehirDataGridViewTextBoxColumn";
            this.persehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // permaasDataGridViewTextBoxColumn
            // 
            this.permaasDataGridViewTextBoxColumn.DataPropertyName = "Permaas";
            this.permaasDataGridViewTextBoxColumn.HeaderText = "Permaas";
            this.permaasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.permaasDataGridViewTextBoxColumn.Name = "permaasDataGridViewTextBoxColumn";
            this.permaasDataGridViewTextBoxColumn.Width = 125;
            // 
            // perdurumDataGridViewCheckBoxColumn
            // 
            this.perdurumDataGridViewCheckBoxColumn.DataPropertyName = "Perdurum";
            this.perdurumDataGridViewCheckBoxColumn.HeaderText = "Perdurum";
            this.perdurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.perdurumDataGridViewCheckBoxColumn.Name = "perdurumDataGridViewCheckBoxColumn";
            this.perdurumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // permeslekDataGridViewTextBoxColumn
            // 
            this.permeslekDataGridViewTextBoxColumn.DataPropertyName = "Permeslek";
            this.permeslekDataGridViewTextBoxColumn.HeaderText = "Permeslek";
            this.permeslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.permeslekDataGridViewTextBoxColumn.Name = "permeslekDataGridViewTextBoxColumn";
            this.permeslekDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.bospersonelveritabaniDataSet;
            // 
            // bospersonelveritabaniDataSet
            // 
            this.bospersonelveritabaniDataSet.DataSetName = "bospersonelveritabaniDataSet";
            this.bospersonelveritabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(955, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "label8";
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1103, 709);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmAnaForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bospersonelveritabaniDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmeslek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskmaas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbsehir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btngrafik;
        private System.Windows.Forms.Button btnistatistik;
        private System.Windows.Forms.Button btntemizlik;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private bospersonelveritabaniDataSet bospersonelveritabaniDataSet;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private bospersonelveritabaniDataSetTableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perdurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
    }
}

