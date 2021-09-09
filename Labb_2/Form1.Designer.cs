namespace Labb_2
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
            this.läggTillStudent = new System.Windows.Forms.Button();
            this.txtNamn = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.visaStudenter = new System.Windows.Forms.DataGridView();
            this.listLärare = new System.Windows.Forms.DataGridView();
            this.txtKursNamn = new System.Windows.Forms.TextBox();
            this.labelKursNamn = new System.Windows.Forms.Label();
            this.btnLäggTillKurs = new System.Windows.Forms.Button();
            this.txtKursID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBetyg = new System.Windows.Forms.TextBox();
            this.btnLäggtillLaboration = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLabbID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLabbNamn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ListaLabbar6 = new System.Windows.Forms.DataGridView();
            this.dataGridViewKurser = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSignatur = new System.Windows.Forms.TextBox();
            this.btnTaBortKurs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.visaStudenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listLärare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaLabbar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKurser)).BeginInit();
            this.SuspendLayout();
            // 
            // läggTillStudent
            // 
            this.läggTillStudent.Location = new System.Drawing.Point(510, 146);
            this.läggTillStudent.Name = "läggTillStudent";
            this.läggTillStudent.Size = new System.Drawing.Size(221, 133);
            this.läggTillStudent.TabIndex = 6;
            this.läggTillStudent.Text = " Lägg till studenter";
            this.läggTillStudent.UseVisualStyleBackColor = true;
            this.läggTillStudent.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNamn
            // 
            this.txtNamn.Location = new System.Drawing.Point(548, 16);
            this.txtNamn.Name = "txtNamn";
            this.txtNamn.Size = new System.Drawing.Size(421, 20);
            this.txtNamn.TabIndex = 1;
            this.txtNamn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(737, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 133);
            this.button2.TabIndex = 7;
            this.button2.Text = "Lägg till lärare";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Namn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personnummer";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPersNum
            // 
            this.txtPersNum.Location = new System.Drawing.Point(589, 42);
            this.txtPersNum.Name = "txtPersNum";
            this.txtPersNum.Size = new System.Drawing.Size(380, 20);
            this.txtPersNum.TabIndex = 3;
            this.txtPersNum.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(510, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(548, 68);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(421, 20);
            this.txtID.TabIndex = 5;
            this.txtID.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // visaStudenter
            // 
            this.visaStudenter.AllowDrop = true;
            this.visaStudenter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visaStudenter.Location = new System.Drawing.Point(975, 16);
            this.visaStudenter.Name = "visaStudenter";
            this.visaStudenter.Size = new System.Drawing.Size(459, 263);
            this.visaStudenter.TabIndex = 9;
            this.visaStudenter.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.visaStudentet_CellContentClick);
            this.visaStudenter.SelectionChanged += new System.EventHandler(this.visaStudenter_SelectionChanged);
            // 
            // listLärare
            // 
            this.listLärare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listLärare.Location = new System.Drawing.Point(975, 292);
            this.listLärare.Name = "listLärare";
            this.listLärare.Size = new System.Drawing.Size(459, 253);
            this.listLärare.TabIndex = 11;
            this.listLärare.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listLärare_CellContentClick);
            // 
            // txtKursNamn
            // 
            this.txtKursNamn.Location = new System.Drawing.Point(70, 16);
            this.txtKursNamn.Name = "txtKursNamn";
            this.txtKursNamn.Size = new System.Drawing.Size(401, 20);
            this.txtKursNamn.TabIndex = 13;
            this.txtKursNamn.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // labelKursNamn
            // 
            this.labelKursNamn.AutoSize = true;
            this.labelKursNamn.Location = new System.Drawing.Point(7, 13);
            this.labelKursNamn.Name = "labelKursNamn";
            this.labelKursNamn.Size = new System.Drawing.Size(57, 13);
            this.labelKursNamn.TabIndex = 14;
            this.labelKursNamn.Text = "Kurs namn";
            // 
            // btnLäggTillKurs
            // 
            this.btnLäggTillKurs.Location = new System.Drawing.Point(11, 68);
            this.btnLäggTillKurs.Name = "btnLäggTillKurs";
            this.btnLäggTillKurs.Size = new System.Drawing.Size(460, 39);
            this.btnLäggTillKurs.TabIndex = 15;
            this.btnLäggTillKurs.Text = " Lägg till kurs";
            this.btnLäggTillKurs.UseVisualStyleBackColor = true;
            this.btnLäggTillKurs.Click += new System.EventHandler(this.btnLäggTillKurs_Click);
            // 
            // txtKursID
            // 
            this.txtKursID.Location = new System.Drawing.Point(35, 42);
            this.txtKursID.Name = "txtKursID";
            this.txtKursID.Size = new System.Drawing.Size(435, 20);
            this.txtKursID.TabIndex = 16;
            this.txtKursID.TextChanged += new System.EventHandler(this.txtKursID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Betyg*";
            // 
            // txtBetyg
            // 
            this.txtBetyg.Location = new System.Drawing.Point(548, 94);
            this.txtBetyg.Name = "txtBetyg";
            this.txtBetyg.Size = new System.Drawing.Size(421, 20);
            this.txtBetyg.TabIndex = 19;
            this.txtBetyg.TextChanged += new System.EventHandler(this.txtBetyg_TextChanged);
            // 
            // btnLäggtillLaboration
            // 
            this.btnLäggtillLaboration.Location = new System.Drawing.Point(496, 334);
            this.btnLäggtillLaboration.Name = "btnLäggtillLaboration";
            this.btnLäggtillLaboration.Size = new System.Drawing.Size(473, 39);
            this.btnLäggtillLaboration.TabIndex = 20;
            this.btnLäggtillLaboration.Text = "Registrera en laboration";
            this.btnLäggtillLaboration.UseVisualStyleBackColor = true;
            this.btnLäggtillLaboration.Click += new System.EventHandler(this.btnLäggtillLaboration_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(502, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "ID";
            // 
            // txtLabbID
            // 
            this.txtLabbID.Location = new System.Drawing.Point(531, 308);
            this.txtLabbID.Name = "txtLabbID";
            this.txtLabbID.Size = new System.Drawing.Size(435, 20);
            this.txtLabbID.TabIndex = 21;
            this.txtLabbID.TextChanged += new System.EventHandler(this.txtLabbID_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(502, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Namn";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtLabbNamn
            // 
            this.txtLabbNamn.Location = new System.Drawing.Point(543, 282);
            this.txtLabbNamn.Name = "txtLabbNamn";
            this.txtLabbNamn.Size = new System.Drawing.Size(423, 20);
            this.txtLabbNamn.TabIndex = 23;
            this.txtLabbNamn.TextChanged += new System.EventHandler(this.txtLabbNamn_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(654, 830);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Namn på student:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(654, 856);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Namn på lärare:";
            // 
            // ListaLabbar6
            // 
            this.ListaLabbar6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaLabbar6.Location = new System.Drawing.Point(496, 379);
            this.ListaLabbar6.Name = "ListaLabbar6";
            this.ListaLabbar6.Size = new System.Drawing.Size(473, 166);
            this.ListaLabbar6.TabIndex = 41;
            this.ListaLabbar6.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaLabbar6_CellContentClick);
            // 
            // dataGridViewKurser
            // 
            this.dataGridViewKurser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKurser.Location = new System.Drawing.Point(9, 113);
            this.dataGridViewKurser.Name = "dataGridViewKurser";
            this.dataGridViewKurser.Size = new System.Drawing.Size(460, 163);
            this.dataGridViewKurser.TabIndex = 42;
            this.dataGridViewKurser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKurser_SelectionChanged);
            this.dataGridViewKurser.SelectionChanged += new System.EventHandler(this.dataGridViewKurser_SelectionChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(507, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Lärarsignatur*";
            // 
            // txtSignatur
            // 
            this.txtSignatur.Location = new System.Drawing.Point(585, 120);
            this.txtSignatur.Name = "txtSignatur";
            this.txtSignatur.Size = new System.Drawing.Size(384, 20);
            this.txtSignatur.TabIndex = 44;
            this.txtSignatur.TextChanged += new System.EventHandler(this.txtSignatur_TextChanged);
            // 
            // btnTaBortKurs
            // 
            this.btnTaBortKurs.Location = new System.Drawing.Point(9, 289);
            this.btnTaBortKurs.Name = "btnTaBortKurs";
            this.btnTaBortKurs.Size = new System.Drawing.Size(460, 39);
            this.btnTaBortKurs.TabIndex = 45;
            this.btnTaBortKurs.Text = "Ta bort kurs";
            this.btnTaBortKurs.UseVisualStyleBackColor = true;
            this.btnTaBortKurs.Click += new System.EventHandler(this.btnTaBortKurs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 557);
            this.Controls.Add(this.btnTaBortKurs);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSignatur);
            this.Controls.Add(this.dataGridViewKurser);
            this.Controls.Add(this.ListaLabbar6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLabbNamn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLabbID);
            this.Controls.Add(this.btnLäggtillLaboration);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBetyg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKursID);
            this.Controls.Add(this.btnLäggTillKurs);
            this.Controls.Add(this.labelKursNamn);
            this.Controls.Add(this.txtKursNamn);
            this.Controls.Add(this.listLärare);
            this.Controls.Add(this.visaStudenter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPersNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtNamn);
            this.Controls.Add(this.läggTillStudent);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visaStudenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listLärare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaLabbar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKurser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button läggTillStudent;
        private System.Windows.Forms.TextBox txtNamn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPersNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView visaStudenter;
        private System.Windows.Forms.DataGridView listLärare;
        private System.Windows.Forms.TextBox txtKursNamn;
        private System.Windows.Forms.Label labelKursNamn;
        private System.Windows.Forms.Button btnLäggTillKurs;
        private System.Windows.Forms.TextBox txtKursID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBetyg;
        private System.Windows.Forms.Button btnLäggtillLaboration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLabbID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLabbNamn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView ListaLabbar6;
        private System.Windows.Forms.DataGridView dataGridViewKurser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSignatur;
        private System.Windows.Forms.Button btnTaBortKurs;
    }
}

