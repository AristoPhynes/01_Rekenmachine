
namespace Rekenmachine
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CalculationResultText = new System.Windows.Forms.Label();
            this.KnoppenPaneel = new System.Windows.Forms.TableLayoutPanel();
            this.knp_memoryclear = new System.Windows.Forms.Button();
            this.knp_memoryrecall = new System.Windows.Forms.Button();
            this.knp_memoryplus = new System.Windows.Forms.Button();
            this.knp_memorystore = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.knp_euronaardollar = new System.Windows.Forms.Button();
            this.knp_allclear = new System.Windows.Forms.Button();
            this.knp_backspace = new System.Windows.Forms.Button();
            this.knp_pondnaareuro = new System.Windows.Forms.Button();
            this.knp_dollarnaareuro = new System.Windows.Forms.Button();
            this.knp_procent = new System.Windows.Forms.Button();
            this.knp_deeldoor = new System.Windows.Forms.Button();
            this.knp_zeven = new System.Windows.Forms.Button();
            this.knp_acht = new System.Windows.Forms.Button();
            this.knp_negen = new System.Windows.Forms.Button();
            this.knp_keer = new System.Windows.Forms.Button();
            this.knp_vier = new System.Windows.Forms.Button();
            this.knp_vijf = new System.Windows.Forms.Button();
            this.knp_zes = new System.Windows.Forms.Button();
            this.knp_plus = new System.Windows.Forms.Button();
            this.knp_een = new System.Windows.Forms.Button();
            this.knp_twee = new System.Windows.Forms.Button();
            this.knp_drie = new System.Windows.Forms.Button();
            this.knp_min = new System.Windows.Forms.Button();
            this.knp_sine = new System.Windows.Forms.Button();
            this.knp_nul = new System.Windows.Forms.Button();
            this.knp_commapunt = new System.Windows.Forms.Button();
            this.knp_isgelijkaan = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.KnoppenPaneel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Source Code Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 31);
            this.textBox1.TabIndex = 26;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CalculationResultText
            // 
            this.CalculationResultText.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalculationResultText.Location = new System.Drawing.Point(15, 158);
            this.CalculationResultText.Name = "CalculationResultText";
            this.CalculationResultText.Size = new System.Drawing.Size(360, 23);
            this.CalculationResultText.TabIndex = 27;
            this.CalculationResultText.Text = "Voer een berekening in en druk op enter of \"=\"";
            this.CalculationResultText.Click += new System.EventHandler(this.label1_Click);
            // 
            // KnoppenPaneel
            // 
            this.KnoppenPaneel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KnoppenPaneel.ColumnCount = 4;
            this.KnoppenPaneel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.KnoppenPaneel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.KnoppenPaneel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.KnoppenPaneel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.KnoppenPaneel.Controls.Add(this.knp_memoryclear, 0, 0);
            this.KnoppenPaneel.Controls.Add(this.knp_memoryrecall, 1, 0);
            this.KnoppenPaneel.Controls.Add(this.knp_memoryplus, 2, 0);
            this.KnoppenPaneel.Controls.Add(this.knp_memorystore, 3, 0);
            this.KnoppenPaneel.Controls.Add(this.button5, 0, 1);
            this.KnoppenPaneel.Controls.Add(this.knp_euronaardollar, 1, 1);
            this.KnoppenPaneel.Controls.Add(this.knp_allclear, 2, 1);
            this.KnoppenPaneel.Controls.Add(this.knp_backspace, 3, 1);
            this.KnoppenPaneel.Controls.Add(this.knp_pondnaareuro, 0, 2);
            this.KnoppenPaneel.Controls.Add(this.knp_dollarnaareuro, 1, 2);
            this.KnoppenPaneel.Controls.Add(this.knp_procent, 2, 2);
            this.KnoppenPaneel.Controls.Add(this.knp_deeldoor, 3, 2);
            this.KnoppenPaneel.Controls.Add(this.knp_zeven, 0, 3);
            this.KnoppenPaneel.Controls.Add(this.knp_acht, 1, 3);
            this.KnoppenPaneel.Controls.Add(this.knp_negen, 2, 3);
            this.KnoppenPaneel.Controls.Add(this.knp_keer, 3, 3);
            this.KnoppenPaneel.Controls.Add(this.knp_vier, 0, 4);
            this.KnoppenPaneel.Controls.Add(this.knp_vijf, 1, 4);
            this.KnoppenPaneel.Controls.Add(this.knp_zes, 2, 4);
            this.KnoppenPaneel.Controls.Add(this.knp_plus, 3, 4);
            this.KnoppenPaneel.Controls.Add(this.knp_een, 0, 5);
            this.KnoppenPaneel.Controls.Add(this.knp_twee, 1, 5);
            this.KnoppenPaneel.Controls.Add(this.knp_drie, 2, 5);
            this.KnoppenPaneel.Controls.Add(this.knp_min, 3, 5);
            this.KnoppenPaneel.Controls.Add(this.knp_sine, 0, 6);
            this.KnoppenPaneel.Controls.Add(this.knp_nul, 1, 6);
            this.KnoppenPaneel.Controls.Add(this.knp_commapunt, 2, 6);
            this.KnoppenPaneel.Controls.Add(this.knp_isgelijkaan, 3, 6);
            this.KnoppenPaneel.Location = new System.Drawing.Point(12, 184);
            this.KnoppenPaneel.Name = "KnoppenPaneel";
            this.KnoppenPaneel.RowCount = 7;
            this.KnoppenPaneel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.KnoppenPaneel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.KnoppenPaneel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.KnoppenPaneel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.KnoppenPaneel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.KnoppenPaneel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.KnoppenPaneel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.KnoppenPaneel.Size = new System.Drawing.Size(360, 412);
            this.KnoppenPaneel.TabIndex = 28;
            // 
            // knp_memoryclear
            // 
            this.knp_memoryclear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.knp_memoryclear.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.knp_memoryclear.Location = new System.Drawing.Point(3, 3);
            this.knp_memoryclear.Name = "knp_memoryclear";
            this.knp_memoryclear.Size = new System.Drawing.Size(84, 52);
            this.knp_memoryclear.TabIndex = 0;
            this.knp_memoryclear.Text = "MC";
            this.knp_memoryclear.UseVisualStyleBackColor = true;
            this.knp_memoryclear.Click += new System.EventHandler(this.button1_Click);
            // 
            // knp_memoryrecall
            // 
            this.knp_memoryrecall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.knp_memoryrecall.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.knp_memoryrecall.Location = new System.Drawing.Point(93, 3);
            this.knp_memoryrecall.Name = "knp_memoryrecall";
            this.knp_memoryrecall.Size = new System.Drawing.Size(84, 52);
            this.knp_memoryrecall.TabIndex = 1;
            this.knp_memoryrecall.Text = "MR";
            this.knp_memoryrecall.UseVisualStyleBackColor = true;
            // 
            // knp_memoryplus
            // 
            this.knp_memoryplus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.knp_memoryplus.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.knp_memoryplus.Location = new System.Drawing.Point(183, 3);
            this.knp_memoryplus.Name = "knp_memoryplus";
            this.knp_memoryplus.Size = new System.Drawing.Size(84, 52);
            this.knp_memoryplus.TabIndex = 2;
            this.knp_memoryplus.Text = "M+";
            this.knp_memoryplus.UseVisualStyleBackColor = true;
            // 
            // knp_memorystore
            // 
            this.knp_memorystore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.knp_memorystore.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.knp_memorystore.Location = new System.Drawing.Point(273, 3);
            this.knp_memorystore.Name = "knp_memorystore";
            this.knp_memorystore.Size = new System.Drawing.Size(84, 52);
            this.knp_memorystore.TabIndex = 3;
            this.knp_memorystore.Text = "MS";
            this.knp_memorystore.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightCoral;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(3, 61);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 52);
            this.button5.TabIndex = 4;
            this.button5.Text = "€ > £";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // knp_euronaardollar
            // 
            this.knp_euronaardollar.BackColor = System.Drawing.Color.LightCoral;
            this.knp_euronaardollar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.knp_euronaardollar.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.knp_euronaardollar.Location = new System.Drawing.Point(93, 61);
            this.knp_euronaardollar.Name = "knp_euronaardollar";
            this.knp_euronaardollar.Size = new System.Drawing.Size(84, 52);
            this.knp_euronaardollar.TabIndex = 5;
            this.knp_euronaardollar.Text = "€ > $";
            this.knp_euronaardollar.UseVisualStyleBackColor = false;
            // 
            // knp_allclear
            // 
            this.knp_allclear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.knp_allclear.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.knp_allclear.Location = new System.Drawing.Point(183, 61);
            this.knp_allclear.Name = "knp_allclear";
            this.knp_allclear.Size = new System.Drawing.Size(84, 52);
            this.knp_allclear.TabIndex = 6;
            this.knp_allclear.Text = "AC";
            this.knp_allclear.UseVisualStyleBackColor = true;
            // 
            // knp_backspace
            // 
            this.knp_backspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.knp_backspace.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.knp_backspace.Location = new System.Drawing.Point(273, 61);
            this.knp_backspace.Name = "knp_backspace";
            this.knp_backspace.Size = new System.Drawing.Size(84, 52);
            this.knp_backspace.TabIndex = 7;
            this.knp_backspace.Text = "< backspace";
            this.knp_backspace.UseVisualStyleBackColor = true;
            // 
            // knp_pondnaareuro
            // 
            this.knp_pondnaareuro.BackColor = System.Drawing.Color.LightCoral;
            this.knp_pondnaareuro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.knp_pondnaareuro.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.knp_pondnaareuro.Location = new System.Drawing.Point(3, 119);
            this.knp_pondnaareuro.Name = "knp_pondnaareuro";
            this.knp_pondnaareuro.Size = new System.Drawing.Size(84, 52);
            this.knp_pondnaareuro.TabIndex = 8;
            this.knp_pondnaareuro.Text = "£ > €";
            this.knp_pondnaareuro.UseVisualStyleBackColor = false;
            // 
            // knp_dollarnaareuro
            // 
            this.knp_dollarnaareuro.BackColor = System.Drawing.Color.LightCoral;
            this.knp_dollarnaareuro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.knp_dollarnaareuro.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.knp_dollarnaareuro.Location = new System.Drawing.Point(93, 119);
            this.knp_dollarnaareuro.Name = "knp_dollarnaareuro";
            this.knp_dollarnaareuro.Size = new System.Drawing.Size(84, 52);
            this.knp_dollarnaareuro.TabIndex = 9;
            this.knp_dollarnaareuro.Text = "$ > €";
            this.knp_dollarnaareuro.UseVisualStyleBackColor = false;
            // 
            // knp_procent
            // 
            this.knp_procent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.knp_procent.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.knp_procent.Location = new System.Drawing.Point(183, 119);
            this.knp_procent.Name = "knp_procent";
            this.knp_procent.Size = new System.Drawing.Size(84, 52);
            this.knp_procent.TabIndex = 10;
            this.knp_procent.Text = "%";
            this.knp_procent.UseVisualStyleBackColor = true;
            // 
            // knp_deeldoor
            // 
            this.knp_deeldoor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.knp_deeldoor.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.knp_deeldoor.Location = new System.Drawing.Point(273, 119);
            this.knp_deeldoor.Name = "knp_deeldoor";
            this.knp_deeldoor.Size = new System.Drawing.Size(84, 52);
            this.knp_deeldoor.TabIndex = 11;
            this.knp_deeldoor.Text = "÷";
            this.knp_deeldoor.UseVisualStyleBackColor = true;
            // 
            // knp_zeven
            // 
            this.knp_zeven.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.knp_zeven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.knp_zeven.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.knp_zeven.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.knp_zeven.Location = new System.Drawing.Point(3, 177);
            this.knp_zeven.Name = "knp_zeven";
            this.knp_zeven.Size = new System.Drawing.Size(84, 52);
            this.knp_zeven.TabIndex = 12;
            this.knp_zeven.Text = "7";
            this.knp_zeven.UseVisualStyleBackColor = false;
            // 
            // knp_acht
            // 
            this.knp_acht.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.knp_acht.Dock = System.Windows.Forms.DockStyle.Fill;
            this.knp_acht.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.knp_acht.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.knp_acht.Location = new System.Drawing.Point(93, 177);
            this.knp_acht.Name = "knp_acht";
            this.knp_acht.Size = new System.Drawing.Size(84, 52);
            this.knp_acht.TabIndex = 13;
            this.knp_acht.Text = "8";
            this.knp_acht.UseVisualStyleBackColor = false;
            // 
            // knp_negen
            // 
            this.knp_negen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.knp_negen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.knp_negen.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.knp_negen.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.knp_negen.Location = new System.Drawing.Point(183, 177);
            this.knp_negen.Name = "knp_negen";
            this.knp_negen.Size = new System.Drawing.Size(84, 52);
            this.knp_negen.TabIndex = 14;
            this.knp_negen.Text = "9";
            this.knp_negen.UseVisualStyleBackColor = false;
            // 
            // knp_keer
            // 
            this.knp_keer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.knp_keer.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.knp_keer.Location = new System.Drawing.Point(273, 177);
            this.knp_keer.Name = "knp_keer";
            this.knp_keer.Size = new System.Drawing.Size(84, 52);
            this.knp_keer.TabIndex = 15;
            this.knp_keer.Text = "x";
            this.knp_keer.UseVisualStyleBackColor = true;
            // 
            // knp_vier
            // 
            this.knp_vier.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.knp_vier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.knp_vier.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.knp_vier.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.knp_vier.Location = new System.Drawing.Point(3, 235);
            this.knp_vier.Name = "knp_vier";
            this.knp_vier.Size = new System.Drawing.Size(84, 52);
            this.knp_vier.TabIndex = 16;
            this.knp_vier.Text = "4";
            this.knp_vier.UseVisualStyleBackColor = false;
            // 
            // knp_vijf
            // 
            this.knp_vijf.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.knp_vijf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.knp_vijf.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.knp_vijf.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.knp_vijf.Location = new System.Drawing.Point(93, 235);
            this.knp_vijf.Name = "knp_vijf";
            this.knp_vijf.Size = new System.Drawing.Size(84, 52);
            this.knp_vijf.TabIndex = 17;
            this.knp_vijf.Text = "5";
            this.knp_vijf.UseVisualStyleBackColor = false;
            // 
            // knp_zes
            // 
            this.knp_zes.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.knp_zes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.knp_zes.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.knp_zes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.knp_zes.Location = new System.Drawing.Point(183, 235);
            this.knp_zes.Name = "knp_zes";
            this.knp_zes.Size = new System.Drawing.Size(84, 52);
            this.knp_zes.TabIndex = 18;
            this.knp_zes.Text = "6";
            this.knp_zes.UseVisualStyleBackColor = false;
            // 
            // knp_plus
            // 
            this.knp_plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.knp_plus.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.knp_plus.Location = new System.Drawing.Point(273, 235);
            this.knp_plus.Name = "knp_plus";
            this.knp_plus.Size = new System.Drawing.Size(84, 52);
            this.knp_plus.TabIndex = 19;
            this.knp_plus.Text = "+";
            this.knp_plus.UseVisualStyleBackColor = true;
            // 
            // knp_een
            // 
            this.knp_een.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.knp_een.Dock = System.Windows.Forms.DockStyle.Fill;
            this.knp_een.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.knp_een.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.knp_een.Location = new System.Drawing.Point(3, 293);
            this.knp_een.Name = "knp_een";
            this.knp_een.Size = new System.Drawing.Size(84, 52);
            this.knp_een.TabIndex = 20;
            this.knp_een.Text = "1";
            this.knp_een.UseVisualStyleBackColor = false;
            this.knp_een.Click += new System.EventHandler(this.knp_een_Click);
            // 
            // knp_twee
            // 
            this.knp_twee.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.knp_twee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.knp_twee.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.knp_twee.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.knp_twee.Location = new System.Drawing.Point(93, 293);
            this.knp_twee.Name = "knp_twee";
            this.knp_twee.Size = new System.Drawing.Size(84, 52);
            this.knp_twee.TabIndex = 21;
            this.knp_twee.Text = "2";
            this.knp_twee.UseVisualStyleBackColor = false;
            this.knp_twee.Click += new System.EventHandler(this.knp_twee_Click);
            // 
            // knp_drie
            // 
            this.knp_drie.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.knp_drie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.knp_drie.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.knp_drie.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.knp_drie.Location = new System.Drawing.Point(183, 293);
            this.knp_drie.Name = "knp_drie";
            this.knp_drie.Size = new System.Drawing.Size(84, 52);
            this.knp_drie.TabIndex = 22;
            this.knp_drie.Text = "3";
            this.knp_drie.UseVisualStyleBackColor = false;
            // 
            // knp_min
            // 
            this.knp_min.Dock = System.Windows.Forms.DockStyle.Fill;
            this.knp_min.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.knp_min.Location = new System.Drawing.Point(273, 293);
            this.knp_min.Name = "knp_min";
            this.knp_min.Size = new System.Drawing.Size(84, 52);
            this.knp_min.TabIndex = 23;
            this.knp_min.Text = "-";
            this.knp_min.UseVisualStyleBackColor = true;
            // 
            // knp_sine
            // 
            this.knp_sine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.knp_sine.Location = new System.Drawing.Point(3, 351);
            this.knp_sine.Name = "knp_sine";
            this.knp_sine.Size = new System.Drawing.Size(84, 58);
            this.knp_sine.TabIndex = 24;
            this.knp_sine.Text = "+/-";
            this.knp_sine.UseVisualStyleBackColor = true;
            // 
            // knp_nul
            // 
            this.knp_nul.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.knp_nul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.knp_nul.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.knp_nul.Location = new System.Drawing.Point(93, 351);
            this.knp_nul.Name = "knp_nul";
            this.knp_nul.Size = new System.Drawing.Size(84, 58);
            this.knp_nul.TabIndex = 25;
            this.knp_nul.Text = "0";
            this.knp_nul.UseVisualStyleBackColor = false;
            // 
            // knp_commapunt
            // 
            this.knp_commapunt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.knp_commapunt.Location = new System.Drawing.Point(183, 351);
            this.knp_commapunt.Name = "knp_commapunt";
            this.knp_commapunt.Size = new System.Drawing.Size(84, 58);
            this.knp_commapunt.TabIndex = 26;
            this.knp_commapunt.Text = ". / ,";
            this.knp_commapunt.UseVisualStyleBackColor = true;
            // 
            // knp_isgelijkaan
            // 
            this.knp_isgelijkaan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.knp_isgelijkaan.Location = new System.Drawing.Point(273, 351);
            this.knp_isgelijkaan.Name = "knp_isgelijkaan";
            this.knp_isgelijkaan.Size = new System.Drawing.Size(84, 58);
            this.knp_isgelijkaan.TabIndex = 27;
            this.knp_isgelijkaan.Text = "=";
            this.knp_isgelijkaan.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Source Code Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(12, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(360, 31);
            this.textBox2.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(384, 608);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.KnoppenPaneel);
            this.Controls.Add(this.CalculationResultText);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "ap | Rekenmachine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KnoppenPaneel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label CalculationResultText;
        private System.Windows.Forms.TableLayoutPanel KnoppenPaneel;
        private System.Windows.Forms.Button knp_memoryclear;
        private System.Windows.Forms.Button knp_memoryrecall;
        private System.Windows.Forms.Button knp_memoryplus;
        private System.Windows.Forms.Button knp_memorystore;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button knp_euronaardollar;
        private System.Windows.Forms.Button knp_allclear;
        private System.Windows.Forms.Button knp_backspace;
        private System.Windows.Forms.Button knp_pondnaareuro;
        private System.Windows.Forms.Button knp_dollarnaareuro;
        private System.Windows.Forms.Button knp_procent;
        private System.Windows.Forms.Button knp_deeldoor;
        private System.Windows.Forms.Button knp_zeven;
        private System.Windows.Forms.Button knp_acht;
        private System.Windows.Forms.Button knp_negen;
        private System.Windows.Forms.Button knp_keer;
        private System.Windows.Forms.Button knp_vier;
        private System.Windows.Forms.Button knp_vijf;
        private System.Windows.Forms.Button knp_zes;
        private System.Windows.Forms.Button knp_plus;
        private System.Windows.Forms.Button knp_een;
        private System.Windows.Forms.Button knp_twee;
        private System.Windows.Forms.Button knp_drie;
        private System.Windows.Forms.Button knp_min;
        private System.Windows.Forms.Button knp_sine;
        private System.Windows.Forms.Button knp_nul;
        private System.Windows.Forms.Button knp_commapunt;
        private System.Windows.Forms.Button knp_isgelijkaan;
        private System.Windows.Forms.TextBox textBox2;
    }
}

