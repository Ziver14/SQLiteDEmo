namespace SQLiteDEmo
{
    partial class Form1
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
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.tbInputNewCategory = new System.Windows.Forms.TextBox();
            this.dgCategory = new System.Windows.Forms.DataGridView();
            this.btnRefreshDG = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbQuery = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOutput
            // 
            this.tbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOutput.Location = new System.Drawing.Point(37, 55);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(501, 70);
            this.tbOutput.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefresh.Location = new System.Drawing.Point(574, 55);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(185, 70);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddCategory.Location = new System.Drawing.Point(574, 131);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(185, 67);
            this.btnAddCategory.TabIndex = 1;
            this.btnAddCategory.Text = "Добавиьт категорию";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // tbInputNewCategory
            // 
            this.tbInputNewCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInputNewCategory.Location = new System.Drawing.Point(37, 140);
            this.tbInputNewCategory.Multiline = true;
            this.tbInputNewCategory.Name = "tbInputNewCategory";
            this.tbInputNewCategory.Size = new System.Drawing.Size(391, 76);
            this.tbInputNewCategory.TabIndex = 3;
            // 
            // dgCategory
            // 
            this.dgCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategory.Location = new System.Drawing.Point(37, 243);
            this.dgCategory.Name = "dgCategory";
            this.dgCategory.Size = new System.Drawing.Size(391, 69);
            this.dgCategory.TabIndex = 4;
            // 
            // btnRefreshDG
            // 
            this.btnRefreshDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefreshDG.Location = new System.Drawing.Point(574, 213);
            this.btnRefreshDG.Name = "btnRefreshDG";
            this.btnRefreshDG.Size = new System.Drawing.Size(185, 58);
            this.btnRefreshDG.TabIndex = 5;
            this.btnRefreshDG.Text = "Обновить";
            this.btnRefreshDG.UseVisualStyleBackColor = true;
            this.btnRefreshDG.Click += new System.EventHandler(this.btnRefreshDG_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(574, 277);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(185, 62);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Записать Изменения";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbQuery
            // 
            this.tbQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbQuery.Location = new System.Drawing.Point(27, 345);
            this.tbQuery.Multiline = true;
            this.tbQuery.Name = "tbQuery";
            this.tbQuery.Size = new System.Drawing.Size(853, 163);
            this.tbQuery.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 599);
            this.Controls.Add(this.tbQuery);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRefreshDG);
            this.Controls.Add(this.dgCategory);
            this.Controls.Add(this.tbInputNewCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tbOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox tbInputNewCategory;
        private System.Windows.Forms.DataGridView dgCategory;
        private System.Windows.Forms.Button btnRefreshDG;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbQuery;
    }
}

