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
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.numscreen = new System.Windows.Forms.Label();
            this.numplus = new System.Windows.Forms.Button();
            this.Operation = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.numdiv = new System.Windows.Forms.Button();
            this.nummul = new System.Windows.Forms.Button();
            this.numsub = new System.Windows.Forms.Button();
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
            this.result.Location = new System.Drawing.Point(381, 333);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(75, 48);
            this.result.TabIndex = 5;
            this.result.Text = "=";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(217, 124);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(62, 53);
            this.num3.TabIndex = 6;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(45, 194);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(62, 53);
            this.num4.TabIndex = 7;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(129, 194);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(62, 53);
            this.num5.TabIndex = 8;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num6
            // 
            this.num6.Location = new System.Drawing.Point(217, 196);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(62, 53);
            this.num6.TabIndex = 9;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num7
            // 
            this.num7.Location = new System.Drawing.Point(45, 263);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(62, 53);
            this.num7.TabIndex = 10;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num8
            // 
            this.num8.Location = new System.Drawing.Point(129, 263);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(62, 53);
            this.num8.TabIndex = 11;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num9
            // 
            this.num9.Location = new System.Drawing.Point(217, 263);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(62, 53);
            this.num9.TabIndex = 12;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num0
            // 
            this.num0.Location = new System.Drawing.Point(128, 333);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(62, 53);
            this.num0.TabIndex = 13;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // numdiv
            // 
            this.numdiv.Location = new System.Drawing.Point(493, 196);
            this.numdiv.Name = "numdiv";
            this.numdiv.Size = new System.Drawing.Size(75, 53);
            this.numdiv.TabIndex = 14;
            this.numdiv.Text = "/";
            this.numdiv.UseVisualStyleBackColor = true;
            this.numdiv.Click += new System.EventHandler(this.numdiv_Click);
            // 
            // nummul
            // 
            this.nummul.Location = new System.Drawing.Point(391, 196);
            this.nummul.Name = "nummul";
            this.nummul.Size = new System.Drawing.Size(75, 53);
            this.nummul.TabIndex = 15;
            this.nummul.Text = "*";
            this.nummul.UseVisualStyleBackColor = true;
            this.nummul.Click += new System.EventHandler(this.nummul_Click);
            // 
            // numsub
            // 
            this.numsub.Location = new System.Drawing.Point(493, 124);
            this.numsub.Name = "numsub";
            this.numsub.Size = new System.Drawing.Size(75, 53);
            this.numsub.TabIndex = 16;
            this.numsub.Text = "-";
            this.numsub.UseVisualStyleBackColor = true;
            this.numsub.Click += new System.EventHandler(this.numsub_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numsub);
            this.Controls.Add(this.nummul);
            this.Controls.Add(this.numdiv);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
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
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button numdiv;
        private System.Windows.Forms.Button nummul;
        private System.Windows.Forms.Button numsub;
    }
}

