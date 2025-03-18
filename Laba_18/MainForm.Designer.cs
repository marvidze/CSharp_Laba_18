namespace Laba_18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            buttonCreateQueue = new Button();
            buttonClearQueue = new Button();
            buttonGetMax = new Button();
            buttonAddNew = new Button();
            buttonResetPriority = new Button();
            numericUpDownAddNew = new NumericUpDown();
            numericUpDownFrom = new NumericUpDown();
            numericUpDownTo = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            buttonExit = new Button();
            label3 = new Label();
            dataGridViewArray = new DataGridView();
            label4 = new Label();
            dataGridViewTree = new DataGridView();
            label5 = new Label();
            dataGridViewResultSelection = new DataGridView();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAddNew).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFrom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewArray).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultSelection).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCreateQueue
            // 
            buttonCreateQueue.Location = new Point(634, 264);
            buttonCreateQueue.Name = "buttonCreateQueue";
            buttonCreateQueue.Size = new Size(146, 35);
            buttonCreateQueue.TabIndex = 0;
            buttonCreateQueue.Text = "Создать очередь";
            buttonCreateQueue.UseVisualStyleBackColor = true;
            buttonCreateQueue.Click += buttonCreateQueue_Click;
            // 
            // buttonClearQueue
            // 
            buttonClearQueue.Location = new Point(634, 305);
            buttonClearQueue.Name = "buttonClearQueue";
            buttonClearQueue.Size = new Size(146, 35);
            buttonClearQueue.TabIndex = 0;
            buttonClearQueue.Text = "Очистить очередь";
            buttonClearQueue.UseVisualStyleBackColor = true;
            buttonClearQueue.Click += buttonClearQueue_Click;
            // 
            // buttonGetMax
            // 
            buttonGetMax.Location = new Point(411, 264);
            buttonGetMax.Name = "buttonGetMax";
            buttonGetMax.Size = new Size(202, 35);
            buttonGetMax.TabIndex = 0;
            buttonGetMax.Text = "Извлечь наибольший";
            buttonGetMax.UseVisualStyleBackColor = true;
            // 
            // buttonAddNew
            // 
            buttonAddNew.Location = new Point(87, 264);
            buttonAddNew.Name = "buttonAddNew";
            buttonAddNew.Size = new Size(202, 35);
            buttonAddNew.TabIndex = 0;
            buttonAddNew.Text = "Вставить новый";
            buttonAddNew.UseVisualStyleBackColor = true;
            // 
            // buttonResetPriority
            // 
            buttonResetPriority.Location = new Point(87, 305);
            buttonResetPriority.Name = "buttonResetPriority";
            buttonResetPriority.Size = new Size(202, 35);
            buttonResetPriority.TabIndex = 0;
            buttonResetPriority.Text = "Изменить приоритет";
            buttonResetPriority.UseVisualStyleBackColor = true;
            // 
            // numericUpDownAddNew
            // 
            numericUpDownAddNew.Location = new Point(318, 272);
            numericUpDownAddNew.Name = "numericUpDownAddNew";
            numericUpDownAddNew.Size = new Size(76, 23);
            numericUpDownAddNew.TabIndex = 1;
            // 
            // numericUpDownFrom
            // 
            numericUpDownFrom.Location = new Point(318, 313);
            numericUpDownFrom.Name = "numericUpDownFrom";
            numericUpDownFrom.Size = new Size(76, 23);
            numericUpDownFrom.TabIndex = 1;
            // 
            // numericUpDownTo
            // 
            numericUpDownTo.Location = new Point(444, 313);
            numericUpDownTo.Name = "numericUpDownTo";
            numericUpDownTo.Size = new Size(76, 23);
            numericUpDownTo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(295, 313);
            label1.Name = "label1";
            label1.Size = new Size(17, 21);
            label1.TabIndex = 2;
            label1.Text = "с";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(411, 313);
            label2.Name = "label2";
            label2.Size = new Size(27, 21);
            label2.TabIndex = 2;
            label2.Text = "на";
            // 
            // buttonExit
            // 
            buttonExit.BackgroundImage = (Image)resources.GetObject("buttonExit.BackgroundImage");
            buttonExit.BackgroundImageLayout = ImageLayout.Zoom;
            buttonExit.Location = new Point(810, 264);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(64, 76);
            buttonExit.TabIndex = 3;
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(360, 5);
            label3.Name = "label3";
            label3.Size = new Size(231, 21);
            label3.TabIndex = 4;
            label3.Text = "Представление в виде массива";
            // 
            // dataGridViewArray
            // 
            dataGridViewArray.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewArray.ColumnHeadersVisible = false;
            dataGridViewArray.Location = new Point(4, 29);
            dataGridViewArray.Name = "dataGridViewArray";
            dataGridViewArray.RowHeadersVisible = false;
            dataGridViewArray.Size = new Size(903, 28);
            dataGridViewArray.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(360, 60);
            label4.Name = "label4";
            label4.Size = new Size(223, 21);
            label4.TabIndex = 4;
            label4.Text = "Представление в виде дерева";
            // 
            // dataGridViewTree
            // 
            dataGridViewTree.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTree.ColumnHeadersVisible = false;
            dataGridViewTree.Location = new Point(4, 84);
            dataGridViewTree.Name = "dataGridViewTree";
            dataGridViewTree.RowHeadersVisible = false;
            dataGridViewTree.Size = new Size(903, 103);
            dataGridViewTree.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(399, 190);
            label5.Name = "label5";
            label5.Size = new Size(147, 21);
            label5.TabIndex = 4;
            label5.Text = "Результат выборки";
            // 
            // dataGridViewResultSelection
            // 
            dataGridViewResultSelection.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResultSelection.ColumnHeadersVisible = false;
            dataGridViewResultSelection.Location = new Point(4, 214);
            dataGridViewResultSelection.Name = "dataGridViewResultSelection";
            dataGridViewResultSelection.RowHeadersVisible = false;
            dataGridViewResultSelection.Size = new Size(903, 28);
            dataGridViewResultSelection.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewTree);
            groupBox1.Controls.Add(dataGridViewResultSelection);
            groupBox1.Controls.Add(dataGridViewArray);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(28, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(911, 246);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 350);
            Controls.Add(groupBox1);
            Controls.Add(buttonExit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDownTo);
            Controls.Add(numericUpDownFrom);
            Controls.Add(numericUpDownAddNew);
            Controls.Add(buttonGetMax);
            Controls.Add(buttonClearQueue);
            Controls.Add(buttonResetPriority);
            Controls.Add(buttonAddNew);
            Controls.Add(buttonCreateQueue);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Аюпов 23ВП1 Лабораторная работа №18";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownAddNew).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFrom).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewArray).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTree).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultSelection).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCreateQueue;
        private Button buttonClearQueue;
        private Button buttonGetMax;
        private Button buttonAddNew;
        private Button buttonResetPriority;
        private NumericUpDown numericUpDownAddNew;
        private NumericUpDown numericUpDownFrom;
        private NumericUpDown numericUpDownTo;
        private Label label1;
        private Label label2;
        private Button buttonExit;
        private Label label3;
        private DataGridView dataGridViewArray;
        private Label label4;
        private DataGridView dataGridViewTree;
        private Label label5;
        private DataGridView dataGridViewResultSelection;
        private GroupBox groupBox1;
    }
}
