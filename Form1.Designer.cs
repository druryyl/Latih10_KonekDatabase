namespace Latih10_KonekDatabase
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            NewButton = new Button();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            SaveButton = new Button();
            DeleteButton = new Button();
            panel2 = new Panel();
            comboBox1 = new ComboBox();
            label5 = new Label();
            TglLahirPicker = new DateTimePicker();
            KotaText = new TextBox();
            label4 = new Label();
            AlamatText = new TextBox();
            TempatLahirText = new TextBox();
            label6 = new Label();
            panel1 = new Panel();
            NisText = new TextBox();
            label3 = new Label();
            SiswaNameText = new TextBox();
            label2 = new Label();
            SiswaIdText = new TextBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(544, 354);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(NewButton);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(536, 326);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "List Data";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // NewButton
            // 
            NewButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            NewButton.Location = new Point(453, 295);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(75, 23);
            NewButton.TabIndex = 1;
            NewButton.Text = "New";
            NewButton.UseVisualStyleBackColor = true;
            NewButton.Click += NewButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(536, 289);
            dataGridView1.TabIndex = 0;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.ButtonShadow;
            tabPage2.Controls.Add(SaveButton);
            tabPage2.Controls.Add(DeleteButton);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(536, 326);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Input Data";
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveButton.Location = new Point(451, 293);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DeleteButton.Location = new Point(370, 293);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 9;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(TglLahirPicker);
            panel2.Controls.Add(KotaText);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(AlamatText);
            panel2.Controls.Add(TempatLahirText);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(270, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(256, 281);
            panel2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(8, 99);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(231, 23);
            comboBox1.TabIndex = 6;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(8, 81);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 7;
            label5.Text = "Gender";
            // 
            // TglLahirPicker
            // 
            TglLahirPicker.Anchor = AnchorStyles.None;
            TglLahirPicker.Location = new Point(8, 55);
            TglLahirPicker.Name = "TglLahirPicker";
            TglLahirPicker.Size = new Size(231, 23);
            TglLahirPicker.TabIndex = 5;
            // 
            // KotaText
            // 
            KotaText.Anchor = AnchorStyles.None;
            KotaText.Location = new Point(8, 228);
            KotaText.Name = "KotaText";
            KotaText.Size = new Size(231, 23);
            KotaText.TabIndex = 8;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(8, 150);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 4;
            label4.Text = "Alamat - Kota";
            // 
            // AlamatText
            // 
            AlamatText.Anchor = AnchorStyles.None;
            AlamatText.Location = new Point(8, 168);
            AlamatText.Multiline = true;
            AlamatText.Name = "AlamatText";
            AlamatText.Size = new Size(231, 54);
            AlamatText.TabIndex = 7;
            // 
            // TempatLahirText
            // 
            TempatLahirText.Anchor = AnchorStyles.None;
            TempatLahirText.Location = new Point(8, 26);
            TempatLahirText.Name = "TempatLahirText";
            TempatLahirText.Size = new Size(231, 23);
            TempatLahirText.TabIndex = 4;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(8, 8);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 0;
            label6.Text = "Tempat - Tgl Lahir";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(NisText);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(SiswaNameText);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(SiswaIdText);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(8, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 281);
            panel1.TabIndex = 0;
            // 
            // NisText
            // 
            NisText.Anchor = AnchorStyles.None;
            NisText.Location = new Point(8, 114);
            NisText.Name = "NisText";
            NisText.Size = new Size(231, 23);
            NisText.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(8, 96);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 4;
            label3.Text = "Nomor Induk Siswa";
            // 
            // SiswaNameText
            // 
            SiswaNameText.Anchor = AnchorStyles.None;
            SiswaNameText.Location = new Point(8, 70);
            SiswaNameText.Name = "SiswaNameText";
            SiswaNameText.Size = new Size(231, 23);
            SiswaNameText.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(8, 52);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 2;
            label2.Text = "Siswa Name";
            // 
            // SiswaIdText
            // 
            SiswaIdText.Anchor = AnchorStyles.None;
            SiswaIdText.Location = new Point(8, 26);
            SiswaIdText.Name = "SiswaIdText";
            SiswaIdText.Size = new Size(231, 23);
            SiswaIdText.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Siswa ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 354);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button NewButton;
        private DataGridView dataGridView1;
        private TabPage tabPage2;
        private Panel panel1;
        private TextBox SiswaNameText;
        private Label label2;
        private TextBox SiswaIdText;
        private Label label1;
        private Button SaveButton;
        private Button DeleteButton;
        private Panel panel2;
        private ComboBox comboBox1;
        private Label label5;
        private DateTimePicker TglLahirPicker;
        private TextBox KotaText;
        private Label label4;
        private TextBox AlamatText;
        private TextBox TempatLahirText;
        private Label label6;
        private TextBox NisText;
        private Label label3;
    }
}
