﻿namespace pract_5
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
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddOnlyMark = new System.Windows.Forms.ToolStripMenuItem();
            this.AddOnlyCylinders = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMarkPower = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMarkCylinders = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCylindersPower = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ClearList = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.powerAuto = new System.Windows.Forms.NumericUpDown();
            this.countCylinders = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.markAuto = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.powerAuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countCylinders)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.AboutUs,
            this.Exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddOnlyMark,
            this.AddOnlyCylinders,
            this.AddMarkPower,
            this.AddMarkCylinders,
            this.AddCylindersPower});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // AddOnlyMark
            // 
            this.AddOnlyMark.Name = "AddOnlyMark";
            this.AddOnlyMark.Size = new System.Drawing.Size(260, 22);
            this.AddOnlyMark.Text = "Добавить только с маркой";
            this.AddOnlyMark.Click += new System.EventHandler(this.AddOnlyMark_Click);
            // 
            // AddOnlyCylinders
            // 
            this.AddOnlyCylinders.Name = "AddOnlyCylinders";
            this.AddOnlyCylinders.Size = new System.Drawing.Size(260, 22);
            this.AddOnlyCylinders.Text = "Добавить только цилиндры";
            this.AddOnlyCylinders.Click += new System.EventHandler(this.AddOnlyCylinders_Click);
            // 
            // AddMarkPower
            // 
            this.AddMarkPower.Name = "AddMarkPower";
            this.AddMarkPower.Size = new System.Drawing.Size(260, 22);
            this.AddMarkPower.Text = "Добавить марку и мощность";
            this.AddMarkPower.Click += new System.EventHandler(this.AddMarkPower_Click);
            // 
            // AddMarkCylinders
            // 
            this.AddMarkCylinders.Name = "AddMarkCylinders";
            this.AddMarkCylinders.Size = new System.Drawing.Size(260, 22);
            this.AddMarkCylinders.Text = "Добавить марку и цилиндры";
            this.AddMarkCylinders.Click += new System.EventHandler(this.AddMarkCylinders_Click);
            // 
            // AddCylindersPower
            // 
            this.AddCylindersPower.Name = "AddCylindersPower";
            this.AddCylindersPower.Size = new System.Drawing.Size(260, 22);
            this.AddCylindersPower.Text = "Добавить цилиндры и мощность ";
            this.AddCylindersPower.Click += new System.EventHandler(this.AddCylindersPower_Click);
            // 
            // AboutUs
            // 
            this.AboutUs.Name = "AboutUs";
            this.AboutUs.Size = new System.Drawing.Size(94, 20);
            this.AboutUs.Text = "О программе";
            this.AboutUs.Click += new System.EventHandler(this.AboutUs_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(54, 20);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(6, 19);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(509, 381);
            this.listBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.listBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 407);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Автомобили";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClearList);
            this.groupBox2.Controls.Add(this.ChangeButton);
            this.groupBox2.Controls.Add(this.DeleteButton);
            this.groupBox2.Controls.Add(this.AddButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.powerAuto);
            this.groupBox2.Controls.Add(this.countCylinders);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.markAuto);
            this.groupBox2.Location = new System.Drawing.Point(543, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 407);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры автомобиля";
            // 
            // ClearList
            // 
            this.ClearList.Location = new System.Drawing.Point(35, 372);
            this.ClearList.Name = "ClearList";
            this.ClearList.Size = new System.Drawing.Size(166, 25);
            this.ClearList.TabIndex = 9;
            this.ClearList.Text = "Очистить список";
            this.ClearList.UseVisualStyleBackColor = true;
            this.ClearList.Click += new System.EventHandler(this.ClearList_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(121, 310);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(80, 25);
            this.ChangeButton.TabIndex = 8;
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(35, 341);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(166, 25);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Удалить из списка";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(35, 310);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(80, 25);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Мощность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Число цилиндров";
            // 
            // powerAuto
            // 
            this.powerAuto.Location = new System.Drawing.Point(6, 149);
            this.powerAuto.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.powerAuto.Name = "powerAuto";
            this.powerAuto.Size = new System.Drawing.Size(156, 20);
            this.powerAuto.TabIndex = 3;
            // 
            // countCylinders
            // 
            this.countCylinders.Location = new System.Drawing.Point(6, 99);
            this.countCylinders.Minimum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.countCylinders.Name = "countCylinders";
            this.countCylinders.Size = new System.Drawing.Size(156, 20);
            this.countCylinders.TabIndex = 2;
            this.countCylinders.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Марка автомобиля";
            // 
            // markAuto
            // 
            this.markAuto.Location = new System.Drawing.Point(6, 45);
            this.markAuto.Name = "markAuto";
            this.markAuto.Size = new System.Drawing.Size(156, 20);
            this.markAuto.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практическая №5";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.powerAuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countCylinders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutUs;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown powerAuto;
        private System.Windows.Forms.NumericUpDown countCylinders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox markAuto;
        private System.Windows.Forms.ToolStripMenuItem AddOnlyMark;
        private System.Windows.Forms.ToolStripMenuItem AddOnlyCylinders;
        private System.Windows.Forms.ToolStripMenuItem AddMarkPower;
        private System.Windows.Forms.ToolStripMenuItem AddMarkCylinders;
        private System.Windows.Forms.ToolStripMenuItem AddCylindersPower;
        private System.Windows.Forms.Button ClearList;
    }
}

