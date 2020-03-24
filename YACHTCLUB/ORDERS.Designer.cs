namespace YACHTCLUB
{
    partial class Orders
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodeProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeWood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1 = new YACHTCLUB.DataSet1();
            this.yCATALOGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.add = new System.Windows.Forms.Button();
            this.cp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.md = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adduser = new System.Windows.Forms.Label();
            this.gw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ms = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCATALOGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeProduct,
            this.Model,
            this.Type,
            this.Capacity,
            this.GradeWood,
            this.Color,
            this.Mast,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(271, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(856, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // CodeProduct
            // 
            this.CodeProduct.DataPropertyName = "CodeProduct";
            this.CodeProduct.HeaderText = "CodeProduct";
            this.CodeProduct.Name = "CodeProduct";
            // 
            // Model
            // 
            this.Model.DataPropertyName = "CodeProduct";
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            // 
            // Type
            // 
            this.Type.DataPropertyName = "CodeProduct";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // Capacity
            // 
            this.Capacity.DataPropertyName = "CodeProduct";
            this.Capacity.HeaderText = "Capacity";
            this.Capacity.Name = "Capacity";
            // 
            // GradeWood
            // 
            this.GradeWood.DataPropertyName = "CodeProduct";
            this.GradeWood.HeaderText = "GradeWood";
            this.GradeWood.Name = "GradeWood";
            // 
            // Color
            // 
            this.Color.DataPropertyName = "CodeProduct";
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            // 
            // Mast
            // 
            this.Mast.DataPropertyName = "CodeProduct";
            this.Mast.HeaderText = "Mast";
            this.Mast.Name = "Mast";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "CodeProduct";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yCATALOGBindingSource
            // 
            this.yCATALOGBindingSource.DataMember = "Y.CATALOG";
            this.yCATALOGBindingSource.DataSource = this.dataSet1;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.Location = new System.Drawing.Point(6, 231);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(86, 23);
            this.add.TabIndex = 21;
            this.add.Text = "ДОБАВИТЬ";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // cp
            // 
            this.cp.Location = new System.Drawing.Point(118, 112);
            this.cp.Name = "cp";
            this.cp.Size = new System.Drawing.Size(147, 20);
            this.cp.TabIndex = 20;
            this.cp.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Вместимость:";
            // 
            // tp
            // 
            this.tp.Location = new System.Drawing.Point(118, 90);
            this.tp.Name = "tp";
            this.tp.Size = new System.Drawing.Size(147, 20);
            this.tp.TabIndex = 18;
            this.tp.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Тип:";
            // 
            // md
            // 
            this.md.Location = new System.Drawing.Point(118, 68);
            this.md.Name = "md";
            this.md.Size = new System.Drawing.Size(147, 20);
            this.md.TabIndex = 16;
            this.md.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Модель:";
            // 
            // cd
            // 
            this.cd.Location = new System.Drawing.Point(118, 46);
            this.cd.Name = "cd";
            this.cd.Size = new System.Drawing.Size(147, 20);
            this.cd.TabIndex = 14;
            this.cd.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Код продукта:";
            // 
            // adduser
            // 
            this.adduser.AutoSize = true;
            this.adduser.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adduser.ForeColor = System.Drawing.Color.White;
            this.adduser.Location = new System.Drawing.Point(47, 12);
            this.adduser.Name = "adduser";
            this.adduser.Size = new System.Drawing.Size(161, 19);
            this.adduser.TabIndex = 12;
            this.adduser.Text = "Добавить продукт";
            // 
            // gw
            // 
            this.gw.Location = new System.Drawing.Point(118, 134);
            this.gw.Name = "gw";
            this.gw.Size = new System.Drawing.Size(147, 20);
            this.gw.TabIndex = 24;
            this.gw.Text = "GradeWood";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Дерево:";
            // 
            // cl
            // 
            this.cl.Location = new System.Drawing.Point(118, 156);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(147, 20);
            this.cl.TabIndex = 26;
            this.cl.Text = "Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "Цвет:";
            // 
            // ms
            // 
            this.ms.Location = new System.Drawing.Point(118, 179);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(147, 20);
            this.ms.TabIndex = 28;
            this.ms.Text = "Mast";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "Мачта:";
            // 
            // pr
            // 
            this.pr.Location = new System.Drawing.Point(118, 201);
            this.pr.Name = "pr";
            this.pr.Size = new System.Drawing.Size(147, 20);
            this.pr.TabIndex = 30;
            this.pr.Text = "10000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 18);
            this.label8.TabIndex = 29;
            this.label8.Text = "Цена:";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.Location = new System.Drawing.Point(179, 231);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(86, 23);
            this.delete.TabIndex = 31;
            this.delete.Text = "УДАЛИТЬ";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(1141, 265);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.pr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ms);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.cp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.md);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adduser);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ОКНО КЛИЕНТА";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCATALOGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource yCATALOGBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeWood;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mast;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox cp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox md;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label adduser;
        private System.Windows.Forms.TextBox gw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ms;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button delete;
    }
}