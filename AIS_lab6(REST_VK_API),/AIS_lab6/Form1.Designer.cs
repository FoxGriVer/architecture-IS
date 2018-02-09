namespace AIS_lab6
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
            this.ourBrowser = new System.Windows.Forms.WebBrowser();
            this.autif = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ourBrowser
            // 
            this.ourBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ourBrowser.Location = new System.Drawing.Point(12, 12);
            this.ourBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.ourBrowser.Name = "ourBrowser";
            this.ourBrowser.Size = new System.Drawing.Size(763, 576);
            this.ourBrowser.TabIndex = 0;
            this.ourBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.ourBrowser_Navigated);
            // 
            // autif
            // 
            this.autif.Location = new System.Drawing.Point(12, 668);
            this.autif.Name = "autif";
            this.autif.Size = new System.Drawing.Size(189, 74);
            this.autif.TabIndex = 1;
            this.autif.Text = "Авторизация";
            this.autif.UseVisualStyleBackColor = true;
            this.autif.Click += new System.EventHandler(this.autif_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 754);
            this.Controls.Add(this.autif);
            this.Controls.Add(this.ourBrowser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser ourBrowser;
        private System.Windows.Forms.Button autif;
    }
}

