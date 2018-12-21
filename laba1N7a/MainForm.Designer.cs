namespace laba1N7a
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
            this.listBox_dictionary = new System.Windows.Forms.ListBox();
            this.dataGridView_Cubes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_LoadFromFile = new System.Windows.Forms.Button();
            this.textBox_Word = new System.Windows.Forms.TextBox();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Run = new System.Windows.Forms.Button();
            this.listBox_Result = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_About = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cubes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_dictionary
            // 
            this.listBox_dictionary.FormattingEnabled = true;
            this.listBox_dictionary.ItemHeight = 16;
            this.listBox_dictionary.Location = new System.Drawing.Point(12, 35);
            this.listBox_dictionary.Name = "listBox_dictionary";
            this.listBox_dictionary.Size = new System.Drawing.Size(274, 484);
            this.listBox_dictionary.TabIndex = 8;
            // 
            // dataGridView_Cubes
            // 
            this.dataGridView_Cubes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Cubes.Location = new System.Drawing.Point(292, 35);
            this.dataGridView_Cubes.Name = "dataGridView_Cubes";
            this.dataGridView_Cubes.RowTemplate.Height = 24;
            this.dataGridView_Cubes.Size = new System.Drawing.Size(240, 484);
            this.dataGridView_Cubes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Словарь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Кубики";
            // 
            // btn_LoadFromFile
            // 
            this.btn_LoadFromFile.Location = new System.Drawing.Point(599, 35);
            this.btn_LoadFromFile.Name = "btn_LoadFromFile";
            this.btn_LoadFromFile.Size = new System.Drawing.Size(266, 32);
            this.btn_LoadFromFile.TabIndex = 11;
            this.btn_LoadFromFile.Text = "Загрузить словарь из файла";
            this.btn_LoadFromFile.UseVisualStyleBackColor = true;
            // 
            // textBox_Word
            // 
            this.textBox_Word.Location = new System.Drawing.Point(599, 116);
            this.textBox_Word.Name = "textBox_Word";
            this.textBox_Word.Size = new System.Drawing.Size(130, 22);
            this.textBox_Word.TabIndex = 12;
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(742, 240);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(135, 22);
            this.textBox_Result.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(616, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "введите слово";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(740, 112);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(125, 30);
            this.btn_Add.TabIndex = 15;
            this.btn_Add.Text = "добавить слово";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // numUpDown
            // 
            this.numUpDown.Location = new System.Drawing.Point(599, 175);
            this.numUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown.Name = "numUpDown";
            this.numUpDown.Size = new System.Drawing.Size(120, 22);
            this.numUpDown.TabIndex = 16;
            this.numUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(752, 171);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(113, 26);
            this.btn_Generate.TabIndex = 17;
            this.btn_Generate.Text = "сгенерировать кубики";
            this.btn_Generate.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(766, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Результат";
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(592, 235);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(110, 41);
            this.btn_Run.TabIndex = 19;
            this.btn_Run.Text = "выполнить";
            this.btn_Run.UseVisualStyleBackColor = true;
            // 
            // listBox_Result
            // 
            this.listBox_Result.FormattingEnabled = true;
            this.listBox_Result.ItemHeight = 16;
            this.listBox_Result.Location = new System.Drawing.Point(742, 325);
            this.listBox_Result.Name = "listBox_Result";
            this.listBox_Result.Size = new System.Drawing.Size(125, 180);
            this.listBox_Result.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(589, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "количество кубиков";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(599, 325);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(103, 39);
            this.btn_Clear.TabIndex = 22;
            this.btn_Clear.Text = "очистить";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // btn_About
            // 
            this.btn_About.Location = new System.Drawing.Point(599, 402);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(103, 35);
            this.btn_About.TabIndex = 23;
            this.btn_About.Text = "задание";
            this.btn_About.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(599, 473);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(103, 32);
            this.btn_Exit.TabIndex = 24;
            this.btn_Exit.Text = "выход";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(737, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Подходящие слова";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 564);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_About);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox_Result);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.numUpDown);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.textBox_Word);
            this.Controls.Add(this.btn_LoadFromFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Cubes);
            this.Controls.Add(this.listBox_dictionary);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cubes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_dictionary;
        private System.Windows.Forms.DataGridView dataGridView_Cubes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_LoadFromFile;
        private System.Windows.Forms.TextBox textBox_Word;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.NumericUpDown numUpDown;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.ListBox listBox_Result;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_About;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label6;
    }
}

