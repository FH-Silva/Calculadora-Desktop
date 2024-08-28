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
            btnDois = new Button();
            btnTres = new Button();
            btnQuatro = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnSete = new Button();
            btnOito = new Button();
            btnNove = new Button();
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
            btnDois.BackColor = Color.FromArgb(192, 192, 255);
            btnDois.Cursor = Cursors.Hand;
            btnDois.FlatAppearance.BorderColor = Color.Silver;
            btnDois.FlatStyle = FlatStyle.Flat;
            btnDois.Font = new Font("Roboto Light", 12F);
            btnDois.Location = new Point(93, 145);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(75, 41);
            btnDois.TabIndex = 2;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = false;
            btnDois.Click += btnDois_Click;
            // 
            // btnTres
            // 
            btnTres.BackColor = Color.FromArgb(192, 192, 255);
            btnTres.Cursor = Cursors.Hand;
            btnTres.FlatAppearance.BorderColor = Color.Silver;
            btnTres.FlatStyle = FlatStyle.Flat;
            btnTres.Font = new Font("Roboto Light", 12F);
            btnTres.Location = new Point(174, 145);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(75, 41);
            btnTres.TabIndex = 3;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = false;
            btnTres.Click += btnTres_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.BackColor = Color.FromArgb(192, 192, 255);
            btnQuatro.Cursor = Cursors.Hand;
            btnQuatro.FlatAppearance.BorderColor = Color.Silver;
            btnQuatro.FlatStyle = FlatStyle.Flat;
            btnQuatro.Font = new Font("Roboto Light", 12F);
            btnQuatro.Location = new Point(12, 192);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(75, 41);
            btnQuatro.TabIndex = 4;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = false;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnCinco
            // 
            btnCinco.BackColor = Color.FromArgb(192, 192, 255);
            btnCinco.Cursor = Cursors.Hand;
            btnCinco.FlatAppearance.BorderColor = Color.Silver;
            btnCinco.FlatStyle = FlatStyle.Flat;
            btnCinco.Font = new Font("Roboto Light", 12F);
            btnCinco.Location = new Point(93, 192);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(75, 41);
            btnCinco.TabIndex = 5;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = false;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnSeis
            // 
            btnSeis.BackColor = Color.FromArgb(192, 192, 255);
            btnSeis.Cursor = Cursors.Hand;
            btnSeis.FlatAppearance.BorderColor = Color.Silver;
            btnSeis.FlatStyle = FlatStyle.Flat;
            btnSeis.Font = new Font("Roboto Light", 12F);
            btnSeis.Location = new Point(174, 192);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(75, 41);
            btnSeis.TabIndex = 6;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = false;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnSete
            // 
            btnSete.BackColor = Color.FromArgb(192, 192, 255);
            btnSete.Cursor = Cursors.Hand;
            btnSete.FlatAppearance.BorderColor = Color.Silver;
            btnSete.FlatStyle = FlatStyle.Flat;
            btnSete.Font = new Font("Roboto Light", 12F);
            btnSete.Location = new Point(12, 239);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(75, 41);
            btnSete.TabIndex = 7;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = false;
            btnSete.Click += btnSete_Click_1;
            // 
            // btnOito
            // 
            btnOito.BackColor = Color.FromArgb(192, 192, 255);
            btnOito.Cursor = Cursors.Hand;
            btnOito.FlatAppearance.BorderColor = Color.Silver;
            btnOito.FlatStyle = FlatStyle.Flat;
            btnOito.Font = new Font("Roboto Light", 12F);
            btnOito.Location = new Point(93, 239);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(75, 41);
            btnOito.TabIndex = 8;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = false;
            btnOito.Click += btnOito_Click;
            // 
            // btnNove
            // 
            btnNove.BackColor = Color.FromArgb(192, 192, 255);
            btnNove.Cursor = Cursors.Hand;
            btnNove.FlatAppearance.BorderColor = Color.Silver;
            btnNove.FlatStyle = FlatStyle.Flat;
            btnNove.Font = new Font("Roboto Light", 12F);
            btnNove.Location = new Point(174, 239);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(75, 41);
            btnNove.TabIndex = 9;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = false;
            btnNove.Click += btnNove_Click;
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
            btnPonto.Font = new Font("Roboto Light", 20F);
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
            btnSoma.BackColor = Color.FromArgb(128, 128, 255);
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
            btnSubtrai.BackColor = Color.FromArgb(128, 128, 255);
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
            btnMulti.BackColor = Color.FromArgb(128, 128, 255);
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
            btnDivide.BackColor = Color.FromArgb(128, 128, 255);
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
            display.MaxLength = 30;
            display.Multiline = true;
            display.Name = "display";
            display.PlaceholderText = "00";
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
            btnResult.BackColor = Color.FromArgb(128, 128, 255);
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
            Controls.Add(btnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnQuatro);
            Controls.Add(btnTres);
            Controls.Add(btnDois);
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

        private void BtnSete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnUm;
        private Button btnDois;
        private Button btnTres;
        private Button btnQuatro;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnSete;
        private Button btnOito;
        private Button btnNove;
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
