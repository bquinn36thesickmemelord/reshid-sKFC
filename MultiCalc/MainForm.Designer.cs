namespace MultiCalc
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MenuFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SampleButton = new System.Windows.Forms.Button();
            this.JetFuel = new System.Windows.Forms.Button();
            this.johncenabutton = new System.Windows.Forms.Button();
            this.btnLoveCalculator = new System.Windows.Forms.Button();
            this.HostPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.MenuFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.65648F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.34352F));
            this.tableLayoutPanel1.Controls.Add(this.MenuFlowLayoutPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.HostPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(687, 447);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // MenuFlowLayoutPanel
            // 
            this.MenuFlowLayoutPanel.Controls.Add(this.SampleButton);
            this.MenuFlowLayoutPanel.Controls.Add(this.JetFuel);
            this.MenuFlowLayoutPanel.Controls.Add(this.johncenabutton);
            this.MenuFlowLayoutPanel.Controls.Add(this.btnLoveCalculator);
            this.MenuFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MenuFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MenuFlowLayoutPanel.Name = "MenuFlowLayoutPanel";
            this.MenuFlowLayoutPanel.Size = new System.Drawing.Size(190, 447);
            this.MenuFlowLayoutPanel.TabIndex = 0;
            // 
            // SampleButton
            // 
            this.SampleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SampleButton.Location = new System.Drawing.Point(3, 3);
            this.SampleButton.Name = "SampleButton";
            this.SampleButton.Size = new System.Drawing.Size(180, 29);
            this.SampleButton.TabIndex = 0;
            this.SampleButton.Text = "Sample Calculator";
            this.SampleButton.UseVisualStyleBackColor = true;
            this.SampleButton.Click += new System.EventHandler(this.SampleButton_Click);
            // 
            // JetFuel
            // 
            this.JetFuel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JetFuel.Location = new System.Drawing.Point(3, 38);
            this.JetFuel.Name = "JetFuel";
            this.JetFuel.Size = new System.Drawing.Size(180, 29);
            this.JetFuel.TabIndex = 1;
            this.JetFuel.Text = "Jet fuel can\'t melt steel beams";
            this.JetFuel.UseVisualStyleBackColor = true;
            this.JetFuel.Click += new System.EventHandler(this.JetFuel_Click);
            // 
            // johncenabutton
            // 
            this.johncenabutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.johncenabutton.Location = new System.Drawing.Point(3, 73);
            this.johncenabutton.Name = "johncenabutton";
            this.johncenabutton.Size = new System.Drawing.Size(180, 29);
            this.johncenabutton.TabIndex = 2;
            this.johncenabutton.Text = "John Cena";
            this.johncenabutton.UseVisualStyleBackColor = true;
            this.johncenabutton.Click += new System.EventHandler(this.johncenabutton_Click);
            // 
            // btnLoveCalculator
            // 
            this.btnLoveCalculator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoveCalculator.Location = new System.Drawing.Point(3, 108);
            this.btnLoveCalculator.Name = "btnLoveCalculator";
            this.btnLoveCalculator.Size = new System.Drawing.Size(180, 29);
            this.btnLoveCalculator.TabIndex = 3;
            this.btnLoveCalculator.Text = "Love Calculator";
            this.btnLoveCalculator.UseVisualStyleBackColor = true;
            this.btnLoveCalculator.Click += new System.EventHandler(this.btnLoveCalculator_Click);
            // 
            // HostPanel
            // 
            this.HostPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HostPanel.Location = new System.Drawing.Point(193, 3);
            this.HostPanel.Name = "HostPanel";
            this.HostPanel.Size = new System.Drawing.Size(491, 441);
            this.HostPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 447);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Multi-Calc 2015 by Year 11 FCCC";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.MenuFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel MenuFlowLayoutPanel;
        private System.Windows.Forms.Button SampleButton;
        private System.Windows.Forms.Panel HostPanel;
        private System.Windows.Forms.Button JetFuel;
        private System.Windows.Forms.Button johncenabutton;
        private System.Windows.Forms.Button btnLoveCalculator;


    }
}

