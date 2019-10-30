namespace Cash
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
            this.girisBox = new System.Windows.Forms.GroupBox();
            this.girisButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.girisSifreText = new System.Windows.Forms.TextBox();
            this.girisIsimText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.katılUrlText = new System.Windows.Forms.TextBox();
            this.katılButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.katılSifreText = new System.Windows.Forms.TextBox();
            this.katılIsimText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.girisBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // girisBox
            // 
            this.girisBox.Controls.Add(this.girisButton);
            this.girisBox.Controls.Add(this.label2);
            this.girisBox.Controls.Add(this.label1);
            this.girisBox.Controls.Add(this.girisSifreText);
            this.girisBox.Controls.Add(this.girisIsimText);
            this.girisBox.Location = new System.Drawing.Point(12, 12);
            this.girisBox.Name = "girisBox";
            this.girisBox.Size = new System.Drawing.Size(314, 238);
            this.girisBox.TabIndex = 0;
            this.girisBox.TabStop = false;
            this.girisBox.Text = "Giriş Kapısı";
            // 
            // girisButton
            // 
            this.girisButton.Font = new System.Drawing.Font("Andalus", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisButton.Location = new System.Drawing.Point(207, 135);
            this.girisButton.Name = "girisButton";
            this.girisButton.Size = new System.Drawing.Size(101, 43);
            this.girisButton.TabIndex = 4;
            this.girisButton.Text = "Giriş";
            this.girisButton.UseVisualStyleBackColor = true;
            this.girisButton.Click += new System.EventHandler(this.girisButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Andalus", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Andalus", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "İsim";
            // 
            // girisSifreText
            // 
            this.girisSifreText.Location = new System.Drawing.Point(6, 109);
            this.girisSifreText.MaxLength = 10;
            this.girisSifreText.Name = "girisSifreText";
            this.girisSifreText.PasswordChar = '*';
            this.girisSifreText.Size = new System.Drawing.Size(302, 20);
            this.girisSifreText.TabIndex = 1;
            // 
            // girisIsimText
            // 
            this.girisIsimText.Location = new System.Drawing.Point(6, 51);
            this.girisIsimText.Name = "girisIsimText";
            this.girisIsimText.Size = new System.Drawing.Size(302, 20);
            this.girisIsimText.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.katılUrlText);
            this.groupBox2.Controls.Add(this.katılButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.katılSifreText);
            this.groupBox2.Controls.Add(this.katılIsimText);
            this.groupBox2.Location = new System.Drawing.Point(358, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 407);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aramıza Katıl";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Andalus", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(6, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(302, 50);
            this.label9.TabIndex = 17;
            this.label9.Text = "3) Url\'niz örnek olarak \"http://link.tl/aBAb\" olsun, URL kısmına yazmanız gereken" +
    " \"aBAb\" dir.";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Andalus", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(302, 39);
            this.label8.TabIndex = 16;
            this.label8.Text = "2) Url sadece link.tl url\'si olmalıdır. Diğer siteler şimdilik kabul edilmemekted" +
    "ir.";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Andalus", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(302, 33);
            this.label7.TabIndex = 15;
            this.label7.Text = "1) İsim ve şifre en az 3 en fazla 10 karakter, url en az 2 en fazla 6 karakter ol" +
    "malıdır.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Andalus", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "OKUYUNUZ;";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Andalus", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "URL (sadece link.tl olduğunu unutma!!)";
            // 
            // katılUrlText
            // 
            this.katılUrlText.Location = new System.Drawing.Point(6, 167);
            this.katılUrlText.Name = "katılUrlText";
            this.katılUrlText.Size = new System.Drawing.Size(302, 20);
            this.katılUrlText.TabIndex = 11;
            // 
            // katılButton
            // 
            this.katılButton.Font = new System.Drawing.Font("Andalus", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.katılButton.Location = new System.Drawing.Point(207, 189);
            this.katılButton.Name = "katılButton";
            this.katılButton.Size = new System.Drawing.Size(101, 43);
            this.katılButton.TabIndex = 9;
            this.katılButton.Text = "Katıl";
            this.katılButton.UseVisualStyleBackColor = true;
            this.katılButton.Click += new System.EventHandler(this.katılButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Andalus", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Andalus", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "İsim";
            // 
            // katılSifreText
            // 
            this.katılSifreText.Location = new System.Drawing.Point(6, 109);
            this.katılSifreText.MaxLength = 10;
            this.katılSifreText.Name = "katılSifreText";
            this.katılSifreText.PasswordChar = '*';
            this.katılSifreText.Size = new System.Drawing.Size(302, 20);
            this.katılSifreText.TabIndex = 6;
            // 
            // katılIsimText
            // 
            this.katılIsimText.Location = new System.Drawing.Point(6, 51);
            this.katılIsimText.Name = "katılIsimText";
            this.katılIsimText.Size = new System.Drawing.Size(302, 20);
            this.katılIsimText.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(12, 406);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "248817";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "twitter.com/cashAppOfficial";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 280);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(239, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "facebook.com/profile.php?id=100012684049772";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 423);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.girisBox);
            this.Name = "Form1";
            this.Text = "Cash";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.girisBox.ResumeLayout(false);
            this.girisBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox girisBox;
        private System.Windows.Forms.Button girisButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox girisSifreText;
        private System.Windows.Forms.TextBox girisIsimText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox katılUrlText;
        private System.Windows.Forms.Button katılButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox katılSifreText;
        private System.Windows.Forms.TextBox katılIsimText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

