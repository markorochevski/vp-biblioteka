namespace vp_proektna_biblioteka
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lbKnigi = new System.Windows.Forms.ListBox();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksDataSet = new vp_proektna_biblioteka.BooksDataSet();
            this.booksTableAdapter = new vp_proektna_biblioteka.BooksDataSetTableAdapters.BooksTableAdapter();
            this.tableAdapterManager = new vp_proektna_biblioteka.BooksDataSetTableAdapters.TableAdapterManager();
            this.tbPrebaraj = new System.Windows.Forms.TextBox();
            this.btnPrebaraj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbKosnicka = new System.Windows.Forms.ListBox();
            this.btnNaracaj = new System.Windows.Forms.Button();
            this.btnDetali = new System.Windows.Forms.Button();
            this.btnOtstraniKosnicka = new System.Windows.Forms.Button();
            this.btnDodadiKniga = new System.Windows.Forms.Button();
            this.btnDodadiKosnicka = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbPrebaruvanje = new System.Windows.Forms.RadioButton();
            this.rbCelosna = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbKnigi
            // 
            this.lbKnigi.FormattingEnabled = true;
            this.lbKnigi.Location = new System.Drawing.Point(6, 19);
            this.lbKnigi.Name = "lbKnigi";
            this.lbKnigi.Size = new System.Drawing.Size(236, 173);
            this.lbKnigi.TabIndex = 0;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.booksDataSet;
            // 
            // booksDataSet
            // 
            this.booksDataSet.DataSetName = "BooksDataSet";
            this.booksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BooksTableAdapter = this.booksTableAdapter;
            this.tableAdapterManager.UpdateOrder = vp_proektna_biblioteka.BooksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbPrebaraj
            // 
            this.tbPrebaraj.Location = new System.Drawing.Point(6, 19);
            this.tbPrebaraj.Name = "tbPrebaraj";
            this.tbPrebaraj.Size = new System.Drawing.Size(155, 20);
            this.tbPrebaraj.TabIndex = 1;
            // 
            // btnPrebaraj
            // 
            this.btnPrebaraj.Location = new System.Drawing.Point(167, 16);
            this.btnPrebaraj.Name = "btnPrebaraj";
            this.btnPrebaraj.Size = new System.Drawing.Size(75, 23);
            this.btnPrebaraj.TabIndex = 2;
            this.btnPrebaraj.Text = "Пребарај";
            this.btnPrebaraj.UseVisualStyleBackColor = true;
            this.btnPrebaraj.Click += new System.EventHandler(this.btnPrebaraj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPrebaraj);
            this.groupBox1.Controls.Add(this.btnPrebaraj);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 51);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пребарување";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbKnigi);
            this.groupBox2.Location = new System.Drawing.Point(12, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 201);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Книги";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbKosnicka);
            this.groupBox3.Location = new System.Drawing.Point(266, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 258);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Кошничка";
            // 
            // lbKosnicka
            // 
            this.lbKosnicka.FormattingEnabled = true;
            this.lbKosnicka.Location = new System.Drawing.Point(3, 16);
            this.lbKosnicka.Name = "lbKosnicka";
            this.lbKosnicka.Size = new System.Drawing.Size(120, 95);
            this.lbKosnicka.TabIndex = 0;
            // 
            // btnNaracaj
            // 
            this.btnNaracaj.Location = new System.Drawing.Point(266, 317);
            this.btnNaracaj.Name = "btnNaracaj";
            this.btnNaracaj.Size = new System.Drawing.Size(259, 30);
            this.btnNaracaj.TabIndex = 1;
            this.btnNaracaj.Text = "НАРАЧАЈ";
            this.btnNaracaj.UseVisualStyleBackColor = true;
            // 
            // btnDetali
            // 
            this.btnDetali.Location = new System.Drawing.Point(147, 276);
            this.btnDetali.Name = "btnDetali";
            this.btnDetali.Size = new System.Drawing.Size(107, 23);
            this.btnDetali.TabIndex = 2;
            this.btnDetali.Text = "Прикажи детали";
            this.btnDetali.UseVisualStyleBackColor = true;
            // 
            // btnOtstraniKosnicka
            // 
            this.btnOtstraniKosnicka.Location = new System.Drawing.Point(393, 276);
            this.btnOtstraniKosnicka.Name = "btnOtstraniKosnicka";
            this.btnOtstraniKosnicka.Size = new System.Drawing.Size(132, 23);
            this.btnOtstraniKosnicka.TabIndex = 3;
            this.btnOtstraniKosnicka.Text = "Отстрани од кошничка";
            this.btnOtstraniKosnicka.UseVisualStyleBackColor = true;
            // 
            // btnDodadiKniga
            // 
            this.btnDodadiKniga.Location = new System.Drawing.Point(18, 276);
            this.btnDodadiKniga.Name = "btnDodadiKniga";
            this.btnDodadiKniga.Size = new System.Drawing.Size(107, 23);
            this.btnDodadiKniga.TabIndex = 6;
            this.btnDodadiKniga.Text = "Додади книга";
            this.btnDodadiKniga.UseVisualStyleBackColor = true;
            this.btnDodadiKniga.Click += new System.EventHandler(this.btnDodadiKniga_Click);
            // 
            // btnDodadiKosnicka
            // 
            this.btnDodadiKosnicka.Location = new System.Drawing.Point(266, 276);
            this.btnDodadiKosnicka.Name = "btnDodadiKosnicka";
            this.btnDodadiKosnicka.Size = new System.Drawing.Size(121, 23);
            this.btnDodadiKosnicka.TabIndex = 7;
            this.btnDodadiKosnicka.Text = "Додади во кошничка";
            this.btnDodadiKosnicka.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbPrebaruvanje);
            this.groupBox4.Controls.Add(this.rbCelosna);
            this.groupBox4.Location = new System.Drawing.Point(18, 308);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(236, 47);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Прикажи резултати од:";
            // 
            // rbPrebaruvanje
            // 
            this.rbPrebaruvanje.AutoSize = true;
            this.rbPrebaruvanje.Location = new System.Drawing.Point(129, 22);
            this.rbPrebaruvanje.Name = "rbPrebaruvanje";
            this.rbPrebaruvanje.Size = new System.Drawing.Size(96, 17);
            this.rbPrebaruvanje.TabIndex = 1;
            this.rbPrebaruvanje.Text = "Пребарување";
            this.rbPrebaruvanje.UseVisualStyleBackColor = true;
            // 
            // rbCelosna
            // 
            this.rbCelosna.AutoSize = true;
            this.rbCelosna.Checked = true;
            this.rbCelosna.Location = new System.Drawing.Point(6, 22);
            this.rbCelosna.Name = "rbCelosna";
            this.rbCelosna.Size = new System.Drawing.Size(101, 17);
            this.rbCelosna.TabIndex = 0;
            this.rbCelosna.TabStop = true;
            this.rbCelosna.Text = "Целосна листа";
            this.rbCelosna.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 367);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnDodadiKosnicka);
            this.Controls.Add(this.btnDodadiKniga);
            this.Controls.Add(this.btnNaracaj);
            this.Controls.Add(this.btnDetali);
            this.Controls.Add(this.btnOtstraniKosnicka);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbKnigi;
        private BooksDataSet booksDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private BooksDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private BooksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tbPrebaraj;
        private System.Windows.Forms.Button btnPrebaraj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnNaracaj;
        private System.Windows.Forms.Button btnDetali;
        private System.Windows.Forms.Button btnOtstraniKosnicka;
        private System.Windows.Forms.Button btnDodadiKniga;
        private System.Windows.Forms.Button btnDodadiKosnicka;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbPrebaruvanje;
        private System.Windows.Forms.RadioButton rbCelosna;
        private System.Windows.Forms.ListBox lbKosnicka;
    }
}

