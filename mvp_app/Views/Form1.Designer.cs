
namespace mvp_app
{
    partial class Form1
    {

        private void InitializeComponent()
        {
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInfo.Location = new System.Drawing.Point(10, 50);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.Size = new System.Drawing.Size(538, 150);
            this.textBoxInfo.TabIndex = 1;
            this.textBoxInfo.TextChanged += new System.EventHandler(this.textBoxInfo_TextChanged);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(10, 206);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(147, 28);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Загрузить информацию";
            this.buttonLoad.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(10, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(236, 24);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Информация о котиках";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 347);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textBoxInfo);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label labelTitle;
    }
}

