namespace Faceing
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
            this.components = new System.ComponentModel.Container();
            this.menu = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addressbar = new System.Windows.Forms.TextBox();
            this.home_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.forward_btn = new System.Windows.Forms.Button();
            this.Talk_Btn = new System.Windows.Forms.Button();
            this.favorites_btn = new System.Windows.Forms.Button();
            this.speek_box = new System.Windows.Forms.TextBox();
            this.Record_BTN = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.menu.Location = new System.Drawing.Point(1299, 753);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(75, 23);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // addressbar
            // 
            this.addressbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressbar.Location = new System.Drawing.Point(84, 19);
            this.addressbar.Name = "addressbar";
            this.addressbar.Size = new System.Drawing.Size(1176, 20);
            this.addressbar.TabIndex = 3;
            // 
            // home_btn
            // 
            this.home_btn.Location = new System.Drawing.Point(46, 12);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(32, 32);
            this.home_btn.TabIndex = 4;
            this.home_btn.Text = "home";
            this.home_btn.UseVisualStyleBackColor = true;
            // 
            // refresh_btn
            // 
            this.refresh_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refresh_btn.Location = new System.Drawing.Point(1266, 12);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(32, 32);
            this.refresh_btn.TabIndex = 5;
            this.refresh_btn.Text = "refresh";
            this.refresh_btn.UseVisualStyleBackColor = true;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(8, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(32, 32);
            this.back_btn.TabIndex = 6;
            this.back_btn.Text = "back";
            this.back_btn.UseVisualStyleBackColor = true;
            // 
            // forward_btn
            // 
            this.forward_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.forward_btn.Location = new System.Drawing.Point(1342, 12);
            this.forward_btn.Name = "forward_btn";
            this.forward_btn.Size = new System.Drawing.Size(32, 32);
            this.forward_btn.TabIndex = 7;
            this.forward_btn.Text = "forward";
            this.forward_btn.UseVisualStyleBackColor = true;
            // 
            // Talk_Btn
            // 
            this.Talk_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Talk_Btn.Location = new System.Drawing.Point(677, 378);
            this.Talk_Btn.Name = "Talk_Btn";
            this.Talk_Btn.Size = new System.Drawing.Size(112, 32);
            this.Talk_Btn.TabIndex = 8;
            this.Talk_Btn.Text = "Talk";
            this.Talk_Btn.UseVisualStyleBackColor = true;
            this.Talk_Btn.Click += new System.EventHandler(this.Talk_Btn_Click);
            // 
            // favorites_btn
            // 
            this.favorites_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.favorites_btn.Location = new System.Drawing.Point(1304, 12);
            this.favorites_btn.Name = "favorites_btn";
            this.favorites_btn.Size = new System.Drawing.Size(32, 32);
            this.favorites_btn.TabIndex = 9;
            this.favorites_btn.Text = "favorites";
            this.favorites_btn.UseVisualStyleBackColor = true;
            // 
            // speek_box
            // 
            this.speek_box.Location = new System.Drawing.Point(677, 282);
            this.speek_box.Multiline = true;
            this.speek_box.Name = "speek_box";
            this.speek_box.Size = new System.Drawing.Size(112, 90);
            this.speek_box.TabIndex = 10;
            // 
            // Record_BTN
            // 
            this.Record_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Record_BTN.Location = new System.Drawing.Point(677, 416);
            this.Record_BTN.Name = "Record_BTN";
            this.Record_BTN.Size = new System.Drawing.Size(112, 32);
            this.Record_BTN.TabIndex = 11;
            this.Record_BTN.Text = "Record";
            this.Record_BTN.UseVisualStyleBackColor = true;
            this.Record_BTN.Click += new System.EventHandler(this.Record_BTN_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(559, 282);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 90);
            this.textBox1.TabIndex = 12;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 11;
            this.listBox1.Location = new System.Drawing.Point(8, 648);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(1285, 132);
            this.listBox1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Record_BTN);
            this.Controls.Add(this.speek_box);
            this.Controls.Add(this.favorites_btn);
            this.Controls.Add(this.Talk_Btn);
            this.Controls.Add(this.forward_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.addressbar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addressbar;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button forward_btn;
        private System.Windows.Forms.Button Talk_Btn;
        private System.Windows.Forms.Button favorites_btn;
        private System.Windows.Forms.TextBox speek_box;
        private System.Windows.Forms.Button Record_BTN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

