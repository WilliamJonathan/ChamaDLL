
namespace ChamaDLL
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.longitude = new System.Windows.Forms.Label();
            this.latitude = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(446, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "executar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // longitude
            // 
            this.longitude.AutoSize = true;
            this.longitude.Location = new System.Drawing.Point(16, 111);
            this.longitude.Name = "longitude";
            this.longitude.Size = new System.Drawing.Size(50, 13);
            this.longitude.TabIndex = 2;
            this.longitude.Text = "longitude";
            // 
            // latitude
            // 
            this.latitude.AutoSize = true;
            this.latitude.Location = new System.Drawing.Point(16, 70);
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(41, 13);
            this.latitude.TabIndex = 3;
            this.latitude.Text = "latitude";
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Location = new System.Drawing.Point(16, 152);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(28, 13);
            this.data.TabIndex = 4;
            this.data.Text = "data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 450);
            this.Controls.Add(this.data);
            this.Controls.Add(this.latitude);
            this.Controls.Add(this.longitude);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label longitude;
        private System.Windows.Forms.Label latitude;
        private System.Windows.Forms.Label data;
    }
}

