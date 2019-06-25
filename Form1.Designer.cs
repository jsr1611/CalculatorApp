namespace Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.np = new System.Windows.Forms.Button();
            this.nsqrt = new System.Windows.Forms.Button();
            this.ndivByOne = new System.Windows.Forms.Button();
            this.npowOfTwo = new System.Windows.Forms.Button();
            this.ndivide = new System.Windows.Forms.Button();
            this.nback = new System.Windows.Forms.Button();
            this.nc = new System.Windows.Forms.Button();
            this.nce = new System.Windows.Forms.Button();
            this.nminus = new System.Windows.Forms.Button();
            this.nsix = new System.Windows.Forms.Button();
            this.nfive = new System.Windows.Forms.Button();
            this.nfour = new System.Windows.Forms.Button();
            this.nmultiply = new System.Windows.Forms.Button();
            this.nnine = new System.Windows.Forms.Button();
            this.neight = new System.Windows.Forms.Button();
            this.nseven = new System.Windows.Forms.Button();
            this.nequal = new System.Windows.Forms.Button();
            this.ndot = new System.Windows.Forms.Button();
            this.nNull = new System.Windows.Forms.Button();
            this.nplusMinus = new System.Windows.Forms.Button();
            this.nplus = new System.Windows.Forms.Button();
            this.nthree = new System.Windows.Forms.Button();
            this.ntwo = new System.Windows.Forms.Button();
            this.nOne = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(260, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(260, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.scientificToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.standardToolStripMenuItem.Text = "Standard";
            // 
            // scientificToolStripMenuItem
            // 
            this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            this.scientificToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.scientificToolStripMenuItem.Text = "Scientific";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(42, 0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(218, 25);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Standard";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // np
            // 
            this.np.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.np.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.np.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.np.Location = new System.Drawing.Point(0, 61);
            this.np.Name = "np";
            this.np.Size = new System.Drawing.Size(70, 50);
            this.np.TabIndex = 3;
            this.np.Text = "%";
            this.np.UseVisualStyleBackColor = false;
            this.np.Click += new System.EventHandler(this.np_Click);
            // 
            // nsqrt
            // 
            this.nsqrt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nsqrt.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nsqrt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nsqrt.Location = new System.Drawing.Point(63, 61);
            this.nsqrt.Name = "nsqrt";
            this.nsqrt.Size = new System.Drawing.Size(70, 50);
            this.nsqrt.TabIndex = 4;
            this.nsqrt.Text = "√";
            this.nsqrt.UseVisualStyleBackColor = false;
            this.nsqrt.Click += new System.EventHandler(this.nsqrt_Click);
            // 
            // ndivByOne
            // 
            this.ndivByOne.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ndivByOne.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndivByOne.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ndivByOne.Location = new System.Drawing.Point(189, 61);
            this.ndivByOne.Name = "ndivByOne";
            this.ndivByOne.Size = new System.Drawing.Size(70, 50);
            this.ndivByOne.TabIndex = 6;
            this.ndivByOne.Text = "1/x";
            this.ndivByOne.UseVisualStyleBackColor = false;
            this.ndivByOne.Click += new System.EventHandler(this.ndivByOne_Click);
            // 
            // npowOfTwo
            // 
            this.npowOfTwo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.npowOfTwo.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npowOfTwo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.npowOfTwo.Location = new System.Drawing.Point(126, 61);
            this.npowOfTwo.Name = "npowOfTwo";
            this.npowOfTwo.Size = new System.Drawing.Size(70, 50);
            this.npowOfTwo.TabIndex = 5;
            this.npowOfTwo.Text = "^2";
            this.npowOfTwo.UseVisualStyleBackColor = false;
            this.npowOfTwo.Click += new System.EventHandler(this.npowOfTwo_Click);
            // 
            // ndivide
            // 
            this.ndivide.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ndivide.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndivide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ndivide.Location = new System.Drawing.Point(189, 107);
            this.ndivide.Name = "ndivide";
            this.ndivide.Size = new System.Drawing.Size(70, 50);
            this.ndivide.TabIndex = 10;
            this.ndivide.Text = "/";
            this.ndivide.UseVisualStyleBackColor = false;
            this.ndivide.Click += new System.EventHandler(this.ndivide_Click);
            // 
            // nback
            // 
            this.nback.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nback.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nback.Location = new System.Drawing.Point(126, 107);
            this.nback.Name = "nback";
            this.nback.Size = new System.Drawing.Size(70, 50);
            this.nback.TabIndex = 9;
            this.nback.Text = "<--";
            this.nback.UseVisualStyleBackColor = false;
            // 
            // nc
            // 
            this.nc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nc.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nc.Location = new System.Drawing.Point(63, 107);
            this.nc.Name = "nc";
            this.nc.Size = new System.Drawing.Size(70, 50);
            this.nc.TabIndex = 8;
            this.nc.Text = "C";
            this.nc.UseVisualStyleBackColor = false;
            this.nc.Click += new System.EventHandler(this.nc_Click);
            // 
            // nce
            // 
            this.nce.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nce.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nce.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nce.Location = new System.Drawing.Point(0, 107);
            this.nce.Name = "nce";
            this.nce.Size = new System.Drawing.Size(70, 50);
            this.nce.TabIndex = 7;
            this.nce.Text = "CE";
            this.nce.UseVisualStyleBackColor = false;
            this.nce.Click += new System.EventHandler(this.nce_Click);
            // 
            // nminus
            // 
            this.nminus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nminus.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nminus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nminus.Location = new System.Drawing.Point(189, 199);
            this.nminus.Name = "nminus";
            this.nminus.Size = new System.Drawing.Size(70, 50);
            this.nminus.TabIndex = 18;
            this.nminus.Text = "-";
            this.nminus.UseVisualStyleBackColor = false;
            this.nminus.Click += new System.EventHandler(this.nminus_Click);
            // 
            // nsix
            // 
            this.nsix.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nsix.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nsix.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nsix.Location = new System.Drawing.Point(126, 199);
            this.nsix.Name = "nsix";
            this.nsix.Size = new System.Drawing.Size(70, 50);
            this.nsix.TabIndex = 17;
            this.nsix.Text = "6";
            this.nsix.UseVisualStyleBackColor = false;
            this.nsix.Click += new System.EventHandler(this.nsix_Click);
            // 
            // nfive
            // 
            this.nfive.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nfive.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nfive.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nfive.Location = new System.Drawing.Point(63, 199);
            this.nfive.Name = "nfive";
            this.nfive.Size = new System.Drawing.Size(70, 50);
            this.nfive.TabIndex = 16;
            this.nfive.Text = "5";
            this.nfive.UseVisualStyleBackColor = false;
            this.nfive.Click += new System.EventHandler(this.nfive_Click);
            // 
            // nfour
            // 
            this.nfour.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nfour.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nfour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nfour.Location = new System.Drawing.Point(0, 199);
            this.nfour.Name = "nfour";
            this.nfour.Size = new System.Drawing.Size(70, 50);
            this.nfour.TabIndex = 15;
            this.nfour.Text = "4";
            this.nfour.UseVisualStyleBackColor = false;
            this.nfour.Click += new System.EventHandler(this.nfour_Click);
            // 
            // nmultiply
            // 
            this.nmultiply.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nmultiply.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmultiply.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nmultiply.Location = new System.Drawing.Point(189, 153);
            this.nmultiply.Name = "nmultiply";
            this.nmultiply.Size = new System.Drawing.Size(70, 50);
            this.nmultiply.TabIndex = 14;
            this.nmultiply.Text = "x";
            this.nmultiply.UseVisualStyleBackColor = false;
            this.nmultiply.Click += new System.EventHandler(this.nmultiply_Click);
            // 
            // nnine
            // 
            this.nnine.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nnine.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nnine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nnine.Location = new System.Drawing.Point(126, 153);
            this.nnine.Name = "nnine";
            this.nnine.Size = new System.Drawing.Size(70, 50);
            this.nnine.TabIndex = 13;
            this.nnine.Text = "9";
            this.nnine.UseVisualStyleBackColor = false;
            this.nnine.Click += new System.EventHandler(this.nnine_Click);
            // 
            // neight
            // 
            this.neight.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.neight.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.neight.Location = new System.Drawing.Point(63, 153);
            this.neight.Name = "neight";
            this.neight.Size = new System.Drawing.Size(70, 50);
            this.neight.TabIndex = 12;
            this.neight.Text = "8";
            this.neight.UseVisualStyleBackColor = false;
            this.neight.Click += new System.EventHandler(this.neight_Click);
            // 
            // nseven
            // 
            this.nseven.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nseven.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nseven.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nseven.Location = new System.Drawing.Point(0, 153);
            this.nseven.Name = "nseven";
            this.nseven.Size = new System.Drawing.Size(70, 50);
            this.nseven.TabIndex = 11;
            this.nseven.Text = "7";
            this.nseven.UseVisualStyleBackColor = false;
            this.nseven.Click += new System.EventHandler(this.nseven_Click);
            // 
            // nequal
            // 
            this.nequal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nequal.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nequal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nequal.Location = new System.Drawing.Point(189, 291);
            this.nequal.Name = "nequal";
            this.nequal.Size = new System.Drawing.Size(70, 50);
            this.nequal.TabIndex = 26;
            this.nequal.Text = "=";
            this.nequal.UseVisualStyleBackColor = false;
            this.nequal.Click += new System.EventHandler(this.nequal_Click);
            // 
            // ndot
            // 
            this.ndot.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ndot.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ndot.Location = new System.Drawing.Point(126, 291);
            this.ndot.Name = "ndot";
            this.ndot.Size = new System.Drawing.Size(70, 50);
            this.ndot.TabIndex = 25;
            this.ndot.Text = ".";
            this.ndot.UseVisualStyleBackColor = false;
            this.ndot.Click += new System.EventHandler(this.ndot_Click);
            // 
            // nNull
            // 
            this.nNull.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nNull.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nNull.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nNull.Location = new System.Drawing.Point(63, 291);
            this.nNull.Name = "nNull";
            this.nNull.Size = new System.Drawing.Size(70, 50);
            this.nNull.TabIndex = 24;
            this.nNull.Text = "0";
            this.nNull.UseVisualStyleBackColor = false;
            this.nNull.Click += new System.EventHandler(this.nNull_Click);
            // 
            // nplusMinus
            // 
            this.nplusMinus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nplusMinus.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nplusMinus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nplusMinus.Location = new System.Drawing.Point(0, 291);
            this.nplusMinus.Name = "nplusMinus";
            this.nplusMinus.Size = new System.Drawing.Size(70, 50);
            this.nplusMinus.TabIndex = 23;
            this.nplusMinus.Text = "+/-";
            this.nplusMinus.UseVisualStyleBackColor = false;
            this.nplusMinus.Click += new System.EventHandler(this.nplusMinus_Click);
            // 
            // nplus
            // 
            this.nplus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nplus.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nplus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nplus.Location = new System.Drawing.Point(189, 245);
            this.nplus.Name = "nplus";
            this.nplus.Size = new System.Drawing.Size(70, 50);
            this.nplus.TabIndex = 22;
            this.nplus.Text = "+";
            this.nplus.UseVisualStyleBackColor = false;
            this.nplus.Click += new System.EventHandler(this.nplus_Click);
            // 
            // nthree
            // 
            this.nthree.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nthree.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nthree.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nthree.Location = new System.Drawing.Point(126, 245);
            this.nthree.Name = "nthree";
            this.nthree.Size = new System.Drawing.Size(70, 50);
            this.nthree.TabIndex = 21;
            this.nthree.Text = "3";
            this.nthree.UseVisualStyleBackColor = false;
            this.nthree.Click += new System.EventHandler(this.nthree_Click);
            // 
            // ntwo
            // 
            this.ntwo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ntwo.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntwo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ntwo.Location = new System.Drawing.Point(63, 245);
            this.ntwo.Name = "ntwo";
            this.ntwo.Size = new System.Drawing.Size(70, 50);
            this.ntwo.TabIndex = 20;
            this.ntwo.Text = "2";
            this.ntwo.UseVisualStyleBackColor = false;
            this.ntwo.Click += new System.EventHandler(this.ntwo_Click);
            // 
            // nOne
            // 
            this.nOne.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nOne.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nOne.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nOne.Location = new System.Drawing.Point(0, 245);
            this.nOne.Name = "nOne";
            this.nOne.Size = new System.Drawing.Size(70, 50);
            this.nOne.TabIndex = 19;
            this.nOne.Text = "1";
            this.nOne.UseVisualStyleBackColor = false;
            this.nOne.Click += new System.EventHandler(this.nOne_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 341);
            this.Controls.Add(this.nequal);
            this.Controls.Add(this.ndot);
            this.Controls.Add(this.nNull);
            this.Controls.Add(this.nplusMinus);
            this.Controls.Add(this.nplus);
            this.Controls.Add(this.nthree);
            this.Controls.Add(this.ntwo);
            this.Controls.Add(this.nOne);
            this.Controls.Add(this.nminus);
            this.Controls.Add(this.nsix);
            this.Controls.Add(this.nfive);
            this.Controls.Add(this.nfour);
            this.Controls.Add(this.nmultiply);
            this.Controls.Add(this.nnine);
            this.Controls.Add(this.neight);
            this.Controls.Add(this.nseven);
            this.Controls.Add(this.ndivide);
            this.Controls.Add(this.nback);
            this.Controls.Add(this.nc);
            this.Controls.Add(this.nce);
            this.Controls.Add(this.ndivByOne);
            this.Controls.Add(this.npowOfTwo);
            this.Controls.Add(this.nsqrt);
            this.Controls.Add(this.np);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripMenuItem scientificToolStripMenuItem;
        private System.Windows.Forms.Button np;
        private System.Windows.Forms.Button nsqrt;
        private System.Windows.Forms.Button ndivByOne;
        private System.Windows.Forms.Button npowOfTwo;
        private System.Windows.Forms.Button ndivide;
        private System.Windows.Forms.Button nback;
        private System.Windows.Forms.Button nc;
        private System.Windows.Forms.Button nce;
        private System.Windows.Forms.Button nminus;
        private System.Windows.Forms.Button nsix;
        private System.Windows.Forms.Button nfive;
        private System.Windows.Forms.Button nfour;
        private System.Windows.Forms.Button nmultiply;
        private System.Windows.Forms.Button nnine;
        private System.Windows.Forms.Button neight;
        private System.Windows.Forms.Button nseven;
        private System.Windows.Forms.Button nequal;
        private System.Windows.Forms.Button ndot;
        private System.Windows.Forms.Button nNull;
        private System.Windows.Forms.Button nplusMinus;
        private System.Windows.Forms.Button nplus;
        private System.Windows.Forms.Button nthree;
        private System.Windows.Forms.Button ntwo;
        private System.Windows.Forms.Button nOne;
    }
}

