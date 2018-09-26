namespace Another_Text_File_Example
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
            this.namelbl = new System.Windows.Forms.Label();
            this.agelbl = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.agetxt = new System.Windows.Forms.TextBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.loadbtn = new System.Windows.Forms.Button();
            this.displatbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(12, 9);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(43, 17);
            this.namelbl.TabIndex = 0;
            this.namelbl.Text = "name";
            // 
            // agelbl
            // 
            this.agelbl.AutoSize = true;
            this.agelbl.Location = new System.Drawing.Point(12, 40);
            this.agelbl.Name = "agelbl";
            this.agelbl.Size = new System.Drawing.Size(32, 17);
            this.agelbl.TabIndex = 1;
            this.agelbl.Text = "age";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(64, 9);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(100, 22);
            this.nametxt.TabIndex = 2;
            // 
            // agetxt
            // 
            this.agetxt.Location = new System.Drawing.Point(64, 40);
            this.agetxt.Name = "agetxt";
            this.agetxt.Size = new System.Drawing.Size(100, 22);
            this.agetxt.TabIndex = 3;
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(28, 145);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 4;
            this.savebtn.Text = "save";
            this.savebtn.UseVisualStyleBackColor = true;
            // 
            // loadbtn
            // 
            this.loadbtn.Location = new System.Drawing.Point(28, 174);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(75, 23);
            this.loadbtn.TabIndex = 5;
            this.loadbtn.Text = "load";
            this.loadbtn.UseVisualStyleBackColor = true;
            // 
            // displatbtn
            // 
            this.displatbtn.Location = new System.Drawing.Point(28, 203);
            this.displatbtn.Name = "displatbtn";
            this.displatbtn.Size = new System.Drawing.Size(75, 23);
            this.displatbtn.TabIndex = 6;
            this.displatbtn.Text = "display";
            this.displatbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.displatbtn);
            this.Controls.Add(this.loadbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.agetxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.agelbl);
            this.Controls.Add(this.namelbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label agelbl;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox agetxt;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button loadbtn;
        private System.Windows.Forms.Button displatbtn;
    }
}

