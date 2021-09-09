using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labb_2
{
    public partial class Form1 : Form
    {
        public BindingList<Kurs> kurser = new BindingList<Kurs>();

        Kurs k = new Kurs();

        public Form1()
        {
            InitializeComponent();
            UpdateUI();
        }

        string namn;
        string personnummer;
        string ID;
        string betyg;
        string labbNamn;
        string labbID;
        string kursNamn;
        string kursID;
        string Signatur;


        public void UpdateUI()
        {
            dataGridViewKurser.DataSource = null;
            dataGridViewKurser.DataSource = kurser;

            if(dataGridViewKurser.CurrentRow != null)
            {
                visaStudenter.DataSource = null;
                visaStudenter.DataSource = ((Kurs)dataGridViewKurser.CurrentRow.DataBoundItem).studenter;

                listLärare.DataSource = null;
                listLärare.DataSource = ((Kurs)dataGridViewKurser.CurrentRow.DataBoundItem).lärare;

                ListaLabbar6.DataSource = null;
                ListaLabbar6.DataSource = ((Kurs)dataGridViewKurser.CurrentRow.DataBoundItem).laborationer;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Namn = namn;
            s.Personnummer = personnummer; 
            s.ID = ID;
            s.Betyg = betyg;

            ((Kurs)dataGridViewKurser.CurrentRow.DataBoundItem).studenter.Add(s);
            UpdateUI();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            namn = this.txtNamn.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            personnummer = this.txtPersNum.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            ID = this.txtID.Text;
        }

        private void txtBetyg_TextChanged(object sender, EventArgs e)
        {
            betyg = this.txtBetyg.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lärare l = new Lärare(namn, personnummer, ID, Signatur);

            ((Kurs)dataGridViewKurser.CurrentRow.DataBoundItem).lärare.Add(l);
            UpdateUI();
        }
        
        private void btnLäggtillLaboration_Click(object sender, EventArgs e)
        {
            Laboration la = new Laboration(labbNamn, labbID);

            ((Kurs)dataGridViewKurser.CurrentRow.DataBoundItem).laborationer.Add(la);
            UpdateUI();
        }
        private void txtLabbNamn_TextChanged(object sender, EventArgs e)
        {
            labbNamn = this.txtLabbNamn.Text;
        }

        private void txtLabbID_TextChanged(object sender, EventArgs e)
        {
            labbID = this.txtLabbID.Text;
        }
        
        private void visaStudentet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void listLärare_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            kursNamn = this.txtKursNamn.Text;
        }

        private void btnLäggTillKurs_Click(object sender, EventArgs e)
        {
            Kurs k = new Kurs();
            k.kursNamn = txtKursNamn.Text;
            k.kursID = txtKursID.Text;

            kurser.Add(k);
            UpdateUI();
        }

        private void txtKursID_TextChanged(object sender, EventArgs e)
        {
            kursID = this.txtKursID.Text;
        }

        private void ListaLabbar6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewKurser_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtSignatur_TextChanged(object sender, EventArgs e)
        {
            Signatur = this.txtSignatur.Text;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewKurser_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewKurser.CurrentRow != null)
            {
                visaStudenter.DataSource = null;
                visaStudenter.DataSource = ((Kurs)dataGridViewKurser.CurrentRow.DataBoundItem).studenter;

                listLärare.DataSource = null;
                listLärare.DataSource = ((Kurs)dataGridViewKurser.CurrentRow.DataBoundItem).lärare;

                ListaLabbar6.DataSource = null;
                ListaLabbar6.DataSource = ((Kurs)dataGridViewKurser.CurrentRow.DataBoundItem).laborationer;
            }
        }

        private void visaStudenter_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnTaBortKurs_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow dr in dataGridViewKurser.SelectedRows)
            {
                dataGridViewKurser.Rows.RemoveAt(dr.Index);
            }
        }
    }
}
