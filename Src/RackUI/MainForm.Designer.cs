
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
            this.BuildButton.Location = new System.Drawing.Point(333, 204);
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
            // 
            // MaterialThickness
            // 
            this.MaterialThickness.Location = new System.Drawing.Point(333, 125);
            this.MaterialThickness.Name = "MaterialThickness";
            this.MaterialThickness.Size = new System.Drawing.Size(100, 23);
            this.MaterialThickness.TabIndex = 17;
            this.MaterialThickness.Text = "15";
            // 
            // ShelvesNumber
            // 
            this.ShelvesNumber.Location = new System.Drawing.Point(333, 154);
            this.ShelvesNumber.Name = "ShelvesNumber";
            this.ShelvesNumber.Size = new System.Drawing.Size(100, 23);
            this.ShelvesNumber.TabIndex = 18;
            this.ShelvesNumber.Text = "6";
            // 
            // SchemeButton
            // 
            this.SchemeButton.Location = new System.Drawing.Point(13, 204);
            this.SchemeButton.Name = "SchemeButton";
            this.SchemeButton.Size = new System.Drawing.Size(89, 29);
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
            this.label7.Size = new System.Drawing.Size(265, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "(от 2 до 13 в зависимости от высоты стеллажа)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 248);
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
    }
}

