namespace RegressionAnalyzer
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
            tbX = new TextBox();
            tbY = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnRun = new Button();
            label3 = new Label();
            pnlInput = new Panel();
            pnlSimpleModel = new Panel();
            tbPredictedY = new TextBox();
            label42 = new Label();
            tbXInput = new TextBox();
            label41 = new Label();
            lblDF2 = new Label();
            label43 = new Label();
            label44 = new Label();
            lblDF1 = new Label();
            label37 = new Label();
            label38 = new Label();
            label39 = new Label();
            label40 = new Label();
            label36 = new Label();
            lblFStat = new Label();
            label35 = new Label();
            label34 = new Label();
            label33 = new Label();
            label32 = new Label();
            label30 = new Label();
            label29 = new Label();
            lblCOE = new Label();
            label31 = new Label();
            lblCOD = new Label();
            label21 = new Label();
            lblMSR = new Label();
            label25 = new Label();
            label27 = new Label();
            label28 = new Label();
            lblSD = new Label();
            label26 = new Label();
            label23 = new Label();
            lblMSE = new Label();
            label19 = new Label();
            label18 = new Label();
            label15 = new Label();
            label11 = new Label();
            lblSSRSum = new Label();
            label24 = new Label();
            lblSSESum = new Label();
            label22 = new Label();
            lblSSTSum = new Label();
            label20 = new Label();
            lblSSR = new Label();
            lblSSE = new Label();
            lblSST = new Label();
            gridModelFitness = new DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            lblRegressionEQ = new Label();
            label16 = new Label();
            label17 = new Label();
            lblIntercept = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            lblSlope = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            lblXDiffSquaredSum = new Label();
            lblXYDiffProductSum = new Label();
            label7 = new Label();
            label6 = new Label();
            lblYMean = new Label();
            lblXMean = new Label();
            label5 = new Label();
            label4 = new Label();
            gridModelIntermediate = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            gridSample = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            msReset = new ToolStripMenuItem();
            label45 = new Label();
            pnlInput.SuspendLayout();
            pnlSimpleModel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridModelFitness).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridModelIntermediate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridSample).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tbX
            // 
            tbX.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbX.Location = new Point(157, 82);
            tbX.Name = "tbX";
            tbX.Size = new Size(308, 27);
            tbX.TabIndex = 0;
            // 
            // tbY
            // 
            tbY.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbY.Location = new Point(157, 130);
            tbY.Name = "tbY";
            tbY.Size = new Size(308, 27);
            tbY.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 89);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 2;
            label1.Text = "x values";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 137);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 3;
            label2.Text = "y values";
            // 
            // btnRun
            // 
            btnRun.Location = new Point(233, 193);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(128, 40);
            btnRun.TabIndex = 4;
            btnRun.Text = "Run Regression";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(192, 37);
            label3.Name = "label3";
            label3.Size = new Size(207, 15);
            label3.TabIndex = 5;
            label3.Text = "Enter sample data separated by space.";
            // 
            // pnlInput
            // 
            pnlInput.Controls.Add(tbX);
            pnlInput.Controls.Add(label3);
            pnlInput.Controls.Add(tbY);
            pnlInput.Controls.Add(btnRun);
            pnlInput.Controls.Add(label1);
            pnlInput.Controls.Add(label2);
            pnlInput.Location = new Point(146, 153);
            pnlInput.Name = "pnlInput";
            pnlInput.Size = new Size(568, 266);
            pnlInput.TabIndex = 6;
            // 
            // pnlSimpleModel
            // 
            pnlSimpleModel.Controls.Add(label45);
            pnlSimpleModel.Controls.Add(tbPredictedY);
            pnlSimpleModel.Controls.Add(label42);
            pnlSimpleModel.Controls.Add(tbXInput);
            pnlSimpleModel.Controls.Add(label41);
            pnlSimpleModel.Controls.Add(lblDF2);
            pnlSimpleModel.Controls.Add(label43);
            pnlSimpleModel.Controls.Add(label44);
            pnlSimpleModel.Controls.Add(lblDF1);
            pnlSimpleModel.Controls.Add(label37);
            pnlSimpleModel.Controls.Add(label38);
            pnlSimpleModel.Controls.Add(label39);
            pnlSimpleModel.Controls.Add(label40);
            pnlSimpleModel.Controls.Add(label36);
            pnlSimpleModel.Controls.Add(lblFStat);
            pnlSimpleModel.Controls.Add(label35);
            pnlSimpleModel.Controls.Add(label34);
            pnlSimpleModel.Controls.Add(label33);
            pnlSimpleModel.Controls.Add(label32);
            pnlSimpleModel.Controls.Add(label30);
            pnlSimpleModel.Controls.Add(label29);
            pnlSimpleModel.Controls.Add(lblCOE);
            pnlSimpleModel.Controls.Add(label31);
            pnlSimpleModel.Controls.Add(lblCOD);
            pnlSimpleModel.Controls.Add(label21);
            pnlSimpleModel.Controls.Add(lblMSR);
            pnlSimpleModel.Controls.Add(label25);
            pnlSimpleModel.Controls.Add(label27);
            pnlSimpleModel.Controls.Add(label28);
            pnlSimpleModel.Controls.Add(lblSD);
            pnlSimpleModel.Controls.Add(label26);
            pnlSimpleModel.Controls.Add(label23);
            pnlSimpleModel.Controls.Add(lblMSE);
            pnlSimpleModel.Controls.Add(label19);
            pnlSimpleModel.Controls.Add(label18);
            pnlSimpleModel.Controls.Add(label15);
            pnlSimpleModel.Controls.Add(label11);
            pnlSimpleModel.Controls.Add(lblSSRSum);
            pnlSimpleModel.Controls.Add(label24);
            pnlSimpleModel.Controls.Add(lblSSESum);
            pnlSimpleModel.Controls.Add(label22);
            pnlSimpleModel.Controls.Add(lblSSTSum);
            pnlSimpleModel.Controls.Add(label20);
            pnlSimpleModel.Controls.Add(lblSSR);
            pnlSimpleModel.Controls.Add(lblSSE);
            pnlSimpleModel.Controls.Add(lblSST);
            pnlSimpleModel.Controls.Add(gridModelFitness);
            pnlSimpleModel.Controls.Add(lblRegressionEQ);
            pnlSimpleModel.Controls.Add(label16);
            pnlSimpleModel.Controls.Add(label17);
            pnlSimpleModel.Controls.Add(lblIntercept);
            pnlSimpleModel.Controls.Add(label12);
            pnlSimpleModel.Controls.Add(label13);
            pnlSimpleModel.Controls.Add(label14);
            pnlSimpleModel.Controls.Add(lblSlope);
            pnlSimpleModel.Controls.Add(label10);
            pnlSimpleModel.Controls.Add(label9);
            pnlSimpleModel.Controls.Add(label8);
            pnlSimpleModel.Controls.Add(lblXDiffSquaredSum);
            pnlSimpleModel.Controls.Add(lblXYDiffProductSum);
            pnlSimpleModel.Controls.Add(label7);
            pnlSimpleModel.Controls.Add(label6);
            pnlSimpleModel.Controls.Add(lblYMean);
            pnlSimpleModel.Controls.Add(lblXMean);
            pnlSimpleModel.Controls.Add(label5);
            pnlSimpleModel.Controls.Add(label4);
            pnlSimpleModel.Controls.Add(gridModelIntermediate);
            pnlSimpleModel.Controls.Add(gridSample);
            pnlSimpleModel.Location = new Point(0, 27);
            pnlSimpleModel.Name = "pnlSimpleModel";
            pnlSimpleModel.Size = new Size(852, 602);
            pnlSimpleModel.TabIndex = 7;
            // 
            // tbPredictedY
            // 
            tbPredictedY.Location = new Point(376, 493);
            tbPredictedY.Name = "tbPredictedY";
            tbPredictedY.ReadOnly = true;
            tbPredictedY.Size = new Size(76, 23);
            tbPredictedY.TabIndex = 66;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label42.Location = new Point(353, 494);
            label42.Name = "label42";
            label42.Size = new Size(24, 15);
            label42.TabIndex = 65;
            label42.Text = "ŷ =";
            // 
            // tbXInput
            // 
            tbXInput.Location = new Point(425, 467);
            tbXInput.Name = "tbXInput";
            tbXInput.PlaceholderText = "enter x";
            tbXInput.Size = new Size(82, 23);
            tbXInput.TabIndex = 64;
            tbXInput.TextChanged += tbXInput_TextChanged;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label41.Location = new Point(353, 470);
            label41.Name = "label41";
            label41.Size = new Size(67, 15);
            label41.TabIndex = 63;
            label41.Text = "PREDICT ŷ:";
            // 
            // lblDF2
            // 
            lblDF2.AutoSize = true;
            lblDF2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDF2.Location = new Point(153, 515);
            lblDF2.Name = "lblDF2";
            lblDF2.Size = new Size(16, 15);
            lblDF2.TabIndex = 62;
            lblDF2.Text = "N";
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label43.Location = new Point(121, 514);
            label43.Name = "label43";
            label43.Size = new Size(34, 15);
            label43.TabIndex = 61;
            label43.Text = "df₂ =";
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label44.Location = new Point(142, 515);
            label44.Name = "label44";
            label44.Size = new Size(16, 15);
            label44.TabIndex = 60;
            label44.Text = "N";
            // 
            // lblDF1
            // 
            lblDF1.AutoSize = true;
            lblDF1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDF1.Location = new Point(153, 498);
            lblDF1.Name = "lblDF1";
            lblDF1.Size = new Size(16, 15);
            lblDF1.TabIndex = 59;
            lblDF1.Text = "N";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label37.Location = new Point(121, 497);
            label37.Name = "label37";
            label37.Size = new Size(34, 15);
            label37.TabIndex = 58;
            label37.Text = "df₁ =";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label38.Location = new Point(142, 498);
            label38.Name = "label38";
            label38.Size = new Size(16, 15);
            label38.TabIndex = 57;
            label38.Text = "N";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label39.Location = new Point(121, 482);
            label39.Name = "label39";
            label39.Size = new Size(145, 15);
            label39.TabIndex = 56;
            label39.Text = "Fcritical​ = F⁻¹(1−α,df1,df2)";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label40.Location = new Point(121, 467);
            label40.Name = "label40";
            label40.Size = new Size(69, 15);
            label40.TabIndex = 55;
            label40.Text = "F-CRITICAL";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label36.Location = new Point(25, 497);
            label36.Name = "label36";
            label36.Size = new Size(24, 15);
            label36.TabIndex = 54;
            label36.Text = "F =";
            // 
            // lblFStat
            // 
            lblFStat.AutoSize = true;
            lblFStat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblFStat.Location = new Point(46, 498);
            lblFStat.Name = "lblFStat";
            lblFStat.Size = new Size(16, 15);
            lblFStat.TabIndex = 53;
            lblFStat.Text = "N";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label35.Location = new Point(25, 482);
            label35.Name = "label35";
            label35.Size = new Size(77, 15);
            label35.TabIndex = 52;
            label35.Text = "F = MSR/MSE";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label34.Location = new Point(25, 467);
            label34.Name = "label34";
            label34.Size = new Size(90, 15);
            label34.TabIndex = 51;
            label34.Text = "F-CALCULATED";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label33.Location = new Point(581, 545);
            label33.Name = "label33";
            label33.Size = new Size(22, 15);
            label33.TabIndex = 50;
            label33.Text = "r =";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label32.Location = new Point(581, 530);
            label32.Name = "label32";
            label32.Size = new Size(49, 15);
            label32.TabIndex = 49;
            label32.Text = "r = √(r²)";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label30.Location = new Point(581, 482);
            label30.Name = "label30";
            label30.Size = new Size(26, 15);
            label30.TabIndex = 48;
            label30.Text = "r² =";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label29.Location = new Point(581, 467);
            label29.Name = "label29";
            label29.Size = new Size(77, 15);
            label29.TabIndex = 47;
            label29.Text = "r² = SSR / SST";
            // 
            // lblCOE
            // 
            lblCOE.AutoSize = true;
            lblCOE.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCOE.Location = new Point(602, 546);
            lblCOE.Name = "lblCOE";
            lblCOE.Size = new Size(16, 15);
            lblCOE.TabIndex = 46;
            lblCOE.Text = "N";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label31.Location = new Point(581, 514);
            label31.Name = "label31";
            label31.Size = new Size(177, 15);
            label31.TabIndex = 45;
            label31.Text = "CORRELATION COEFFICIENT (r)";
            // 
            // lblCOD
            // 
            lblCOD.AutoSize = true;
            lblCOD.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCOD.Location = new Point(604, 483);
            lblCOD.Name = "lblCOD";
            lblCOD.Size = new Size(16, 15);
            lblCOD.TabIndex = 44;
            lblCOD.Text = "N";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(581, 450);
            label21.Name = "label21";
            label21.Size = new Size(216, 15);
            label21.TabIndex = 43;
            label21.Text = "COEFFICIENT OF DETERMINATION (r²)";
            // 
            // lblMSR
            // 
            lblMSR.AutoSize = true;
            lblMSR.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMSR.Location = new Point(790, 414);
            lblMSR.Name = "lblMSR";
            lblMSR.Size = new Size(16, 15);
            lblMSR.TabIndex = 42;
            lblMSR.Text = "N";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label25.Location = new Point(750, 413);
            label25.Name = "label25";
            label25.Size = new Size(44, 15);
            label25.TabIndex = 41;
            label25.Text = "MSR = ";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label27.Location = new Point(750, 394);
            label27.Name = "label27";
            label27.Size = new Size(79, 15);
            label27.TabIndex = 40;
            label27.Text = "MSR = SSE / k";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label28.Location = new Point(750, 376);
            label28.Name = "label28";
            label28.Size = new Size(33, 15);
            label28.TabIndex = 39;
            label28.Text = "MSR";
            // 
            // lblSD
            // 
            lblSD.AutoSize = true;
            lblSD.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSD.Location = new Point(702, 415);
            lblSD.Name = "lblSD";
            lblSD.Size = new Size(16, 15);
            lblSD.TabIndex = 38;
            lblSD.Text = "N";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label26.Location = new Point(681, 414);
            label26.Name = "label26";
            label26.Size = new Size(26, 15);
            label26.TabIndex = 37;
            label26.Text = "s = ";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label23.Location = new Point(681, 394);
            label23.Name = "label23";
            label23.Size = new Size(51, 15);
            label23.TabIndex = 36;
            label23.Text = "s = √(s²)";
            // 
            // lblMSE
            // 
            lblMSE.AutoSize = true;
            lblMSE.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMSE.Location = new Point(604, 414);
            lblMSE.Name = "lblMSE";
            lblMSE.Size = new Size(16, 15);
            lblMSE.TabIndex = 35;
            lblMSE.Text = "N";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label19.Location = new Point(580, 413);
            label19.Name = "label19";
            label19.Size = new Size(30, 15);
            label19.TabIndex = 34;
            label19.Text = "s² = ";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label18.Location = new Point(580, 394);
            label18.Name = "label18";
            label18.Size = new Size(88, 15);
            label18.TabIndex = 33;
            label18.Text = "s² = SSE / n-k-1";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(681, 376);
            label15.Name = "label15";
            label15.Size = new Size(39, 15);
            label15.TabIndex = 32;
            label15.Text = "SD (s)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(580, 376);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 31;
            label11.Text = "MSE (s²)";
            // 
            // lblSSRSum
            // 
            lblSSRSum.AutoSize = true;
            lblSSRSum.Location = new Point(782, 326);
            lblSSRSum.Name = "lblSSRSum";
            lblSSRSum.Size = new Size(16, 15);
            lblSSRSum.TabIndex = 30;
            lblSSRSum.Text = "N";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(759, 324);
            label24.Name = "label24";
            label24.Size = new Size(25, 15);
            label24.TabIndex = 29;
            label24.Text = "∑ =";
            // 
            // lblSSESum
            // 
            lblSSESum.AutoSize = true;
            lblSSESum.Location = new Point(711, 326);
            lblSSESum.Name = "lblSSESum";
            lblSSESum.Size = new Size(16, 15);
            lblSSESum.TabIndex = 28;
            lblSSESum.Text = "N";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(688, 324);
            label22.Name = "label22";
            label22.Size = new Size(25, 15);
            label22.TabIndex = 27;
            label22.Text = "∑ =";
            // 
            // lblSSTSum
            // 
            lblSSTSum.AutoSize = true;
            lblSSTSum.Location = new Point(634, 326);
            lblSSTSum.Name = "lblSSTSum";
            lblSSTSum.Size = new Size(16, 15);
            lblSSTSum.TabIndex = 26;
            lblSSTSum.Text = "N";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(611, 324);
            label20.Name = "label20";
            label20.Size = new Size(25, 15);
            label20.TabIndex = 25;
            label20.Text = "∑ =";
            // 
            // lblSSR
            // 
            lblSSR.AutoSize = true;
            lblSSR.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSSR.Location = new Point(469, 413);
            lblSSR.Name = "lblSSR";
            lblSSR.Size = new Size(16, 15);
            lblSSR.TabIndex = 24;
            lblSSR.Text = "N";
            // 
            // lblSSE
            // 
            lblSSE.AutoSize = true;
            lblSSE.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSSE.Location = new Point(469, 394);
            lblSSE.Name = "lblSSE";
            lblSSE.Size = new Size(16, 15);
            lblSSE.TabIndex = 23;
            lblSSE.Text = "N";
            // 
            // lblSST
            // 
            lblSST.AutoSize = true;
            lblSST.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSST.Location = new Point(469, 376);
            lblSST.Name = "lblSST";
            lblSST.Size = new Size(16, 15);
            lblSST.TabIndex = 22;
            lblSST.Text = "N";
            // 
            // gridModelFitness
            // 
            gridModelFitness.AllowUserToAddRows = false;
            gridModelFitness.AllowUserToDeleteRows = false;
            gridModelFitness.AllowUserToResizeColumns = false;
            gridModelFitness.AllowUserToResizeRows = false;
            gridModelFitness.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridModelFitness.Columns.AddRange(new DataGridViewColumn[] { Column7, Column8, Column9, Column10 });
            gridModelFitness.Location = new Point(522, 14);
            gridModelFitness.MultiSelect = false;
            gridModelFitness.Name = "gridModelFitness";
            gridModelFitness.RowHeadersVisible = false;
            gridModelFitness.RowTemplate.Height = 25;
            gridModelFitness.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridModelFitness.Size = new Size(305, 307);
            gridModelFitness.TabIndex = 21;
            gridModelFitness.SelectionChanged += selectionChanged;
            // 
            // Column7
            // 
            Column7.HeaderText = "ŷ";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column7.Width = 75;
            // 
            // Column8
            // 
            Column8.HeaderText = "(y - ȳ)²";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column8.Width = 75;
            // 
            // Column9
            // 
            Column9.HeaderText = "(y - ŷ)²";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column9.Width = 75;
            // 
            // Column10
            // 
            Column10.HeaderText = "(ŷ - ȳ)²";
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column10.Width = 75;
            // 
            // lblRegressionEQ
            // 
            lblRegressionEQ.AutoSize = true;
            lblRegressionEQ.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblRegressionEQ.Location = new Point(328, 413);
            lblRegressionEQ.Name = "lblRegressionEQ";
            lblRegressionEQ.Size = new Size(17, 15);
            lblRegressionEQ.TabIndex = 20;
            lblRegressionEQ.Text = "N";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label16.Location = new Point(328, 394);
            label16.Name = "label16";
            label16.Size = new Size(69, 15);
            label16.TabIndex = 19;
            label16.Text = "ŷ = b₀ + b₁x";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(328, 376);
            label17.Name = "label17";
            label17.Size = new Size(98, 15);
            label17.TabIndex = 18;
            label17.Text = "REGRESSION EQ";
            // 
            // lblIntercept
            // 
            lblIntercept.AutoSize = true;
            lblIntercept.Location = new Point(225, 414);
            lblIntercept.Name = "lblIntercept";
            lblIntercept.Size = new Size(16, 15);
            lblIntercept.TabIndex = 17;
            lblIntercept.Text = "N";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(196, 413);
            label12.Name = "label12";
            label12.Size = new Size(32, 15);
            label12.TabIndex = 16;
            label12.Text = "b₀ = ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label13.Location = new Point(196, 394);
            label13.Name = "label13";
            label13.Size = new Size(66, 15);
            label13.TabIndex = 15;
            label13.Text = "b₀ = ȳ - b₁x̄";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(196, 376);
            label14.Name = "label14";
            label14.Size = new Size(101, 15);
            label14.TabIndex = 14;
            label14.Text = "Y INTERCEPT (b₀)";
            // 
            // lblSlope
            // 
            lblSlope.AutoSize = true;
            lblSlope.Location = new Point(54, 414);
            lblSlope.Name = "lblSlope";
            lblSlope.Size = new Size(16, 15);
            lblSlope.TabIndex = 13;
            lblSlope.Text = "N";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(25, 413);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 12;
            label10.Text = "b₁ = ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(25, 394);
            label9.Name = "label9";
            label9.Size = new Size(154, 15);
            label9.TabIndex = 11;
            label9.Text = "b₁ = ∑(x - x̄) (y - ȳ) / ∑(x - x̄)²";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(25, 376);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 10;
            label8.Text = "SLOPE (b₁)";
            // 
            // lblXDiffSquaredSum
            // 
            lblXDiffSquaredSum.AutoSize = true;
            lblXDiffSquaredSum.Location = new Point(461, 326);
            lblXDiffSquaredSum.Name = "lblXDiffSquaredSum";
            lblXDiffSquaredSum.Size = new Size(16, 15);
            lblXDiffSquaredSum.TabIndex = 9;
            lblXDiffSquaredSum.Text = "N";
            // 
            // lblXYDiffProductSum
            // 
            lblXYDiffProductSum.AutoSize = true;
            lblXYDiffProductSum.Location = new Point(374, 326);
            lblXYDiffProductSum.Name = "lblXYDiffProductSum";
            lblXYDiffProductSum.Size = new Size(16, 15);
            lblXYDiffProductSum.TabIndex = 8;
            lblXYDiffProductSum.Text = "N";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(439, 324);
            label7.Name = "label7";
            label7.Size = new Size(25, 15);
            label7.TabIndex = 7;
            label7.Text = "∑ =";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(351, 324);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 6;
            label6.Text = "∑ =";
            // 
            // lblYMean
            // 
            lblYMean.AutoSize = true;
            lblYMean.Location = new Point(132, 325);
            lblYMean.Name = "lblYMean";
            lblYMean.Size = new Size(16, 15);
            lblYMean.TabIndex = 5;
            lblYMean.Text = "N";
            // 
            // lblXMean
            // 
            lblXMean.AutoSize = true;
            lblXMean.Location = new Point(46, 325);
            lblXMean.Name = "lblXMean";
            lblXMean.Size = new Size(16, 15);
            lblXMean.TabIndex = 4;
            lblXMean.Text = "N";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(111, 324);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 3;
            label5.Text = "ȳ =";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 324);
            label4.Name = "label4";
            label4.Size = new Size(23, 15);
            label4.TabIndex = 2;
            label4.Text = "x̄ =";
            // 
            // gridModelIntermediate
            // 
            gridModelIntermediate.AllowUserToAddRows = false;
            gridModelIntermediate.AllowUserToDeleteRows = false;
            gridModelIntermediate.AllowUserToResizeColumns = false;
            gridModelIntermediate.AllowUserToResizeRows = false;
            gridModelIntermediate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridModelIntermediate.Columns.AddRange(new DataGridViewColumn[] { Column3, Column4, Column5, Column6 });
            gridModelIntermediate.Location = new Point(186, 14);
            gridModelIntermediate.MultiSelect = false;
            gridModelIntermediate.Name = "gridModelIntermediate";
            gridModelIntermediate.ReadOnly = true;
            gridModelIntermediate.RowHeadersVisible = false;
            gridModelIntermediate.RowTemplate.Height = 25;
            gridModelIntermediate.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridModelIntermediate.Size = new Size(330, 307);
            gridModelIntermediate.TabIndex = 1;
            gridModelIntermediate.SelectionChanged += selectionChanged;
            // 
            // Column3
            // 
            Column3.HeaderText = "(x - x̄)";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column3.Width = 75;
            // 
            // Column4
            // 
            Column4.HeaderText = "(y - ȳ)";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column4.Width = 75;
            // 
            // Column5
            // 
            Column5.HeaderText = "(x - x̄) (y - ȳ)";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            Column6.HeaderText = "(x - x̄)²";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column6.Width = 75;
            // 
            // gridSample
            // 
            gridSample.AllowUserToAddRows = false;
            gridSample.AllowUserToDeleteRows = false;
            gridSample.AllowUserToResizeColumns = false;
            gridSample.AllowUserToResizeRows = false;
            gridSample.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridSample.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            gridSample.Location = new Point(24, 14);
            gridSample.MultiSelect = false;
            gridSample.Name = "gridSample";
            gridSample.RowHeadersVisible = false;
            gridSample.RowTemplate.Height = 25;
            gridSample.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridSample.Size = new Size(156, 307);
            gridSample.TabIndex = 0;
            gridSample.SelectionChanged += selectionChanged;
            // 
            // Column1
            // 
            Column1.HeaderText = "x";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column1.Width = 75;
            // 
            // Column2
            // 
            Column2.HeaderText = "y";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column2.Width = 75;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { msReset });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(853, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // msReset
            // 
            msReset.Name = "msReset";
            msReset.Size = new Size(47, 20);
            msReset.Text = "Reset";
            msReset.Click += msReset_Click;
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label45.Location = new Point(24, 545);
            label45.Name = "label45";
            label45.Size = new Size(230, 15);
            label45.TabIndex = 67;
            label45.Text = "F-CALCULATED > F-CRITICAL= Reject H₀";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 630);
            Controls.Add(menuStrip1);
            Controls.Add(pnlSimpleModel);
            Controls.Add(pnlInput);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Simple Regression Analyzer";
            pnlInput.ResumeLayout(false);
            pnlInput.PerformLayout();
            pnlSimpleModel.ResumeLayout(false);
            pnlSimpleModel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridModelFitness).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridModelIntermediate).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridSample).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbX;
        private TextBox tbY;
        private Label label1;
        private Label label2;
        private Button btnRun;
        private Label label3;
        private Panel pnlInput;
        private Panel pnlSimpleModel;
        private DataGridView gridSample;
        private DataGridView gridModelIntermediate;
        private Label lblYMean;
        private Label lblXMean;
        private Label label5;
        private Label label4;
        private Label lblXDiffSquaredSum;
        private Label lblXYDiffProductSum;
        private Label label7;
        private Label label6;
        private Label label9;
        private Label label8;
        private Label lblIntercept;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label lblSlope;
        private Label label10;
        private Label lblRegressionEQ;
        private Label label16;
        private Label label17;
        private DataGridView gridModelFitness;
        private Label lblSSR;
        private Label lblSSE;
        private Label lblSST;
        private Label lblSSRSum;
        private Label label24;
        private Label lblSSESum;
        private Label label22;
        private Label lblSSTSum;
        private Label label20;
        private Label label23;
        private Label lblMSE;
        private Label label19;
        private Label label18;
        private Label label15;
        private Label label11;
        private Label lblSD;
        private Label label26;
        private Label lblMSR;
        private Label label25;
        private Label label27;
        private Label label28;
        private Label lblCOE;
        private Label label31;
        private Label lblCOD;
        private Label label21;
        private Label label30;
        private Label label29;
        private Label label33;
        private Label label32;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem msReset;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Label label37;
        private Label label38;
        private Label label39;
        private Label label40;
        private Label label36;
        private Label lblFStat;
        private Label label35;
        private Label label34;
        private Label lblDF2;
        private Label label43;
        private Label label44;
        private Label lblDF1;
        private TextBox tbPredictedY;
        private Label label42;
        private TextBox tbXInput;
        private Label label41;
        private Label label45;
    }
}
