namespace MyDogRace
{
    partial class GamePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePanel));
            this.btnBets = new System.Windows.Forms.Button();
            this.numDog = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numBets = new System.Windows.Forms.NumericUpDown();
            this.lblName = new System.Windows.Forms.Label();
            this.btnRace = new System.Windows.Forms.Button();
            this.lblAl = new System.Windows.Forms.Label();
            this.lblBob = new System.Windows.Forms.Label();
            this.lblJoe = new System.Windows.Forms.Label();
            this.lblBets = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioGroupBox = new System.Windows.Forms.GroupBox();
            this.radioJoe = new System.Windows.Forms.RadioButton();
            this.radioAl = new System.Windows.Forms.RadioButton();
            this.radioBob = new System.Windows.Forms.RadioButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.racetrackPictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBets)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.radioGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBets
            // 
            this.btnBets.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnBets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBets.ForeColor = System.Drawing.Color.Snow;
            this.btnBets.Location = new System.Drawing.Point(82, 189);
            this.btnBets.Name = "btnBets";
            this.btnBets.Size = new System.Drawing.Size(82, 24);
            this.btnBets.TabIndex = 14;
            this.btnBets.Text = "Bets";
            this.btnBets.UseVisualStyleBackColor = false;
            this.btnBets.Click += new System.EventHandler(this.btnBets_Click);
            // 
            // numDog
            // 
            this.numDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDog.Location = new System.Drawing.Point(299, 190);
            this.numDog.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numDog.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDog.Name = "numDog";
            this.numDog.Size = new System.Drawing.Size(46, 23);
            this.numDog.TabIndex = 13;
            this.numDog.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(214, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "$ on dog :";
            // 
            // numBets
            // 
            this.numBets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBets.Location = new System.Drawing.Point(170, 189);
            this.numBets.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numBets.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numBets.Name = "numBets";
            this.numBets.Size = new System.Drawing.Size(38, 23);
            this.numBets.TabIndex = 11;
            this.numBets.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(23, 190);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 20);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "name";
            // 
            // btnRace
            // 
            this.btnRace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRace.ForeColor = System.Drawing.Color.Snow;
            this.btnRace.Location = new System.Drawing.Point(361, 183);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(154, 35);
            this.btnRace.TabIndex = 8;
            this.btnRace.Text = "RACE";
            this.btnRace.UseVisualStyleBackColor = false;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // lblAl
            // 
            this.lblAl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAl.Location = new System.Drawing.Point(311, 88);
            this.lblAl.Name = "lblAl";
            this.lblAl.Size = new System.Drawing.Size(204, 21);
            this.lblAl.TabIndex = 7;
            this.lblAl.Text = "label3";
            // 
            // lblBob
            // 
            this.lblBob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBob.Location = new System.Drawing.Point(311, 119);
            this.lblBob.Name = "lblBob";
            this.lblBob.Size = new System.Drawing.Size(204, 21);
            this.lblBob.TabIndex = 6;
            this.lblBob.Text = "label2";
            // 
            // lblJoe
            // 
            this.lblJoe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoe.Location = new System.Drawing.Point(311, 55);
            this.lblJoe.Name = "lblJoe";
            this.lblJoe.Size = new System.Drawing.Size(204, 21);
            this.lblJoe.TabIndex = 5;
            this.lblJoe.Text = "label1";
            // 
            // lblBets
            // 
            this.lblBets.AutoSize = true;
            this.lblBets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBets.ForeColor = System.Drawing.Color.White;
            this.lblBets.Location = new System.Drawing.Point(308, 30);
            this.lblBets.Name = "lblBets";
            this.lblBets.Size = new System.Drawing.Size(95, 17);
            this.lblBets.TabIndex = 4;
            this.lblBets.Text = "Description:";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnBets);
            this.groupBox1.Controls.Add(this.numDog);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numBets);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.radioGroupBox);
            this.groupBox1.Controls.Add(this.btnRace);
            this.groupBox1.Controls.Add(this.lblAl);
            this.groupBox1.Controls.Add(this.lblBob);
            this.groupBox1.Controls.Add(this.lblJoe);
            this.groupBox1.Controls.Add(this.lblBets);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(10, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 245);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls:";
            // 
            // radioGroupBox
            // 
            this.radioGroupBox.Controls.Add(this.radioJoe);
            this.radioGroupBox.Controls.Add(this.radioAl);
            this.radioGroupBox.Controls.Add(this.radioBob);
            this.radioGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroupBox.ForeColor = System.Drawing.Color.White;
            this.radioGroupBox.Location = new System.Drawing.Point(27, 33);
            this.radioGroupBox.Name = "radioGroupBox";
            this.radioGroupBox.Size = new System.Drawing.Size(164, 126);
            this.radioGroupBox.TabIndex = 15;
            this.radioGroupBox.TabStop = false;
            this.radioGroupBox.Text = "Minimum Bet: $5";
            // 
            // radioJoe
            // 
            this.radioJoe.AutoSize = true;
            this.radioJoe.Checked = true;
            this.radioJoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioJoe.ForeColor = System.Drawing.Color.SeaShell;
            this.radioJoe.Location = new System.Drawing.Point(16, 20);
            this.radioJoe.Name = "radioJoe";
            this.radioJoe.Size = new System.Drawing.Size(52, 21);
            this.radioJoe.TabIndex = 1;
            this.radioJoe.TabStop = true;
            this.radioJoe.Text = "Joe";
            this.radioJoe.UseVisualStyleBackColor = true;
            this.radioJoe.CheckedChanged += new System.EventHandler(this.radioJoe_CheckedChanged);
            // 
            // radioAl
            // 
            this.radioAl.AutoSize = true;
            this.radioAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAl.ForeColor = System.Drawing.Color.SeaShell;
            this.radioAl.Location = new System.Drawing.Point(16, 52);
            this.radioAl.Name = "radioAl";
            this.radioAl.Size = new System.Drawing.Size(40, 21);
            this.radioAl.TabIndex = 3;
            this.radioAl.Text = "Al";
            this.radioAl.UseVisualStyleBackColor = true;
            this.radioAl.CheckedChanged += new System.EventHandler(this.radioAl_CheckedChanged);
            // 
            // radioBob
            // 
            this.radioBob.AutoSize = true;
            this.radioBob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBob.ForeColor = System.Drawing.Color.SeaShell;
            this.radioBob.Location = new System.Drawing.Point(14, 81);
            this.radioBob.Name = "radioBob";
            this.radioBob.Size = new System.Drawing.Size(54, 21);
            this.radioBob.TabIndex = 2;
            this.radioBob.Text = "Bob";
            this.radioBob.UseVisualStyleBackColor = true;
            this.radioBob.CheckedChanged += new System.EventHandler(this.radioBob_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1, 178);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(68, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1, 126);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // racetrackPictureBox
            // 
            this.racetrackPictureBox.Image = global::MyDogRace.Properties.Resources.bg2;
            this.racetrackPictureBox.Location = new System.Drawing.Point(0, 6);
            this.racetrackPictureBox.Name = "racetrackPictureBox";
            this.racetrackPictureBox.Size = new System.Drawing.Size(600, 203);
            this.racetrackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racetrackPictureBox.TabIndex = 6;
            this.racetrackPictureBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(67, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 202);
            this.label3.TabIndex = 12;
            this.label3.Text = "START";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GamePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyDogRace.Properties.Resources.brownfluidwallpaper;
            this.ClientSize = new System.Drawing.Size(600, 470);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.racetrackPictureBox);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "GamePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GamePanel";
            ((System.ComponentModel.ISupportInitialize)(this.numDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBets)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.radioGroupBox.ResumeLayout(false);
            this.radioGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioAl;
        private System.Windows.Forms.RadioButton radioBob;
        private System.Windows.Forms.RadioButton radioJoe;
        private System.Windows.Forms.Button btnBets;
        private System.Windows.Forms.NumericUpDown numDog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numBets;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox radioGroupBox;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.Label lblAl;
        private System.Windows.Forms.Label lblBob;
        private System.Windows.Forms.Label lblJoe;
        public System.Windows.Forms.Label lblBets;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox racetrackPictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
    }
}