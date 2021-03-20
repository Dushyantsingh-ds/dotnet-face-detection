
namespace Sanskriti_Univ_01
{
    partial class AddNew_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddNew_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // AddNew_btn
            // 
            this.AddNew_btn.Location = new System.Drawing.Point(39, 33);
            this.AddNew_btn.Name = "AddNew_btn";
            this.AddNew_btn.Size = new System.Drawing.Size(75, 23);
            this.AddNew_btn.TabIndex = 1;
            this.AddNew_btn.Text = "AddNew_btn";
            this.AddNew_btn.UseVisualStyleBackColor = true;
            this.AddNew_btn.Click += new System.EventHandler(this.AddNew_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(715, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNew_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddNew_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddNew_UC";
            this.Size = new System.Drawing.Size(848, 459);
            this.Load += new System.EventHandler(this.AddNew_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddNew_btn;
        private System.Windows.Forms.Button button1;
    }
}
