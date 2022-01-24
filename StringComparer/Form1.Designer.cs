namespace StringComparer
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStringX = new System.Windows.Forms.Label();
            this.lblStringY = new System.Windows.Forms.Label();
            this.txtStringX = new System.Windows.Forms.TextBox();
            this.txtStringY = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(93, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(377, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "String Comparer";
            // 
            // lblStringX
            // 
            this.lblStringX.AutoSize = true;
            this.lblStringX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStringX.Location = new System.Drawing.Point(12, 93);
            this.lblStringX.Name = "lblStringX";
            this.lblStringX.Size = new System.Drawing.Size(88, 25);
            this.lblStringX.TabIndex = 1;
            this.lblStringX.Text = "String X";
            // 
            // lblStringY
            // 
            this.lblStringY.AutoSize = true;
            this.lblStringY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStringY.Location = new System.Drawing.Point(12, 137);
            this.lblStringY.Name = "lblStringY";
            this.lblStringY.Size = new System.Drawing.Size(89, 25);
            this.lblStringY.TabIndex = 1;
            this.lblStringY.Text = "String Y";
            // 
            // txtStringX
            // 
            this.txtStringX.Location = new System.Drawing.Point(174, 95);
            this.txtStringX.Name = "txtStringX";
            this.txtStringX.Size = new System.Drawing.Size(265, 20);
            this.txtStringX.TabIndex = 2;
            this.txtStringX.TextChanged += new System.EventHandler(this.txtStringX_TextChanged);
            // 
            // txtStringY
            // 
            this.txtStringY.Location = new System.Drawing.Point(174, 140);
            this.txtStringY.Name = "txtStringY";
            this.txtStringY.Size = new System.Drawing.Size(265, 20);
            this.txtStringY.TabIndex = 2;
            this.txtStringY.TextChanged += new System.EventHandler(this.txtStringY_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(208, 181);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(187, 39);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter two strings and press calculate ";
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(436, 334);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(115, 40);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 386);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtStringY);
            this.Controls.Add(this.txtStringX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStringY);
            this.Controls.Add(this.lblStringX);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStringX;
        private System.Windows.Forms.Label lblStringY;
        private System.Windows.Forms.TextBox txtStringX;
        private System.Windows.Forms.TextBox txtStringY;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHelp;
    }
}

