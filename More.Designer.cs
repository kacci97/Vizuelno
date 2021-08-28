
namespace Kinoteka
{
    partial class lbDurration
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewMovieName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudRating = new System.Windows.Forms.NumericUpDown();
            this.nudDurration = new System.Windows.Forms.NumericUpDown();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.lbNewMovies = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancelMore = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter movie\'s name";
            // 
            // btnNewMovieName
            // 
            this.btnNewMovieName.Location = new System.Drawing.Point(22, 49);
            this.btnNewMovieName.Name = "btnNewMovieName";
            this.btnNewMovieName.Size = new System.Drawing.Size(248, 27);
            this.btnNewMovieName.TabIndex = 1;
            this.btnNewMovieName.TextChanged += new System.EventHandler(this.btnAddName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter movie\'s rating";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter movie\'s durration";
            // 
            // nudRating
            // 
            this.nudRating.DecimalPlaces = 1;
            this.nudRating.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudRating.Location = new System.Drawing.Point(22, 111);
            this.nudRating.Name = "nudRating";
            this.nudRating.Size = new System.Drawing.Size(150, 27);
            this.nudRating.TabIndex = 4;
            this.nudRating.Validating += new System.ComponentModel.CancelEventHandler(this.nudRating_Validating);
            // 
            // nudDurration
            // 
            this.nudDurration.Location = new System.Drawing.Point(22, 183);
            this.nudDurration.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudDurration.Name = "nudDurration";
            this.nudDurration.Size = new System.Drawing.Size(150, 27);
            this.nudDurration.TabIndex = 5;
            this.nudDurration.Validating += new System.ComponentModel.CancelEventHandler(this.nudDurration_Validating);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(44, 241);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(94, 29);
            this.btnAddMovie.TabIndex = 7;
            this.btnAddMovie.Text = "Add";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // lbNewMovies
            // 
            this.lbNewMovies.FormattingEnabled = true;
            this.lbNewMovies.ItemHeight = 20;
            this.lbNewMovies.Location = new System.Drawing.Point(324, 26);
            this.lbNewMovies.Name = "lbNewMovies";
            this.lbNewMovies.Size = new System.Drawing.Size(401, 244);
            this.lbNewMovies.TabIndex = 8;
            this.lbNewMovies.DoubleClick += new System.EventHandler(this.lbNewMovies_DoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(156, 241);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancelMore
            // 
            this.btnCancelMore.Location = new System.Drawing.Point(280, 284);
            this.btnCancelMore.Name = "btnCancelMore";
            this.btnCancelMore.Size = new System.Drawing.Size(94, 29);
            this.btnCancelMore.TabIndex = 10;
            this.btnCancelMore.Text = "Cancel";
            this.btnCancelMore.UseVisualStyleBackColor = true;
            this.btnCancelMore.Click += new System.EventHandler(this.btnCancelMore_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Information for the movies:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbDurration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 325);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelMore);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbNewMovies);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.nudDurration);
            this.Controls.Add(this.nudRating);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNewMovieName);
            this.Controls.Add(this.label1);
            this.Name = "lbDurration";
            this.Text = "More";
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox btnNewMovieName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudRating;
        private System.Windows.Forms.NumericUpDown nudDurration;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.ListBox lbNewMovies;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancelMore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}