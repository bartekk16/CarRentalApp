
namespace CarRentalApp
{
    partial class AddEditRentalRecord
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtRented = new System.Windows.Forms.DateTimePicker();
            this.dtReturned = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTypeOfCar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.lbCost = new System.Windows.Forms.Label();
            this.lblRecordId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Matura MT Script Capitals", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(80, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(470, 64);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dodaj wypożyczenie";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(18, 104);
            this.tbCustomerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(241, 26);
            this.tbCustomerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Imię i Nazwisko klienta";
            // 
            // dtRented
            // 
            this.dtRented.Location = new System.Drawing.Point(18, 173);
            this.dtRented.Name = "dtRented";
            this.dtRented.Size = new System.Drawing.Size(241, 26);
            this.dtRented.TabIndex = 3;
            // 
            // dtReturned
            // 
            this.dtReturned.Location = new System.Drawing.Point(343, 173);
            this.dtReturned.Name = "dtReturned";
            this.dtReturned.Size = new System.Drawing.Size(278, 26);
            this.dtReturned.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data wypożyczenia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data zwrotu";
            // 
            // cbTypeOfCar
            // 
            this.cbTypeOfCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeOfCar.FormattingEnabled = true;
            this.cbTypeOfCar.Location = new System.Drawing.Point(18, 249);
            this.cbTypeOfCar.Name = "cbTypeOfCar";
            this.cbTypeOfCar.Size = new System.Drawing.Size(241, 28);
            this.cbTypeOfCar.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Typ samochodu";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Matura MT Script Capitals", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(363, 226);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(158, 50);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Wpisz";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(343, 102);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(278, 26);
            this.tbCost.TabIndex = 10;
            // 
            // lbCost
            // 
            this.lbCost.AutoSize = true;
            this.lbCost.Location = new System.Drawing.Point(339, 79);
            this.lbCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(89, 20);
            this.lbCost.TabIndex = 11;
            this.lbCost.Text = "Cena [PLN]";
            // 
            // lblRecordId
            // 
            this.lblRecordId.AutoSize = true;
            this.lblRecordId.Location = new System.Drawing.Point(223, 338);
            this.lblRecordId.Name = "lblRecordId";
            this.lblRecordId.Size = new System.Drawing.Size(0, 20);
            this.lblRecordId.TabIndex = 12;
            this.lblRecordId.Visible = false;
            // 
            // AddEditRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 402);
            this.Controls.Add(this.lblRecordId);
            this.Controls.Add(this.lbCost);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTypeOfCar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtReturned);
            this.Controls.Add(this.dtRented);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddEditRentalRecord";
            this.Text = "Add Rental Record";
            this.Load += new System.EventHandler(this.AddEditRentalRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtRented;
        private System.Windows.Forms.DateTimePicker dtReturned;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTypeOfCar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.Label lblRecordId;
    }
}

