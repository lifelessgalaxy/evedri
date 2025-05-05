namespace Info
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
            this.lblNameDisplay = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblGenderDisplay = new System.Windows.Forms.Label();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.lblHobbyDisplay = new System.Windows.Forms.Label();
            this.chkBasketball = new System.Windows.Forms.CheckBox();
            this.chkVolleyBall = new System.Windows.Forms.CheckBox();
            this.chkSoccer = new System.Windows.Forms.CheckBox();
            this.lblFavorateColor = new System.Windows.Forms.Label();
            this.cmbFavoriteColor = new System.Windows.Forms.ComboBox();
            this.lblSaying = new System.Windows.Forms.Label();
            this.txtSaying = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNameDisplay
            // 
            this.lblNameDisplay.AutoSize = true;
            this.lblNameDisplay.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameDisplay.Location = new System.Drawing.Point(47, 23);
            this.lblNameDisplay.Name = "lblNameDisplay";
            this.lblNameDisplay.Size = new System.Drawing.Size(55, 21);
            this.lblNameDisplay.TabIndex = 0;
            this.lblNameDisplay.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(123, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblGenderDisplay
            // 
            this.lblGenderDisplay.AutoSize = true;
            this.lblGenderDisplay.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblGenderDisplay.Location = new System.Drawing.Point(39, 74);
            this.lblGenderDisplay.Name = "lblGenderDisplay";
            this.lblGenderDisplay.Size = new System.Drawing.Size(67, 21);
            this.lblGenderDisplay.TabIndex = 2;
            this.lblGenderDisplay.Text = "Gender:";
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMale.Location = new System.Drawing.Point(127, 77);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(57, 21);
            this.radMale.TabIndex = 3;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFemale.Location = new System.Drawing.Point(201, 77);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(70, 21);
            this.radFemale.TabIndex = 4;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // lblHobbyDisplay
            // 
            this.lblHobbyDisplay.AutoSize = true;
            this.lblHobbyDisplay.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblHobbyDisplay.Location = new System.Drawing.Point(40, 141);
            this.lblHobbyDisplay.Name = "lblHobbyDisplay";
            this.lblHobbyDisplay.Size = new System.Drawing.Size(62, 21);
            this.lblHobbyDisplay.TabIndex = 5;
            this.lblHobbyDisplay.Text = "Hobby:";
            // 
            // chkBasketball
            // 
            this.chkBasketball.AutoSize = true;
            this.chkBasketball.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBasketball.Location = new System.Drawing.Point(123, 145);
            this.chkBasketball.Name = "chkBasketball";
            this.chkBasketball.Size = new System.Drawing.Size(79, 19);
            this.chkBasketball.TabIndex = 6;
            this.chkBasketball.Text = "BasketBall";
            this.chkBasketball.UseVisualStyleBackColor = true;
            // 
            // chkVolleyBall
            // 
            this.chkVolleyBall.AutoSize = true;
            this.chkVolleyBall.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVolleyBall.Location = new System.Drawing.Point(123, 173);
            this.chkVolleyBall.Name = "chkVolleyBall";
            this.chkVolleyBall.Size = new System.Drawing.Size(78, 19);
            this.chkVolleyBall.TabIndex = 7;
            this.chkVolleyBall.Text = "VolleyBall";
            this.chkVolleyBall.UseVisualStyleBackColor = true;
            // 
            // chkSoccer
            // 
            this.chkSoccer.AutoSize = true;
            this.chkSoccer.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSoccer.Location = new System.Drawing.Point(123, 201);
            this.chkSoccer.Name = "chkSoccer";
            this.chkSoccer.Size = new System.Drawing.Size(61, 19);
            this.chkSoccer.TabIndex = 8;
            this.chkSoccer.Text = "Soccer";
            this.chkSoccer.UseVisualStyleBackColor = true;
            // 
            // lblFavorateColor
            // 
            this.lblFavorateColor.AutoSize = true;
            this.lblFavorateColor.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblFavorateColor.Location = new System.Drawing.Point(39, 248);
            this.lblFavorateColor.Name = "lblFavorateColor";
            this.lblFavorateColor.Size = new System.Drawing.Size(115, 21);
            this.lblFavorateColor.TabIndex = 9;
            this.lblFavorateColor.Text = "Favorite Color:";
            // 
            // cmbFavoriteColor
            // 
            this.cmbFavoriteColor.CausesValidation = false;
            this.cmbFavoriteColor.FormattingEnabled = true;
            this.cmbFavoriteColor.Items.AddRange(new object[] {
            "Red",
            "Black",
            "Yellow",
            "Green",
            "Blue",
            "White",
            "Pink",
            "Orange",
            "Purple"});
            this.cmbFavoriteColor.Location = new System.Drawing.Point(160, 250);
            this.cmbFavoriteColor.Name = "cmbFavoriteColor";
            this.cmbFavoriteColor.Size = new System.Drawing.Size(121, 21);
            this.cmbFavoriteColor.TabIndex = 10;
            // 
            // lblSaying
            // 
            this.lblSaying.AutoSize = true;
            this.lblSaying.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblSaying.Location = new System.Drawing.Point(33, 285);
            this.lblSaying.Name = "lblSaying";
            this.lblSaying.Size = new System.Drawing.Size(63, 21);
            this.lblSaying.TabIndex = 11;
            this.lblSaying.Text = "Saying:";
            // 
            // txtSaying
            // 
            this.txtSaying.Location = new System.Drawing.Point(101, 287);
            this.txtSaying.Multiline = true;
            this.txtSaying.Name = "txtSaying";
            this.txtSaying.Size = new System.Drawing.Size(196, 81);
            this.txtSaying.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(91, 387);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 35);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(216, 387);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(80, 35);
            this.btnDisplay.TabIndex = 14;
            this.btnDisplay.Text = "DISPLAY";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(143, 387);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 35);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(-3, 435);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 21);
            this.lblID.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(345, 474);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSaying);
            this.Controls.Add(this.lblSaying);
            this.Controls.Add(this.cmbFavoriteColor);
            this.Controls.Add(this.lblFavorateColor);
            this.Controls.Add(this.chkSoccer);
            this.Controls.Add(this.chkVolleyBall);
            this.Controls.Add(this.chkBasketball);
            this.Controls.Add(this.lblHobbyDisplay);
            this.Controls.Add(this.radFemale);
            this.Controls.Add(this.radMale);
            this.Controls.Add(this.lblGenderDisplay);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblNameDisplay);
            this.Name = "Form1";
            this.Text = "INFORMATION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameDisplay;
        private System.Windows.Forms.Label lblGenderDisplay;
        private System.Windows.Forms.Label lblHobbyDisplay;
        private System.Windows.Forms.Label lblFavorateColor;
        private System.Windows.Forms.Label lblSaying;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.RadioButton radMale;
        public System.Windows.Forms.RadioButton radFemale;
        public System.Windows.Forms.CheckBox chkBasketball;
        public System.Windows.Forms.CheckBox chkVolleyBall;
        public System.Windows.Forms.CheckBox chkSoccer;
        public System.Windows.Forms.ComboBox cmbFavoriteColor;
        public System.Windows.Forms.TextBox txtSaying;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Button btnDisplay;
    }
}

