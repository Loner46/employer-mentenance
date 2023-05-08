namespace MentenaceUI
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
            this.controlCodeDropDown = new System.Windows.Forms.ComboBox();
            this.controlLabel = new System.Windows.Forms.Label();
            this.displayButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.cancelButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // controlCodeDropDown
            // 
            this.controlCodeDropDown.FormattingEnabled = true;
            this.controlCodeDropDown.Location = new System.Drawing.Point(222, 45);
            this.controlCodeDropDown.Name = "controlCodeDropDown";
            this.controlCodeDropDown.Size = new System.Drawing.Size(188, 38);
            this.controlCodeDropDown.TabIndex = 0;
            // 
            // controlLabel
            // 
            this.controlLabel.AutoSize = true;
            this.controlLabel.Location = new System.Drawing.Point(53, 48);
            this.controlLabel.Name = "controlLabel";
            this.controlLabel.Size = new System.Drawing.Size(57, 30);
            this.controlLabel.TabIndex = 5;
            this.controlLabel.Text = "所属";
            // 
            // displayButton
            // 
            this.displayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayButton.Location = new System.Drawing.Point(448, 44);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(126, 38);
            this.displayButton.TabIndex = 1;
            this.displayButton.Text = "表示";
            this.displayButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(60, 104);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(668, 307);
            this.dataGridView.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(602, 465);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(126, 38);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // selectButton
            // 
            this.selectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectButton.Location = new System.Drawing.Point(448, 465);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(126, 38);
            this.selectButton.TabIndex = 3;
            this.selectButton.Text = "選択";
            this.selectButton.UseVisualStyleBackColor = true;
            // 
            // ReferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(825, 560);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.controlCodeDropDown);
            this.Controls.Add(this.controlLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ReferenceForm";
            this.Text = "ReferenceForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox controlCodeDropDown;
        private Label controlLabel;
        private Button displayButton;
        private DataGridView dataGridView;
        private Button cancelButton;
        private Button selectButton;
    }
}