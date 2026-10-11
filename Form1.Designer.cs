namespace Lab3_MIP
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.home_btn = new System.Windows.Forms.ToolStripButton();
            this.navigate_btn = new System.Windows.Forms.ToolStripButton();
            this.text_box = new System.Windows.Forms.ToolStripTextBox();
            this.forward_btn = new System.Windows.Forms.ToolStripButton();
            this.back_btn = new System.Windows.Forms.ToolStripButton();
            this.keyword_text = new System.Windows.Forms.ToolStripTextBox();
            this.add_keyword_btn = new System.Windows.Forms.ToolStripButton();
            this.keywords_combo = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 450);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.home_btn,
            this.navigate_btn,
            this.text_box,
            this.forward_btn,
            this.back_btn,
            this.keyword_text,
            this.add_keyword_btn,
            this.keywords_combo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // home_btn
            // 
            this.home_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.home_btn.Image = ((System.Drawing.Image)(resources.GetObject("home_btn.Image")));
            this.home_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(29, 28);
            this.home_btn.Text = "Home";
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // navigate_btn
            // 
            this.navigate_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.navigate_btn.Image = ((System.Drawing.Image)(resources.GetObject("navigate_btn.Image")));
            this.navigate_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.navigate_btn.Name = "navigate_btn";
            this.navigate_btn.Size = new System.Drawing.Size(29, 28);
            this.navigate_btn.Text = "Navigate";
            this.navigate_btn.Click += new System.EventHandler(this.navigate_btn_Click);
            // 
            // text_box
            // 
            this.text_box.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_box.Name = "text_box";
            this.text_box.Size = new System.Drawing.Size(350, 31);
            this.text_box.Text = "Search...";
            this.text_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_box_KeyDown);
            // 
            // forward_btn
            // 
            this.forward_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forward_btn.Image = ((System.Drawing.Image)(resources.GetObject("forward_btn.Image")));
            this.forward_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forward_btn.Name = "forward_btn";
            this.forward_btn.Size = new System.Drawing.Size(29, 28);
            this.forward_btn.Text = "Forward";
            this.forward_btn.Click += new System.EventHandler(this.forward_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.back_btn.Image = ((System.Drawing.Image)(resources.GetObject("back_btn.Image")));
            this.back_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(29, 28);
            this.back_btn.Text = "Back";
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // keyword_text
            // 
            this.keyword_text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.keyword_text.Name = "keyword_text";
            this.keyword_text.Size = new System.Drawing.Size(100, 31);
            // 
            // add_keyword_btn
            // 
            this.add_keyword_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.add_keyword_btn.Image = ((System.Drawing.Image)(resources.GetObject("add_keyword_btn.Image")));
            this.add_keyword_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add_keyword_btn.Name = "add_keyword_btn";
            this.add_keyword_btn.Size = new System.Drawing.Size(29, 28);
            this.add_keyword_btn.Text = "Add keyword...";
            this.add_keyword_btn.Click += new System.EventHandler(this.add_keyword_btn_Click);
            // 
            // keywords_combo
            // 
            this.keywords_combo.Name = "keywords_combo";
            this.keywords_combo.Size = new System.Drawing.Size(121, 31);
            this.keywords_combo.Text = "Keywords list";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton navigate_btn;
        private System.Windows.Forms.ToolStripButton back_btn;
        private System.Windows.Forms.ToolStripButton forward_btn;
        private System.Windows.Forms.ToolStripButton home_btn;
        private System.Windows.Forms.ToolStripTextBox text_box;
        private System.Windows.Forms.ToolStripTextBox keyword_text;
        private System.Windows.Forms.ToolStripButton add_keyword_btn;
        private System.Windows.Forms.ToolStripComboBox keywords_combo;
    }
}

