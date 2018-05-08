namespace AreaProcedureThomasA
{
    partial class frmAreaProcedure
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblLengthPrompt = new System.Windows.Forms.Label();
            this.lblWidthPrompt = new System.Windows.Forms.Label();
            this.lblTitlePrompt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(169, 200);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(52, 143);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 1;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(263, 143);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 2;
            // 
            // lblLengthPrompt
            // 
            this.lblLengthPrompt.AutoSize = true;
            this.lblLengthPrompt.Location = new System.Drawing.Point(49, 116);
            this.lblLengthPrompt.Name = "lblLengthPrompt";
            this.lblLengthPrompt.Size = new System.Drawing.Size(87, 13);
            this.lblLengthPrompt.TabIndex = 3;
            this.lblLengthPrompt.Text = "Enter your length";
            // 
            // lblWidthPrompt
            // 
            this.lblWidthPrompt.AutoSize = true;
            this.lblWidthPrompt.Location = new System.Drawing.Point(260, 116);
            this.lblWidthPrompt.Name = "lblWidthPrompt";
            this.lblWidthPrompt.Size = new System.Drawing.Size(83, 13);
            this.lblWidthPrompt.TabIndex = 4;
            this.lblWidthPrompt.Text = "Enter your width";
            // 
            // lblTitlePrompt
            // 
            this.lblTitlePrompt.AutoSize = true;
            this.lblTitlePrompt.Location = new System.Drawing.Point(122, 37);
            this.lblTitlePrompt.Name = "lblTitlePrompt";
            this.lblTitlePrompt.Size = new System.Drawing.Size(158, 13);
            this.lblTitlePrompt.TabIndex = 5;
            this.lblTitlePrompt.Text = "Calculate Area With Procedures";
            // 
            // frmAreaProcedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 253);
            this.Controls.Add(this.lblTitlePrompt);
            this.Controls.Add(this.lblWidthPrompt);
            this.Controls.Add(this.lblLengthPrompt);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmAreaProcedure";
            this.Text = "Area Procedure By Thomas Aubin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblLengthPrompt;
        private System.Windows.Forms.Label lblWidthPrompt;
        private System.Windows.Forms.Label lblTitlePrompt;
    }
}

