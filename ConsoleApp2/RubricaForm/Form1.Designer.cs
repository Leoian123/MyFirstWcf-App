
namespace RubricaForm
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSaveSubscribeForm = new System.Windows.Forms.Button();
            this.PanelSubscribe = new System.Windows.Forms.Panel();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TxtTitleRubrica = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.NumberphoneLabel = new System.Windows.Forms.Label();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtNumberPhone = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BirthdayDatePicker = new System.Windows.Forms.DateTimePicker();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.cbxRubrica = new System.Windows.Forms.ComboBox();
            this.PanelSubscribe.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSaveSubscribeForm
            // 
            this.BtnSaveSubscribeForm.Location = new System.Drawing.Point(421, 71);
            this.BtnSaveSubscribeForm.Name = "BtnSaveSubscribeForm";
            this.BtnSaveSubscribeForm.Size = new System.Drawing.Size(75, 23);
            this.BtnSaveSubscribeForm.TabIndex = 1;
            this.BtnSaveSubscribeForm.Text = "Subscribe";
            this.BtnSaveSubscribeForm.UseVisualStyleBackColor = true;
            this.BtnSaveSubscribeForm.Click += new System.EventHandler(this.BtnSaveSubscribeForm_Click);
            // 
            // PanelSubscribe
            // 
            this.PanelSubscribe.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.PanelSubscribe.Controls.Add(this.BirthdayLabel);
            this.PanelSubscribe.Controls.Add(this.BirthdayDatePicker);
            this.PanelSubscribe.Controls.Add(this.BtnUpdate);
            this.PanelSubscribe.Controls.Add(this.TxtNumberPhone);
            this.PanelSubscribe.Controls.Add(this.TxtLastName);
            this.PanelSubscribe.Controls.Add(this.BtnSaveSubscribeForm);
            this.PanelSubscribe.Controls.Add(this.NumberphoneLabel);
            this.PanelSubscribe.Controls.Add(this.LastNameLabel);
            this.PanelSubscribe.Controls.Add(this.NameLabel);
            this.PanelSubscribe.Controls.Add(this.TxtName);
            this.PanelSubscribe.Location = new System.Drawing.Point(11, 223);
            this.PanelSubscribe.Name = "PanelSubscribe";
            this.PanelSubscribe.Size = new System.Drawing.Size(501, 99);
            this.PanelSubscribe.TabIndex = 2;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(126, 3);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AllowDrop = true;
            this.NameLabel.Location = new System.Drawing.Point(3, 6);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(117, 23);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Nome";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtTitleRubrica
            // 
            this.TxtTitleRubrica.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitleRubrica.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TxtTitleRubrica.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.TxtTitleRubrica.Location = new System.Drawing.Point(24, 9);
            this.TxtTitleRubrica.Name = "TxtTitleRubrica";
            this.TxtTitleRubrica.Size = new System.Drawing.Size(764, 65);
            this.TxtTitleRubrica.TabIndex = 3;
            this.TxtTitleRubrica.Text = "Rubrica Contatti";
            this.TxtTitleRubrica.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Location = new System.Drawing.Point(3, 29);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(88, 17);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "LastName";
            this.LastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NumberphoneLabel
            // 
            this.NumberphoneLabel.Location = new System.Drawing.Point(3, 48);
            this.NumberphoneLabel.Name = "NumberphoneLabel";
            this.NumberphoneLabel.Size = new System.Drawing.Size(88, 20);
            this.NumberphoneLabel.TabIndex = 3;
            this.NumberphoneLabel.Text = "NumberPhone";
            this.NumberphoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(126, 26);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(100, 20);
            this.TxtLastName.TabIndex = 4;
            // 
            // TxtNumberPhone
            // 
            this.TxtNumberPhone.Location = new System.Drawing.Point(126, 48);
            this.TxtNumberPhone.Name = "TxtNumberPhone";
            this.TxtNumberPhone.Size = new System.Drawing.Size(100, 20);
            this.TxtNumberPhone.TabIndex = 5;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(3, 71);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 6;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // BirthdayDatePicker
            // 
            this.BirthdayDatePicker.Location = new System.Drawing.Point(232, 3);
            this.BirthdayDatePicker.Name = "BirthdayDatePicker";
            this.BirthdayDatePicker.Size = new System.Drawing.Size(180, 20);
            this.BirthdayDatePicker.TabIndex = 4;
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.Location = new System.Drawing.Point(232, 26);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(180, 20);
            this.BirthdayLabel.TabIndex = 7;
            this.BirthdayLabel.Text = "Inserire la Data di Nascita";
            this.BirthdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxRubrica
            // 
            this.cbxRubrica.FormattingEnabled = true;
            this.cbxRubrica.Location = new System.Drawing.Point(11, 77);
            this.cbxRubrica.Name = "cbxRubrica";
            this.cbxRubrica.Size = new System.Drawing.Size(502, 21);
            this.cbxRubrica.TabIndex = 5;
            this.cbxRubrica.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxRubrica);
            this.Controls.Add(this.TxtTitleRubrica);
            this.Controls.Add(this.PanelSubscribe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelSubscribe.ResumeLayout(false);
            this.PanelSubscribe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnSaveSubscribeForm;
        private System.Windows.Forms.Panel PanelSubscribe;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label TxtTitleRubrica;
        private System.Windows.Forms.TextBox TxtNumberPhone;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label NumberphoneLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.DateTimePicker BirthdayDatePicker;
        private System.Windows.Forms.ComboBox cbxRubrica;
    }
}

