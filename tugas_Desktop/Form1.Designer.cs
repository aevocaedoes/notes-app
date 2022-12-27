namespace tugas_Desktop
{
    partial class NoteTaker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteTaker));
            this.titlebox = new System.Windows.Forms.TextBox();
            this.notebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.previousnotes = new System.Windows.Forms.DataGridView();
            this.loadbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.newbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.previousnotes)).BeginInit();
            this.SuspendLayout();
            // 
            // titlebox
            // 
            this.titlebox.Location = new System.Drawing.Point(416, 52);
            this.titlebox.Name = "titlebox";
            this.titlebox.Size = new System.Drawing.Size(372, 23);
            this.titlebox.TabIndex = 0;
            // 
            // notebox
            // 
            this.notebox.Location = new System.Drawing.Point(416, 104);
            this.notebox.Multiline = true;
            this.notebox.Name = "notebox";
            this.notebox.Size = new System.Drawing.Size(372, 334);
            this.notebox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(416, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(416, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Note:";
            // 
            // previousnotes
            // 
            this.previousnotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.previousnotes.BackgroundColor = System.Drawing.Color.White;
            this.previousnotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previousnotes.Location = new System.Drawing.Point(12, 12);
            this.previousnotes.Name = "previousnotes";
            this.previousnotes.RowTemplate.Height = 25;
            this.previousnotes.Size = new System.Drawing.Size(388, 330);
            this.previousnotes.TabIndex = 4;
            this.previousnotes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.previousnotes_CellDoubleClick);
            // 
            // loadbutton
            // 
            this.loadbutton.BackColor = System.Drawing.Color.White;
            this.loadbutton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadbutton.Location = new System.Drawing.Point(12, 348);
            this.loadbutton.Name = "loadbutton";
            this.loadbutton.Size = new System.Drawing.Size(188, 45);
            this.loadbutton.TabIndex = 5;
            this.loadbutton.Text = "Load";
            this.loadbutton.UseVisualStyleBackColor = false;
            this.loadbutton.Click += new System.EventHandler(this.loadbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.White;
            this.deletebutton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deletebutton.Location = new System.Drawing.Point(206, 348);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(194, 45);
            this.deletebutton.TabIndex = 6;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.Color.White;
            this.savebutton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.savebutton.Location = new System.Drawing.Point(206, 399);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(194, 45);
            this.savebutton.TabIndex = 7;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // newbutton
            // 
            this.newbutton.BackColor = System.Drawing.Color.White;
            this.newbutton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newbutton.Location = new System.Drawing.Point(12, 399);
            this.newbutton.Name = "newbutton";
            this.newbutton.Size = new System.Drawing.Size(188, 45);
            this.newbutton.TabIndex = 8;
            this.newbutton.Text = "New";
            this.newbutton.UseVisualStyleBackColor = false;
            this.newbutton.Click += new System.EventHandler(this.newbutton_Click);
            // 
            // NoteTaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.newbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.loadbutton);
            this.Controls.Add(this.previousnotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notebox);
            this.Controls.Add(this.titlebox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NoteTaker";
            this.Text = "Note Taker";
            this.Load += new System.EventHandler(this.NoteTaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previousnotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox titlebox;
        private TextBox notebox;
        private Label label1;
        private Label label2;
        private DataGridView previousnotes;
        private Button loadbutton;
        private Button deletebutton;
        private Button savebutton;
        private Button newbutton;
    }
}