namespace ProvaSegundoBi
{
    partial class Servicos
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
            lb_computador = new Label();
            tx_computador = new TextBox();
            lb_cliente = new Label();
            tx_cliente = new TextBox();
            lb_servicos = new Label();
            lb_pag = new Label();
            lb_valorFinal = new Label();
            bt_salvar = new Button();
            bt_cancelar = new Button();
            cb_servicos = new ComboBox();
            cb_pag = new ComboBox();
            SuspendLayout();
            // 
            // lb_computador
            // 
            lb_computador.AutoSize = true;
            lb_computador.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb_computador.Location = new Point(89, 24);
            lb_computador.Name = "lb_computador";
            lb_computador.Size = new Size(85, 17);
            lb_computador.TabIndex = 0;
            lb_computador.Text = "Computador:";
            lb_computador.Click += label1_Click;
            // 
            // tx_computador
            // 
            tx_computador.Location = new Point(180, 23);
            tx_computador.Name = "tx_computador";
            tx_computador.Size = new Size(199, 23);
            tx_computador.TabIndex = 1;
            // 
            // lb_cliente
            // 
            lb_cliente.AutoSize = true;
            lb_cliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb_cliente.Location = new Point(124, 58);
            lb_cliente.Name = "lb_cliente";
            lb_cliente.Size = new Size(50, 17);
            lb_cliente.TabIndex = 2;
            lb_cliente.Text = "Cliente:";
            // 
            // tx_cliente
            // 
            tx_cliente.Location = new Point(180, 58);
            tx_cliente.Name = "tx_cliente";
            tx_cliente.Size = new Size(199, 23);
            tx_cliente.TabIndex = 3;
            // 
            // lb_servicos
            // 
            lb_servicos.AutoSize = true;
            lb_servicos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb_servicos.Location = new Point(115, 93);
            lb_servicos.Name = "lb_servicos";
            lb_servicos.Size = new Size(59, 17);
            lb_servicos.TabIndex = 4;
            lb_servicos.Text = "Serviços:";
            // 
            // lb_pag
            // 
            lb_pag.AutoSize = true;
            lb_pag.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb_pag.Location = new Point(48, 130);
            lb_pag.Name = "lb_pag";
            lb_pag.Size = new Size(126, 17);
            lb_pag.TabIndex = 6;
            lb_pag.Text = "Tipo de Pagamento:";
            // 
            // lb_valorFinal
            // 
            lb_valorFinal.AutoSize = true;
            lb_valorFinal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb_valorFinal.Location = new Point(103, 185);
            lb_valorFinal.Name = "lb_valorFinal";
            lb_valorFinal.Size = new Size(71, 17);
            lb_valorFinal.TabIndex = 8;
            lb_valorFinal.Text = "Valor Final:";
            // 
            // bt_salvar
            // 
            bt_salvar.Location = new Point(99, 245);
            bt_salvar.Name = "bt_salvar";
            bt_salvar.Size = new Size(75, 23);
            bt_salvar.TabIndex = 9;
            bt_salvar.Text = "Salvar";
            bt_salvar.UseVisualStyleBackColor = true;
            // 
            // bt_cancelar
            // 
            bt_cancelar.Location = new Point(275, 245);
            bt_cancelar.Name = "bt_cancelar";
            bt_cancelar.Size = new Size(75, 23);
            bt_cancelar.TabIndex = 10;
            bt_cancelar.Text = "Cancelar";
            bt_cancelar.UseVisualStyleBackColor = true;
            // 
            // cb_servicos
            // 
            cb_servicos.FormattingEnabled = true;
            cb_servicos.Items.AddRange(new object[] { "Formatação R$100", "Limpeza R$ 50", "Troca de peça R$ 200" });
            cb_servicos.Location = new Point(180, 92);
            cb_servicos.Name = "cb_servicos";
            cb_servicos.Size = new Size(199, 23);
            cb_servicos.TabIndex = 11;
            // 
            // cb_pag
            // 
            cb_pag.FormattingEnabled = true;
            cb_pag.Items.AddRange(new object[] { "Dinherio com 20% de desconto ", "Pix com 10% de desconto", "Cartão sem desconto" });
            cb_pag.Location = new Point(180, 129);
            cb_pag.Name = "cb_pag";
            cb_pag.Size = new Size(199, 23);
            cb_pag.TabIndex = 12;
            cb_pag.SelectedIndexChanged += cb_pag_SelectedIndexChanged;
            // 
            // Servicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cb_pag);
            Controls.Add(cb_servicos);
            Controls.Add(bt_cancelar);
            Controls.Add(bt_salvar);
            Controls.Add(lb_valorFinal);
            Controls.Add(lb_pag);
            Controls.Add(lb_servicos);
            Controls.Add(tx_cliente);
            Controls.Add(lb_cliente);
            Controls.Add(tx_computador);
            Controls.Add(lb_computador);
            Name = "Servicos";
            Text = "Servicos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_computador;
        private TextBox tx_computador;
        private Label lb_cliente;
        private TextBox tx_cliente;
        private Label lb_servicos;
        private Label lb_pag;
        private Label lb_valorFinal;
        private Button bt_salvar;
        private Button bt_cancelar;
        private ComboBox cb_servicos;
        private ComboBox cb_pag;
    }
}