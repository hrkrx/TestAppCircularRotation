namespace WindowsFormsApplication1
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.btCircular = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btCircular
			// 
			this.btCircular.Location = new System.Drawing.Point(71, 107);
			this.btCircular.Name = "btCircular";
			this.btCircular.Size = new System.Drawing.Size(50, 40);
			this.btCircular.TabIndex = 0;
			this.btCircular.Text = "O";
			this.btCircular.UseVisualStyleBackColor = true;
			this.btCircular.Click += new System.EventHandler(this.btCircular_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(595, 398);
			this.Controls.Add(this.btCircular);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btCircular;
	}
}

