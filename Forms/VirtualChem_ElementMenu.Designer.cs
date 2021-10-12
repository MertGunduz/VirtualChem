
namespace VirtualChem.Forms
{
    partial class VirtualChem_ElementMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VirtualChem_ElementMenu));
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.Return_Button = new System.Windows.Forms.Button();
            this.Discovered_TextBox = new System.Windows.Forms.TextBox();
            this.Radius_TextBox = new System.Windows.Forms.TextBox();
            this.BoilingPoint_TextBox = new System.Windows.Forms.TextBox();
            this.MeltingPoint_TextBox = new System.Windows.Forms.TextBox();
            this.Weight_TextBox = new System.Windows.Forms.TextBox();
            this.Series_TextBox = new System.Windows.Forms.TextBox();
            this.Element_Label = new System.Windows.Forms.Label();
            this.LeftBorder_Panel = new System.Windows.Forms.Panel();
            this.RightBorder_Panel = new System.Windows.Forms.Panel();
            this.BottomBorder_Panel = new System.Windows.Forms.Panel();
            this.TopBorder_Panel = new System.Windows.Forms.Panel();
            this.LeftMargin_Panel = new System.Windows.Forms.Panel();
            this.RightMargin_Panel = new System.Windows.Forms.Panel();
            this.BottomMargin_Panel = new System.Windows.Forms.Panel();
            this.TopMargin_Panel = new System.Windows.Forms.Panel();
            this.Main_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Panel
            // 
            this.Main_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Main_Panel.Controls.Add(this.Return_Button);
            this.Main_Panel.Controls.Add(this.Discovered_TextBox);
            this.Main_Panel.Controls.Add(this.Radius_TextBox);
            this.Main_Panel.Controls.Add(this.BoilingPoint_TextBox);
            this.Main_Panel.Controls.Add(this.MeltingPoint_TextBox);
            this.Main_Panel.Controls.Add(this.Weight_TextBox);
            this.Main_Panel.Controls.Add(this.Series_TextBox);
            this.Main_Panel.Controls.Add(this.Element_Label);
            this.Main_Panel.Controls.Add(this.LeftBorder_Panel);
            this.Main_Panel.Controls.Add(this.RightBorder_Panel);
            this.Main_Panel.Controls.Add(this.BottomBorder_Panel);
            this.Main_Panel.Controls.Add(this.TopBorder_Panel);
            this.Main_Panel.Controls.Add(this.LeftMargin_Panel);
            this.Main_Panel.Controls.Add(this.RightMargin_Panel);
            this.Main_Panel.Controls.Add(this.BottomMargin_Panel);
            this.Main_Panel.Controls.Add(this.TopMargin_Panel);
            this.Main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Panel.Location = new System.Drawing.Point(0, 0);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(400, 450);
            this.Main_Panel.TabIndex = 0;
            // 
            // Return_Button
            // 
            this.Return_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Return_Button.FlatAppearance.BorderSize = 0;
            this.Return_Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Return_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Return_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Return_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Return_Button.Image = global::VirtualChem.VirtualChem_Resources.VirtualChem_ReturnIcon;
            this.Return_Button.Location = new System.Drawing.Point(349, 17);
            this.Return_Button.Name = "Return_Button";
            this.Return_Button.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.Return_Button.Size = new System.Drawing.Size(25, 30);
            this.Return_Button.TabIndex = 15;
            this.Return_Button.UseVisualStyleBackColor = true;
            this.Return_Button.Click += new System.EventHandler(this.Return_Button_Click);
            // 
            // Discovered_TextBox
            // 
            this.Discovered_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Discovered_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Discovered_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(150)))), ((int)(((byte)(239)))));
            this.Discovered_TextBox.Location = new System.Drawing.Point(27, 390);
            this.Discovered_TextBox.Name = "Discovered_TextBox";
            this.Discovered_TextBox.ReadOnly = true;
            this.Discovered_TextBox.Size = new System.Drawing.Size(347, 27);
            this.Discovered_TextBox.TabIndex = 14;
            this.Discovered_TextBox.Text = "  Discovered:";
            // 
            // Radius_TextBox
            // 
            this.Radius_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Radius_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Radius_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(150)))), ((int)(((byte)(239)))));
            this.Radius_TextBox.Location = new System.Drawing.Point(27, 328);
            this.Radius_TextBox.Name = "Radius_TextBox";
            this.Radius_TextBox.ReadOnly = true;
            this.Radius_TextBox.Size = new System.Drawing.Size(347, 27);
            this.Radius_TextBox.TabIndex = 13;
            this.Radius_TextBox.Text = "  Radius:";
            // 
            // BoilingPoint_TextBox
            // 
            this.BoilingPoint_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BoilingPoint_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BoilingPoint_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(150)))), ((int)(((byte)(239)))));
            this.BoilingPoint_TextBox.Location = new System.Drawing.Point(27, 266);
            this.BoilingPoint_TextBox.Name = "BoilingPoint_TextBox";
            this.BoilingPoint_TextBox.ReadOnly = true;
            this.BoilingPoint_TextBox.Size = new System.Drawing.Size(347, 27);
            this.BoilingPoint_TextBox.TabIndex = 12;
            this.BoilingPoint_TextBox.Text = "  Boiling Point:";
            // 
            // MeltingPoint_TextBox
            // 
            this.MeltingPoint_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.MeltingPoint_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MeltingPoint_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(150)))), ((int)(((byte)(239)))));
            this.MeltingPoint_TextBox.Location = new System.Drawing.Point(27, 204);
            this.MeltingPoint_TextBox.Name = "MeltingPoint_TextBox";
            this.MeltingPoint_TextBox.ReadOnly = true;
            this.MeltingPoint_TextBox.Size = new System.Drawing.Size(347, 27);
            this.MeltingPoint_TextBox.TabIndex = 11;
            this.MeltingPoint_TextBox.Text = "  Melting Point:";
            // 
            // Weight_TextBox
            // 
            this.Weight_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Weight_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Weight_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(150)))), ((int)(((byte)(239)))));
            this.Weight_TextBox.Location = new System.Drawing.Point(27, 142);
            this.Weight_TextBox.Name = "Weight_TextBox";
            this.Weight_TextBox.ReadOnly = true;
            this.Weight_TextBox.Size = new System.Drawing.Size(347, 27);
            this.Weight_TextBox.TabIndex = 10;
            this.Weight_TextBox.Text = "  Weight:";
            // 
            // Series_TextBox
            // 
            this.Series_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Series_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Series_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(150)))), ((int)(((byte)(239)))));
            this.Series_TextBox.Location = new System.Drawing.Point(27, 80);
            this.Series_TextBox.Name = "Series_TextBox";
            this.Series_TextBox.ReadOnly = true;
            this.Series_TextBox.Size = new System.Drawing.Size(347, 27);
            this.Series_TextBox.TabIndex = 9;
            this.Series_TextBox.Text = "  Series:";
            // 
            // Element_Label
            // 
            this.Element_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Element_Label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Element_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(150)))), ((int)(((byte)(239)))));
            this.Element_Label.Location = new System.Drawing.Point(12, 12);
            this.Element_Label.Name = "Element_Label";
            this.Element_Label.Size = new System.Drawing.Size(376, 50);
            this.Element_Label.TabIndex = 8;
            this.Element_Label.Text = "Element";
            this.Element_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeftBorder_Panel
            // 
            this.LeftBorder_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(150)))), ((int)(((byte)(239)))));
            this.LeftBorder_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftBorder_Panel.Location = new System.Drawing.Point(10, 12);
            this.LeftBorder_Panel.Name = "LeftBorder_Panel";
            this.LeftBorder_Panel.Size = new System.Drawing.Size(2, 426);
            this.LeftBorder_Panel.TabIndex = 7;
            // 
            // RightBorder_Panel
            // 
            this.RightBorder_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(150)))), ((int)(((byte)(239)))));
            this.RightBorder_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightBorder_Panel.Location = new System.Drawing.Point(388, 12);
            this.RightBorder_Panel.Name = "RightBorder_Panel";
            this.RightBorder_Panel.Size = new System.Drawing.Size(2, 426);
            this.RightBorder_Panel.TabIndex = 6;
            // 
            // BottomBorder_Panel
            // 
            this.BottomBorder_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(150)))), ((int)(((byte)(239)))));
            this.BottomBorder_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBorder_Panel.Location = new System.Drawing.Point(10, 438);
            this.BottomBorder_Panel.Name = "BottomBorder_Panel";
            this.BottomBorder_Panel.Size = new System.Drawing.Size(380, 2);
            this.BottomBorder_Panel.TabIndex = 5;
            // 
            // TopBorder_Panel
            // 
            this.TopBorder_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(150)))), ((int)(((byte)(239)))));
            this.TopBorder_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBorder_Panel.Location = new System.Drawing.Point(10, 10);
            this.TopBorder_Panel.Name = "TopBorder_Panel";
            this.TopBorder_Panel.Size = new System.Drawing.Size(380, 2);
            this.TopBorder_Panel.TabIndex = 4;
            // 
            // LeftMargin_Panel
            // 
            this.LeftMargin_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.LeftMargin_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMargin_Panel.Location = new System.Drawing.Point(0, 10);
            this.LeftMargin_Panel.Name = "LeftMargin_Panel";
            this.LeftMargin_Panel.Size = new System.Drawing.Size(10, 430);
            this.LeftMargin_Panel.TabIndex = 3;
            // 
            // RightMargin_Panel
            // 
            this.RightMargin_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.RightMargin_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightMargin_Panel.Location = new System.Drawing.Point(390, 10);
            this.RightMargin_Panel.Name = "RightMargin_Panel";
            this.RightMargin_Panel.Size = new System.Drawing.Size(10, 430);
            this.RightMargin_Panel.TabIndex = 2;
            // 
            // BottomMargin_Panel
            // 
            this.BottomMargin_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BottomMargin_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomMargin_Panel.Location = new System.Drawing.Point(0, 440);
            this.BottomMargin_Panel.Name = "BottomMargin_Panel";
            this.BottomMargin_Panel.Size = new System.Drawing.Size(400, 10);
            this.BottomMargin_Panel.TabIndex = 1;
            // 
            // TopMargin_Panel
            // 
            this.TopMargin_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TopMargin_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopMargin_Panel.Location = new System.Drawing.Point(0, 0);
            this.TopMargin_Panel.Name = "TopMargin_Panel";
            this.TopMargin_Panel.Size = new System.Drawing.Size(400, 10);
            this.TopMargin_Panel.TabIndex = 0;
            // 
            // VirtualChem_ElementMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.Main_Panel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VirtualChem_ElementMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VirtualChem";
            this.Load += new System.EventHandler(this.VirtualChem_ElementMenu_Load);
            this.Main_Panel.ResumeLayout(false);
            this.Main_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main_Panel;
        private System.Windows.Forms.Panel BottomMargin_Panel;
        private System.Windows.Forms.Panel TopMargin_Panel;
        private System.Windows.Forms.Panel LeftMargin_Panel;
        private System.Windows.Forms.Panel RightMargin_Panel;
        private System.Windows.Forms.Panel TopBorder_Panel;
        private System.Windows.Forms.Panel BottomBorder_Panel;
        private System.Windows.Forms.Panel RightBorder_Panel;
        private System.Windows.Forms.Panel LeftBorder_Panel;
        private System.Windows.Forms.Label Element_Label;
        private System.Windows.Forms.TextBox Series_TextBox;
        private System.Windows.Forms.TextBox Discovered_TextBox;
        private System.Windows.Forms.TextBox Radius_TextBox;
        private System.Windows.Forms.TextBox BoilingPoint_TextBox;
        private System.Windows.Forms.TextBox MeltingPoint_TextBox;
        private System.Windows.Forms.TextBox Weight_TextBox;
        private System.Windows.Forms.Button Return_Button;
    }
}