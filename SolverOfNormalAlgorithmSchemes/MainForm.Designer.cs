namespace SolverOfNormalAlgorithmSchemes
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.word = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.scheme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.stages = new System.Windows.Forms.TextBox();
            this.example1 = new System.Windows.Forms.LinkLabel();
            this.example2 = new System.Windows.Forms.LinkLabel();
            this.example3 = new System.Windows.Forms.LinkLabel();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.label4 = new System.Windows.Forms.Label();
            this.example4 = new System.Windows.Forms.LinkLabel();
            this.example5 = new System.Windows.Forms.LinkLabel();
            this.example6 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word:";
            // 
            // word
            // 
            this.word.Location = new System.Drawing.Point(10, 27);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(184, 23);
            this.word.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Scheme:";
            // 
            // scheme
            // 
            this.scheme.Location = new System.Drawing.Point(10, 71);
            this.scheme.Multiline = true;
            this.scheme.Name = "scheme";
            this.scheme.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.scheme.Size = new System.Drawing.Size(184, 126);
            this.scheme.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Result:";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(10, 225);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(184, 23);
            this.result.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Apply scheme algorithms";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ApplyScheme);
            // 
            // stages
            // 
            this.stages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stages.Location = new System.Drawing.Point(211, 27);
            this.stages.Multiline = true;
            this.stages.Name = "stages";
            this.stages.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.stages.Size = new System.Drawing.Size(420, 522);
            this.stages.TabIndex = 7;
            this.stages.WordWrap = false;
            // 
            // example1
            // 
            this.example1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.example1.AutoSize = true;
            this.example1.Location = new System.Drawing.Point(637, 27);
            this.example1.Margin = new System.Windows.Forms.Padding(3);
            this.example1.Name = "example1";
            this.example1.Size = new System.Drawing.Size(140, 30);
            this.example1.TabIndex = 8;
            this.example1.TabStop = true;
            this.example1.Text = "example1: Σ={a,b}\r\nDelete first symbol";
            this.example1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ExampleCliked);
            // 
            // example2
            // 
            this.example2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.example2.AutoSize = true;
            this.example2.Location = new System.Drawing.Point(637, 73);
            this.example2.Margin = new System.Windows.Forms.Padding(3);
            this.example2.Name = "example2";
            this.example2.Size = new System.Drawing.Size(133, 30);
            this.example2.TabIndex = 9;
            this.example2.TabStop = true;
            this.example2.Text = "example2: Σ={a,b}\r\nDelete last symbol";
            this.example2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ExampleCliked);
            // 
            // example3
            // 
            this.example3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.example3.AutoSize = true;
            this.example3.Location = new System.Drawing.Point(637, 119);
            this.example3.Margin = new System.Windows.Forms.Padding(3);
            this.example3.Name = "example3";
            this.example3.Size = new System.Drawing.Size(133, 30);
            this.example3.TabIndex = 10;
            this.example3.TabStop = true;
            this.example3.Text = "example3: Σ={|}\r\nMultiply number *2";
            this.example3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ExampleCliked);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.propertyGrid1.Location = new System.Drawing.Point(10, 283);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(182, 266);
            this.propertyGrid1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "The stages of the computing:";
            // 
            // example4
            // 
            this.example4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.example4.AutoSize = true;
            this.example4.Location = new System.Drawing.Point(637, 165);
            this.example4.Margin = new System.Windows.Forms.Padding(3);
            this.example4.Name = "example4";
            this.example4.Size = new System.Drawing.Size(112, 30);
            this.example4.TabIndex = 11;
            this.example4.TabStop = true;
            this.example4.Text = "example4: Σ={|}\r\nIs number even";
            this.example4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ExampleCliked);
            // 
            // example5
            // 
            this.example5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.example5.AutoSize = true;
            this.example5.Location = new System.Drawing.Point(637, 211);
            this.example5.Margin = new System.Windows.Forms.Padding(3);
            this.example5.Name = "example5";
            this.example5.Size = new System.Drawing.Size(140, 30);
            this.example5.TabIndex = 12;
            this.example5.TabStop = true;
            this.example5.Text = "example5: Σ={a,b,c}\r\nDelete all symbols";
            this.example5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ExampleCliked);
            // 
            // example6
            // 
            this.example6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.example6.AutoSize = true;
            this.example6.Location = new System.Drawing.Point(637, 257);
            this.example6.Margin = new System.Windows.Forms.Padding(3);
            this.example6.Name = "example6";
            this.example6.Size = new System.Drawing.Size(126, 30);
            this.example6.TabIndex = 11;
            this.example6.TabStop = true;
            this.example6.Text = "example6: Σ={+}\r\nInfinity addition";
            this.example6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ExampleCliked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.example5);
            this.Controls.Add(this.example6);
            this.Controls.Add(this.example4);
            this.Controls.Add(this.example3);
            this.Controls.Add(this.example2);
            this.Controls.Add(this.example1);
            this.Controls.Add(this.stages);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scheme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.word);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(430, 470);
            this.Name = "MainForm";
            this.Text = "SolverOfNormalAlgorithmSchemes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox word;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox scheme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox stages;
        private System.Windows.Forms.LinkLabel example1;
        private System.Windows.Forms.LinkLabel example2;
        private System.Windows.Forms.LinkLabel example3;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel example4;
        private System.Windows.Forms.LinkLabel example5;
        private System.Windows.Forms.LinkLabel example6;
    }
}

