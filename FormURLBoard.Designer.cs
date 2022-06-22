namespace ShortURL_DesktopClient
{
    partial class FormURLBoard
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
            this.listViewURLs = new System.Windows.Forms.ListView();
            this.buttonReload = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewURLs
            // 
            this.listViewURLs.AccessibleName = "URLs list box";
            this.listViewURLs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewURLs.FullRowSelect = true;
            this.listViewURLs.HideSelection = false;
            this.listViewURLs.LabelWrap = false;
            this.listViewURLs.Location = new System.Drawing.Point(0, 53);
            this.listViewURLs.MultiSelect = false;
            this.listViewURLs.Name = "listViewURLs";
            this.listViewURLs.Size = new System.Drawing.Size(908, 507);
            this.listViewURLs.TabIndex = 4;
            this.listViewURLs.UseCompatibleStateImageBehavior = false;
            this.listViewURLs.View = System.Windows.Forms.View.Details;
            // 
            // buttonReload
            // 
            this.buttonReload.AccessibleName = "reload button";
            this.buttonReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReload.Location = new System.Drawing.Point(802, 12);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(94, 29);
            this.buttonReload.TabIndex = 3;
            this.buttonReload.Text = "⟳ Reload";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 561);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(908, 24);
            this.statusStrip.TabIndex = 7;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.AccessibleName = "status box";
            this.toolStripStatusLabel.AutoToolTip = true;
            this.toolStripStatusLabel.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.toolStripStatusLabel.Size = new System.Drawing.Size(854, 24);
            this.toolStripStatusLabel.Spring = true;
            this.toolStripStatusLabel.Text = "Connecting ...";
            this.toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonAdd
            // 
            this.buttonAdd.AccessibleName = "add button";
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(12, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(79, 29);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "✚ Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormURLBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 585);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.listViewURLs);
            this.Controls.Add(this.statusStrip);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "FormURLBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Short URLs";
            this.Shown += new System.EventHandler(this.URLBoardForm_Shown);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewURLs;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Button buttonAdd;
    }
}