
namespace AddAndRemoveForm
{
    partial class AddAndRemoveForm
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxWithWords = new System.Windows.Forms.ListBox();
            this.textBoxToAddWords = new System.Windows.Forms.TextBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(23, 191);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(60, 60);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // listBoxWithWords
            // 
            this.listBoxWithWords.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBoxWithWords.FormattingEnabled = true;
            this.listBoxWithWords.ItemHeight = 30;
            this.listBoxWithWords.Location = new System.Drawing.Point(393, 12);
            this.listBoxWithWords.Name = "listBoxWithWords";
            this.listBoxWithWords.Size = new System.Drawing.Size(187, 304);
            this.listBoxWithWords.TabIndex = 1;
            // 
            // textBoxToAddWords
            // 
            this.textBoxToAddWords.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxToAddWords.Location = new System.Drawing.Point(88, 140);
            this.textBoxToAddWords.Name = "textBoxToAddWords";
            this.textBoxToAddWords.Size = new System.Drawing.Size(187, 35);
            this.textBoxToAddWords.TabIndex = 2;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRemove.Location = new System.Drawing.Point(281, 191);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(60, 60);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "-";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // AddAndRemoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 327);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.textBoxToAddWords);
            this.Controls.Add(this.listBoxWithWords);
            this.Controls.Add(this.buttonAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddAndRemoveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAndRemoveForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxWithWords;
        private System.Windows.Forms.TextBox textBoxToAddWords;
        private System.Windows.Forms.Button buttonRemove;
    }
}

