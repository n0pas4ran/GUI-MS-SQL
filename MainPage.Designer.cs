namespace client
{
    partial class MainPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Правообладатель");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Регистрация прав собственности");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Земельный участок");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Координаты участка");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Объект недвижимости");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Характеристики объекта");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Кадастровая база ", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.holderPlaceB = new System.Windows.Forms.Button();
            this.holderObjB = new System.Windows.Forms.Button();
            this.reviewB = new System.Windows.Forms.Button();
            this.commercialB = new System.Windows.Forms.Button();
            this.refreshObjB = new System.Windows.Forms.Button();
            this.transObjB = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextHolder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showHolder = new System.Windows.Forms.ToolStripMenuItem();
            this.addHolder = new System.Windows.Forms.ToolStripMenuItem();
            this.updateHolder = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteHolder = new System.Windows.Forms.ToolStripMenuItem();
            this.contextRegister = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.addRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.updateRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.contextPlace = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextKoordinati = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextObject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextParametrs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.infoB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextHolder.SuspendLayout();
            this.contextRegister.SuspendLayout();
            this.contextPlace.SuspendLayout();
            this.contextKoordinati.SuspendLayout();
            this.contextObject.SuspendLayout();
            this.contextParametrs.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(247, 3);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(616, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // holderPlaceB
            // 
            this.holderPlaceB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.holderPlaceB.FlatAppearance.BorderSize = 2;
            this.holderPlaceB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.holderPlaceB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.holderPlaceB.Location = new System.Drawing.Point(12, 388);
            this.holderPlaceB.Name = "holderPlaceB";
            this.holderPlaceB.Size = new System.Drawing.Size(110, 44);
            this.holderPlaceB.TabIndex = 1;
            this.holderPlaceB.Text = "Свод земельных участков";
            this.holderPlaceB.UseVisualStyleBackColor = true;
            this.holderPlaceB.Click += new System.EventHandler(this.holderPlaceB_Click);
            // 
            // holderObjB
            // 
            this.holderObjB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.holderObjB.FlatAppearance.BorderSize = 2;
            this.holderObjB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.holderObjB.Location = new System.Drawing.Point(153, 388);
            this.holderObjB.Name = "holderObjB";
            this.holderObjB.Size = new System.Drawing.Size(102, 44);
            this.holderObjB.TabIndex = 2;
            this.holderObjB.Text = "Свод объектов";
            this.holderObjB.UseVisualStyleBackColor = true;
            this.holderObjB.Click += new System.EventHandler(this.holderObjB_Click);
            // 
            // reviewB
            // 
            this.reviewB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reviewB.FlatAppearance.BorderSize = 2;
            this.reviewB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reviewB.Location = new System.Drawing.Point(295, 388);
            this.reviewB.Name = "reviewB";
            this.reviewB.Size = new System.Drawing.Size(99, 44);
            this.reviewB.TabIndex = 3;
            this.reviewB.Text = "Обзор";
            this.reviewB.UseVisualStyleBackColor = true;
            this.reviewB.Click += new System.EventHandler(this.reviewB_Click);
            // 
            // commercialB
            // 
            this.commercialB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.commercialB.FlatAppearance.BorderSize = 2;
            this.commercialB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.commercialB.Location = new System.Drawing.Point(437, 388);
            this.commercialB.Name = "commercialB";
            this.commercialB.Size = new System.Drawing.Size(113, 44);
            this.commercialB.TabIndex = 4;
            this.commercialB.Text = "Коммерческая недвижимость";
            this.commercialB.UseVisualStyleBackColor = true;
            this.commercialB.Click += new System.EventHandler(this.commercialB_Click);
            // 
            // refreshObjB
            // 
            this.refreshObjB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshObjB.FlatAppearance.BorderSize = 2;
            this.refreshObjB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refreshObjB.Location = new System.Drawing.Point(717, 388);
            this.refreshObjB.Name = "refreshObjB";
            this.refreshObjB.Size = new System.Drawing.Size(118, 44);
            this.refreshObjB.TabIndex = 5;
            this.refreshObjB.Text = "Обновить данные объектов";
            this.refreshObjB.UseVisualStyleBackColor = true;
            this.refreshObjB.Click += new System.EventHandler(this.refreshObjB_Click);
            // 
            // transObjB
            // 
            this.transObjB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transObjB.FlatAppearance.BorderSize = 2;
            this.transObjB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.transObjB.Location = new System.Drawing.Point(583, 388);
            this.transObjB.Name = "transObjB";
            this.transObjB.Size = new System.Drawing.Size(109, 44);
            this.transObjB.TabIndex = 12;
            this.transObjB.Text = "Форматрование объектов";
            this.transObjB.UseVisualStyleBackColor = true;
            this.transObjB.Click += new System.EventHandler(this.transObjB_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.treeView1.Location = new System.Drawing.Point(-1, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "holder";
            treeNode1.Text = "Правообладатель";
            treeNode2.Name = "register";
            treeNode2.Text = "Регистрация прав собственности";
            treeNode3.Name = "place";
            treeNode3.Text = "Земельный участок";
            treeNode4.Name = "koordinati";
            treeNode4.Text = "Координаты участка";
            treeNode5.Name = "object";
            treeNode5.Text = "Объект недвижимости";
            treeNode6.Name = "parametrs";
            treeNode6.Text = "Характеристики объекта";
            treeNode7.Name = "root";
            treeNode7.Text = "Кадастровая база ";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.treeView1.Scrollable = false;
            this.treeView1.Size = new System.Drawing.Size(242, 288);
            this.treeView1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(413, 3);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(64, 57);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(295, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Подключение к БД";
            // 
            // contextHolder
            // 
            this.contextHolder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHolder,
            this.addHolder,
            this.updateHolder,
            this.deleteHolder});
            this.contextHolder.Name = "contextHolder";
            this.contextHolder.Size = new System.Drawing.Size(181, 92);
            // 
            // showHolder
            // 
            this.showHolder.Name = "showHolder";
            this.showHolder.Size = new System.Drawing.Size(180, 22);
            this.showHolder.Text = "Вывод всех данных";
            this.showHolder.Click += new System.EventHandler(this.showHolder_Click);
            // 
            // addHolder
            // 
            this.addHolder.Name = "addHolder";
            this.addHolder.Size = new System.Drawing.Size(180, 22);
            this.addHolder.Text = "Добавить данные";
            this.addHolder.Click += new System.EventHandler(this.addHolder_Click);
            // 
            // updateHolder
            // 
            this.updateHolder.Name = "updateHolder";
            this.updateHolder.Size = new System.Drawing.Size(180, 22);
            this.updateHolder.Text = "Обновить данные";
            this.updateHolder.Click += new System.EventHandler(this.updateHolder_Click);
            // 
            // deleteHolder
            // 
            this.deleteHolder.Name = "deleteHolder";
            this.deleteHolder.Size = new System.Drawing.Size(180, 22);
            this.deleteHolder.Text = "Удалить данные";
            this.deleteHolder.Click += new System.EventHandler(this.deleteHolder_Click);
            // 
            // contextRegister
            // 
            this.contextRegister.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showRegister,
            this.addRegister,
            this.updateRegister,
            this.deleteRegister});
            this.contextRegister.Name = "contextRegister";
            this.contextRegister.Size = new System.Drawing.Size(181, 92);
            // 
            // showRegister
            // 
            this.showRegister.Name = "showRegister";
            this.showRegister.Size = new System.Drawing.Size(180, 22);
            this.showRegister.Text = "Вывод всех данных";
            this.showRegister.Click += new System.EventHandler(this.showRegister_Click);
            // 
            // addRegister
            // 
            this.addRegister.Name = "addRegister";
            this.addRegister.Size = new System.Drawing.Size(180, 22);
            this.addRegister.Text = "Добавить данные ";
            this.addRegister.Click += new System.EventHandler(this.addRegister_Click);
            // 
            // updateRegister
            // 
            this.updateRegister.Name = "updateRegister";
            this.updateRegister.Size = new System.Drawing.Size(180, 22);
            this.updateRegister.Text = "Обновить данные";
            this.updateRegister.Click += new System.EventHandler(this.updateRegister_Click);
            // 
            // deleteRegister
            // 
            this.deleteRegister.Name = "deleteRegister";
            this.deleteRegister.Size = new System.Drawing.Size(180, 22);
            this.deleteRegister.Text = "Удалить данные ";
            this.deleteRegister.Click += new System.EventHandler(this.deleteRegister_Click);
            // 
            // contextPlace
            // 
            this.contextPlace.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.contextPlace.Name = "contextPlace";
            this.contextPlace.Size = new System.Drawing.Size(181, 92);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Вывод всех данных";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Добавить данные";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.addPlace_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "Обновить данные";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.updatePlace_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "Удалить данные";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.deletePlace_Click);
            // 
            // contextKoordinati
            // 
            this.contextKoordinati.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.contextKoordinati.Name = "contextKoordinati";
            this.contextKoordinati.Size = new System.Drawing.Size(181, 92);
            this.contextKoordinati.Click += new System.EventHandler(this.contextKoordinati_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem5.Text = "Вывод всех данных";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem6.Text = "Добавить данные";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.addKoordinati_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem7.Text = "Обновить данные";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.updateKoordinati_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem8.Text = "Удалить данные";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.deleteKoordinati_Click);
            // 
            // contextObject
            // 
            this.contextObject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12});
            this.contextObject.Name = "contextObject";
            this.contextObject.Size = new System.Drawing.Size(181, 92);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem9.Text = "Вывод всех данных";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem10.Text = "Добавить данные";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.addObject_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem11.Text = "Обновить данные";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.updateObject_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem12.Text = "Удалить данные";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.deleteObject_Click);
            // 
            // contextParametrs
            // 
            this.contextParametrs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem13,
            this.toolStripMenuItem14,
            this.toolStripMenuItem15,
            this.toolStripMenuItem16});
            this.contextParametrs.Name = "contextParametrs";
            this.contextParametrs.Size = new System.Drawing.Size(181, 92);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem13.Text = "Вывод всех данных";
            this.toolStripMenuItem13.Click += new System.EventHandler(this.toolStripMenuItem13_Click);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem14.Text = "Добавить данные";
            this.toolStripMenuItem14.Click += new System.EventHandler(this.addParametrs_Click);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem15.Text = "Обновить данные";
            this.toolStripMenuItem15.Click += new System.EventHandler(this.updateParametrs_Click);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem16.Text = "Удалить данные";
            this.toolStripMenuItem16.Click += new System.EventHandler(this.deleteParametrs_Click);
            // 
            // infoB
            // 
            this.infoB.Image = ((System.Drawing.Image)(resources.GetObject("infoB.Image")));
            this.infoB.Location = new System.Drawing.Point(804, 438);
            this.infoB.Name = "infoB";
            this.infoB.Size = new System.Drawing.Size(48, 41);
            this.infoB.TabIndex = 17;
            this.infoB.UseVisualStyleBackColor = true;
            this.infoB.Click += new System.EventHandler(this.infoB_Click);
            // 
            // MainPage
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(864, 506);
            this.Controls.Add(this.infoB);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.transObjB);
            this.Controls.Add(this.refreshObjB);
            this.Controls.Add(this.commercialB);
            this.Controls.Add(this.reviewB);
            this.Controls.Add(this.holderObjB);
            this.Controls.Add(this.holderPlaceB);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainPage";
            this.Text = "Система администрирования базы данных";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextHolder.ResumeLayout(false);
            this.contextRegister.ResumeLayout(false);
            this.contextPlace.ResumeLayout(false);
            this.contextKoordinati.ResumeLayout(false);
            this.contextObject.ResumeLayout(false);
            this.contextParametrs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button holderPlaceB;
        private Button holderObjB;
        private Button reviewB;
        private Button commercialB;
        private Button refreshObjB;
        private Button transObjB;
        private TreeView treeView1;
        private Button button1;
        private Label label1;
        private ContextMenuStrip contextHolder;
        private ToolStripMenuItem showHolder;
        private ToolStripMenuItem addHolder;
        private ToolStripMenuItem updateHolder;
        private ToolStripMenuItem deleteHolder;
        private ContextMenuStrip contextRegister;
        private ToolStripMenuItem showRegister;
        private ToolStripMenuItem addRegister;
        private ToolStripMenuItem updateRegister;
        private ToolStripMenuItem deleteRegister;
        private ContextMenuStrip contextPlace;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ContextMenuStrip contextKoordinati;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private ContextMenuStrip contextObject;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem toolStripMenuItem10;
        private ToolStripMenuItem toolStripMenuItem11;
        private ToolStripMenuItem toolStripMenuItem12;
        private ContextMenuStrip contextParametrs;
        private ToolStripMenuItem toolStripMenuItem13;
        private ToolStripMenuItem toolStripMenuItem14;
        private ToolStripMenuItem toolStripMenuItem15;
        private ToolStripMenuItem toolStripMenuItem16;
        public Button infoB;
    }
}
