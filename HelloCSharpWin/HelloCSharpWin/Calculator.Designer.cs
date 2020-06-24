namespace HelloCSharpWin
{
    partial class Calculator
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Hellolabel = new System.Windows.Forms.Label();
            this.sum1 = new System.Windows.Forms.TextBox();
            this.sum2 = new System.Windows.Forms.TextBox();
            this.sum_btn = new System.Windows.Forms.Button();
            this.sum_res = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Hellolabel
            // 
            this.Hellolabel.AutoSize = true;
            this.Hellolabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hellolabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Hellolabel.Location = new System.Drawing.Point(95, 46);
            this.Hellolabel.Name = "Hellolabel";
            this.Hellolabel.Size = new System.Drawing.Size(105, 12);
            this.Hellolabel.TabIndex = 0;
            this.Hellolabel.Text = "여기를 클릭하시오";
            this.Hellolabel.Click += new System.EventHandler(this.Hellolabel_Click);
            // 
            // sum1
            // 
            this.sum1.Location = new System.Drawing.Point(12, 113);
            this.sum1.Name = "sum1";
            this.sum1.Size = new System.Drawing.Size(100, 21);
            this.sum1.TabIndex = 1;
            // 
            // sum2
            // 
            this.sum2.Location = new System.Drawing.Point(116, 113);
            this.sum2.Name = "sum2";
            this.sum2.Size = new System.Drawing.Size(100, 21);
            this.sum2.TabIndex = 2;
            // 
            // sum_btn
            // 
            this.sum_btn.Location = new System.Drawing.Point(222, 113);
            this.sum_btn.Name = "sum_btn";
            this.sum_btn.Size = new System.Drawing.Size(75, 23);
            this.sum_btn.TabIndex = 3;
            this.sum_btn.Text = "=";
            this.sum_btn.UseVisualStyleBackColor = true;
            this.sum_btn.Click += new System.EventHandler(this.sum_btn_Click);
            // 
            // sum_res
            // 
            this.sum_res.Location = new System.Drawing.Point(303, 113);
            this.sum_res.Name = "sum_res";
            this.sum_res.Size = new System.Drawing.Size(100, 21);
            this.sum_res.TabIndex = 4;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sum_res);
            this.Controls.Add(this.sum_btn);
            this.Controls.Add(this.sum2);
            this.Controls.Add(this.sum1);
            this.Controls.Add(this.Hellolabel);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Hellolabel;
        private System.Windows.Forms.TextBox sum1;
        private System.Windows.Forms.TextBox sum2;
        private System.Windows.Forms.Button sum_btn;
        private System.Windows.Forms.TextBox sum_res;
    }
}

