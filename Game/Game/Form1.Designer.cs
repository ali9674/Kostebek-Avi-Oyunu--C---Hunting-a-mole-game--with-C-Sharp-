namespace Game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainbox3 = new System.Windows.Forms.PictureBox();
            this.mainbox4 = new System.Windows.Forms.PictureBox();
            this.mainbox2 = new System.Windows.Forms.PictureBox();
            this.mainbox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Zor = new System.Windows.Forms.Timer(this.components);
            this.puan_update = new System.Windows.Forms.Timer(this.components);
            this.zaman = new System.Windows.Forms.Timer(this.components);
            this.Orta = new System.Windows.Forms.Timer(this.components);
            this.Kolay = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yuvarlakbuton4 = new Game.yuvarlakbuton();
            this.yuvarlakbuton3 = new Game.yuvarlakbuton();
            this.yuvarlakbuton2 = new Game.yuvarlakbuton();
            this.yuvarlakbuton1 = new Game.yuvarlakbuton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainbox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainbox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // mainbox3
            // 
            this.mainbox3.Location = new System.Drawing.Point(1005, 388);
            this.mainbox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainbox3.Name = "mainbox3";
            this.mainbox3.Size = new System.Drawing.Size(44, 50);
            this.mainbox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainbox3.TabIndex = 14;
            this.mainbox3.TabStop = false;
            // 
            // mainbox4
            // 
            this.mainbox4.Location = new System.Drawing.Point(1005, 161);
            this.mainbox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainbox4.Name = "mainbox4";
            this.mainbox4.Size = new System.Drawing.Size(44, 50);
            this.mainbox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainbox4.TabIndex = 13;
            this.mainbox4.TabStop = false;
            // 
            // mainbox2
            // 
            this.mainbox2.Location = new System.Drawing.Point(1005, 308);
            this.mainbox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainbox2.Name = "mainbox2";
            this.mainbox2.Size = new System.Drawing.Size(44, 50);
            this.mainbox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainbox2.TabIndex = 12;
            this.mainbox2.TabStop = false;
            // 
            // mainbox1
            // 
            this.mainbox1.Location = new System.Drawing.Point(989, 244);
            this.mainbox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainbox1.Name = "mainbox1";
            this.mainbox1.Size = new System.Drawing.Size(44, 50);
            this.mainbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainbox1.TabIndex = 11;
            this.mainbox1.TabStop = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk_1);
            // 
            // Zor
            // 
            this.Zor.Interval = 1000;
            this.Zor.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // puan_update
            // 
            this.puan_update.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // zaman
            // 
            this.zaman.Interval = 1000;
            this.zaman.Tick += new System.EventHandler(this.zaman_Tick);
            // 
            // Orta
            // 
            this.Orta.Interval = 2000;
            this.Orta.Tick += new System.EventHandler(this.Orta_Tick);
            // 
            // Kolay
            // 
            this.Kolay.Interval = 4000;
            this.Kolay.Tick += new System.EventHandler(this.Kolay_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(596, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(474, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "60";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(575, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "PUAN";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(380, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 42);
            this.label4.TabIndex = 12;
            this.label4.Text = "KALAN SÜRE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(44, 57);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(229, 57);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(416, 182);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(115, 95);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(229, 182);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(115, 95);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(416, 57);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(115, 95);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(40, 182);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(115, 95);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(40, 345);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(115, 95);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(229, 342);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(115, 95);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(416, 345);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(115, 95);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.yuvarlakbuton4);
            this.panel1.Controls.Add(this.yuvarlakbuton3);
            this.panel1.Controls.Add(this.yuvarlakbuton2);
            this.panel1.Controls.Add(this.yuvarlakbuton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 672);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // yuvarlakbuton4
            // 
            this.yuvarlakbuton4.BackColor = System.Drawing.Color.DodgerBlue;
            this.yuvarlakbuton4.FlatAppearance.BorderSize = 0;
            this.yuvarlakbuton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yuvarlakbuton4.Location = new System.Drawing.Point(31, 343);
            this.yuvarlakbuton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yuvarlakbuton4.Name = "yuvarlakbuton4";
            this.yuvarlakbuton4.Size = new System.Drawing.Size(97, 36);
            this.yuvarlakbuton4.TabIndex = 3;
            this.yuvarlakbuton4.TabStop = false;
            this.yuvarlakbuton4.Text = "Orta";
            this.yuvarlakbuton4.UseVisualStyleBackColor = false;
            this.yuvarlakbuton4.Click += new System.EventHandler(this.yuvarlakbuton4_Click);
            // 
            // yuvarlakbuton3
            // 
            this.yuvarlakbuton3.BackColor = System.Drawing.Color.DodgerBlue;
            this.yuvarlakbuton3.FlatAppearance.BorderSize = 0;
            this.yuvarlakbuton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yuvarlakbuton3.Location = new System.Drawing.Point(31, 259);
            this.yuvarlakbuton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yuvarlakbuton3.Name = "yuvarlakbuton3";
            this.yuvarlakbuton3.Size = new System.Drawing.Size(97, 36);
            this.yuvarlakbuton3.TabIndex = 2;
            this.yuvarlakbuton3.TabStop = false;
            this.yuvarlakbuton3.Text = "Zor";
            this.yuvarlakbuton3.UseVisualStyleBackColor = false;
            this.yuvarlakbuton3.Click += new System.EventHandler(this.yuvarlakbuton3_Click);
            // 
            // yuvarlakbuton2
            // 
            this.yuvarlakbuton2.BackColor = System.Drawing.Color.DodgerBlue;
            this.yuvarlakbuton2.FlatAppearance.BorderSize = 0;
            this.yuvarlakbuton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yuvarlakbuton2.Location = new System.Drawing.Point(31, 301);
            this.yuvarlakbuton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yuvarlakbuton2.Name = "yuvarlakbuton2";
            this.yuvarlakbuton2.Size = new System.Drawing.Size(97, 36);
            this.yuvarlakbuton2.TabIndex = 1;
            this.yuvarlakbuton2.TabStop = false;
            this.yuvarlakbuton2.Text = "Kolay";
            this.yuvarlakbuton2.UseVisualStyleBackColor = false;
            this.yuvarlakbuton2.Click += new System.EventHandler(this.yuvarlakbuton2_Click_1);
            // 
            // yuvarlakbuton1
            // 
            this.yuvarlakbuton1.BackColor = System.Drawing.Color.Red;
            this.yuvarlakbuton1.FlatAppearance.BorderSize = 0;
            this.yuvarlakbuton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yuvarlakbuton1.Location = new System.Drawing.Point(5, 164);
            this.yuvarlakbuton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yuvarlakbuton1.Name = "yuvarlakbuton1";
            this.yuvarlakbuton1.Size = new System.Drawing.Size(165, 91);
            this.yuvarlakbuton1.TabIndex = 0;
            this.yuvarlakbuton1.TabStop = false;
            this.yuvarlakbuton1.Text = "PLAY";
            this.yuvarlakbuton1.UseVisualStyleBackColor = false;
            this.yuvarlakbuton1.Click += new System.EventHandler(this.yuvarlakbuton1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.pictureBox9);
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel2.Location = new System.Drawing.Point(12, 161);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 626);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Enabled = false;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(387, 57);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(69, 54);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 14;
            this.pictureBox10.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.GreenYellow;
            this.label5.Location = new System.Drawing.Point(24, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 42);
            this.label5.TabIndex = 15;
            this.label5.Text = "EN YÜKSEK PUAN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(47, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(670, 672);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.mainbox4);
            this.Controls.Add(this.mainbox1);
            this.Controls.Add(this.mainbox2);
            this.Controls.Add(this.mainbox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Köstebek Avı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainbox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainbox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox mainbox2;
        private System.Windows.Forms.PictureBox mainbox1;
        private System.Windows.Forms.PictureBox mainbox3;
        private System.Windows.Forms.PictureBox mainbox4;
        private System.Windows.Forms.Timer Zor;
        private System.Windows.Forms.Timer puan_update;
        private System.Windows.Forms.Timer zaman;
        private System.Windows.Forms.Timer Orta;
        private System.Windows.Forms.Timer Kolay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Panel panel1;
        private yuvarlakbuton yuvarlakbuton4;
        private yuvarlakbuton yuvarlakbuton3;
        private yuvarlakbuton yuvarlakbuton2;
        private yuvarlakbuton yuvarlakbuton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

