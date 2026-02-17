namespace RayWare
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.executebtn = new System.Windows.Forms.Button();
            this.attachbtn = new System.Windows.Forms.Button();
            this.scriptbox = new System.Windows.Forms.RichTextBox();
            this.killrbxbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // executebtn
            // 
            this.executebtn.Location = new System.Drawing.Point(719, 272);
            this.executebtn.Name = "executebtn";
            this.executebtn.Size = new System.Drawing.Size(75, 34);
            this.executebtn.TabIndex = 0;
            this.executebtn.Text = "Execute";
            this.executebtn.UseVisualStyleBackColor = true;
            this.executebtn.Click += new System.EventHandler(this.executebtn_Click);
            // 
            // attachbtn
            // 
            this.attachbtn.Location = new System.Drawing.Point(12, 272);
            this.attachbtn.Name = "attachbtn";
            this.attachbtn.Size = new System.Drawing.Size(75, 34);
            this.attachbtn.TabIndex = 0;
            this.attachbtn.Text = "Attach";
            this.attachbtn.UseVisualStyleBackColor = true;
            this.attachbtn.Click += new System.EventHandler(this.attachbtn_Click);
            // 
            // scriptbox
            // 
            this.scriptbox.BackColor = System.Drawing.Color.White;
            this.scriptbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scriptbox.Location = new System.Drawing.Point(13, 13);
            this.scriptbox.Name = "scriptbox";
            this.scriptbox.Size = new System.Drawing.Size(781, 253);
            this.scriptbox.TabIndex = 1;
            this.scriptbox.Text = "";
            // 
            // killrbxbtn
            // 
            this.killrbxbtn.Location = new System.Drawing.Point(93, 272);
            this.killrbxbtn.Name = "killrbxbtn";
            this.killrbxbtn.Size = new System.Drawing.Size(75, 34);
            this.killrbxbtn.TabIndex = 0;
            this.killrbxbtn.Text = "Kill Rbx";
            this.killrbxbtn.UseVisualStyleBackColor = true;
            this.killrbxbtn.Click += new System.EventHandler(this.attachbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(806, 318);
            this.Controls.Add(this.scriptbox);
            this.Controls.Add(this.killrbxbtn);
            this.Controls.Add(this.attachbtn);
            this.Controls.Add(this.executebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "RayWare";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button executebtn;
        private System.Windows.Forms.Button attachbtn;
        private System.Windows.Forms.RichTextBox scriptbox;
        private System.Windows.Forms.Button killrbxbtn;
    }
}

