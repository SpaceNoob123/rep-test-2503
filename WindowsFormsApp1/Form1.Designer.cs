using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
            this.BackColor = Color.Yellow;
            this.Size = new Size(600, 625);
            this.Location = new Point(500, 500);
            btnred = new Button();
            btnred.Text = "Red";
            btnred.ForeColor = Color.Green;
            btnred.Size = new Size(90, 100);
            btnred.Location = new Point(0, 250);
            btnred.BackColor = Color.Aquamarine;
            btnred.Font = new Font("Times New Roman", 13, FontStyle.Bold | FontStyle.Italic);
            btnred.Click += (e, sender) =>
            {
                this.BackColor = Color.Red;
                btnred.Visible = true;
            };

            btngreen = new Button();
            btngreen.Text = "Green";
            btngreen.ForeColor = Color.Green;
            btngreen.Size = new Size(90, 100);
            btngreen.Location = new Point(500, 250);
            btngreen.BackColor = Color.Aquamarine;
            btngreen.Font = new Font("Times New Roman", 13, FontStyle.Bold | FontStyle.Italic);
            btngreen.Click += (e, sender) =>
            {
                this.BackColor = Color.Green;
                btngreen.Visible = true;
            };
            btnblue = new Button();
            btnblue.Text = "Blue";
            btnblue.ForeColor = Color.Green;
            btnblue.Size = new Size(90, 100);
            btnblue.Location = new Point(260, 250);
            btnblue.BackColor = Color.Aquamarine;
            btnblue.Font = new Font("Times New Roman", 13, FontStyle.Bold | FontStyle.Italic);
            btnblue.Click += (e, sender) =>
            {
                this.BackColor = Color.Blue;
                btngreen.Visible = true;
            };

            this.Controls.Add(btnred);
            this.Controls.Add(btngreen);
            this.Controls.Add(btnblue);
        }
        Button btnred;
        Button btngreen;
        Button btnblue;

        #endregion
    }
}

