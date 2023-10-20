namespace Jacky.Zungu_c__SectionB_WordConcanate
{
    partial class Form1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnConcatenate = new System.Windows.Forms.Button();
            this.txtEnterWrd = new System.Windows.Forms.TextBox();
            this.cbWord1 = new System.Windows.Forms.ComboBox();
            this.cbWord2 = new System.Windows.Forms.ComboBox();
            this.rBtn = new System.Windows.Forms.RadioButton();
            this.rBtn2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblConcatenatedWord = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(428, 123);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 35);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Word";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnConcatenate
            // 
            this.btnConcatenate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcatenate.Location = new System.Drawing.Point(428, 386);
            this.btnConcatenate.Name = "btnConcatenate";
            this.btnConcatenate.Size = new System.Drawing.Size(141, 38);
            this.btnConcatenate.TabIndex = 1;
            this.btnConcatenate.Text = "Concatenate";
            this.btnConcatenate.UseVisualStyleBackColor = true;
            this.btnConcatenate.Click += new System.EventHandler(this.btnConcatenate_Click);
            // 
            // txtEnterWrd
            // 
            this.txtEnterWrd.Location = new System.Drawing.Point(365, 76);
            this.txtEnterWrd.Name = "txtEnterWrd";
            this.txtEnterWrd.Size = new System.Drawing.Size(257, 22);
            this.txtEnterWrd.TabIndex = 2;
            // 
            // cbWord1
            // 
            this.cbWord1.BackColor = System.Drawing.Color.White;
            this.cbWord1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWord1.FormattingEnabled = true;
            this.cbWord1.Location = new System.Drawing.Point(143, 225);
            this.cbWord1.Name = "cbWord1";
            this.cbWord1.Size = new System.Drawing.Size(216, 24);
            this.cbWord1.TabIndex = 3;
            // 
            // cbWord2
            // 
            this.cbWord2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWord2.FormattingEnabled = true;
            this.cbWord2.Location = new System.Drawing.Point(664, 224);
            this.cbWord2.Name = "cbWord2";
            this.cbWord2.Size = new System.Drawing.Size(199, 24);
            this.cbWord2.TabIndex = 4;
            // 
            // rBtn
            // 
            this.rBtn.AutoSize = true;
            this.rBtn.Location = new System.Drawing.Point(220, 289);
            this.rBtn.Name = "rBtn";
            this.rBtn.Size = new System.Drawing.Size(80, 20);
            this.rBtn.TabIndex = 5;
            this.rBtn.TabStop = true;
            this.rBtn.Text = "Remove";
            this.rBtn.UseVisualStyleBackColor = true;
            this.rBtn.CheckedChanged += new System.EventHandler(this.rBtn_CheckedChanged);
            // 
            // rBtn2
            // 
            this.rBtn2.AutoSize = true;
            this.rBtn2.Location = new System.Drawing.Point(751, 289);
            this.rBtn2.Name = "rBtn2";
            this.rBtn2.Size = new System.Drawing.Size(80, 20);
            this.rBtn2.TabIndex = 6;
            this.rBtn2.TabStop = true;
            this.rBtn2.Text = "Remove";
            this.rBtn2.UseVisualStyleBackColor = true;
            this.rBtn2.CheckedChanged += new System.EventHandler(this.rBtn2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter a new word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(481, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "OR";
            // 
            // lblConcatenatedWord
            // 
            this.lblConcatenatedWord.BackColor = System.Drawing.Color.White;
            this.lblConcatenatedWord.Location = new System.Drawing.Point(385, 483);
            this.lblConcatenatedWord.Name = "lblConcatenatedWord";
            this.lblConcatenatedWord.Size = new System.Drawing.Size(311, 39);
            this.lblConcatenatedWord.TabIndex = 9;
            this.lblConcatenatedWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select a word:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(688, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Selecte another word:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(910, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1043, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblConcatenatedWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rBtn2);
            this.Controls.Add(this.rBtn);
            this.Controls.Add(this.cbWord2);
            this.Controls.Add(this.cbWord1);
            this.Controls.Add(this.txtEnterWrd);
            this.Controls.Add(this.btnConcatenate);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Word Concatenate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnConcatenate;
        private System.Windows.Forms.TextBox txtEnterWrd;
        private System.Windows.Forms.ComboBox cbWord1;
        private System.Windows.Forms.ComboBox cbWord2;
        private System.Windows.Forms.RadioButton rBtn;
        private System.Windows.Forms.RadioButton rBtn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblConcatenatedWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

