namespace ProvaSegundoBi
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
            bt_sevicos = new Button();
            SuspendLayout();
            // 
            // bt_sevicos
            // 
            bt_sevicos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            bt_sevicos.Location = new Point(132, 79);
            bt_sevicos.Name = "bt_sevicos";
            bt_sevicos.Size = new Size(75, 32);
            bt_sevicos.TabIndex = 0;
            bt_sevicos.Text = "Serviços";
            bt_sevicos.UseVisualStyleBackColor = true;
            bt_sevicos.Click += bt_sevicos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 214);
            Controls.Add(bt_sevicos);
            Name = "Form1";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button bt_sevicos;
    }
}