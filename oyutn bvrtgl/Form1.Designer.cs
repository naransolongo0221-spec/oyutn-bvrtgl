namespace oyutn_bvrtgl
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
            TreeNode treeNode1 = new TreeNode("Компьютерын ухаан");
            TreeNode treeNode2 = new TreeNode("Мэдээллийн технологи");
            TreeNode treeNode3 = new TreeNode("Программ хангамж");
            TreeNode treeNode4 = new TreeNode("Байгалийн ухааны сургууль");
            TreeNode treeNode5 = new TreeNode("Математик");
            TreeNode treeNode6 = new TreeNode("Физик");
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            radioButton1 = new RadioButton();
            checkedListBox1 = new CheckedListBox();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            maskedTextBox1 = new MaskedTextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            jkjjj = new RichTextBox();
            treeView2 = new TreeView();
            listBox1 = new ListBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "M.IT24D002";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 45);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 24);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Тэтгэлэгтэй";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(12, 88);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(140, 24);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Өдрийн сургалт";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Программчлал", "Өгөгдлийн бүтэц ", "Алгоритм ", "Өгөгдлийн сан", "Сүлжээ" });
            checkedListBox1.Location = new Point(1, 118);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(150, 114);
            checkedListBox1.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(1, 261);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1, 317);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "Мэдээллийн технологи";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(2, 362);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 6;
            maskedTextBox1.Text = "9911-9911";
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1, 419);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(26, 476);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Бүртгэх";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(554, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(73, 20);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Цэвэрлэх";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._244559267_1726655544199590_8389934776276984328_n;
            pictureBox1.Location = new Point(222, 184);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // jkjjj
            // 
            jkjjj.ForeColor = SystemColors.InactiveCaptionText;
            jkjjj.Location = new Point(386, 317);
            jkjjj.Name = "jkjjj";
            jkjjj.Size = new Size(374, 222);
            jkjjj.TabIndex = 13;
            jkjjj.Text = "Оюутны бүртгэл\n_______________________________\nКод:M.IT24D002\nНас:20\nТөрсөн өдөр:2008-02-02\nСургалт:Өдрийн\nТэнхим:Мэдээлэлийн технологи\nТэтгэлэг:Тийм\nХичээл:Програмчлал, Өгөгдлийн бүтэц\nХэл:Англи";
            jkjjj.TextChanged += richTextBox1_TextChanged;
            // 
            // treeView2
            // 
            treeView2.Location = new Point(453, 131);
            treeView2.Name = "treeView2";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Компьютерын ухаан";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Мэдээллийн технологи";
            treeNode3.Name = "Node2";
            treeNode3.Text = "Программ хангамж";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Байгалийн ухааны сургууль";
            treeNode5.Name = "Node3";
            treeNode5.Text = "Математик";
            treeNode6.Name = "Node5";
            treeNode6.Text = "Физик";
            treeView2.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4, treeNode5, treeNode6 });
            treeView2.Size = new Size(217, 157);
            treeView2.TabIndex = 15;
            treeView2.AfterSelect += treeView2_AfterSelect;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Монгол", "Англи", "Орос", "Хятад", "Япон", "Солонгос" });
            listBox1.Location = new Point(230, 58);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 16;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(294, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 17;
            label1.Text = " Нийт: 1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(414, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(374, 80);
            dataGridView1.TabIndex = 18;
            // 
            // Column1
            // 
            Column1.HeaderText = "Овог Нэр";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Утас";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Нас";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(414, 74);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 19;
            textBox2.Text = "M.IT24D002";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(554, 77);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 20;
            label2.Text = "99119911";
            label2.Click += label2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(663, 74);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 21;
            textBox3.Text = "            20";
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.ForeColor = Color.Chartreuse;
            panel1.Location = new Point(2, 557);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 26);
            panel1.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 595);
            Controls.Add(panel1);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(treeView2);
            Controls.Add(jkjjj);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(maskedTextBox1);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(checkedListBox1);
            Controls.Add(radioButton1);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "\"Оюутны бүртгэлийн програм\"-";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private CheckBox checkBox1;
        private RadioButton radioButton1;
        private CheckedListBox checkedListBox1;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private MaskedTextBox maskedTextBox1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private RichTextBox jkjjj;
        private TreeView treeView2;
        private ListBox listBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label label2;
        private TextBox textBox3;
        private Panel panel1;
    }
}
