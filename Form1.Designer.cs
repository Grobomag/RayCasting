﻿namespace WindowsFormsApplaba2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.открытьUint8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьFloat32ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raycastingPickcherbox = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.X0 = new System.Windows.Forms.NumericUpDown();
            this.Y0 = new System.Windows.Forms.NumericUpDown();
            this.Z0 = new System.Windows.Forms.NumericUpDown();
            this.RenderQuality = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.NeedPaint = new System.Windows.Forms.CheckBox();
            this.Zoom = new System.Windows.Forms.NumericUpDown();
            this.NeedSafe = new System.Windows.Forms.CheckBox();
            this.MaxBox = new System.Windows.Forms.TextBox();
            this.MinBox = new System.Windows.Forms.TextBox();
            this.TreshHold = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.treshbox2 = new System.Windows.Forms.TextBox();
            this.treshbox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raycastingPickcherbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RenderQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьUint8ToolStripMenuItem,
            this.открытьFloat32ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1028, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // открытьUint8ToolStripMenuItem
            // 
            this.открытьUint8ToolStripMenuItem.Name = "открытьUint8ToolStripMenuItem";
            this.открытьUint8ToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.открытьUint8ToolStripMenuItem.Text = "открыть uint8";
            this.открытьUint8ToolStripMenuItem.Click += new System.EventHandler(this.открытьUint8ToolStripMenuItem_Click);
            // 
            // открытьFloat32ToolStripMenuItem
            // 
            this.открытьFloat32ToolStripMenuItem.Name = "открытьFloat32ToolStripMenuItem";
            this.открытьFloat32ToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.открытьFloat32ToolStripMenuItem.Text = "открыть float32";
            this.открытьFloat32ToolStripMenuItem.Click += new System.EventHandler(this.открытьFloat32ToolStripMenuItem_Click);
            // 
            // raycastingPickcherbox
            // 
            this.raycastingPickcherbox.Location = new System.Drawing.Point(300, 27);
            this.raycastingPickcherbox.Name = "raycastingPickcherbox";
            this.raycastingPickcherbox.Size = new System.Drawing.Size(755, 500);
            this.raycastingPickcherbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.raycastingPickcherbox.TabIndex = 12;
            this.raycastingPickcherbox.TabStop = false;
            this.raycastingPickcherbox.Click += new System.EventHandler(this.raycastingPickcherbox_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(12, 487);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(266, 72);
            this.button2.TabIndex = 13;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // X0
            // 
            this.X0.Location = new System.Drawing.Point(36, 299);
            this.X0.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.X0.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.X0.Name = "X0";
            this.X0.Size = new System.Drawing.Size(65, 20);
            this.X0.TabIndex = 14;
            this.X0.Value = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            // 
            // Y0
            // 
            this.Y0.Location = new System.Drawing.Point(36, 325);
            this.Y0.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.Y0.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.Y0.Name = "Y0";
            this.Y0.Size = new System.Drawing.Size(65, 20);
            this.Y0.TabIndex = 15;
            this.Y0.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // Z0
            // 
            this.Z0.Location = new System.Drawing.Point(36, 351);
            this.Z0.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.Z0.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.Z0.Name = "Z0";
            this.Z0.Size = new System.Drawing.Size(65, 20);
            this.Z0.TabIndex = 16;
            this.Z0.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // RenderQuality
            // 
            this.RenderQuality.Location = new System.Drawing.Point(166, 309);
            this.RenderQuality.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.RenderQuality.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.RenderQuality.Name = "RenderQuality";
            this.RenderQuality.Size = new System.Drawing.Size(89, 20);
            this.RenderQuality.TabIndex = 17;
            this.RenderQuality.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.progressBar1.Location = new System.Drawing.Point(10, 457);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(265, 23);
            this.progressBar1.TabIndex = 18;
            // 
            // NeedPaint
            // 
            this.NeedPaint.AutoSize = true;
            this.NeedPaint.Location = new System.Drawing.Point(108, 523);
            this.NeedPaint.Name = "NeedPaint";
            this.NeedPaint.Size = new System.Drawing.Size(82, 17);
            this.NeedPaint.TabIndex = 19;
            this.NeedPaint.Text = "NeedPaint?";
            this.NeedPaint.UseVisualStyleBackColor = true;
            // 
            // Zoom
            // 
            this.Zoom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Zoom.Location = new System.Drawing.Point(196, 504);
            this.Zoom.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.Zoom.Name = "Zoom";
            this.Zoom.Size = new System.Drawing.Size(82, 20);
            this.Zoom.TabIndex = 20;
            this.Zoom.Value = new decimal(new int[] {
            170,
            0,
            0,
            0});
            // 
            // NeedSafe
            // 
            this.NeedSafe.AutoSize = true;
            this.NeedSafe.Location = new System.Drawing.Point(196, 523);
            this.NeedSafe.Name = "NeedSafe";
            this.NeedSafe.Size = new System.Drawing.Size(80, 17);
            this.NeedSafe.TabIndex = 21;
            this.NeedSafe.Text = "NeedSafe?";
            this.NeedSafe.UseVisualStyleBackColor = true;
            // 
            // MaxBox
            // 
            this.MaxBox.Location = new System.Drawing.Point(175, 30);
            this.MaxBox.Name = "MaxBox";
            this.MaxBox.Size = new System.Drawing.Size(89, 20);
            this.MaxBox.TabIndex = 22;
            this.MaxBox.Text = "128";
            // 
            // MinBox
            // 
            this.MinBox.Location = new System.Drawing.Point(46, 28);
            this.MinBox.Name = "MinBox";
            this.MinBox.Size = new System.Drawing.Size(89, 20);
            this.MinBox.TabIndex = 23;
            this.MinBox.Text = "-128";
            // 
            // TreshHold
            // 
            this.TreshHold.Location = new System.Drawing.Point(58, 108);
            this.TreshHold.Name = "TreshHold";
            this.TreshHold.Size = new System.Drawing.Size(55, 20);
            this.TreshHold.TabIndex = 24;
            this.TreshHold.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Максимум";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Минимум";
            // 
            // treshbox2
            // 
            this.treshbox2.Location = new System.Drawing.Point(58, 143);
            this.treshbox2.Name = "treshbox2";
            this.treshbox2.Size = new System.Drawing.Size(55, 20);
            this.treshbox2.TabIndex = 28;
            this.treshbox2.Text = "5";
            // 
            // treshbox3
            // 
            this.treshbox3.Location = new System.Drawing.Point(58, 169);
            this.treshbox3.Name = "treshbox3";
            this.treshbox3.Size = new System.Drawing.Size(55, 20);
            this.treshbox3.TabIndex = 29;
            this.treshbox3.Text = "15";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Изоповерхность 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Изоповерхность 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Изоповерхность 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Разрешение";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "X Y Z";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(155, 504);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "ЗУум";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(172, 332);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Прозрачность (%)";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(166, 351);
            this.numericUpDown4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(89, 20);
            this.numericUpDown4.TabIndex = 17;
            this.numericUpDown4.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1028, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.treshbox3);
            this.Controls.Add(this.treshbox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TreshHold);
            this.Controls.Add(this.MinBox);
            this.Controls.Add(this.MaxBox);
            this.Controls.Add(this.NeedSafe);
            this.Controls.Add(this.Zoom);
            this.Controls.Add(this.NeedPaint);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.RenderQuality);
            this.Controls.Add(this.Z0);
            this.Controls.Add(this.Y0);
            this.Controls.Add(this.X0);
            this.Controls.Add(this.raycastingPickcherbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "VISUALISATION";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raycastingPickcherbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RenderQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox raycastingPickcherbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown X0;
        private System.Windows.Forms.NumericUpDown Y0;
        private System.Windows.Forms.NumericUpDown Z0;
        private System.Windows.Forms.NumericUpDown RenderQuality;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox NeedPaint;
        private System.Windows.Forms.NumericUpDown Zoom;
        private System.Windows.Forms.CheckBox NeedSafe;
        private System.Windows.Forms.TextBox MaxBox;
        private System.Windows.Forms.TextBox MinBox;
        private System.Windows.Forms.TextBox TreshHold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox treshbox2;
        private System.Windows.Forms.TextBox treshbox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.ToolStripMenuItem открытьUint8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьFloat32ToolStripMenuItem;
    }
}

