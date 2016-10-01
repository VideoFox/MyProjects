namespace Kubiki
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
            this.textDices = new System.Windows.Forms.TextBox();
            this.labelSum = new System.Windows.Forms.Label();
            this.box1 = new System.Windows.Forms.PictureBox();
            this.box2 = new System.Windows.Forms.PictureBox();
            this.buttonGo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.box1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box2)).BeginInit();
            this.SuspendLayout();
            // 
            // textDices
            // 
            this.textDices.Location = new System.Drawing.Point(12, 12);
            this.textDices.Name = "textDices";
            this.textDices.ReadOnly = true;
            this.textDices.Size = new System.Drawing.Size(116, 20);
            this.textDices.TabIndex = 0;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(12, 45);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(35, 13);
            this.labelSum.TabIndex = 1;
            this.labelSum.Text = "label1";
            // 
            // box1
            // 
            this.box1.Location = new System.Drawing.Point(12, 71);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(50, 49);
            this.box1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box1.TabIndex = 2;
            this.box1.TabStop = false;
            // 
            // box2
            // 
            this.box2.Location = new System.Drawing.Point(78, 71);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(50, 49);
            this.box2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box2.TabIndex = 3;
            this.box2.TabStop = false;
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(29, 155);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 4;
            this.buttonGo.Text = "Бросок";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(143, 211);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.textDices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кубики";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.box1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDices;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.PictureBox box1;
        private System.Windows.Forms.PictureBox box2;
        private System.Windows.Forms.Button buttonGo;
    }
}

