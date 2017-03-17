namespace Birthday_App
{
    partial class Main_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mainFormTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.secondPictureBox2 = new System.Windows.Forms.PictureBox();
            this.secondPictureBox1 = new System.Windows.Forms.PictureBox();
            this.minutePictureBox2 = new System.Windows.Forms.PictureBox();
            this.minutePictureBox1 = new System.Windows.Forms.PictureBox();
            this.hourPictureBox2 = new System.Windows.Forms.PictureBox();
            this.hourPictureBox1 = new System.Windows.Forms.PictureBox();
            this.dayPictureBox3 = new System.Windows.Forms.PictureBox();
            this.dayPictureBox2 = new System.Windows.Forms.PictureBox();
            this.dayPictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.secondPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remaing Time To Activate :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Day : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hour : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(322, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Minute : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(487, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Second : ";
            // 
            // mainFormTimer
            // 
            this.mainFormTimer.Enabled = true;
            this.mainFormTimer.Interval = 1000;
            this.mainFormTimer.Tick += new System.EventHandler(this.mainFormTimer_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Fax", 9.75F);
            this.button1.Location = new System.Drawing.Point(482, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 13;
            this.button2.Text = "Hide";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // secondPictureBox2
            // 
            this.secondPictureBox2.Location = new System.Drawing.Point(529, 111);
            this.secondPictureBox2.Name = "secondPictureBox2";
            this.secondPictureBox2.Size = new System.Drawing.Size(28, 33);
            this.secondPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.secondPictureBox2.TabIndex = 12;
            this.secondPictureBox2.TabStop = false;
            // 
            // secondPictureBox1
            // 
            this.secondPictureBox1.Location = new System.Drawing.Point(495, 111);
            this.secondPictureBox1.Name = "secondPictureBox1";
            this.secondPictureBox1.Size = new System.Drawing.Size(28, 33);
            this.secondPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.secondPictureBox1.TabIndex = 11;
            this.secondPictureBox1.TabStop = false;
            // 
            // minutePictureBox2
            // 
            this.minutePictureBox2.Location = new System.Drawing.Point(355, 111);
            this.minutePictureBox2.Name = "minutePictureBox2";
            this.minutePictureBox2.Size = new System.Drawing.Size(28, 33);
            this.minutePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minutePictureBox2.TabIndex = 10;
            this.minutePictureBox2.TabStop = false;
            // 
            // minutePictureBox1
            // 
            this.minutePictureBox1.Location = new System.Drawing.Point(322, 111);
            this.minutePictureBox1.Name = "minutePictureBox1";
            this.minutePictureBox1.Size = new System.Drawing.Size(28, 33);
            this.minutePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minutePictureBox1.TabIndex = 9;
            this.minutePictureBox1.TabStop = false;
            // 
            // hourPictureBox2
            // 
            this.hourPictureBox2.Location = new System.Drawing.Point(224, 111);
            this.hourPictureBox2.Name = "hourPictureBox2";
            this.hourPictureBox2.Size = new System.Drawing.Size(28, 33);
            this.hourPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hourPictureBox2.TabIndex = 8;
            this.hourPictureBox2.TabStop = false;
            // 
            // hourPictureBox1
            // 
            this.hourPictureBox1.Location = new System.Drawing.Point(190, 111);
            this.hourPictureBox1.Name = "hourPictureBox1";
            this.hourPictureBox1.Size = new System.Drawing.Size(28, 33);
            this.hourPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hourPictureBox1.TabIndex = 7;
            this.hourPictureBox1.TabStop = false;
            // 
            // dayPictureBox3
            // 
            this.dayPictureBox3.Location = new System.Drawing.Point(103, 111);
            this.dayPictureBox3.Name = "dayPictureBox3";
            this.dayPictureBox3.Size = new System.Drawing.Size(28, 33);
            this.dayPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dayPictureBox3.TabIndex = 4;
            this.dayPictureBox3.TabStop = false;
            // 
            // dayPictureBox2
            // 
            this.dayPictureBox2.Location = new System.Drawing.Point(69, 111);
            this.dayPictureBox2.Name = "dayPictureBox2";
            this.dayPictureBox2.Size = new System.Drawing.Size(28, 33);
            this.dayPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dayPictureBox2.TabIndex = 3;
            this.dayPictureBox2.TabStop = false;
            // 
            // dayPictureBox1
            // 
            this.dayPictureBox1.InitialImage = global::Birthday_App.Properties.Resources._0;
            this.dayPictureBox1.Location = new System.Drawing.Point(35, 111);
            this.dayPictureBox1.Name = "dayPictureBox1";
            this.dayPictureBox1.Size = new System.Drawing.Size(28, 33);
            this.dayPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dayPictureBox1.TabIndex = 2;
            this.dayPictureBox1.TabStop = false;
            this.dayPictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 159);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.secondPictureBox2);
            this.Controls.Add(this.secondPictureBox1);
            this.Controls.Add(this.minutePictureBox2);
            this.Controls.Add(this.minutePictureBox1);
            this.Controls.Add(this.hourPictureBox2);
            this.Controls.Add(this.hourPictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dayPictureBox3);
            this.Controls.Add(this.dayPictureBox2);
            this.Controls.Add(this.dayPictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Main_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_FormClosing);
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.Resize += new System.EventHandler(this.Main_Form_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.secondPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox dayPictureBox1;
        private System.Windows.Forms.PictureBox dayPictureBox2;
        private System.Windows.Forms.PictureBox dayPictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox hourPictureBox1;
        private System.Windows.Forms.PictureBox hourPictureBox2;
        private System.Windows.Forms.PictureBox minutePictureBox1;
        private System.Windows.Forms.PictureBox minutePictureBox2;
        private System.Windows.Forms.PictureBox secondPictureBox1;
        private System.Windows.Forms.PictureBox secondPictureBox2;
        private System.Windows.Forms.Timer mainFormTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}