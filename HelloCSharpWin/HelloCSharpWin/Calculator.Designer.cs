﻿namespace HelloCSharpWin
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
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.numscreen = new System.Windows.Forms.Label();
            this.numplus = new System.Windows.Forms.Button();
            this.Operation = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(45, 124);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(62, 53);
            this.num1.TabIndex = 0;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(128, 124);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(63, 53);
            this.num2.TabIndex = 1;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // numscreen
            // 
            this.numscreen.BackColor = System.Drawing.Color.White;
            this.numscreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numscreen.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numscreen.Location = new System.Drawing.Point(36, 13);
            this.numscreen.Name = "numscreen";
            this.numscreen.Size = new System.Drawing.Size(449, 39);
            this.numscreen.TabIndex = 2;
            this.numscreen.Text = "0";
            this.numscreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numplus
            // 
            this.numplus.Location = new System.Drawing.Point(391, 124);
            this.numplus.Name = "numplus";
            this.numplus.Size = new System.Drawing.Size(75, 53);
            this.numplus.TabIndex = 3;
            this.numplus.Text = "+";
            this.numplus.UseVisualStyleBackColor = true;
            this.numplus.Click += new System.EventHandler(this.numplus_Click);
            // 
            // Operation
            // 
            this.Operation.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Operation.Location = new System.Drawing.Point(36, 70);
            this.Operation.Name = "Operation";
            this.Operation.Size = new System.Drawing.Size(449, 36);
            this.Operation.TabIndex = 4;
            this.Operation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(391, 196);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(75, 48);
            this.result.TabIndex = 5;
            this.result.Text = "=";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.Operation);
            this.Controls.Add(this.numplus);
            this.Controls.Add(this.numscreen);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Label numscreen;
        private System.Windows.Forms.Button numplus;
        private System.Windows.Forms.Label Operation;
        private System.Windows.Forms.Button result;
    }
}

