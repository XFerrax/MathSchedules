namespace MathSchedules
{
    partial class Form1Opt
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonGen = new System.Windows.Forms.Button();
            this.buttonTestload = new System.Windows.Forms.Button();
            this.textBoxLenght = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelLenght = new System.Windows.Forms.Label();
            this.backgroundWorkerCalc = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.preTouchFileLable = new System.Windows.Forms.Label();
            this.touchFileLable = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(617, 496);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(155, 53);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonCalc
            // 
            this.buttonCalc.Enabled = false;
            this.buttonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalc.Location = new System.Drawing.Point(12, 496);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(155, 53);
            this.buttonCalc.TabIndex = 1;
            this.buttonCalc.Text = "Считать";
            this.buttonCalc.UseVisualStyleBackColor = true;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpen.Location = new System.Drawing.Point(173, 496);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(155, 53);
            this.buttonOpen.TabIndex = 2;
            this.buttonOpen.Text = "Открыть...";
            this.buttonOpen.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(456, 496);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(155, 53);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить...";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonGen
            // 
            this.buttonGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGen.Location = new System.Drawing.Point(173, 437);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(155, 53);
            this.buttonGen.TabIndex = 4;
            this.buttonGen.Text = "Генерация";
            this.buttonGen.UseVisualStyleBackColor = true;
            // 
            // buttonTestload
            // 
            this.buttonTestload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTestload.Location = new System.Drawing.Point(617, 437);
            this.buttonTestload.Name = "buttonTestload";
            this.buttonTestload.Size = new System.Drawing.Size(155, 53);
            this.buttonTestload.TabIndex = 5;
            this.buttonTestload.Text = "Тест";
            this.buttonTestload.UseVisualStyleBackColor = true;
            // 
            // textBoxLenght
            // 
            this.textBoxLenght.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLenght.Location = new System.Drawing.Point(29, 448);
            this.textBoxLenght.MaxLength = 2;
            this.textBoxLenght.Name = "textBoxLenght";
            this.textBoxLenght.Size = new System.Drawing.Size(45, 29);
            this.textBoxLenght.TabIndex = 6;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHeight.Location = new System.Drawing.Point(108, 448);
            this.textBoxHeight.MaxLength = 2;
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(45, 29);
            this.textBoxHeight.TabIndex = 7;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeight.Location = new System.Drawing.Point(91, 421);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(76, 24);
            this.labelHeight.TabIndex = 8;
            this.labelHeight.Text = "Высота";
            // 
            // labelLenght
            // 
            this.labelLenght.AutoSize = true;
            this.labelLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLenght.Location = new System.Drawing.Point(19, 421);
            this.labelLenght.Name = "labelLenght";
            this.labelLenght.Size = new System.Drawing.Size(66, 24);
            this.labelLenght.TabIndex = 9;
            this.labelLenght.Text = "Длина";
            // 
            // backgroundWorkerCalc
            // 
            this.backgroundWorkerCalc.WorkerReportsProgress = true;
            this.backgroundWorkerCalc.WorkerSupportsCancellation = true;
            this.backgroundWorkerCalc.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCalc_DoWork);
            this.backgroundWorkerCalc.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerCalc_ProgressChanged);
            this.backgroundWorkerCalc.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerCalc_RunWorkerComplited);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "saveFileDialog1";
            // 
            // preTouchFileLable
            // 
            this.preTouchFileLable.AutoSize = true;
            this.preTouchFileLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.preTouchFileLable.Location = new System.Drawing.Point(12, 9);
            this.preTouchFileLable.Name = "preTouchFileLable";
            this.preTouchFileLable.Size = new System.Drawing.Size(83, 24);
            this.preTouchFileLable.TabIndex = 10;
            this.preTouchFileLable.Text = "Выбран:";
            // 
            // touchFileLable
            // 
            this.touchFileLable.AutoSize = true;
            this.touchFileLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.touchFileLable.Location = new System.Drawing.Point(101, 9);
            this.touchFileLable.Name = "touchFileLable";
            this.touchFileLable.Size = new System.Drawing.Size(53, 24);
            this.touchFileLable.TabIndex = 11;
            this.touchFileLable.Text = "свой";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(617, 496);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(155, 53);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 378);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(760, 40);
            this.progressBar1.TabIndex = 14;
            // 
            // Form1Opt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.touchFileLable);
            this.Controls.Add(this.preTouchFileLable);
            this.Controls.Add(this.labelLenght);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxLenght);
            this.Controls.Add(this.buttonTestload);
            this.Controls.Add(this.buttonGen);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.buttonExit);
            this.MaximizeBox = false;
            this.Name = "Form1Opt";
            this.Text = "1Opt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonGen;
        private System.Windows.Forms.Button buttonTestload;
        private System.Windows.Forms.TextBox textBoxLenght;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelLenght;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCalc;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label preTouchFileLable;
        private System.Windows.Forms.Label touchFileLable;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

