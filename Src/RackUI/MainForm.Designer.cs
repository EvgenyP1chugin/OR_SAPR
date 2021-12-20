
namespace RackUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BuildButton = new System.Windows.Forms.Button();
            this.RackHeight = new System.Windows.Forms.TextBox();
            this.RackDepth = new System.Windows.Forms.TextBox();
            this.RackWidth = new System.Windows.Forms.TextBox();
            this.HeightFromFloor = new System.Windows.Forms.TextBox();
            this.MaterialThickness = new System.Windows.Forms.TextBox();
            this.ShelvesNumber = new System.Windows.Forms.TextBox();
            this.SchemeButton = new System.Windows.Forms.Button();
            this.ShelvesHeight = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.CombiningShelvesDownRadioButton = new System.Windows.Forms.RadioButton();
            this.CombiningShelvesCheckBox = new System.Windows.Forms.CheckBox();
            this.CombiningShelvesUpRadioButton = new System.Windows.Forms.RadioButton();
            this.NumberCombinedShelves = new System.Windows.Forms.TextBox();
            this.CombiningShelvesLabelUp = new System.Windows.Forms.Label();
            this.CombiningShelvesLabelDown = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Глубина стеллажа L (от 300 до 600 мм)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ширина стеллажа S (от 300 до 800 мм)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Высота стеллажа H (от 1000 до 3000 мм)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Высота от пола до нижней полки h2 (от 80 до 100 мм)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Толщина материала s1 (от 10 до 20 мм)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Количество полок";
            // 
            // BuildButton
            // 
            this.BuildButton.Location = new System.Drawing.Point(333, 270);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(86, 29);
            this.BuildButton.TabIndex = 12;
            this.BuildButton.Text = "Построить";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // RackHeight
            // 
            this.RackHeight.Location = new System.Drawing.Point(333, 11);
            this.RackHeight.Name = "RackHeight";
            this.RackHeight.Size = new System.Drawing.Size(100, 23);
            this.RackHeight.TabIndex = 13;
            this.RackHeight.Text = "2000";
            this.RackHeight.TextChanged += new System.EventHandler(this.RackHeight_TextChanged);
            // 
            // RackDepth
            // 
            this.RackDepth.Location = new System.Drawing.Point(333, 40);
            this.RackDepth.Name = "RackDepth";
            this.RackDepth.Size = new System.Drawing.Size(100, 23);
            this.RackDepth.TabIndex = 14;
            this.RackDepth.Text = "450";
            // 
            // RackWidth
            // 
            this.RackWidth.Location = new System.Drawing.Point(333, 69);
            this.RackWidth.Name = "RackWidth";
            this.RackWidth.Size = new System.Drawing.Size(100, 23);
            this.RackWidth.TabIndex = 15;
            this.RackWidth.Text = "550";
            // 
            // HeightFromFloor
            // 
            this.HeightFromFloor.Location = new System.Drawing.Point(333, 96);
            this.HeightFromFloor.Name = "HeightFromFloor";
            this.HeightFromFloor.Size = new System.Drawing.Size(100, 23);
            this.HeightFromFloor.TabIndex = 16;
            this.HeightFromFloor.Text = "90";
            this.HeightFromFloor.TextChanged += new System.EventHandler(this.HeightFromFloor_TextChanged);
            // 
            // MaterialThickness
            // 
            this.MaterialThickness.Location = new System.Drawing.Point(333, 125);
            this.MaterialThickness.Name = "MaterialThickness";
            this.MaterialThickness.Size = new System.Drawing.Size(100, 23);
            this.MaterialThickness.TabIndex = 17;
            this.MaterialThickness.Text = "15";
            this.MaterialThickness.TextChanged += new System.EventHandler(this.MaterialThickness_TextChanged);
            // 
            // ShelvesNumber
            // 
            this.ShelvesNumber.Location = new System.Drawing.Point(333, 154);
            this.ShelvesNumber.Name = "ShelvesNumber";
            this.ShelvesNumber.Size = new System.Drawing.Size(100, 23);
            this.ShelvesNumber.TabIndex = 18;
            this.ShelvesNumber.Text = "6";
            this.ShelvesNumber.TextChanged += new System.EventHandler(this.ShelvesNumber_TextChanged);
            // 
            // SchemeButton
            // 
            this.SchemeButton.Location = new System.Drawing.Point(12, 270);
            this.SchemeButton.Name = "SchemeButton";
            this.SchemeButton.Size = new System.Drawing.Size(87, 29);
            this.SchemeButton.TabIndex = 19;
            this.SchemeButton.Text = "Схема";
            this.SchemeButton.UseVisualStyleBackColor = true;
            this.SchemeButton.Click += new System.EventHandler(this.SchemeButton_Click);
            // 
            // ShelvesHeight
            // 
            this.ShelvesHeight.Location = new System.Drawing.Point(439, 6);
            this.ShelvesHeight.Name = "ShelvesHeight";
            this.ShelvesHeight.Size = new System.Drawing.Size(0, 23);
            this.ShelvesHeight.TabIndex = 20;
            this.ShelvesHeight.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "(от 2 до 8)";
            // 
            // CombiningShelvesDownRadioButton
            // 
            this.CombiningShelvesDownRadioButton.AutoSize = true;
            this.CombiningShelvesDownRadioButton.Enabled = false;
            this.CombiningShelvesDownRadioButton.Location = new System.Drawing.Point(163, 200);
            this.CombiningShelvesDownRadioButton.Name = "CombiningShelvesDownRadioButton";
            this.CombiningShelvesDownRadioButton.Size = new System.Drawing.Size(56, 19);
            this.CombiningShelvesDownRadioButton.TabIndex = 23;
            this.CombiningShelvesDownRadioButton.TabStop = true;
            this.CombiningShelvesDownRadioButton.Text = "снизу";
            this.CombiningShelvesDownRadioButton.UseVisualStyleBackColor = true;
            // 
            // CombiningShelvesCheckBox
            // 
            this.CombiningShelvesCheckBox.AutoSize = true;
            this.CombiningShelvesCheckBox.Location = new System.Drawing.Point(13, 201);
            this.CombiningShelvesCheckBox.Name = "CombiningShelvesCheckBox";
            this.CombiningShelvesCheckBox.Size = new System.Drawing.Size(138, 19);
            this.CombiningShelvesCheckBox.TabIndex = 24;
            this.CombiningShelvesCheckBox.Text = "Объединение полок";
            this.CombiningShelvesCheckBox.UseVisualStyleBackColor = true;
            this.CombiningShelvesCheckBox.CheckedChanged += new System.EventHandler(this.CombiningShelvesCheckBox_CheckedChanged);
            // 
            // CombiningShelvesUpRadioButton
            // 
            this.CombiningShelvesUpRadioButton.AutoSize = true;
            this.CombiningShelvesUpRadioButton.Enabled = false;
            this.CombiningShelvesUpRadioButton.Location = new System.Drawing.Point(225, 200);
            this.CombiningShelvesUpRadioButton.Name = "CombiningShelvesUpRadioButton";
            this.CombiningShelvesUpRadioButton.Size = new System.Drawing.Size(62, 19);
            this.CombiningShelvesUpRadioButton.TabIndex = 25;
            this.CombiningShelvesUpRadioButton.TabStop = true;
            this.CombiningShelvesUpRadioButton.Text = "сверху";
            this.CombiningShelvesUpRadioButton.UseVisualStyleBackColor = true;
            // 
            // NumberCombinedShelves
            // 
            this.NumberCombinedShelves.Enabled = false;
            this.NumberCombinedShelves.Location = new System.Drawing.Point(333, 223);
            this.NumberCombinedShelves.Name = "NumberCombinedShelves";
            this.NumberCombinedShelves.Size = new System.Drawing.Size(100, 23);
            this.NumberCombinedShelves.TabIndex = 27;
            this.NumberCombinedShelves.Text = "1";
            // 
            // CombiningShelvesLabelUp
            // 
            this.CombiningShelvesLabelUp.AutoSize = true;
            this.CombiningShelvesLabelUp.Enabled = false;
            this.CombiningShelvesLabelUp.Location = new System.Drawing.Point(12, 223);
            this.CombiningShelvesLabelUp.Name = "CombiningShelvesLabelUp";
            this.CombiningShelvesLabelUp.Size = new System.Drawing.Size(207, 15);
            this.CombiningShelvesLabelUp.TabIndex = 29;
            this.CombiningShelvesLabelUp.Text = "Количество полок для объединения";
            // 
            // CombiningShelvesLabelDown
            // 
            this.CombiningShelvesLabelDown.AutoSize = true;
            this.CombiningShelvesLabelDown.Enabled = false;
            this.CombiningShelvesLabelDown.Location = new System.Drawing.Point(12, 238);
            this.CombiningShelvesLabelDown.Name = "CombiningShelvesLabelDown";
            this.CombiningShelvesLabelDown.Size = new System.Drawing.Size(61, 15);
            this.CombiningShelvesLabelDown.TabIndex = 30;
            this.CombiningShelvesLabelDown.Text = "(от 1 до 5)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 313);
            this.Controls.Add(this.CombiningShelvesLabelDown);
            this.Controls.Add(this.CombiningShelvesLabelUp);
            this.Controls.Add(this.NumberCombinedShelves);
            this.Controls.Add(this.CombiningShelvesUpRadioButton);
            this.Controls.Add(this.CombiningShelvesCheckBox);
            this.Controls.Add(this.CombiningShelvesDownRadioButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ShelvesHeight);
            this.Controls.Add(this.SchemeButton);
            this.Controls.Add(this.ShelvesNumber);
            this.Controls.Add(this.MaterialThickness);
            this.Controls.Add(this.HeightFromFloor);
            this.Controls.Add(this.RackWidth);
            this.Controls.Add(this.RackDepth);
            this.Controls.Add(this.RackHeight);
            this.Controls.Add(this.BuildButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "RackUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.TextBox RackHeight;
        private System.Windows.Forms.TextBox RackDepth;
        private System.Windows.Forms.TextBox RackWidth;
        private System.Windows.Forms.TextBox HeightFromFloor;
        private System.Windows.Forms.TextBox MaterialThickness;
        private System.Windows.Forms.TextBox ShelvesNumber;
        private System.Windows.Forms.Button SchemeButton;
        private System.Windows.Forms.TextBox ShelvesHeight;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton CombiningShelvesDownRadioButton;
        private System.Windows.Forms.CheckBox CombiningShelvesCheckBox;
        private System.Windows.Forms.RadioButton CombiningShelvesUpRadioButton;
        private System.Windows.Forms.TextBox NumberCombinedShelves;
        private System.Windows.Forms.Label CombiningShelvesLabelUp;
        private System.Windows.Forms.Label CombiningShelvesLabelDown;
    }
}

