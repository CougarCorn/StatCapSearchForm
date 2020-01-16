namespace StatCapSearchForm
{
    partial class StateCapForm
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
            this.StateTxtBox = new System.Windows.Forms.TextBox();
            this.CapitalTxtBox = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LstBoxStateCap = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // StateTxtBox
            // 
            this.StateTxtBox.Location = new System.Drawing.Point(169, 85);
            this.StateTxtBox.Name = "StateTxtBox";
            this.StateTxtBox.Size = new System.Drawing.Size(161, 26);
            this.StateTxtBox.TabIndex = 0;
            // 
            // CapitalTxtBox
            // 
            this.CapitalTxtBox.Location = new System.Drawing.Point(169, 144);
            this.CapitalTxtBox.Name = "CapitalTxtBox";
            this.CapitalTxtBox.Size = new System.Drawing.Size(161, 26);
            this.CapitalTxtBox.TabIndex = 1;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(177, 195);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(153, 45);
            this.ButtonSave.TabIndex = 3;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "State";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Capital";
            // 
            // LstBoxStateCap
            // 
            this.LstBoxStateCap.HideSelection = false;
            this.LstBoxStateCap.Location = new System.Drawing.Point(436, 85);
            this.LstBoxStateCap.Name = "LstBoxStateCap";
            this.LstBoxStateCap.Size = new System.Drawing.Size(267, 294);
            this.LstBoxStateCap.TabIndex = 5;
            this.LstBoxStateCap.TabStop = false;
            this.LstBoxStateCap.UseCompatibleStateImageBehavior = false;
            // 
            // StateCapForm
            // 
            this.AcceptButton = this.ButtonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LstBoxStateCap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.CapitalTxtBox);
            this.Controls.Add(this.StateTxtBox);
            this.Name = "StateCapForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StateCapForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StateTxtBox;
        private System.Windows.Forms.TextBox CapitalTxtBox;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView LstBoxStateCap;
    }
}

