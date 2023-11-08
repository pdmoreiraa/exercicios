
namespace exercicios
{
    partial class frmex13
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
            this.txta = new System.Windows.Forms.TextBox();
            this.txtno = new System.Windows.Forms.TextBox();
            this.lblno = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtla = new System.Windows.Forms.TextBox();
            this.lblla = new System.Windows.Forms.Label();
            this.txtco = new System.Windows.Forms.TextBox();
            this.lblco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txta
            // 
            this.txta.Enabled = false;
            this.txta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txta.Location = new System.Drawing.Point(581, 88);
            this.txta.Multiline = true;
            this.txta.Name = "txta";
            this.txta.ReadOnly = true;
            this.txta.Size = new System.Drawing.Size(166, 134);
            this.txta.TabIndex = 36;
            // 
            // txtno
            // 
            this.txtno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtno.Location = new System.Drawing.Point(324, 88);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(100, 26);
            this.txtno.TabIndex = 35;
            this.txtno.TextChanged += new System.EventHandler(this.txtno_TextChanged);
            // 
            // lblno
            // 
            this.lblno.AutoSize = true;
            this.lblno.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblno.Location = new System.Drawing.Point(12, 91);
            this.lblno.Name = "lblno";
            this.lblno.Size = new System.Drawing.Size(240, 26);
            this.lblno.TabIndex = 34;
            this.lblno.Text = "Digite o Nome do Cômodo:";
            this.lblno.Click += new System.EventHandler(this.lblnum_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(268, 343);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(100, 45);
            this.btnvoltar.TabIndex = 33;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(388, 343);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(100, 45);
            this.btnlimpar.TabIndex = 32;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(268, 250);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(220, 45);
            this.btncalcular.TabIndex = 31;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtla
            // 
            this.txtla.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtla.Location = new System.Drawing.Point(324, 142);
            this.txtla.Name = "txtla";
            this.txtla.Size = new System.Drawing.Size(100, 26);
            this.txtla.TabIndex = 38;
            this.txtla.TextChanged += new System.EventHandler(this.txtla_TextChanged);
            // 
            // lblla
            // 
            this.lblla.AutoSize = true;
            this.lblla.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblla.Location = new System.Drawing.Point(12, 145);
            this.lblla.Name = "lblla";
            this.lblla.Size = new System.Drawing.Size(252, 26);
            this.lblla.TabIndex = 37;
            this.lblla.Text = "Digite a Largura do Cômodo:";
            // 
            // txtco
            // 
            this.txtco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtco.Location = new System.Drawing.Point(324, 193);
            this.txtco.Name = "txtco";
            this.txtco.Size = new System.Drawing.Size(100, 26);
            this.txtco.TabIndex = 40;
            this.txtco.TextChanged += new System.EventHandler(this.txtco_TextChanged);
            // 
            // lblco
            // 
            this.lblco.AutoSize = true;
            this.lblco.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblco.Location = new System.Drawing.Point(12, 196);
            this.lblco.Name = "lblco";
            this.lblco.Size = new System.Drawing.Size(303, 26);
            this.lblco.TabIndex = 39;
            this.lblco.Text = "Digite o Comprimento do Cômodo:";
            // 
            // frmex13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtco);
            this.Controls.Add(this.lblco);
            this.Controls.Add(this.txtla);
            this.Controls.Add(this.lblla);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.lblno);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Name = "frmex13";
            this.Text = "Cálculo de Área por Cômodos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.Label lblno;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtla;
        private System.Windows.Forms.Label lblla;
        private System.Windows.Forms.TextBox txtco;
        private System.Windows.Forms.Label lblco;
    }
}