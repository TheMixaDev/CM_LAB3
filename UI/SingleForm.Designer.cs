namespace Lab2.UI
{
    partial class SingleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.equationBox = new System.Windows.Forms.ComboBox();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.boundBox = new System.Windows.Forms.TextBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.secondBoundBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.methodBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.epsilonBox = new System.Windows.Forms.TextBox();
            this.startDivBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите уравнение:";
            // 
            // equationBox
            // 
            this.equationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equationBox.FormattingEnabled = true;
            this.equationBox.Location = new System.Drawing.Point(130, 12);
            this.equationBox.Name = "equationBox";
            this.equationBox.Size = new System.Drawing.Size(205, 21);
            this.equationBox.TabIndex = 2;
            this.equationBox.SelectedIndexChanged += new System.EventHandler(this.equationBox_SelectedIndexChanged);
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(8, 77);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(126, 13);
            this.intervalLabel.TabIndex = 3;
            this.intervalLabel.Text = "Границы интервала: От";
            // 
            // boundBox
            // 
            this.boundBox.Location = new System.Drawing.Point(140, 74);
            this.boundBox.Name = "boundBox";
            this.boundBox.Size = new System.Drawing.Size(100, 20);
            this.boundBox.TabIndex = 4;
            this.boundBox.Text = "-1";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(246, 77);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(22, 13);
            this.toLabel.TabIndex = 5;
            this.toLabel.Text = "До";
            // 
            // secondBoundBox
            // 
            this.secondBoundBox.Location = new System.Drawing.Point(274, 74);
            this.secondBoundBox.Name = "secondBoundBox";
            this.secondBoundBox.Size = new System.Drawing.Size(100, 20);
            this.secondBoundBox.TabIndex = 6;
            this.secondBoundBox.Text = "1";
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(11, 97);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(556, 59);
            this.resultLabel.TabIndex = 8;
            this.resultLabel.Text = "Результат:\r\nВычисления не проводились\r\n";
            // 
            // calculateButton
            // 
            this.calculateButton.Enabled = false;
            this.calculateButton.Location = new System.Drawing.Point(407, 73);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(163, 20);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Вычислить";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Выберите метод:";
            // 
            // methodBox
            // 
            this.methodBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodBox.FormattingEnabled = true;
            this.methodBox.Items.AddRange(new object[] {
            "Левый метод прямоугольников",
            "Правый метод прямоугольников",
            "Средний метод прямоугольников",
            "Метод трапеций",
            "Метод Симпсона"});
            this.methodBox.Location = new System.Drawing.Point(130, 44);
            this.methodBox.Name = "methodBox";
            this.methodBox.Size = new System.Drawing.Size(205, 21);
            this.methodBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Погрешность:";
            // 
            // epsilonBox
            // 
            this.epsilonBox.Location = new System.Drawing.Point(424, 12);
            this.epsilonBox.Name = "epsilonBox";
            this.epsilonBox.Size = new System.Drawing.Size(146, 20);
            this.epsilonBox.TabIndex = 14;
            this.epsilonBox.Text = "0.001";
            // 
            // startDivBox
            // 
            this.startDivBox.Location = new System.Drawing.Point(425, 44);
            this.startDivBox.Name = "startDivBox";
            this.startDivBox.Size = new System.Drawing.Size(146, 20);
            this.startDivBox.TabIndex = 16;
            this.startDivBox.Text = "4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Разбиение:";
            // 
            // SingleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 168);
            this.Controls.Add(this.startDivBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.epsilonBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.methodBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.secondBoundBox);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.boundBox);
            this.Controls.Add(this.intervalLabel);
            this.Controls.Add(this.equationBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SingleForm";
            this.Text = "Лабораторная работа №3";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox equationBox;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.TextBox boundBox;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.TextBox secondBoundBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox methodBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox epsilonBox;
        private System.Windows.Forms.TextBox startDivBox;
        private System.Windows.Forms.Label label4;
    }
}