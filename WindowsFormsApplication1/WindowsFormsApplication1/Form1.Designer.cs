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
			this.btCircular2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btCircular
			// 
			this.btCircular.Location = new System.Drawing.Point(410, 258);
			this.btCircular.Name = "btCircular";
			this.btCircular.Size = new System.Drawing.Size(50, 40);
			this.btCircular.TabIndex = 0;
			this.btCircular.Text = "O";
			this.btCircular.UseVisualStyleBackColor = true;
			this.btCircular.Click += new System.EventHandler(this.btCircular_Click);
			// 
			// btCircular2
			// 
			this.btCircular2.Location = new System.Drawing.Point(410, 313);
			this.btCircular2.Name = "btCircular2";
			this.btCircular2.Size = new System.Drawing.Size(56, 46);
			this.btCircular2.TabIndex = 1;
			this.btCircular2.Text = "X";
			this.btCircular2.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 346);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 376);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "label2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(595, 398);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btCircular2);
			this.Controls.Add(this.btCircular);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btCircular;
		private System.Windows.Forms.Button btCircular2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

