namespace Курсовая
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.InputTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.WidthUpDown = new System.Windows.Forms.NumericUpDown();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.ResultsButton = new System.Windows.Forms.Button();
            this.Matrix = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultsTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ChromaticLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DiameterLabel = new System.Windows.Forms.Label();
            this.RadiusLabel = new System.Windows.Forms.Label();
            this.CenterLabel = new System.Windows.Forms.Label();
            this.BridgesLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.InputTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix)).BeginInit();
            this.ResultsTab.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(43, 16);
            label1.Margin = new System.Windows.Forms.Padding(3);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(179, 13);
            label1.TabIndex = 2;
            label1.Text = "Задайте количество узлов графа:";
            // 
            // TabControl
            // 
            this.TabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.TabControl.Controls.Add(this.InputTab);
            this.TabControl.Controls.Add(this.ResultsTab);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(822, 435);
            this.TabControl.TabIndex = 0;
            // 
            // InputTab
            // 
            this.InputTab.Controls.Add(this.tableLayoutPanel1);
            this.InputTab.Location = new System.Drawing.Point(4, 4);
            this.InputTab.Name = "InputTab";
            this.InputTab.Padding = new System.Windows.Forms.Padding(3);
            this.InputTab.Size = new System.Drawing.Size(814, 409);
            this.InputTab.TabIndex = 0;
            this.InputTab.Text = "Ввод данных";
            this.InputTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.53093F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.46907F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Matrix, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(808, 403);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.WidthUpDown, 0, 1);
            this.tableLayoutPanel2.Controls.Add(label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.GenerateButton, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.ResultsButton, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(22, 119);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(266, 184);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // WidthUpDown
            // 
            this.WidthUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WidthUpDown.BackColor = System.Drawing.Color.AliceBlue;
            this.WidthUpDown.Location = new System.Drawing.Point(109, 59);
            this.WidthUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.WidthUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WidthUpDown.Name = "WidthUpDown";
            this.WidthUpDown.Size = new System.Drawing.Size(48, 20);
            this.WidthUpDown.TabIndex = 0;
            this.WidthUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GenerateButton
            // 
            this.GenerateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GenerateButton.Location = new System.Drawing.Point(51, 103);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(164, 23);
            this.GenerateButton.TabIndex = 5;
            this.GenerateButton.Text = "Сформировать матрицу";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // ResultsButton
            // 
            this.ResultsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ResultsButton.Location = new System.Drawing.Point(50, 141);
            this.ResultsButton.Name = "ResultsButton";
            this.ResultsButton.Size = new System.Drawing.Size(165, 23);
            this.ResultsButton.TabIndex = 6;
            this.ResultsButton.Text = "Получить результаты";
            this.ResultsButton.UseVisualStyleBackColor = true;
            this.ResultsButton.Click += new System.EventHandler(this.ResultsButton_Click);
            // 
            // Matrix
            // 
            this.Matrix.AllowUserToAddRows = false;
            this.Matrix.AllowUserToDeleteRows = false;
            this.Matrix.AllowUserToResizeColumns = false;
            this.Matrix.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.Matrix.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Matrix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Matrix.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.Matrix.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Matrix.Location = new System.Drawing.Point(314, 22);
            this.Matrix.Name = "Matrix";
            this.Matrix.RowHeadersWidth = 50;
            this.Matrix.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Matrix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Matrix.ShowEditingIcon = false;
            this.Matrix.Size = new System.Drawing.Size(491, 378);
            this.Matrix.TabIndex = 0;
            this.Matrix.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Matrix_CellValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Матрица смежности:";
            // 
            // ResultsTab
            // 
            this.ResultsTab.Controls.Add(this.tableLayoutPanel3);
            this.ResultsTab.Location = new System.Drawing.Point(4, 4);
            this.ResultsTab.Name = "ResultsTab";
            this.ResultsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ResultsTab.Size = new System.Drawing.Size(814, 409);
            this.ResultsTab.TabIndex = 1;
            this.ResultsTab.Text = "Результаты";
            this.ResultsTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.ChromaticLabel, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.62305F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5078F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.62304F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.62304F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.62304F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(808, 403);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // ChromaticLabel
            // 
            this.ChromaticLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChromaticLabel.AutoSize = true;
            this.ChromaticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChromaticLabel.Location = new System.Drawing.Point(404, 337);
            this.ChromaticLabel.Name = "ChromaticLabel";
            this.ChromaticLabel.Size = new System.Drawing.Size(0, 25);
            this.ChromaticLabel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label7, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.DiameterLabel, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.RadiusLabel, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.CenterLabel, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.BridgesLabel, 3, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 65);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(802, 145);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(500, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(701, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 3;
            // 
            // DiameterLabel
            // 
            this.DiameterLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DiameterLabel.AutoSize = true;
            this.DiameterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiameterLabel.Location = new System.Drawing.Point(100, 72);
            this.DiameterLabel.Name = "DiameterLabel";
            this.DiameterLabel.Size = new System.Drawing.Size(0, 25);
            this.DiameterLabel.TabIndex = 4;
            // 
            // RadiusLabel
            // 
            this.RadiusLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RadiusLabel.AutoSize = true;
            this.RadiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadiusLabel.Location = new System.Drawing.Point(300, 72);
            this.RadiusLabel.Name = "RadiusLabel";
            this.RadiusLabel.Size = new System.Drawing.Size(0, 25);
            this.RadiusLabel.TabIndex = 4;
            // 
            // CenterLabel
            // 
            this.CenterLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CenterLabel.AutoSize = true;
            this.CenterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CenterLabel.Location = new System.Drawing.Point(500, 72);
            this.CenterLabel.Name = "CenterLabel";
            this.CenterLabel.Size = new System.Drawing.Size(0, 25);
            this.CenterLabel.TabIndex = 4;
            // 
            // BridgesLabel
            // 
            this.BridgesLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BridgesLabel.AutoSize = true;
            this.BridgesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BridgesLabel.Location = new System.Drawing.Point(701, 72);
            this.BridgesLabel.Name = "BridgesLabel";
            this.BridgesLabel.Size = new System.Drawing.Size(0, 25);
            this.BridgesLabel.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(404, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(404, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 435);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Курсовая работа по алгоритмизации и программированию. Рвач В., ИТ1721, 2017";
            this.TabControl.ResumeLayout(false);
            this.InputTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix)).EndInit();
            this.ResultsTab.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView Matrix;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown WidthUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Button ResultsButton;
        private System.Windows.Forms.TabPage InputTab;
        private System.Windows.Forms.TabPage ResultsTab;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ChromaticLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label DiameterLabel;
        private System.Windows.Forms.Label RadiusLabel;
        private System.Windows.Forms.Label CenterLabel;
        private System.Windows.Forms.Label BridgesLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

