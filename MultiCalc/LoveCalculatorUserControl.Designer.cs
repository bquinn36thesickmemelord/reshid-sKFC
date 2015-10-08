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
            this.button1 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 134);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LoveCalculatorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;

    }
}
