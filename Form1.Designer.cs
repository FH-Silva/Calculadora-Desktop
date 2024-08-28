using System;
using System.DirectoryServices.ActiveDirectory;

namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnUm = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            btnZero = new Button();
            btnPonto = new Button();
            btnSoma = new Button();
            btnSubtrai = new Button();
            btnMulti = new Button();
            btnDivide = new Button();
            btnApagar = new Button();
            display = new TextBox();
            btnLimpa = new Button();
            btnSinais = new Button();
            btnResult = new Button();
            btnHist = new Button();
            SuspendLayout();
            // 
            // btnUm
            // 
            btnUm.BackColor = Color.FromArgb(192, 192, 255);
            btnUm.Cursor = Cursors.Hand;
            btnUm.FlatAppearance.BorderColor = Color.Silver;
            btnUm.FlatStyle = FlatStyle.Flat;
            btnUm.Font = new Font("Roboto Light", 12F);
            btnUm.Location = new Point(12, 145);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(75, 41);
            btnUm.TabIndex = 0;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = false;
            btnUm.Click += btnUm_Click;
            // 
            // btnDois
            // 
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.Silver;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Roboto Light", 12F);
            button2.Location = new Point(93, 145);
            button2.Name = "button2";
            button2.Size = new Size(75, 41);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnTres
            // 
            button3.BackColor = Color.FromArgb(192, 192, 255);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.Silver;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Roboto Light", 12F);
            button3.Location = new Point(174, 145);
            button3.Name = "button3";
            button3.Size = new Size(75, 41);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnQuatro
            // 
            button4.BackColor = Color.FromArgb(192, 192, 255);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.Silver;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Roboto Light", 12F);
            button4.Location = new Point(12, 192);
            button4.Name = "button4";
            button4.Size = new Size(75, 41);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btnCinco
            // 
            button5.BackColor = Color.FromArgb(192, 192, 255);
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = Color.Silver;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Roboto Light", 12F);
            button5.Location = new Point(93, 192);
            button5.Name = "button5";
            button5.Size = new Size(75, 41);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            // 
            // btnSeis
            // 
            button6.BackColor = Color.FromArgb(192, 192, 255);
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderColor = Color.Silver;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Roboto Light", 12F);
            button6.Location = new Point(174, 192);
            button6.Name = "button6";
            button6.Size = new Size(75, 41);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            // 
            // btnSete
            // 
            button7.BackColor = Color.FromArgb(192, 192, 255);
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderColor = Color.Silver;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Roboto Light", 12F);
            button7.Location = new Point(12, 239);
            button7.Name = "button7";
            button7.Size = new Size(75, 41);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            // 
            // btnOito
            // 
            button8.BackColor = Color.FromArgb(192, 192, 255);
            button8.Cursor = Cursors.Hand;
            button8.FlatAppearance.BorderColor = Color.Silver;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Roboto Light", 12F);
            button8.Location = new Point(93, 239);
            button8.Name = "button8";
            button8.Size = new Size(75, 41);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            // 
            // btnNove
            // 
            button9.BackColor = Color.FromArgb(192, 192, 255);
            button9.Cursor = Cursors.Hand;
            button9.FlatAppearance.BorderColor = Color.Silver;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Roboto Light", 12F);
            button9.Location = new Point(174, 239);
            button9.Name = "button9";
            button9.Size = new Size(75, 41);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            // 
            // btnZero
            // 
            btnZero.BackColor = Color.FromArgb(192, 192, 255);
            btnZero.Cursor = Cursors.Hand;
            btnZero.FlatAppearance.BorderColor = Color.Silver;
            btnZero.FlatStyle = FlatStyle.Flat;
            btnZero.Font = new Font("Roboto Light", 12F);
            btnZero.Location = new Point(93, 286);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(75, 41);
            btnZero.TabIndex = 10;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += btnZero_Click;
            // 
            // btnPonto
            // 
            btnPonto.BackColor = Color.FromArgb(192, 192, 255);
            btnPonto.Cursor = Cursors.Hand;
            btnPonto.FlatAppearance.BorderColor = Color.Silver;
            btnPonto.FlatStyle = FlatStyle.Flat;
            btnPonto.Font = new Font("Roboto Light", 12F);
            btnPonto.Location = new Point(174, 286);
            btnPonto.Name = "btnPonto";
            btnPonto.Size = new Size(75, 41);
            btnPonto.TabIndex = 11;
            btnPonto.Text = ".";
            btnPonto.UseVisualStyleBackColor = false;
            btnPonto.Click += btnPonto_Click;
            // 
            // btnSoma
            // 
            btnSoma.BackColor = Color.FromArgb(192, 192, 255);
            btnSoma.Cursor = Cursors.Hand;
            btnSoma.FlatAppearance.BorderColor = Color.Silver;
            btnSoma.FlatStyle = FlatStyle.Flat;
            btnSoma.Font = new Font("Roboto Light", 12F);
            btnSoma.Location = new Point(255, 98);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(75, 41);
            btnSoma.TabIndex = 13;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = false;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnSubtrai
            // 
            btnSubtrai.BackColor = Color.FromArgb(192, 192, 255);
            btnSubtrai.Cursor = Cursors.Hand;
            btnSubtrai.FlatAppearance.BorderColor = Color.Silver;
            btnSubtrai.FlatStyle = FlatStyle.Flat;
            btnSubtrai.Font = new Font("Roboto Light", 12F);
            btnSubtrai.Location = new Point(255, 145);
            btnSubtrai.Name = "btnSubtrai";
            btnSubtrai.Size = new Size(75, 41);
            btnSubtrai.TabIndex = 14;
            btnSubtrai.Text = "-";
            btnSubtrai.UseVisualStyleBackColor = false;
            btnSubtrai.Click += btnSubtrai_Click;
            // 
            // btnMulti
            // 
            btnMulti.BackColor = Color.FromArgb(192, 192, 255);
            btnMulti.Cursor = Cursors.Hand;
            btnMulti.FlatAppearance.BorderColor = Color.Silver;
            btnMulti.FlatStyle = FlatStyle.Flat;
            btnMulti.Font = new Font("Roboto Light", 12F);
            btnMulti.Location = new Point(255, 192);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(75, 41);
            btnMulti.TabIndex = 15;
            btnMulti.Text = "*";
            btnMulti.UseVisualStyleBackColor = false;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(192, 192, 255);
            btnDivide.Cursor = Cursors.Hand;
            btnDivide.FlatAppearance.BorderColor = Color.Silver;
            btnDivide.FlatStyle = FlatStyle.Flat;
            btnDivide.Font = new Font("Roboto Light", 12F);
            btnDivide.Location = new Point(255, 239);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(75, 41);
            btnDivide.TabIndex = 16;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.FromArgb(192, 192, 255);
            btnApagar.Cursor = Cursors.Hand;
            btnApagar.FlatAppearance.BorderColor = Color.Silver;
            btnApagar.FlatStyle = FlatStyle.Flat;
            btnApagar.Font = new Font("Roboto Light", 12F);
            btnApagar.Image = (Image)resources.GetObject("btnApagar.Image");
            btnApagar.Location = new Point(174, 98);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(75, 41);
            btnApagar.TabIndex = 17;
            btnApagar.UseVisualStyleBackColor = false;
            btnApagar.Click += btnApagar_Click;
            // 
            // display
            // 
            display.BackColor = SystemColors.ButtonHighlight;
            display.BorderStyle = BorderStyle.FixedSingle;
            display.Enabled = false;
            display.Font = new Font("Roboto Light", 20F);
            display.ForeColor = SystemColors.GrayText;
            display.Location = new Point(12, 12);
            display.Multiline = true;
            display.Name = "display";
            display.PlaceholderText = "0";
            display.ReadOnly = true;
            display.RightToLeft = RightToLeft.No;
            display.Size = new Size(318, 74);
            display.TabIndex = 18;
            display.TextAlign = HorizontalAlignment.Right;
            display.TextChanged += display_TextChanged;
            // 
            // btnLimpa
            // 
            btnLimpa.BackColor = Color.FromArgb(192, 192, 255);
            btnLimpa.Cursor = Cursors.Hand;
            btnLimpa.FlatAppearance.BorderColor = Color.Silver;
            btnLimpa.FlatStyle = FlatStyle.Flat;
            btnLimpa.Font = new Font("Roboto Light", 12F);
            btnLimpa.Location = new Point(93, 98);
            btnLimpa.Name = "btnLimpa";
            btnLimpa.Size = new Size(75, 41);
            btnLimpa.TabIndex = 19;
            btnLimpa.Text = "C";
            btnLimpa.UseVisualStyleBackColor = false;
            btnLimpa.Click += btnLimpa_Click;
            // 
            // btnSinais
            // 
            btnSinais.BackColor = Color.FromArgb(192, 192, 255);
            btnSinais.Cursor = Cursors.Hand;
            btnSinais.FlatAppearance.BorderColor = Color.Silver;
            btnSinais.FlatStyle = FlatStyle.Flat;
            btnSinais.Font = new Font("Roboto Light", 12F);
            btnSinais.Location = new Point(12, 286);
            btnSinais.Name = "btnSinais";
            btnSinais.Size = new Size(75, 41);
            btnSinais.TabIndex = 20;
            btnSinais.Text = "-/+";
            btnSinais.UseVisualStyleBackColor = false;
            btnSinais.Click += btnSinais_Click;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.FromArgb(192, 192, 255);
            btnResult.Cursor = Cursors.Hand;
            btnResult.FlatAppearance.BorderColor = Color.Silver;
            btnResult.FlatStyle = FlatStyle.Flat;
            btnResult.Font = new Font("Roboto Light", 12F);
            btnResult.Location = new Point(255, 286);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(75, 41);
            btnResult.TabIndex = 21;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click;
            // 
            // btnHist
            // 
            btnHist.BackColor = Color.FromArgb(192, 192, 255);
            btnHist.Cursor = Cursors.Hand;
            btnHist.FlatAppearance.BorderColor = Color.Silver;
            btnHist.FlatStyle = FlatStyle.Flat;
            btnHist.Font = new Font("Roboto Light", 12F);
            btnHist.Location = new Point(12, 98);
            btnHist.Name = "btnHist";
            btnHist.Size = new Size(75, 41);
            btnHist.TabIndex = 22;
            btnHist.Text = "Hist";
            btnHist.UseVisualStyleBackColor = false;
            btnHist.Click += btnHist_Click;
            // 
            // Form1
            // 
            AccessibleName = "Calculator";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(342, 343);
            Controls.Add(btnHist);
            Controls.Add(btnResult);
            Controls.Add(btnSinais);
            Controls.Add(btnLimpa);
            Controls.Add(display);
            Controls.Add(btnApagar);
            Controls.Add(btnDivide);
            Controls.Add(btnMulti);
            Controls.Add(btnSubtrai);
            Controls.Add(btnSoma);
            Controls.Add(btnPonto);
            Controls.Add(btnZero);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnUm);
            Font = new Font("Segoe UI", 9F);
            ForeColor = SystemColors.Desktop;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUm;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button btnZero;
        private Button btnPonto;
        private Button btnSoma;
        private Button btnSubtrai;
        private Button btnMulti;
        private Button btnDivide;
        private Button btnApagar;
        private TextBox display;
        private Button btnLimpa;
        private Button btnSinais;
        private Button btnResult;
        private Button btnHist;
    }
}
