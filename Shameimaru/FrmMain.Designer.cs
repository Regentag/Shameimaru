namespace Shameimaru
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bottom = new System.Windows.Forms.NumericUpDown();
            this.right = new System.Windows.Forms.NumericUpDown();
            this.top = new System.Windows.Forms.NumericUpDown();
            this.left = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbSelectedArea = new System.Windows.Forms.RadioButton();
            this.rbFullScreen = new System.Windows.Forms.RadioButton();
            this.saveDirPath = new System.Windows.Forms.TextBox();
            this.btnSelectDir = new System.Windows.Forms.Button();
            this.seconds = new System.Windows.Forms.NumericUpDown();
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCaptureNow = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seconds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "저장위치 : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bottom);
            this.groupBox1.Controls.Add(this.right);
            this.groupBox1.Controls.Add(this.top);
            this.groupBox1.Controls.Add(this.left);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbSelectedArea);
            this.groupBox1.Controls.Add(this.rbFullScreen);
            this.groupBox1.Location = new System.Drawing.Point(14, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 131);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "캡쳐 영역";
            // 
            // bottom
            // 
            this.bottom.Location = new System.Drawing.Point(139, 101);
            this.bottom.Maximum = new decimal(new int[] {
            1680,
            0,
            0,
            0});
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(49, 21);
            this.bottom.TabIndex = 5;
            this.bottom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(194, 101);
            this.right.Maximum = new decimal(new int[] {
            1680,
            0,
            0,
            0});
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(49, 21);
            this.right.TabIndex = 6;
            this.right.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // top
            // 
            this.top.Location = new System.Drawing.Point(139, 74);
            this.top.Maximum = new decimal(new int[] {
            1680,
            0,
            0,
            0});
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(49, 21);
            this.top.TabIndex = 4;
            this.top.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(194, 74);
            this.left.Maximum = new decimal(new int[] {
            1680,
            0,
            0,
            0});
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(49, 21);
            this.left.TabIndex = 4;
            this.left.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bottom/Right:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Top/Left:";
            // 
            // rbSelectedArea
            // 
            this.rbSelectedArea.AutoSize = true;
            this.rbSelectedArea.Location = new System.Drawing.Point(15, 44);
            this.rbSelectedArea.Name = "rbSelectedArea";
            this.rbSelectedArea.Size = new System.Drawing.Size(75, 16);
            this.rbSelectedArea.TabIndex = 1;
            this.rbSelectedArea.TabStop = true;
            this.rbSelectedArea.Text = "선택 영역";
            this.rbSelectedArea.UseVisualStyleBackColor = true;
            // 
            // rbFullScreen
            // 
            this.rbFullScreen.AutoSize = true;
            this.rbFullScreen.Checked = true;
            this.rbFullScreen.Location = new System.Drawing.Point(15, 20);
            this.rbFullScreen.Name = "rbFullScreen";
            this.rbFullScreen.Size = new System.Drawing.Size(131, 16);
            this.rbFullScreen.TabIndex = 0;
            this.rbFullScreen.TabStop = true;
            this.rbFullScreen.Text = "전체화면(Screen 1)";
            this.rbFullScreen.UseVisualStyleBackColor = true;
            // 
            // saveDirPath
            // 
            this.saveDirPath.Location = new System.Drawing.Point(83, 6);
            this.saveDirPath.Name = "saveDirPath";
            this.saveDirPath.Size = new System.Drawing.Size(252, 21);
            this.saveDirPath.TabIndex = 2;
            // 
            // btnSelectDir
            // 
            this.btnSelectDir.Location = new System.Drawing.Point(341, 6);
            this.btnSelectDir.Name = "btnSelectDir";
            this.btnSelectDir.Size = new System.Drawing.Size(67, 21);
            this.btnSelectDir.TabIndex = 3;
            this.btnSelectDir.Text = "폴더선택";
            this.btnSelectDir.UseVisualStyleBackColor = true;
            this.btnSelectDir.Click += new System.EventHandler(this.BtnSelectDir_Click);
            // 
            // seconds
            // 
            this.seconds.Location = new System.Drawing.Point(271, 54);
            this.seconds.Maximum = new decimal(new int[] {
            1680,
            0,
            0,
            0});
            this.seconds.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(49, 21);
            this.seconds.TabIndex = 4;
            this.seconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.seconds.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.Location = new System.Drawing.Point(401, 54);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(101, 27);
            this.btnStartTimer.TabIndex = 5;
            this.btnStartTimer.Text = "시작";
            this.btnStartTimer.UseVisualStyleBackColor = true;
            this.btnStartTimer.Click += new System.EventHandler(this.BtnStartTimer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "초마다 캡쳐";
            // 
            // btnCaptureNow
            // 
            this.btnCaptureNow.Location = new System.Drawing.Point(401, 87);
            this.btnCaptureNow.Name = "btnCaptureNow";
            this.btnCaptureNow.Size = new System.Drawing.Size(101, 26);
            this.btnCaptureNow.TabIndex = 7;
            this.btnCaptureNow.Text = "즉시 캡쳐";
            this.btnCaptureNow.UseVisualStyleBackColor = true;
            this.btnCaptureNow.Click += new System.EventHandler(this.CaptureNow);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 177);
            this.Controls.Add(this.btnCaptureNow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStartTimer);
            this.Controls.Add(this.btnSelectDir);
            this.Controls.Add(this.saveDirPath);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.seconds);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capture";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbSelectedArea;
        private System.Windows.Forms.RadioButton rbFullScreen;
        private System.Windows.Forms.TextBox saveDirPath;
        private System.Windows.Forms.Button btnSelectDir;
        private System.Windows.Forms.NumericUpDown bottom;
        private System.Windows.Forms.NumericUpDown right;
        private System.Windows.Forms.NumericUpDown top;
        private System.Windows.Forms.NumericUpDown left;
        private System.Windows.Forms.NumericUpDown seconds;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCaptureNow;
    }
}

