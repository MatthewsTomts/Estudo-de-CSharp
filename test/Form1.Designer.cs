namespace test
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_adicionar = new Button();
            txt_nome = new TextBox();
            txt_idade = new TextBox();
            txt_curso = new TextBox();
            panel1 = new Panel();
            label5 = new Label();
            lv_alunos = new ListView();
            Nome = new ColumnHeader();
            Idade = new ColumnHeader();
            Curso = new ColumnHeader();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(107, 32);
            label1.Name = "label1";
            label1.Size = new Size(118, 30);
            label1.TabIndex = 0;
            label1.Text = "Formulário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 108);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(27, 288);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 2;
            label3.Text = "Curso:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(27, 198);
            label4.Name = "label4";
            label4.Size = new Size(51, 21);
            label4.TabIndex = 3;
            label4.Text = "Idade:";
            label4.Click += label4_Click;
            // 
            // btn_adicionar
            // 
            btn_adicionar.Location = new Point(116, 382);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(84, 25);
            btn_adicionar.TabIndex = 4;
            btn_adicionar.Text = "Adicionar";
            btn_adicionar.UseVisualStyleBackColor = true;
            btn_adicionar.Click += button1_Click;
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(30, 132);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(266, 23);
            txt_nome.TabIndex = 5;
            // 
            // txt_idade
            // 
            txt_idade.Location = new Point(30, 222);
            txt_idade.Name = "txt_idade";
            txt_idade.Size = new Size(266, 23);
            txt_idade.TabIndex = 6;
            txt_idade.TextChanged += textBox2_TextChanged;
            // 
            // txt_curso
            // 
            txt_curso.Location = new Point(30, 312);
            txt_curso.Name = "txt_curso";
            txt_curso.Size = new Size(266, 23);
            txt_curso.TabIndex = 7;
            txt_curso.TextChanged += textBox3_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lv_alunos);
            panel1.Location = new Point(361, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 454);
            panel1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(121, 32);
            label5.Name = "label5";
            label5.Size = new Size(157, 30);
            label5.TabIndex = 9;
            label5.Text = "Lista de Alunos";
            // 
            // lv_alunos
            // 
            lv_alunos.Columns.AddRange(new ColumnHeader[] { Nome, Idade, Curso });
            lv_alunos.Location = new Point(12, 104);
            lv_alunos.Name = "lv_alunos";
            lv_alunos.Size = new Size(419, 335);
            lv_alunos.TabIndex = 0;
            lv_alunos.UseCompatibleStateImageBehavior = false;
            lv_alunos.View = View.Details;
            // 
            // Nome
            // 
            Nome.Text = "Nome";
            Nome.Width = 120;
            // 
            // Idade
            // 
            Idade.Text = "Idade";
            // 
            // Curso
            // 
            Curso.Text = "Curso";
            Curso.Width = 160;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(txt_curso);
            Controls.Add(txt_idade);
            Controls.Add(txt_nome);
            Controls.Add(btn_adicionar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_adicionar;
        private TextBox txt_nome;
        private TextBox txt_idade;
        private TextBox txt_curso;
        private Panel panel1;
        private Label label5;
        private ListView lv_alunos;
        private ColumnHeader Nome;
        private ColumnHeader Idade;
        private ColumnHeader Curso;
    }
}