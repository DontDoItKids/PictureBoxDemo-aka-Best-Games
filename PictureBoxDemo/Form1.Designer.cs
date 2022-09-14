namespace PictureBoxDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picBestGame = new System.Windows.Forms.PictureBox();
            this.picSecondBest = new System.Windows.Forms.PictureBox();
            this.picThirdBest = new System.Windows.Forms.PictureBox();
            this.btn1st = new System.Windows.Forms.Button();
            this.btn2nd = new System.Windows.Forms.Button();
            this.btn3rd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBestGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSecondBest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThirdBest)).BeginInit();
            this.SuspendLayout();
            // 
            // picBestGame
            // 
            this.picBestGame.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picBestGame.Image = global::PictureBoxDemo.Properties.Resources.ROR2;
            this.picBestGame.Location = new System.Drawing.Point(12, 12);
            this.picBestGame.Name = "picBestGame";
            this.picBestGame.Size = new System.Drawing.Size(211, 219);
            this.picBestGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBestGame.TabIndex = 0;
            this.picBestGame.TabStop = false;
            this.picBestGame.Visible = false;
            this.picBestGame.Click += new System.EventHandler(this.picBestGame_Click);
            // 
            // picSecondBest
            // 
            this.picSecondBest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picSecondBest.Image = ((System.Drawing.Image)(resources.GetObject("picSecondBest.Image")));
            this.picSecondBest.Location = new System.Drawing.Point(229, 12);
            this.picSecondBest.Name = "picSecondBest";
            this.picSecondBest.Size = new System.Drawing.Size(366, 219);
            this.picSecondBest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSecondBest.TabIndex = 1;
            this.picSecondBest.TabStop = false;
            this.picSecondBest.Visible = false;
            // 
            // picThirdBest
            // 
            this.picThirdBest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picThirdBest.Image = ((System.Drawing.Image)(resources.GetObject("picThirdBest.Image")));
            this.picThirdBest.Location = new System.Drawing.Point(601, 12);
            this.picThirdBest.Name = "picThirdBest";
            this.picThirdBest.Size = new System.Drawing.Size(367, 219);
            this.picThirdBest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picThirdBest.TabIndex = 2;
            this.picThirdBest.TabStop = false;
            this.picThirdBest.Visible = false;
            // 
            // btn1st
            // 
            this.btn1st.Location = new System.Drawing.Point(12, 237);
            this.btn1st.Name = "btn1st";
            this.btn1st.Size = new System.Drawing.Size(211, 23);
            this.btn1st.TabIndex = 3;
            this.btn1st.Text = "BestGame";
            this.btn1st.UseVisualStyleBackColor = true;
            this.btn1st.Click += new System.EventHandler(this.btn1st_Click);
            // 
            // btn2nd
            // 
            this.btn2nd.Location = new System.Drawing.Point(229, 237);
            this.btn2nd.Name = "btn2nd";
            this.btn2nd.Size = new System.Drawing.Size(366, 23);
            this.btn2nd.TabIndex = 4;
            this.btn2nd.Text = "SecondBest";
            this.btn2nd.UseVisualStyleBackColor = true;
            this.btn2nd.Click += new System.EventHandler(this.btn2nd_Click);
            // 
            // btn3rd
            // 
            this.btn3rd.Location = new System.Drawing.Point(601, 237);
            this.btn3rd.Name = "btn3rd";
            this.btn3rd.Size = new System.Drawing.Size(367, 23);
            this.btn3rd.TabIndex = 5;
            this.btn3rd.Text = "Third Best";
            this.btn3rd.UseVisualStyleBackColor = true;
            this.btn3rd.Click += new System.EventHandler(this.btn3rd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 324);
            this.Controls.Add(this.btn3rd);
            this.Controls.Add(this.btn2nd);
            this.Controls.Add(this.btn1st);
            this.Controls.Add(this.picThirdBest);
            this.Controls.Add(this.picSecondBest);
            this.Controls.Add(this.picBestGame);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBestGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSecondBest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThirdBest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picBestGame;
        private PictureBox picSecondBest;
        private PictureBox picThirdBest;
        private Button btn1st;
        private Button btn2nd;
        private Button btn3rd;
    }
}