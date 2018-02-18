namespace hbpm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_title = new System.Windows.Forms.Panel();
            this.label1_x = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.pictureBox_icon = new System.Windows.Forms.PictureBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.button1_register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label1_dia = new System.Windows.Forms.Label();
            this.label1_sys = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel5_save_color = new System.Windows.Forms.Panel();
            this.panel5_save_buttonpanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4_db_color = new System.Windows.Forms.Panel();
            this.panel4_db_buttonpanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_hbpm_color = new System.Windows.Forms.Panel();
            this.panel3_hbpm_buttonpanel = new System.Windows.Forms.Panel();
            this.pictureBox2_hbpm = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).BeginInit();
            this.panel_main.SuspendLayout();
            this.panel5_save_color.SuspendLayout();
            this.panel5_save_buttonpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4_db_color.SuspendLayout();
            this.panel4_db_buttonpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_hbpm_color.SuspendLayout();
            this.panel3_hbpm_buttonpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_hbpm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.Color.Tomato;
            this.panel_title.Controls.Add(this.label1_x);
            this.panel_title.Controls.Add(this.panel2);
            this.panel_title.Controls.Add(this.label_title);
            this.panel_title.Controls.Add(this.pictureBox_icon);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.ForeColor = System.Drawing.Color.Black;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(363, 20);
            this.panel_title.TabIndex = 0;
            this.panel_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseDown);
            this.panel_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseMove);
            this.panel_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseUp);
            // 
            // label1_x
            // 
            this.label1_x.AutoSize = true;
            this.label1_x.Location = new System.Drawing.Point(346, 4);
            this.label1_x.Name = "label1_x";
            this.label1_x.Size = new System.Drawing.Size(14, 13);
            this.label1_x.TabIndex = 3;
            this.label1_x.Text = "X";
            this.label1_x.Click += new System.EventHandler(this.label1_x_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 3);
            this.panel2.TabIndex = 2;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(3, 2);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(92, 17);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "HBPM Register";
            // 
            // pictureBox_icon
            // 
            this.pictureBox_icon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_icon.Image")));
            this.pictureBox_icon.Location = new System.Drawing.Point(95, 3);
            this.pictureBox_icon.Name = "pictureBox_icon";
            this.pictureBox_icon.Size = new System.Drawing.Size(20, 16);
            this.pictureBox_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_icon.TabIndex = 0;
            this.pictureBox_icon.TabStop = false;
            this.pictureBox_icon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox_icon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            this.pictureBox_icon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.White;
            this.panel_main.Controls.Add(this.button1_register);
            this.panel_main.Controls.Add(this.label1);
            this.panel_main.Controls.Add(this.label1_dia);
            this.panel_main.Controls.Add(this.label1_sys);
            this.panel_main.Controls.Add(this.textBox3);
            this.panel_main.Controls.Add(this.textBox2);
            this.panel_main.Controls.Add(this.textBox1);
            this.panel_main.Controls.Add(this.panel5_save_color);
            this.panel_main.Controls.Add(this.panel4_db_color);
            this.panel_main.Controls.Add(this.panel_hbpm_color);
            this.panel_main.Controls.Add(this.panel1);
            this.panel_main.Controls.Add(this.pictureBox1);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 20);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(363, 125);
            this.panel_main.TabIndex = 1;
            // 
            // button1_register
            // 
            this.button1_register.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1_register.FlatAppearance.BorderSize = 0;
            this.button1_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_register.Location = new System.Drawing.Point(79, 93);
            this.button1_register.Name = "button1_register";
            this.button1_register.Size = new System.Drawing.Size(252, 23);
            this.button1_register.TabIndex = 11;
            this.button1_register.Text = "Register";
            this.button1_register.UseVisualStyleBackColor = false;
            this.button1_register.Click += new System.EventHandler(this.button1_register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(273, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pulse";
            // 
            // label1_dia
            // 
            this.label1_dia.AutoSize = true;
            this.label1_dia.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1_dia.Location = new System.Drawing.Point(178, 13);
            this.label1_dia.Name = "label1_dia";
            this.label1_dia.Size = new System.Drawing.Size(57, 17);
            this.label1_dia.TabIndex = 9;
            this.label1_dia.Text = "Diastole";
            // 
            // label1_sys
            // 
            this.label1_sys.AutoSize = true;
            this.label1_sys.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1_sys.Location = new System.Drawing.Point(95, 13);
            this.label1_sys.Name = "label1_sys";
            this.label1_sys.Size = new System.Drawing.Size(50, 17);
            this.label1_sys.TabIndex = 8;
            this.label1_sys.Text = "Systole";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(251, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(80, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(165, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(79, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.ModifiedChanged += new System.EventHandler(this.textBox1_ModifiedChanged);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // panel5_save_color
            // 
            this.panel5_save_color.BackColor = System.Drawing.Color.LimeGreen;
            this.panel5_save_color.Controls.Add(this.panel5_save_buttonpanel);
            this.panel5_save_color.Location = new System.Drawing.Point(0, 82);
            this.panel5_save_color.Name = "panel5_save_color";
            this.panel5_save_color.Size = new System.Drawing.Size(42, 40);
            this.panel5_save_color.TabIndex = 4;
            // 
            // panel5_save_buttonpanel
            // 
            this.panel5_save_buttonpanel.BackColor = System.Drawing.Color.DarkGray;
            this.panel5_save_buttonpanel.Controls.Add(this.pictureBox3);
            this.panel5_save_buttonpanel.Location = new System.Drawing.Point(0, 0);
            this.panel5_save_buttonpanel.Name = "panel5_save_buttonpanel";
            this.panel5_save_buttonpanel.Size = new System.Drawing.Size(40, 40);
            this.panel5_save_buttonpanel.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel4_db_color
            // 
            this.panel4_db_color.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel4_db_color.Controls.Add(this.panel4_db_buttonpanel);
            this.panel4_db_color.Location = new System.Drawing.Point(0, 41);
            this.panel4_db_color.Name = "panel4_db_color";
            this.panel4_db_color.Size = new System.Drawing.Size(42, 41);
            this.panel4_db_color.TabIndex = 3;
            // 
            // panel4_db_buttonpanel
            // 
            this.panel4_db_buttonpanel.BackColor = System.Drawing.Color.Gray;
            this.panel4_db_buttonpanel.Controls.Add(this.pictureBox2);
            this.panel4_db_buttonpanel.Location = new System.Drawing.Point(0, 0);
            this.panel4_db_buttonpanel.Name = "panel4_db_buttonpanel";
            this.panel4_db_buttonpanel.Size = new System.Drawing.Size(40, 41);
            this.panel4_db_buttonpanel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel_hbpm_color
            // 
            this.panel_hbpm_color.BackColor = System.Drawing.Color.Crimson;
            this.panel_hbpm_color.Controls.Add(this.panel3_hbpm_buttonpanel);
            this.panel_hbpm_color.Location = new System.Drawing.Point(0, 0);
            this.panel_hbpm_color.Name = "panel_hbpm_color";
            this.panel_hbpm_color.Size = new System.Drawing.Size(42, 41);
            this.panel_hbpm_color.TabIndex = 2;
            // 
            // panel3_hbpm_buttonpanel
            // 
            this.panel3_hbpm_buttonpanel.BackColor = System.Drawing.Color.DimGray;
            this.panel3_hbpm_buttonpanel.Controls.Add(this.pictureBox2_hbpm);
            this.panel3_hbpm_buttonpanel.Location = new System.Drawing.Point(0, 0);
            this.panel3_hbpm_buttonpanel.Name = "panel3_hbpm_buttonpanel";
            this.panel3_hbpm_buttonpanel.Size = new System.Drawing.Size(40, 41);
            this.panel3_hbpm_buttonpanel.TabIndex = 0;
            // 
            // pictureBox2_hbpm
            // 
            this.pictureBox2_hbpm.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2_hbpm.Image")));
            this.pictureBox2_hbpm.Location = new System.Drawing.Point(5, 5);
            this.pictureBox2_hbpm.Name = "pictureBox2_hbpm";
            this.pictureBox2_hbpm.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2_hbpm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2_hbpm.TabIndex = 0;
            this.pictureBox2_hbpm.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Location = new System.Drawing.Point(0, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 10);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 145);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.panel5_save_color.ResumeLayout(false);
            this.panel5_save_buttonpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4_db_color.ResumeLayout(false);
            this.panel4_db_buttonpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_hbpm_color.ResumeLayout(false);
            this.panel3_hbpm_buttonpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_hbpm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox_icon;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_hbpm_color;
        private System.Windows.Forms.Panel panel5_save_color;
        private System.Windows.Forms.Panel panel4_db_color;
        private System.Windows.Forms.Panel panel5_save_buttonpanel;
        private System.Windows.Forms.Panel panel4_db_buttonpanel;
        private System.Windows.Forms.Panel panel3_hbpm_buttonpanel;
        private System.Windows.Forms.PictureBox pictureBox2_hbpm;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1_x;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label1_dia;
        private System.Windows.Forms.Label label1_sys;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1_register;
    }
}

