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
            this.linia = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.wylicz = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Menu_panel.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.Menu_panel.Controls.Add(this.panel1);
            this.Menu_panel.Controls.Add(this.panel2);
            this.Menu_panel.Controls.Add(this.linia);
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
            this.Main_panel.Margin = new System.Windows.Forms.Padding(0);
            this.Main_panel.Name = "Main_panel";
            this.Main_panel.Size = new System.Drawing.Size(872, 445);
            this.Main_panel.TabIndex = 3;
            // 
            // linia
            // 
            this.linia.BackColor = System.Drawing.Color.White;
            this.linia.Dock = System.Windows.Forms.DockStyle.Top;
            this.linia.Location = new System.Drawing.Point(0, 0);
            this.linia.Margin = new System.Windows.Forms.Padding(0);
            this.linia.Name = "linia";
            this.linia.Size = new System.Drawing.Size(200, 2);
            this.linia.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.wylicz);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 60);
            this.panel2.TabIndex = 2;
            // 
            // wylicz
            // 
            this.wylicz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wylicz.FlatAppearance.BorderSize = 0;
            this.wylicz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wylicz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wylicz.ForeColor = System.Drawing.Color.White;
            this.wylicz.Location = new System.Drawing.Point(0, 0);
            this.wylicz.Margin = new System.Windows.Forms.Padding(0);
            this.wylicz.Name = "wylicz";
            this.wylicz.Size = new System.Drawing.Size(200, 60);
            this.wylicz.TabIndex = 0;
            this.wylicz.Text = "Wylicz";
            this.wylicz.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 2);
            this.panel1.TabIndex = 3;
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
            this.Menu_panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Top_panel;
        private System.Windows.Forms.Panel Menu_panel;
        private System.Windows.Forms.Panel Info_panel;
        private System.Windows.Forms.Panel Main_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button wylicz;
        private System.Windows.Forms.Panel linia;
        private System.Windows.Forms.Panel panel1;
    }
}

