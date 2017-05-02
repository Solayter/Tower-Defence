namespace Tower_Defence
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.timer_for_action = new System.Windows.Forms.Timer(this.components);
            this.startBut = new System.Windows.Forms.Button();
            this.timer_for_drawing = new System.Windows.Forms.Timer(this.components);
            this.timer_for_spawn = new System.Windows.Forms.Timer(this.components);
            this.buildCheck = new System.Windows.Forms.CheckBox();
            this.passCheck = new System.Windows.Forms.CheckBox();
            this.spawnMelee = new System.Windows.Forms.Button();
            this.spawnRange = new System.Windows.Forms.Button();
            this.gridCheck = new System.Windows.Forms.CheckBox();
            this.blueBut = new System.Windows.Forms.Button();
            this.redBut = new System.Windows.Forms.Button();
            this.picMelee = new System.Windows.Forms.PictureBox();
            this.picRange = new System.Windows.Forms.PictureBox();
            this.picBal = new System.Windows.Forms.PictureBox();
            this.spawnBal = new System.Windows.Forms.Button();
            this.saveBut = new System.Windows.Forms.Button();
            this.loadBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMelee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBal)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.Enabled = false;
            this.picBox.InitialImage = null;
            this.picBox.Location = new System.Drawing.Point(196, 12);
            this.picBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(1181, 423);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            this.picBox.Paint += new System.Windows.Forms.PaintEventHandler(this.picBox_Paint);
            this.picBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseClick);
            this.picBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseMove);
            // 
            // timer_for_action
            // 
            this.timer_for_action.Interval = 1000;
            this.timer_for_action.Tick += new System.EventHandler(this.timer_for_action_Tick);
            // 
            // startBut
            // 
            this.startBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startBut.Location = new System.Drawing.Point(12, 12);
            this.startBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startBut.Name = "startBut";
            this.startBut.Size = new System.Drawing.Size(171, 52);
            this.startBut.TabIndex = 1;
            this.startBut.Text = "START";
            this.startBut.UseVisualStyleBackColor = true;
            this.startBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer_for_drawing
            // 
            this.timer_for_drawing.Tick += new System.EventHandler(this.timer_for_drawing_Tick);
            // 
            // timer_for_spawn
            // 
            this.timer_for_spawn.Interval = 10000;
            this.timer_for_spawn.Tick += new System.EventHandler(this.timer_for_spawn_Tick);
            // 
            // buildCheck
            // 
            this.buildCheck.AutoSize = true;
            this.buildCheck.BackColor = System.Drawing.SystemColors.Control;
            this.buildCheck.Location = new System.Drawing.Point(12, 384);
            this.buildCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buildCheck.Name = "buildCheck";
            this.buildCheck.Size = new System.Drawing.Size(64, 21);
            this.buildCheck.TabIndex = 2;
            this.buildCheck.Text = "Builds";
            this.buildCheck.UseVisualStyleBackColor = false;
            this.buildCheck.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // passCheck
            // 
            this.passCheck.AutoSize = true;
            this.passCheck.BackColor = System.Drawing.SystemColors.Control;
            this.passCheck.Location = new System.Drawing.Point(12, 358);
            this.passCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passCheck.Name = "passCheck";
            this.passCheck.Size = new System.Drawing.Size(57, 21);
            this.passCheck.TabIndex = 3;
            this.passCheck.Text = "Pass";
            this.passCheck.UseVisualStyleBackColor = false;
            // 
            // spawnMelee
            // 
            this.spawnMelee.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spawnMelee.Location = new System.Drawing.Point(12, 130);
            this.spawnMelee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spawnMelee.Name = "spawnMelee";
            this.spawnMelee.Size = new System.Drawing.Size(124, 41);
            this.spawnMelee.TabIndex = 4;
            this.spawnMelee.Text = "Melee";
            this.spawnMelee.UseVisualStyleBackColor = true;
            this.spawnMelee.Click += new System.EventHandler(this.spawnMelee_but_Click);
            // 
            // spawnRange
            // 
            this.spawnRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spawnRange.Location = new System.Drawing.Point(12, 176);
            this.spawnRange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spawnRange.Name = "spawnRange";
            this.spawnRange.Size = new System.Drawing.Size(124, 41);
            this.spawnRange.TabIndex = 5;
            this.spawnRange.Text = "Range";
            this.spawnRange.UseVisualStyleBackColor = true;
            this.spawnRange.Click += new System.EventHandler(this.spawnRange_but_Click);
            // 
            // gridCheck
            // 
            this.gridCheck.AutoSize = true;
            this.gridCheck.BackColor = System.Drawing.SystemColors.Control;
            this.gridCheck.Location = new System.Drawing.Point(12, 332);
            this.gridCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridCheck.Name = "gridCheck";
            this.gridCheck.Size = new System.Drawing.Size(54, 21);
            this.gridCheck.TabIndex = 6;
            this.gridCheck.Text = "Grid";
            this.gridCheck.UseVisualStyleBackColor = false;
            // 
            // blueBut
            // 
            this.blueBut.BackColor = System.Drawing.Color.Blue;
            this.blueBut.Location = new System.Drawing.Point(59, 30);
            this.blueBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blueBut.Name = "blueBut";
            this.blueBut.Size = new System.Drawing.Size(40, 23);
            this.blueBut.TabIndex = 7;
            this.blueBut.UseVisualStyleBackColor = false;
            this.blueBut.Click += new System.EventHandler(this.blueBut_Click);
            // 
            // redBut
            // 
            this.redBut.BackColor = System.Drawing.Color.Red;
            this.redBut.Location = new System.Drawing.Point(97, 30);
            this.redBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.redBut.Name = "redBut";
            this.redBut.Size = new System.Drawing.Size(40, 23);
            this.redBut.TabIndex = 8;
            this.redBut.UseVisualStyleBackColor = false;
            this.redBut.Click += new System.EventHandler(this.redBut_Click);
            // 
            // picMelee
            // 
            this.picMelee.Location = new System.Drawing.Point(142, 130);
            this.picMelee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMelee.Name = "picMelee";
            this.picMelee.Size = new System.Drawing.Size(41, 41);
            this.picMelee.TabIndex = 9;
            this.picMelee.TabStop = false;
            // 
            // picRange
            // 
            this.picRange.Location = new System.Drawing.Point(142, 176);
            this.picRange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picRange.Name = "picRange";
            this.picRange.Size = new System.Drawing.Size(41, 41);
            this.picRange.TabIndex = 10;
            this.picRange.TabStop = false;
            // 
            // picBal
            // 
            this.picBal.Location = new System.Drawing.Point(142, 223);
            this.picBal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBal.Name = "picBal";
            this.picBal.Size = new System.Drawing.Size(41, 41);
            this.picBal.TabIndex = 11;
            this.picBal.TabStop = false;
            // 
            // spawnBal
            // 
            this.spawnBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spawnBal.Location = new System.Drawing.Point(12, 223);
            this.spawnBal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spawnBal.Name = "spawnBal";
            this.spawnBal.Size = new System.Drawing.Size(124, 41);
            this.spawnBal.TabIndex = 12;
            this.spawnBal.Text = "Ballista";
            this.spawnBal.UseVisualStyleBackColor = true;
            this.spawnBal.Click += new System.EventHandler(this.spawnBal_Click);
            // 
            // saveBut
            // 
            this.saveBut.Enabled = false;
            this.saveBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBut.Location = new System.Drawing.Point(12, 77);
            this.saveBut.Name = "saveBut";
            this.saveBut.Size = new System.Drawing.Size(79, 41);
            this.saveBut.TabIndex = 13;
            this.saveBut.Text = "Save";
            this.saveBut.UseVisualStyleBackColor = true;
            this.saveBut.Click += new System.EventHandler(this.saveBut_Click);
            // 
            // loadBut
            // 
            this.loadBut.Enabled = false;
            this.loadBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadBut.Location = new System.Drawing.Point(104, 77);
            this.loadBut.Name = "loadBut";
            this.loadBut.Size = new System.Drawing.Size(79, 41);
            this.loadBut.TabIndex = 14;
            this.loadBut.Text = "Load";
            this.loadBut.UseVisualStyleBackColor = true;
            this.loadBut.Click += new System.EventHandler(this.loadBut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 640);
            this.Controls.Add(this.loadBut);
            this.Controls.Add(this.saveBut);
            this.Controls.Add(this.spawnBal);
            this.Controls.Add(this.picBal);
            this.Controls.Add(this.picRange);
            this.Controls.Add(this.picMelee);
            this.Controls.Add(this.redBut);
            this.Controls.Add(this.blueBut);
            this.Controls.Add(this.gridCheck);
            this.Controls.Add(this.spawnRange);
            this.Controls.Add(this.spawnMelee);
            this.Controls.Add(this.passCheck);
            this.Controls.Add(this.buildCheck);
            this.Controls.Add(this.startBut);
            this.Controls.Add(this.picBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMelee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Timer timer_for_action;
        private System.Windows.Forms.Button startBut;
        private System.Windows.Forms.Timer timer_for_drawing;
        private System.Windows.Forms.Timer timer_for_spawn;
        private System.Windows.Forms.CheckBox buildCheck;
        private System.Windows.Forms.CheckBox passCheck;
        private System.Windows.Forms.Button spawnMelee;
        private System.Windows.Forms.Button spawnRange;
        private System.Windows.Forms.CheckBox gridCheck;
        private System.Windows.Forms.Button blueBut;
        private System.Windows.Forms.Button redBut;
        private System.Windows.Forms.PictureBox picMelee;
        private System.Windows.Forms.PictureBox picRange;
        private System.Windows.Forms.PictureBox picBal;
        private System.Windows.Forms.Button spawnBal;
        private System.Windows.Forms.Button saveBut;
        private System.Windows.Forms.Button loadBut;
    }
}

