
namespace BikeRentalCompany
{
    partial class NewRentalForm
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
            this.clientContactComboBox = new System.Windows.Forms.ComboBox();
            this.identificationTypeLabel = new System.Windows.Forms.Label();
            this.identificationLabel = new System.Windows.Forms.Label();
            this.identificationTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.categoryBycicleComboBox = new System.Windows.Forms.ComboBox();
            this.serviceComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.discountComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.exitButton = new System.Windows.Forms.Button();
            this.rentedTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.availableTextBox = new System.Windows.Forms.TextBox();
            this.rentedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // clientContactComboBox
            // 
            this.clientContactComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientContactComboBox.FormattingEnabled = true;
            this.clientContactComboBox.Items.AddRange(new object[] {
            "Telefon",
            "E-mail",
            "CNP"});
            this.clientContactComboBox.Location = new System.Drawing.Point(261, 95);
            this.clientContactComboBox.Name = "clientContactComboBox";
            this.clientContactComboBox.Size = new System.Drawing.Size(194, 24);
            this.clientContactComboBox.TabIndex = 0;
            this.clientContactComboBox.SelectionChangeCommitted += new System.EventHandler(this.clientContactComboBox_SelectionChangeCommitted);
            // 
            // identificationTypeLabel
            // 
            this.identificationTypeLabel.AutoSize = true;
            this.identificationTypeLabel.Location = new System.Drawing.Point(109, 98);
            this.identificationTypeLabel.Name = "identificationTypeLabel";
            this.identificationTypeLabel.Size = new System.Drawing.Size(146, 17);
            this.identificationTypeLabel.TabIndex = 1;
            this.identificationTypeLabel.Text = "Identificare client prin:";
            // 
            // identificationLabel
            // 
            this.identificationLabel.AutoSize = true;
            this.identificationLabel.Location = new System.Drawing.Point(109, 129);
            this.identificationLabel.Name = "identificationLabel";
            this.identificationLabel.Size = new System.Drawing.Size(122, 17);
            this.identificationLabel.TabIndex = 2;
            this.identificationLabel.Text = "Identificator client:";
            // 
            // identificationTextBox
            // 
            this.identificationTextBox.Location = new System.Drawing.Point(261, 125);
            this.identificationTextBox.Name = "identificationTextBox";
            this.identificationTextBox.Size = new System.Drawing.Size(194, 22);
            this.identificationTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Categorie bicicleta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tip serviciu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 6;
            // 
            // categoryBycicleComboBox
            // 
            this.categoryBycicleComboBox.FormattingEnabled = true;
            this.categoryBycicleComboBox.Items.AddRange(new object[] {
            "Bicicleta adult",
            "Bicicleta copil"});
            this.categoryBycicleComboBox.Location = new System.Drawing.Point(261, 154);
            this.categoryBycicleComboBox.Name = "categoryBycicleComboBox";
            this.categoryBycicleComboBox.Size = new System.Drawing.Size(194, 24);
            this.categoryBycicleComboBox.TabIndex = 7;
            // 
            // serviceComboBox
            // 
            this.serviceComboBox.FormattingEnabled = true;
            this.serviceComboBox.Items.AddRange(new object[] {
            "one pass"});
            this.serviceComboBox.Location = new System.Drawing.Point(261, 184);
            this.serviceComboBox.Name = "serviceComboBox";
            this.serviceComboBox.Size = new System.Drawing.Size(194, 24);
            this.serviceComboBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Act reducere:";
            // 
            // discountComboBox
            // 
            this.discountComboBox.FormattingEnabled = true;
            this.discountComboBox.Items.AddRange(new object[] {
            "Elev",
            "Student",
            "Pensionar"});
            this.discountComboBox.Location = new System.Drawing.Point(261, 214);
            this.discountComboBox.Name = "discountComboBox";
            this.discountComboBox.Size = new System.Drawing.Size(194, 24);
            this.discountComboBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(506, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 451);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(867, 49);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.Control;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(859, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(29, 29);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // rentedTextBox
            // 
            this.rentedTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.rentedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rentedTextBox.Location = new System.Drawing.Point(659, 229);
            this.rentedTextBox.Name = "rentedTextBox";
            this.rentedTextBox.Size = new System.Drawing.Size(100, 15);
            this.rentedTextBox.TabIndex = 20;
            this.rentedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(612, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Numarul de biciclete disponibile:";
            // 
            // availableTextBox
            // 
            this.availableTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.availableTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.availableTextBox.Location = new System.Drawing.Point(659, 147);
            this.availableTextBox.Name = "availableTextBox";
            this.availableTextBox.Size = new System.Drawing.Size(100, 15);
            this.availableTextBox.TabIndex = 18;
            this.availableTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rentedLabel
            // 
            this.rentedLabel.AutoSize = true;
            this.rentedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentedLabel.Location = new System.Drawing.Point(612, 191);
            this.rentedLabel.Name = "rentedLabel";
            this.rentedLabel.Size = new System.Drawing.Size(201, 17);
            this.rentedLabel.TabIndex = 17;
            this.rentedLabel.Text = "Numarul de biciclete inchiriate:";
            // 
            // NewRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 530);
            this.Controls.Add(this.rentedTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.availableTextBox);
            this.Controls.Add(this.rentedLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.discountComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.serviceComboBox);
            this.Controls.Add(this.categoryBycicleComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.identificationTextBox);
            this.Controls.Add(this.identificationLabel);
            this.Controls.Add(this.identificationTypeLabel);
            this.Controls.Add(this.clientContactComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewRentalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox clientContactComboBox;
        private System.Windows.Forms.Label identificationTypeLabel;
        private System.Windows.Forms.Label identificationLabel;
        private System.Windows.Forms.TextBox identificationTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox categoryBycicleComboBox;
        private System.Windows.Forms.ComboBox serviceComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox discountComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox rentedTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox availableTextBox;
        private System.Windows.Forms.Label rentedLabel;
    }
}