namespace m_add
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            btnOpenFile = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            Ekle = new Button();
            Mesafe = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(1162, 378);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(94, 29);
            btnOpenFile.TabIndex = 0;
            btnOpenFile.Text = "Dosya Seç";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(72, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(1224, 308);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.Location = new Point(15, 392);
            label1.Name = "label1";
            label1.Size = new Size(107, 27);
            label1.TabIndex = 2;
            label1.Click += label1_Click;
            // 
            // Ekle
            // 
            Ekle.Location = new Point(15, 434);
            Ekle.Name = "Ekle";
            Ekle.Size = new Size(238, 48);
            Ekle.TabIndex = 3;
            Ekle.Text = "Ekle";
            Ekle.UseVisualStyleBackColor = true;
            Ekle.Click += Ekle_Click;
            // 
            // Mesafe
            // 
            Mesafe.Location = new Point(128, 392);
            Mesafe.Name = "Mesafe";
            Mesafe.Size = new Size(125, 27);
            Mesafe.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 932);
            Controls.Add(Mesafe);
            Controls.Add(Ekle);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnOpenFile);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button btnOpenFile;
        private DataGridView dataGridView1;
        private Label label1;
        private Button Ekle;
        private TextBox Mesafe;
    }
}