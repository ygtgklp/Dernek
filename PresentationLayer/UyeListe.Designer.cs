namespace PresentationLayer
{
    partial class UyeListe
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
            listView1 = new ListView();
            uyeid = new ColumnHeader();
            uyead = new ColumnHeader();
            uyesoyad = new ColumnHeader();
            uyetc = new ColumnHeader();
            uyecountry = new ColumnHeader();
            uyeblood = new ColumnHeader();
            uyeactive = new ColumnHeader();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            textBox6 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            button7 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            listView1.BackColor = Color.AntiqueWhite;
            listView1.Columns.AddRange(new ColumnHeader[] { uyeid, uyead, uyesoyad, uyetc, uyecountry, uyeblood, uyeactive });
            listView1.Location = new Point(12, 180);
            listView1.Name = "listView1";
            listView1.Size = new Size(664, 383);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // uyeid
            // 
            uyeid.Text = "uyeid";
            // 
            // uyead
            // 
            uyead.Text = "Uye Adı";
            uyead.Width = 100;
            // 
            // uyesoyad
            // 
            uyesoyad.Text = "uyesoyad";
            uyesoyad.Width = 100;
            // 
            // uyetc
            // 
            uyetc.Text = "uyetc";
            uyetc.Width = 100;
            // 
            // uyecountry
            // 
            uyecountry.Text = "uyecountry";
            uyecountry.Width = 100;
            // 
            // uyeblood
            // 
            uyeblood.Text = "uyeblood";
            uyeblood.Width = 100;
            // 
            // uyeactive
            // 
            uyeactive.Text = "uyeactive";
            uyeactive.Width = 100;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Location = new Point(102, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(308, 19);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(102, 102);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(308, 102);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(561, 19);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(463, 101);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(77, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Aktiflik";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Salmon;
            button1.Location = new Point(561, 58);
            button1.Name = "button1";
            button1.Size = new Size(125, 41);
            button1.TabIndex = 7;
            button1.Text = "Üye Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(15, 12);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(143, 27);
            textBox6.TabIndex = 8;
            textBox6.Text = "Ara";
            // 
            // button2
            // 
            button2.BackColor = Color.Salmon;
            button2.Location = new Point(561, 105);
            button2.Name = "button2";
            button2.Size = new Size(125, 42);
            button2.TabIndex = 9;
            button2.Text = "Tüm Liste";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Salmon;
            button3.Location = new Point(15, 45);
            button3.Name = "button3";
            button3.Size = new Size(143, 29);
            button3.TabIndex = 10;
            button3.Text = "Şehire Göre Ara";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Salmon;
            button4.Location = new Point(15, 80);
            button4.Name = "button4";
            button4.Size = new Size(143, 29);
            button4.TabIndex = 11;
            button4.Text = "Kana Göre Ara";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Salmon;
            button5.Location = new Point(15, 115);
            button5.Name = "button5";
            button5.Size = new Size(143, 31);
            button5.TabIndex = 12;
            button5.Text = "Aktif Üye Ara";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Salmon;
            button6.Location = new Point(15, 152);
            button6.Name = "button6";
            button6.Size = new Size(143, 33);
            button6.TabIndex = 13;
            button6.Text = "Pasif Üye Ara";
            button6.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.DarkSalmon;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(841, 162);
            panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Dernek_logo_removebg_preview;
            pictureBox1.Location = new Point(716, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 93);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(463, 22);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 14;
            label5.Text = "Kan Grubu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(250, 105);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 13;
            label4.Text = "Şehir";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 22);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 12;
            label3.Text = "Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 105);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 11;
            label2.Text = "TC Kimlik";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 22);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 10;
            label1.Text = "Ad";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Right;
            panel2.BackColor = Color.DarkSalmon;
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(textBox6);
            panel2.Location = new Point(682, 180);
            panel2.Name = "panel2";
            panel2.Size = new Size(171, 192);
            panel2.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = Color.DarkSalmon;
            panel3.Controls.Add(button7);
            panel3.Location = new Point(682, 378);
            panel3.Name = "panel3";
            panel3.Size = new Size(171, 185);
            panel3.TabIndex = 16;
            // 
            // button7
            // 
            button7.BackColor = Color.Salmon;
            button7.Location = new Point(15, 14);
            button7.Name = "button7";
            button7.Size = new Size(143, 63);
            button7.TabIndex = 0;
            button7.Text = "Aidat Listesini\r\nGörüntüle";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // UyeListe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(865, 575);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(listView1);
            Name = "UyeListe";
            Text = "Üye Kontrol";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader uyeid;
        private ColumnHeader uyead;
        private ColumnHeader uyesoyad;
        private ColumnHeader uyetc;
        private ColumnHeader uyecountry;
        private ColumnHeader uyeblood;
        private ColumnHeader uyeactive;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private CheckBox checkBox1;
        private Button button1;
        private TextBox textBox6;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Button button7;
        private PictureBox pictureBox1;
    }
}
