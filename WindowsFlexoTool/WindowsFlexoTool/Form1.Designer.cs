namespace WindowsFlexoTool
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
            this.Top_panel = new System.Windows.Forms.Panel();
            this.Menu_panel = new System.Windows.Forms.Panel();
            this.Info_panel = new System.Windows.Forms.Panel();
            this.Main_panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Top_panel
            // 
            this.Top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Top_panel.BackgroundImage = global::WindowsFlexoTool.Properties.Resources.banner_flexotool_70_White;
            this.Top_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_panel.Location = new System.Drawing.Point(0, 0);
            this.Top_panel.Name = "Top_panel";
            this.Top_panel.Size = new System.Drawing.Size(1072, 70);
            this.Top_panel.TabIndex = 0;
            // 
            // Menu_panel
            // 
            this.Menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Menu_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu_panel.Location = new System.Drawing.Point(0, 70);
            this.Menu_panel.Name = "Menu_panel";
            this.Menu_panel.Size = new System.Drawing.Size(200, 515);
            this.Menu_panel.TabIndex = 1;
            // 
            // Info_panel
            // 
            this.Info_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Info_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Info_panel.Location = new System.Drawing.Point(200, 515);
            this.Info_panel.Name = "Info_panel";
            this.Info_panel.Size = new System.Drawing.Size(872, 70);
            this.Info_panel.TabIndex = 2;
            // 
            // Main_panel
            // 
            this.Main_panel.BackColor = System.Drawing.Color.White;
            this.Main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_panel.Location = new System.Drawing.Point(200, 70);
            this.Main_panel.Name = "Main_panel";
            this.Main_panel.Size = new System.Drawing.Size(872, 445);
            this.Main_panel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 585);
            this.Controls.Add(this.Main_panel);
            this.Controls.Add(this.Info_panel);
            this.Controls.Add(this.Menu_panel);
            this.Controls.Add(this.Top_panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Top_panel;
        private System.Windows.Forms.Panel Menu_panel;
        private System.Windows.Forms.Panel Info_panel;
        private System.Windows.Forms.Panel Main_panel;
    }
}

