namespace praktikumweek14
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
            this.textBox1Input = new System.Windows.Forms.TextBox();
            this.label1Input = new System.Windows.Forms.Label();
            this.button1Reverse = new System.Windows.Forms.Button();
            this.button2Sort = new System.Windows.Forms.Button();
            this.label2Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1Input
            // 
            this.textBox1Input.Location = new System.Drawing.Point(64, 83);
            this.textBox1Input.Name = "textBox1Input";
            this.textBox1Input.Size = new System.Drawing.Size(185, 20);
            this.textBox1Input.TabIndex = 0;
            // 
            // label1Input
            // 
            this.label1Input.AutoSize = true;
            this.label1Input.Location = new System.Drawing.Point(64, 64);
            this.label1Input.Name = "label1Input";
            this.label1Input.Size = new System.Drawing.Size(37, 13);
            this.label1Input.TabIndex = 1;
            this.label1Input.Text = "Input :";
            // 
            // button1Reverse
            // 
            this.button1Reverse.Location = new System.Drawing.Point(64, 123);
            this.button1Reverse.Name = "button1Reverse";
            this.button1Reverse.Size = new System.Drawing.Size(92, 23);
            this.button1Reverse.TabIndex = 2;
            this.button1Reverse.Text = "REVERSE";
            this.button1Reverse.UseVisualStyleBackColor = true;
            this.button1Reverse.Click += new System.EventHandler(this.button1Reverse_Click);
            // 
            // button2Sort
            // 
            this.button2Sort.Location = new System.Drawing.Point(162, 123);
            this.button2Sort.Name = "button2Sort";
            this.button2Sort.Size = new System.Drawing.Size(87, 23);
            this.button2Sort.TabIndex = 3;
            this.button2Sort.Text = "URUTKAN";
            this.button2Sort.UseVisualStyleBackColor = true;
            this.button2Sort.Click += new System.EventHandler(this.button2Sort_Click);
            // 
            // label2Output
            // 
            this.label2Output.AutoSize = true;
            this.label2Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Output.Location = new System.Drawing.Point(61, 178);
            this.label2Output.Name = "label2Output";
            this.label2Output.Size = new System.Drawing.Size(52, 16);
            this.label2Output.TabIndex = 4;
            this.label2Output.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 248);
            this.Controls.Add(this.label2Output);
            this.Controls.Add(this.button2Sort);
            this.Controls.Add(this.button1Reverse);
            this.Controls.Add(this.label1Input);
            this.Controls.Add(this.textBox1Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1Input;
        private System.Windows.Forms.Label label1Input;
        private System.Windows.Forms.Button button1Reverse;
        private System.Windows.Forms.Button button2Sort;
        private System.Windows.Forms.Label label2Output;
    }
}

