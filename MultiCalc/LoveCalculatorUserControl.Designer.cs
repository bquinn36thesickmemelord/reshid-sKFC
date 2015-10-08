namespace MultiCalc
{
    partial class LoveCalculatorUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFirstPerson = new System.Windows.Forms.TextBox();
            this.txtSecondPerson = new System.Windows.Forms.TextBox();
            this.btnLoveCalculate = new System.Windows.Forms.Button();
            this.lblLovePercentage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFirstPerson
            // 
            this.txtFirstPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstPerson.Location = new System.Drawing.Point(131, 14);
            this.txtFirstPerson.Name = "txtFirstPerson";
            this.txtFirstPerson.Size = new System.Drawing.Size(246, 31);
            this.txtFirstPerson.TabIndex = 0;
            this.txtFirstPerson.Text = "First Person";
            this.txtFirstPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSecondPerson
            // 
            this.txtSecondPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondPerson.Location = new System.Drawing.Point(131, 56);
            this.txtSecondPerson.Name = "txtSecondPerson";
            this.txtSecondPerson.Size = new System.Drawing.Size(246, 31);
            this.txtSecondPerson.TabIndex = 1;
            this.txtSecondPerson.Text = "Second Person";
            this.txtSecondPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLoveCalculate
            // 
            this.btnLoveCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoveCalculate.Location = new System.Drawing.Point(131, 93);
            this.btnLoveCalculate.Name = "btnLoveCalculate";
            this.btnLoveCalculate.Size = new System.Drawing.Size(246, 134);
            this.btnLoveCalculate.TabIndex = 2;
            this.btnLoveCalculate.Text = "Calculate";
            this.btnLoveCalculate.UseVisualStyleBackColor = true;
            this.btnLoveCalculate.Click += new System.EventHandler(this.btnLoveCalculate_Click);
            // 
            // lblLovePercentage
            // 
            this.lblLovePercentage.AutoSize = true;
            this.lblLovePercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLovePercentage.Location = new System.Drawing.Point(146, 230);
            this.lblLovePercentage.Name = "lblLovePercentage";
            this.lblLovePercentage.Size = new System.Drawing.Size(0, 108);
            this.lblLovePercentage.TabIndex = 3;
            this.lblLovePercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoveCalculatorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.Controls.Add(this.lblLovePercentage);
            this.Controls.Add(this.btnLoveCalculate);
            this.Controls.Add(this.txtSecondPerson);
            this.Controls.Add(this.txtFirstPerson);
            this.Name = "LoveCalculatorUserControl";
            this.Size = new System.Drawing.Size(534, 472);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstPerson;
        private System.Windows.Forms.TextBox txtSecondPerson;
        private System.Windows.Forms.Button btnLoveCalculate;
        private System.Windows.Forms.Label lblLovePercentage;

    }
}
