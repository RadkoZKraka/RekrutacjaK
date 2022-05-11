using System.ComponentModel;

namespace RekrutacjaK
{
    partial class MainView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.simulateButton = new System.Windows.Forms.Button();
            this.numberOfProducts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.lastThreeDays = new System.Windows.Forms.CheckBox();
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.clearTable = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.productGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // simulateButton
            // 
            this.simulateButton.Location = new System.Drawing.Point(508, 181);
            this.simulateButton.Name = "simulateButton";
            this.simulateButton.Size = new System.Drawing.Size(107, 29);
            this.simulateButton.TabIndex = 1;
            this.simulateButton.Text = "Symuluj";
            this.simulateButton.UseVisualStyleBackColor = true;
            this.simulateButton.Click += new System.EventHandler(this.simulateButton_Click);
            // 
            // numberOfProducts
            // 
            this.numberOfProducts.Location = new System.Drawing.Point(494, 112);
            this.numberOfProducts.Name = "numberOfProducts";
            this.numberOfProducts.Size = new System.Drawing.Size(85, 20);
            this.numberOfProducts.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(494, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ilość produktów";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(602, 112);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(78, 20);
            this.startDate.TabIndex = 4;
            this.startDate.ValueChanged += new System.EventHandler(this.startDate_ValueChanged);
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(689, 112);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(78, 20);
            this.endDate.TabIndex = 5;
            this.endDate.ValueChanged += new System.EventHandler(this.endDate_ValueChanged);
            // 
            // lastThreeDays
            // 
            this.lastThreeDays.Location = new System.Drawing.Point(579, 138);
            this.lastThreeDays.Name = "lastThreeDays";
            this.lastThreeDays.Size = new System.Drawing.Size(101, 22);
            this.lastThreeDays.TabIndex = 6;
            this.lastThreeDays.Text = "Ostatnie 3 dni";
            this.lastThreeDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lastThreeDays.UseVisualStyleBackColor = true;
            this.lastThreeDays.CheckedChanged += new System.EventHandler(this.lastThreeDays_CheckedChanged);
            // 
            // productGridView
            // 
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Location = new System.Drawing.Point(3, 22);
            this.productGridView.Name = "productGridView";
            this.productGridView.ReadOnly = true;
            this.productGridView.Size = new System.Drawing.Size(472, 334);
            this.productGridView.TabIndex = 7;
            this.productGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productGridView_CellContentClick);
            // 
            // clearTable
            // 
            this.clearTable.Location = new System.Drawing.Point(640, 180);
            this.clearTable.Name = "clearTable";
            this.clearTable.Size = new System.Drawing.Size(107, 30);
            this.clearTable.TabIndex = 8;
            this.clearTable.Text = "Wyczyść tablice";
            this.clearTable.UseVisualStyleBackColor = true;
            this.clearTable.Click += new System.EventHandler(this.clearTable_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(606, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "Data Od";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(689, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data Do";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(494, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 36);
            this.label4.TabIndex = 11;
            this.label4.Text = "Jeżeli nie zostanie podana liczba produktów to zostanie wygenerowana ich liczba p" + "omiędzy 5 a 20.";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clearTable);
            this.Controls.Add(this.productGridView);
            this.Controls.Add(this.lastThreeDays);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberOfProducts);
            this.Controls.Add(this.simulateButton);
            this.Name = "MainView";
            this.Size = new System.Drawing.Size(779, 385);
            ((System.ComponentModel.ISupportInitialize) (this.productGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Button clearTable;

        public System.Windows.Forms.DataGridView productGridView;

        public System.Windows.Forms.DateTimePicker startDate;
        public System.Windows.Forms.DateTimePicker endDate;
        public System.Windows.Forms.CheckBox lastThreeDays;

        public System.Windows.Forms.TextBox numberOfProducts;
        public System.Windows.Forms.Label label1;

        public System.Windows.Forms.Button simulateButton;

        #endregion
    }
}