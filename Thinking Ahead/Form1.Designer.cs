namespace Thinking_Ahead
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
            this.btnTest = new System.Windows.Forms.Button();
            this.ButtonDoubleCounter = new System.Windows.Forms.Button();
            this.Listcounter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnTest.Location = new System.Drawing.Point(614, 12);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonDoubleCounter
            // 
            this.ButtonDoubleCounter.Location = new System.Drawing.Point(438, 27);
            this.ButtonDoubleCounter.Name = "ButtonDoubleCounter";
            this.ButtonDoubleCounter.Size = new System.Drawing.Size(70, 30);
            this.ButtonDoubleCounter.TabIndex = 1;
            this.ButtonDoubleCounter.Text = "Double";
            this.ButtonDoubleCounter.UseVisualStyleBackColor = true;
            this.ButtonDoubleCounter.Click += new System.EventHandler(this.ButtonDoubleCounter_Click);
            // 
            // Listcounter
            // 
            this.Listcounter.Location = new System.Drawing.Point(568, 87);
            this.Listcounter.Name = "Listcounter";
            this.Listcounter.Size = new System.Drawing.Size(98, 48);
            this.Listcounter.TabIndex = 2;
            this.Listcounter.Text = "List button";
            this.Listcounter.UseVisualStyleBackColor = true;
            this.Listcounter.Click += new System.EventHandler(this.Listcounter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 549);
            this.Controls.Add(this.Listcounter);
            this.Controls.Add(this.ButtonDoubleCounter);
            this.Controls.Add(this.btnTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button ButtonDoubleCounter;
        private System.Windows.Forms.Button Listcounter;
    }
}

