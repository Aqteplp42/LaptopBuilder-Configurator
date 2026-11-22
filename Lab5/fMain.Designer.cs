namespace Lab5
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
            this.panMain = new System.Windows.Forms.Panel();
            this.tboxResult = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.tboxLog = new System.Windows.Forms.TextBox();
            this.lbLog = new System.Windows.Forms.Label();
            this.lbStep = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBuildAll = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lbType = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMain
            // 
            this.panMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panMain.Controls.Add(this.tboxResult);
            this.panMain.Controls.Add(this.lbResult);
            this.panMain.Controls.Add(this.tboxLog);
            this.panMain.Controls.Add(this.lbLog);
            this.panMain.Controls.Add(this.lbStep);
            this.panMain.Controls.Add(this.btnReset);
            this.panMain.Controls.Add(this.btnBuildAll);
            this.panMain.Controls.Add(this.btnNext);
            this.panMain.Controls.Add(this.btnStart);
            this.panMain.Controls.Add(this.cmbType);
            this.panMain.Controls.Add(this.lbType);
            this.panMain.Controls.Add(this.lbTitle);
            this.panMain.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.panMain.Location = new System.Drawing.Point(20, 20);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(940, 640);
            this.panMain.TabIndex = 0;
            // 
            // tboxResult
            // 
            this.tboxResult.Location = new System.Drawing.Point(490, 290);
            this.tboxResult.Multiline = true;
            this.tboxResult.Name = "tboxResult";
            this.tboxResult.ReadOnly = true;
            this.tboxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tboxResult.Size = new System.Drawing.Size(420, 280);
            this.tboxResult.TabIndex = 11;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(490, 260);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(107, 13);
            this.lbResult.TabIndex = 10;
            this.lbResult.Text = "ГОТОВИЙ НОУТБУК";
            // 
            // tboxLog
            // 
            this.tboxLog.Location = new System.Drawing.Point(30, 290);
            this.tboxLog.Multiline = true;
            this.tboxLog.Name = "tboxLog";
            this.tboxLog.ReadOnly = true;
            this.tboxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tboxLog.Size = new System.Drawing.Size(420, 280);
            this.tboxLog.TabIndex = 9;
            // 
            // lbLog
            // 
            this.lbLog.AutoSize = true;
            this.lbLog.Location = new System.Drawing.Point(30, 260);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(120, 13);
            this.lbLog.TabIndex = 8;
            this.lbLog.Text = "ЖУРНАЛ СКЛАДАННЯ";
            // 
            // lbStep
            // 
            this.lbStep.AutoSize = true;
            this.lbStep.Location = new System.Drawing.Point(30, 215);
            this.lbStep.Name = "lbStep";
            this.lbStep.Size = new System.Drawing.Size(304, 13);
            this.lbStep.TabIndex = 7;
            this.lbStep.Text = "Оберіть тип ноутбука та натисніть «Почати складання»";
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(390, 150);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Скинути";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBuildAll
            // 
            this.btnBuildAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuildAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuildAll.Location = new System.Drawing.Point(200, 150);
            this.btnBuildAll.Name = "btnBuildAll";
            this.btnBuildAll.Size = new System.Drawing.Size(75, 23);
            this.btnBuildAll.TabIndex = 5;
            this.btnBuildAll.Text = "Зібрати повністю";
            this.btnBuildAll.UseVisualStyleBackColor = true;
            this.btnBuildAll.Click += new System.EventHandler(this.btnBuildAll_Click);
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(30, 150);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Наступний крок";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(471, 150);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Почати складання";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Офісний ноутбук",
            "Ігровий ноутбук",
            "Професійний ноутбук"});
            this.cmbType.Location = new System.Drawing.Point(33, 106);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 21);
            this.cmbType.TabIndex = 2;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(30, 90);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(80, 13);
            this.lbType.TabIndex = 1;
            this.lbType.Text = "Тип ноутбука:";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbTitle.Location = new System.Drawing.Point(25, 20);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(139, 13);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "КОНСТРУКТОР НОУТБУКІВ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.panMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Laptop Builder";
            this.panMain.ResumeLayout(false);
            this.panMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBuildAll;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbStep;
        private System.Windows.Forms.TextBox tboxResult;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.TextBox tboxLog;
        private System.Windows.Forms.Label lbLog;
    }
}

