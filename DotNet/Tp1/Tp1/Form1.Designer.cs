namespace Tp1
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
            ok = new Button();
            remis = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            res = new TextBox();
            zoneb = new TextBox();
            zonea = new TextBox();
            label = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ok
            // 
            ok.Font = new Font("Segoe UI", 12F);
            ok.Location = new Point(458, 388);
            ok.Name = "ok";
            ok.Size = new Size(169, 40);
            ok.TabIndex = 0;
            ok.Text = "ok";
            ok.UseVisualStyleBackColor = true;
            ok.Click += button1_Click;
            // 
            // remis
            // 
            remis.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            remis.Location = new Point(115, 388);
            remis.Name = "remis";
            remis.Size = new Size(216, 40);
            remis.TabIndex = 1;
            remis.Text = "Remise a blanc";
            remis.UseVisualStyleBackColor = true;
            remis.Click += remis_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(res);
            groupBox1.Controls.Add(zoneb);
            groupBox1.Controls.Add(zonea);
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(ok);
            groupBox1.Controls.Add(remis);
            groupBox1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(42, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(681, 461);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "TP1 n1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(61, 298);
            label3.Name = "label3";
            label3.Size = new Size(123, 41);
            label3.TabIndex = 8;
            label3.Text = "Resultat";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(71, 226);
            label2.Name = "label2";
            label2.Size = new Size(111, 41);
            label2.TabIndex = 7;
            label2.Text = "Zone B";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 155);
            label1.Name = "label1";
            label1.Size = new Size(113, 41);
            label1.TabIndex = 6;
            label1.Text = "Zone A";
            label1.Click += label1_Click_1;
            // 
            // res
            // 
            res.BorderStyle = BorderStyle.FixedSingle;
            res.Location = new Point(187, 299);
            res.Name = "res";
            res.Size = new Size(370, 47);
            res.TabIndex = 5;
            res.TextChanged += res_TextChanged;
            // 
            // zoneb
            // 
            zoneb.BorderStyle = BorderStyle.FixedSingle;
            zoneb.Location = new Point(187, 227);
            zoneb.Name = "zoneb";
            zoneb.Size = new Size(370, 47);
            zoneb.TabIndex = 4;
            zoneb.TextChanged += zoneb_TextChanged;
            // 
            // zonea
            // 
            zonea.BackColor = SystemColors.Window;
            zonea.BorderStyle = BorderStyle.FixedSingle;
            zonea.Location = new Point(187, 156);
            zonea.Name = "zonea";
            zonea.Size = new Size(370, 47);
            zonea.TabIndex = 3;
            zonea.TextChanged += zonea_TextChanged;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Algerian", 18F, FontStyle.Bold);
            label.ForeColor = Color.Blue;
            label.Location = new Point(187, 65);
            label.Name = "label";
            label.Size = new Size(370, 40);
            label.TabIndex = 2;
            label.Text = "LA CONCATENATION";
            label.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 539);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button ok;
        private Button remis;
        private GroupBox groupBox1;
        private Label label;
        private TextBox zoneb;
        private TextBox zonea;
        private TextBox res;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
