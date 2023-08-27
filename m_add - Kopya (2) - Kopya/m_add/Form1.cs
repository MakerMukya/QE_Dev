using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

using System.Text;
using System.Text.RegularExpressions;


namespace m_add
{
    public partial class Form1 : Form
    {
         
        FileReadX fileW = new FileReadX();  
        //public string path; 


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Cif Dosyas� |*.cif";
            file.ShowDialog();
            fileW.FilePath = file.FileName;
            fileW.ReadCifFile();
            dataGridView1.DataSource = fileW.CoordView.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            fileW.MoveCoordCalcul();
            fileW.WriteCoord();
           /*
            *   // ESKI KİRLİ KOD 
            //  using (StreamWriter sw = new StreamWriter(@"C:\Users\Mustafa\Desktop\CH4.txt"))
            //  {


            //      for (int x = 0; x < 5; x++)
            //      {

            //              for (int z = 0; z < 3; z++)
            //              {
            //                  double value = ch4CoordED[x, 0, z];
            //                  sw.Write($"{value} ");
            //              }
            //              sw.WriteLine("");


            //      }

            //  }
            */

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
           
            fileW.X = (double)selectedRow.Cells[1].Value;
            fileW.Y = (double)selectedRow.Cells[2].Value;
            fileW.Z = (double)selectedRow.Cells[3].Value;

        }
    }
}