
namespace WindowsClient
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
            this.dataGridOffices = new System.Windows.Forms.DataGridView();
            this.radioButtonBuildings = new System.Windows.Forms.RadioButton();
            this.radioButtonOffices = new System.Windows.Forms.RadioButton();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOffices)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridOffices
            // 
            this.dataGridOffices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOffices.Location = new System.Drawing.Point(225, 45);
            this.dataGridOffices.Name = "dataGridOffices";
            this.dataGridOffices.RowHeadersWidth = 62;
            this.dataGridOffices.RowTemplate.Height = 28;
            this.dataGridOffices.Size = new System.Drawing.Size(433, 360);
            this.dataGridOffices.TabIndex = 0;
            // 
            // radioButtonBuildings
            // 
            this.radioButtonBuildings.AutoSize = true;
            this.radioButtonBuildings.Checked = true;
            this.radioButtonBuildings.Location = new System.Drawing.Point(34, 71);
            this.radioButtonBuildings.Name = "radioButtonBuildings";
            this.radioButtonBuildings.Size = new System.Drawing.Size(98, 24);
            this.radioButtonBuildings.TabIndex = 1;
            this.radioButtonBuildings.TabStop = true;
            this.radioButtonBuildings.Text = "Buildings";
            this.radioButtonBuildings.UseVisualStyleBackColor = true;
            this.radioButtonBuildings.CheckedChanged += new System.EventHandler(this.radioButtonBuildings_CheckedChanged);
            // 
            // radioButtonOffices
            // 
            this.radioButtonOffices.AutoSize = true;
            this.radioButtonOffices.Location = new System.Drawing.Point(34, 111);
            this.radioButtonOffices.Name = "radioButtonOffices";
            this.radioButtonOffices.Size = new System.Drawing.Size(84, 24);
            this.radioButtonOffices.TabIndex = 2;
            this.radioButtonOffices.Text = "Offices";
            this.radioButtonOffices.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(34, 153);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(126, 35);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.radioButtonOffices);
            this.Controls.Add(this.radioButtonBuildings);
            this.Controls.Add(this.dataGridOffices);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOffices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridOffices;
        private System.Windows.Forms.RadioButton radioButtonBuildings;
        private System.Windows.Forms.RadioButton radioButtonOffices;
        private System.Windows.Forms.Button buttonSearch;
    }
}

