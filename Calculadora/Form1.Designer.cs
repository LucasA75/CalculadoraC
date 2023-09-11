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
            pantalla = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            sumar = new Button();
            Multiplicar = new Button();
            dividir = new Button();
            restar = new Button();
            Cerrar = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            DeleteAll = new Button();
            resultado = new Label();
            label1 = new Label();
            button5 = new Button();
            btnOperacion = new Button();
            ultimaOperacion = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // pantalla
            // 
            pantalla.BackColor = SystemColors.ControlLightLight;
            pantalla.Location = new Point(36, 22);
            pantalla.Multiline = true;
            pantalla.Name = "pantalla";
            pantalla.ReadOnly = true;
            pantalla.Size = new Size(440, 74);
            pantalla.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(41, 124);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(205, 124);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(364, 124);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(364, 187);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 4;
            button4.Text = "6";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // sumar
            // 
            sumar.Location = new Point(603, 174);
            sumar.Name = "sumar";
            sumar.Size = new Size(137, 34);
            sumar.TabIndex = 5;
            sumar.Text = "Sumar";
            sumar.UseVisualStyleBackColor = true;
            sumar.Click += sumar_Click;
            // 
            // Multiplicar
            // 
            Multiplicar.Location = new Point(603, 279);
            Multiplicar.Name = "Multiplicar";
            Multiplicar.Size = new Size(137, 34);
            Multiplicar.TabIndex = 6;
            Multiplicar.Text = "Multiplicar";
            Multiplicar.UseVisualStyleBackColor = true;
            Multiplicar.Click += Multiplicar_Click;
            // 
            // dividir
            // 
            dividir.Location = new Point(603, 331);
            dividir.Name = "dividir";
            dividir.Size = new Size(137, 34);
            dividir.TabIndex = 7;
            dividir.Text = "Dividir";
            dividir.UseVisualStyleBackColor = true;
            dividir.Click += dividir_Click;
            // 
            // restar
            // 
            restar.Location = new Point(603, 229);
            restar.Name = "restar";
            restar.Size = new Size(137, 34);
            restar.TabIndex = 8;
            restar.Text = "Restar";
            restar.UseVisualStyleBackColor = true;
            restar.Click += restar_Click;
            // 
            // Cerrar
            // 
            Cerrar.Location = new Point(41, 383);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(112, 38);
            Cerrar.TabIndex = 9;
            Cerrar.Text = "Cerrar";
            Cerrar.UseVisualStyleBackColor = true;
            Cerrar.Click += Cerrar_Click;
            // 
            // button10
            // 
            button10.Location = new Point(41, 187);
            button10.Name = "button10";
            button10.Size = new Size(112, 34);
            button10.TabIndex = 10;
            button10.Text = "4";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(41, 246);
            button11.Name = "button11";
            button11.Size = new Size(112, 34);
            button11.TabIndex = 11;
            button11.Text = "7";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(205, 187);
            button12.Name = "button12";
            button12.Size = new Size(112, 34);
            button12.TabIndex = 12;
            button12.Text = "5";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Location = new Point(205, 246);
            button13.Name = "button13";
            button13.Size = new Size(112, 34);
            button13.TabIndex = 13;
            button13.Text = "8";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Location = new Point(364, 246);
            button14.Name = "button14";
            button14.Size = new Size(112, 34);
            button14.TabIndex = 14;
            button14.Text = "9";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.Location = new Point(205, 320);
            button15.Name = "button15";
            button15.Size = new Size(112, 34);
            button15.TabIndex = 15;
            button15.Text = "0";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.Location = new Point(364, 320);
            button16.Name = "button16";
            button16.Size = new Size(112, 34);
            button16.TabIndex = 16;
            button16.Text = "Borrar";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // DeleteAll
            // 
            DeleteAll.Location = new Point(603, 124);
            DeleteAll.Name = "DeleteAll";
            DeleteAll.Size = new Size(137, 34);
            DeleteAll.TabIndex = 17;
            DeleteAll.Text = "Borrar Todo";
            DeleteAll.UseVisualStyleBackColor = true;
            DeleteAll.Click += DeleteAll_Click;
            // 
            // resultado
            // 
            resultado.BorderStyle = BorderStyle.FixedSingle;
            resultado.Location = new Point(644, 70);
            resultado.Name = "resultado";
            resultado.Size = new Size(132, 25);
            resultado.TabIndex = 18;
            resultado.Text = " ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(482, 71);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 19;
            label1.Text = "Resultado : ";
            // 
            // button5
            // 
            button5.Location = new Point(41, 320);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 20;
            button5.Text = ",";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // btnOperacion
            // 
            btnOperacion.Location = new Point(605, 387);
            btnOperacion.Name = "btnOperacion";
            btnOperacion.Size = new Size(135, 34);
            btnOperacion.TabIndex = 21;
            btnOperacion.Text = "=";
            btnOperacion.UseVisualStyleBackColor = true;
            btnOperacion.Click += button6_Click;
            // 
            // ultimaOperacion
            // 
            ultimaOperacion.BorderStyle = BorderStyle.FixedSingle;
            ultimaOperacion.Location = new Point(644, 26);
            ultimaOperacion.Name = "ultimaOperacion";
            ultimaOperacion.Size = new Size(132, 25);
            ultimaOperacion.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(482, 27);
            label2.Name = "label2";
            label2.Size = new Size(161, 25);
            label2.TabIndex = 23;
            label2.Text = "Ultima operación : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(ultimaOperacion);
            Controls.Add(btnOperacion);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(resultado);
            Controls.Add(DeleteAll);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(Cerrar);
            Controls.Add(restar);
            Controls.Add(dividir);
            Controls.Add(Multiplicar);
            Controls.Add(sumar);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pantalla);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox pantalla;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button sumar;
        private Button Multiplicar;
        private Button dividir;
        private Button restar;
        private Button Cerrar;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button DeleteAll;
        private Label resultado;
        private Label label1;
        private Button button5;
        private Button btnOperacion;
        private Label ultimaOperacion;
        private Label label2;
    }
}