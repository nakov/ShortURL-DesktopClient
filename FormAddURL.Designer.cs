using System;

namespace ShortURL_DesktopClient
{
    partial class FormAddURL
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelURL = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.labelCode = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Location = new System.Drawing.Point(12, 21);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(38, 20);
            this.labelURL.TabIndex = 0;
            this.labelURL.Text = "URL:";
            // 
            // textBoxURL
            // 
            this.textBoxURL.AccessibleName = "url box";
            this.textBoxURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxURL.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxURL.Location = new System.Drawing.Point(65, 16);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(457, 30);
            this.textBoxURL.TabIndex = 1;
            // 
            // buttonCreate
            // 
            this.buttonCreate.AccessibleName = "create button";
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCreate.Location = new System.Drawing.Point(320, 307);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(168, 47);
            this.buttonCreate.TabIndex = 4;
            this.buttonCreate.Text = "✓ Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(12, 65);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(47, 20);
            this.labelCode.TabIndex = 3;
            this.labelCode.Text = "Code:";
            // 
            // textBoxCode
            // 
            this.textBoxCode.AccessibleName = "code box";
            this.textBoxCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCode.Location = new System.Drawing.Point(65, 62);
            this.textBoxCode.Multiline = true;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(87, 31);
            this.textBoxCode.TabIndex = 2;
            this.textBoxCode.Text = GenerateCode();
            // 
            // buttonCancel
            // 
            this.buttonCancel.AccessibleName = "cancel button";
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(56, 307);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(164, 47);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "✕ Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormAddURL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(550, 366);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.labelURL);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "FormAddURL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Button buttonCancel;

        private string GenerateCode()
        {
            var rand = new Random();
            var range = 58 * 58;
            var randNum = Math.Truncate((double)rand.Next(1, range));
            var ticks = (DateTime.Now - DateTime.Parse("1-1-2021")).Ticks;
            var code = GetInt2Base58(ticks) + GetInt2Base58(randNum);
            return code;
        }

        private string GetInt2Base58(double num)
        {
            var base58chars = "123456789ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz";

            var baseLength = base58chars.Length;

            var result = "";
            while (num > 0)
            {
                result += base58chars[Math.Abs((int)(num % baseLength))];
                num = Math.Truncate((double)num / baseLength);
            }
            return result;
        }
    }
}

