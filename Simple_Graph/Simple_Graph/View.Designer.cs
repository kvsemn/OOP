
namespace Simple_Graph
{
    partial class View
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
            this.sheet = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dlbutton = new System.Windows.Forms.Button();
            this.deleteALLButton = new System.Windows.Forms.Button();
            this.drawEdgeButton = new System.Windows.Forms.Button();
            this.drawVertexButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBoxMatrix = new System.Windows.Forms.ListBox();
            this.Matrix = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sheet
            // 
            this.sheet.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sheet.Location = new System.Drawing.Point(181, 25);
            this.sheet.Name = "sheet";
            this.sheet.Size = new System.Drawing.Size(710, 459);
            this.sheet.TabIndex = 0;
            this.sheet.TabStop = false;
            this.sheet.Click += new System.EventHandler(this.sheet_Click);
            this.sheet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sheet_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.dlbutton);
            this.panel1.Controls.Add(this.deleteALLButton);
            this.panel1.Controls.Add(this.drawEdgeButton);
            this.panel1.Controls.Add(this.drawVertexButton);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 459);
            this.panel1.TabIndex = 1;
            // 
            // dlbutton
            // 
            this.dlbutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dlbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dlbutton.Location = new System.Drawing.Point(29, 246);
            this.dlbutton.Name = "dlbutton";
            this.dlbutton.Size = new System.Drawing.Size(87, 76);
            this.dlbutton.TabIndex = 5;
            this.dlbutton.Text = "DEL";
            this.dlbutton.UseVisualStyleBackColor = false;
            this.dlbutton.Click += new System.EventHandler(this.dlbutton_Click);
            // 
            // deleteALLButton
            // 
            this.deleteALLButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteALLButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.deleteALLButton.Location = new System.Drawing.Point(29, 354);
            this.deleteALLButton.Name = "deleteALLButton";
            this.deleteALLButton.Size = new System.Drawing.Size(87, 76);
            this.deleteALLButton.TabIndex = 4;
            this.deleteALLButton.Text = "DEL ALL";
            this.deleteALLButton.UseVisualStyleBackColor = false;
            this.deleteALLButton.Click += new System.EventHandler(this.deleteALLButton_Click);
            // 
            // drawEdgeButton
            // 
            this.drawEdgeButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.drawEdgeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.drawEdgeButton.Location = new System.Drawing.Point(29, 133);
            this.drawEdgeButton.Name = "drawEdgeButton";
            this.drawEdgeButton.Size = new System.Drawing.Size(87, 76);
            this.drawEdgeButton.TabIndex = 1;
            this.drawEdgeButton.Text = "E";
            this.drawEdgeButton.UseVisualStyleBackColor = false;
            this.drawEdgeButton.Click += new System.EventHandler(this.drawEdgeButton_Click);
            // 
            // drawVertexButton
            // 
            this.drawVertexButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.drawVertexButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.drawVertexButton.Location = new System.Drawing.Point(29, 27);
            this.drawVertexButton.Name = "drawVertexButton";
            this.drawVertexButton.Size = new System.Drawing.Size(87, 76);
            this.drawVertexButton.TabIndex = 0;
            this.drawVertexButton.Text = "V";
            this.drawVertexButton.UseVisualStyleBackColor = false;
            this.drawVertexButton.Click += new System.EventHandler(this.drawVertexButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saveButton.Location = new System.Drawing.Point(66, 370);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(154, 57);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save graph";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.Matrix);
            this.panel3.Controls.Add(this.saveButton);
            this.panel3.Controls.Add(this.listBoxMatrix);
            this.panel3.Location = new System.Drawing.Point(920, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 456);
            this.panel3.TabIndex = 4;
            // 
            // listBoxMatrix
            // 
            this.listBoxMatrix.FormattingEnabled = true;
            this.listBoxMatrix.ItemHeight = 16;
            this.listBoxMatrix.Location = new System.Drawing.Point(15, 24);
            this.listBoxMatrix.Name = "listBoxMatrix";
            this.listBoxMatrix.Size = new System.Drawing.Size(251, 244);
            this.listBoxMatrix.TabIndex = 0;
            // 
            // Matrix
            // 
            this.Matrix.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Matrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Matrix.Location = new System.Drawing.Point(66, 289);
            this.Matrix.Name = "Matrix";
            this.Matrix.Size = new System.Drawing.Size(154, 57);
            this.Matrix.TabIndex = 3;
            this.Matrix.Text = "MATRIX";
            this.Matrix.UseVisualStyleBackColor = false;
            this.Matrix.Click += new System.EventHandler(this.Matrix_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1227, 520);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sheet);
            this.Name = "View";
            this.Text = "Simple Graph";
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox sheet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button drawEdgeButton;
        private System.Windows.Forms.Button drawVertexButton;
        private System.Windows.Forms.Button deleteALLButton;
        private System.Windows.Forms.Button dlbutton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Matrix;
        private System.Windows.Forms.ListBox listBoxMatrix;
    }
}

