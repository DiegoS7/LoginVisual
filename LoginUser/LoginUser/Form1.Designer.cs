namespace LoginUser
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.sistema = new System.Windows.Forms.Label();
            this.uzuario = new System.Windows.Forms.Label();
            this.contrazeña = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.key = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sistema
            // 
            this.sistema.AutoSize = true;
            this.sistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sistema.Location = new System.Drawing.Point(116, 9);
            this.sistema.Name = "sistema";
            this.sistema.Size = new System.Drawing.Size(313, 31);
            this.sistema.TabIndex = 0;
            this.sistema.Text = "Sistema Super Secreto";
            this.sistema.Click += new System.EventHandler(this.Label1_Click);
            // 
            // uzuario
            // 
            this.uzuario.AutoSize = true;
            this.uzuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uzuario.Location = new System.Drawing.Point(12, 85);
            this.uzuario.Name = "uzuario";
            this.uzuario.Size = new System.Drawing.Size(76, 20);
            this.uzuario.TabIndex = 1;
            this.uzuario.Text = "Usuario:";
            // 
            // contrazeña
            // 
            this.contrazeña.AutoSize = true;
            this.contrazeña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrazeña.Location = new System.Drawing.Point(12, 141);
            this.contrazeña.Name = "contrazeña";
            this.contrazeña.Size = new System.Drawing.Size(112, 20);
            this.contrazeña.TabIndex = 2;
            this.contrazeña.Text = "Contraseña: ";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(141, 85);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(268, 20);
            this.user.TabIndex = 3;
            this.user.TextChanged += new System.EventHandler(this.User_TextChanged);
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(141, 141);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(268, 20);
            this.key.TabIndex = 4;
            this.key.TextChanged += new System.EventHandler(this.Keyyy_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(58, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 71);
            this.button1.TabIndex = 5;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(384, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 71);
            this.button2.TabIndex = 6;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(561, 338);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.key);
            this.Controls.Add(this.user);
            this.Controls.Add(this.contrazeña);
            this.Controls.Add(this.uzuario);
            this.Controls.Add(this.sistema);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sistema;
        private System.Windows.Forms.Label uzuario;
        private System.Windows.Forms.Label contrazeña;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

