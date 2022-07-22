
namespace Encrypt_Text
{
    partial class frmEncrypt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEncrypt));
            this.label1 = new System.Windows.Forms.Label();
            this.Textbox = new System.Windows.Forms.TextBox();
            this.MD5Result = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EncryptBox = new System.Windows.Forms.GroupBox();
            this.Encrypt = new System.Windows.Forms.Button();
            this.DecryptBox = new System.Windows.Forms.GroupBox();
            this.Decrypt = new System.Windows.Forms.Button();
            this.TextResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MD5box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EncryptBox.SuspendLayout();
            this.DecryptBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Textbox
            // 
            resources.ApplyResources(this.Textbox, "Textbox");
            this.Textbox.Name = "Textbox";
            this.Textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Textbox_KeyDown);
            // 
            // MD5Result
            // 
            resources.ApplyResources(this.MD5Result, "MD5Result");
            this.MD5Result.Name = "MD5Result";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // EncryptBox
            // 
            this.EncryptBox.Controls.Add(this.Encrypt);
            this.EncryptBox.Controls.Add(this.MD5Result);
            this.EncryptBox.Controls.Add(this.label1);
            this.EncryptBox.Controls.Add(this.label2);
            this.EncryptBox.Controls.Add(this.Textbox);
            resources.ApplyResources(this.EncryptBox, "EncryptBox");
            this.EncryptBox.Name = "EncryptBox";
            this.EncryptBox.TabStop = false;
            // 
            // Encrypt
            // 
            resources.ApplyResources(this.Encrypt, "Encrypt");
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // DecryptBox
            // 
            this.DecryptBox.Controls.Add(this.Decrypt);
            this.DecryptBox.Controls.Add(this.TextResult);
            this.DecryptBox.Controls.Add(this.label3);
            this.DecryptBox.Controls.Add(this.MD5box);
            this.DecryptBox.Controls.Add(this.label4);
            resources.ApplyResources(this.DecryptBox, "DecryptBox");
            this.DecryptBox.Name = "DecryptBox";
            this.DecryptBox.TabStop = false;
            // 
            // Decrypt
            // 
            resources.ApplyResources(this.Decrypt, "Decrypt");
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // TextResult
            // 
            resources.ApplyResources(this.TextResult, "TextResult");
            this.TextResult.Name = "TextResult";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // MD5box
            // 
            resources.ApplyResources(this.MD5box, "MD5box");
            this.MD5box.Name = "MD5box";
            this.MD5box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MD5box_KeyDown);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // frmEncrypt
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DecryptBox);
            this.Controls.Add(this.EncryptBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEncrypt";
            this.EncryptBox.ResumeLayout(false);
            this.EncryptBox.PerformLayout();
            this.DecryptBox.ResumeLayout(false);
            this.DecryptBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Textbox;
        private System.Windows.Forms.TextBox MD5Result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox EncryptBox;
        private System.Windows.Forms.GroupBox DecryptBox;
        private System.Windows.Forms.TextBox TextResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MD5box;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Button Decrypt;
    }
}

