namespace MaintenanceUI
{
    partial class ReferenceForm
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
            this.controlCodeLabel = new System.Windows.Forms.Label();
            this.displayButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cancelButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.controlDropDown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // controlCodeLabel
            // 
            this.controlCodeLabel.AutoSize = true;
            this.controlCodeLabel.Location = new System.Drawing.Point(70, 56);
            this.controlCodeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.controlCodeLabel.Name = "controlCodeLabel";
            this.controlCodeLabel.Size = new System.Drawing.Size(57, 30);
            this.controlCodeLabel.TabIndex = 2;
            this.controlCodeLabel.Text = "所属";
            // 
            // displayButton
            // 
            this.displayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayButton.Location = new System.Drawing.Point(382, 49);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(154, 44);
            this.displayButton.TabIndex = 1;
            this.displayButton.Text = "表示";
            this.displayButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(74, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(771, 335);
            this.dataGridView1.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(691, 504);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(154, 44);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // selectButton
            // 
            this.selectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectButton.Location = new System.Drawing.Point(482, 504);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(154, 44);
            this.selectButton.TabIndex = 3;
            this.selectButton.Text = "選択";
            this.selectButton.UseVisualStyleBackColor = true;
            // 
            // controlDropDown
            // 
            this.controlDropDown.FormattingEnabled = true;
            this.controlDropDown.Location = new System.Drawing.Point(161, 53);
            this.controlDropDown.Name = "controlDropDown";
            this.controlDropDown.Size = new System.Drawing.Size(169, 38);
            this.controlDropDown.TabIndex = 0;
            // 
            // ReferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(942, 589);
            this.Controls.Add(this.controlDropDown);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.controlCodeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "ReferenceForm";
            this.Text = "Reference";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label controlCodeLabel;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.ComboBox controlDropDown;
    }
}