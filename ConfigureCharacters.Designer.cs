
namespace Quiccent
{
    partial class ConfigureCharacters
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
            this.CharacterSelector = new System.Windows.Forms.ListBox();
            this.CharacterComboBox = new System.Windows.Forms.ComboBox();
            this.Remove = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.RemovedCharactersSelector = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CharacterSelector
            // 
            this.CharacterSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterSelector.FormattingEnabled = true;
            this.CharacterSelector.ItemHeight = 37;
            this.CharacterSelector.Location = new System.Drawing.Point(44, 50);
            this.CharacterSelector.Name = "CharacterSelector";
            this.CharacterSelector.Size = new System.Drawing.Size(136, 448);
            this.CharacterSelector.TabIndex = 0;
            this.CharacterSelector.DragDrop += new System.Windows.Forms.DragEventHandler(this.CharacterSelector_DragDrop);
            this.CharacterSelector.DragOver += new System.Windows.Forms.DragEventHandler(this.CharacterSelector_DragOver);
            this.CharacterSelector.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CharacterSelector_MouseDown);
            // 
            // CharacterComboBox
            // 
            this.CharacterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterComboBox.FormattingEnabled = true;
            this.CharacterComboBox.Location = new System.Drawing.Point(242, 188);
            this.CharacterComboBox.Name = "CharacterComboBox";
            this.CharacterComboBox.Size = new System.Drawing.Size(72, 37);
            this.CharacterComboBox.Sorted = true;
            this.CharacterComboBox.TabIndex = 1;
            this.CharacterComboBox.SelectedIndexChanged += new System.EventHandler(this.CharacterComboBox_SelectedIndexChanged);
            // 
            // Remove
            // 
            this.Remove.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove.ForeColor = System.Drawing.Color.Red;
            this.Remove.Location = new System.Drawing.Point(242, 345);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(72, 62);
            this.Remove.TabIndex = 2;
            this.Remove.Text = "-";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Add.Location = new System.Drawing.Point(242, 277);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(72, 62);
            this.Add.TabIndex = 3;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // RemovedCharactersSelector
            // 
            this.RemovedCharactersSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemovedCharactersSelector.FormattingEnabled = true;
            this.RemovedCharactersSelector.ItemHeight = 37;
            this.RemovedCharactersSelector.Location = new System.Drawing.Point(373, 50);
            this.RemovedCharactersSelector.Name = "RemovedCharactersSelector";
            this.RemovedCharactersSelector.Size = new System.Drawing.Size(130, 448);
            this.RemovedCharactersSelector.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Character";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Included Accents";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Excluded Accents";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 505);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Drag and Drop to Order";
            // 
            // ConfigureCharacters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(562, 539);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemovedCharactersSelector);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.CharacterComboBox);
            this.Controls.Add(this.CharacterSelector);
            this.MaximumSize = new System.Drawing.Size(584, 595);
            this.MinimumSize = new System.Drawing.Size(584, 595);
            this.Name = "ConfigureCharacters";
            this.Text = "Quiccent - Configure Characters";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigureCharacters_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CharacterSelector;
        private System.Windows.Forms.ComboBox CharacterComboBox;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ListBox RemovedCharactersSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}