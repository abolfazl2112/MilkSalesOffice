namespace system
{
    partial class markaz
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.btnLeft = new DevComponents.DotNetBar.ButtonX();
            this.btnCenter = new DevComponents.DotNetBar.ButtonX();
            this.btnRight = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn3 = new DevComponents.DotNetBar.ButtonX();
            this.btn2 = new DevComponents.DotNetBar.ButtonX();
            this.btn4 = new DevComponents.DotNetBar.ButtonX();
            this.btn1 = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btn0 = new DevComponents.DotNetBar.ButtonX();
            this.txt2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.mtxt1 = new System.Windows.Forms.MaskedTextBox();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.codemarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new system.DataSet();
            this.markazTableAdapter = new system.DataSetTableAdapters.markazTableAdapter();
            this.itemPanel1.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markazBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // itemPanel1
            // 
            // 
            // 
            // 
            this.itemPanel1.BackgroundStyle.Class = "ItemPanel";
            this.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel1.ContainerControlProcessDialogKey = true;
            this.itemPanel1.Controls.Add(this.btnLeft);
            this.itemPanel1.Controls.Add(this.btnCenter);
            this.itemPanel1.Controls.Add(this.btnRight);
            this.itemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanel1.Location = new System.Drawing.Point(12, 12);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(826, 51);
            this.itemPanel1.TabIndex = 4;
            this.itemPanel1.TabStop = false;
            this.itemPanel1.Text = "itemPanel1";
            // 
            // btnLeft
            // 
            this.btnLeft.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLeft.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLeft.Font = new System.Drawing.Font("B Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnLeft.Location = new System.Drawing.Point(3, 4);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLeft.Size = new System.Drawing.Size(204, 43);
            this.btnLeft.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLeft.TabIndex = 8;
            this.btnLeft.TabStop = false;
            this.btnLeft.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn1_KeyDown);
            // 
            // btnCenter
            // 
            this.btnCenter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCenter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCenter.Font = new System.Drawing.Font("B Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCenter.Location = new System.Drawing.Point(213, 4);
            this.btnCenter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(391, 43);
            this.btnCenter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCenter.TabIndex = 7;
            this.btnCenter.TabStop = false;
            this.btnCenter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn1_KeyDown);
            // 
            // btnRight
            // 
            this.btnRight.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRight.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRight.Font = new System.Drawing.Font("B Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRight.Location = new System.Drawing.Point(610, 4);
            this.btnRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(209, 43);
            this.btnRight.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRight.TabIndex = 6;
            this.btnRight.TabStop = false;
            this.btnRight.Text = "چاپ";
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            this.btnRight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn1_KeyDown);
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.btn3);
            this.groupPanel3.Controls.Add(this.btn2);
            this.groupPanel3.Controls.Add(this.btn4);
            this.groupPanel3.Controls.Add(this.btn1);
            this.groupPanel3.Location = new System.Drawing.Point(12, 389);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(826, 57);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 12;
            // 
            // btn3
            // 
            this.btn3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn3.Image = global::system.Properties.Resources.delete_;
            this.btn3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btn3.Location = new System.Drawing.Point(214, 3);
            this.btn3.Name = "btn3";
            this.btn3.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.btn3.Size = new System.Drawing.Size(204, 41);
            this.btn3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn3.TabIndex = 3;
            this.btn3.Text = "حذف";
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            this.btn3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn1_KeyDown);
            // 
            // btn2
            // 
            this.btn2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn2.Image = global::system.Properties.Resources.edit;
            this.btn2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btn2.Location = new System.Drawing.Point(424, 3);
            this.btn2.Name = "btn2";
            this.btn2.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2);
            this.btn2.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.ShiftIns);
            this.btn2.Size = new System.Drawing.Size(185, 41);
            this.btn2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn2.TabIndex = 2;
            this.btn2.Text = "ویرایش";
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            this.btn2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn1_KeyDown);
            // 
            // btn4
            // 
            this.btn4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn4.Image = global::system.Properties.Resources.back;
            this.btn4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btn4.Location = new System.Drawing.Point(3, 3);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(205, 41);
            this.btn4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn4.TabIndex = 4;
            this.btn4.Text = "خروج";
            this.btn4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn1_KeyDown);
            // 
            // btn1
            // 
            this.btn1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn1.Image = global::system.Properties.Resources.adding;
            this.btn1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btn1.Location = new System.Drawing.Point(615, 3);
            this.btn1.Name = "btn1";
            this.btn1.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            this.btn1.Size = new System.Drawing.Size(202, 41);
            this.btn1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn1.TabIndex = 1;
            this.btn1.Text = "جدید";
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            this.btn1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn1_KeyDown);
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.buttonX1);
            this.groupPanel2.Controls.Add(this.btn0);
            this.groupPanel2.Controls.Add(this.txt2);
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.Controls.Add(this.labelX1);
            this.groupPanel2.Controls.Add(this.mtxt1);
            this.groupPanel2.Enabled = false;
            this.groupPanel2.Location = new System.Drawing.Point(622, 69);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(216, 314);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 11;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::system.Properties.Resources.back;
            this.buttonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonX1.Location = new System.Drawing.Point(3, 256);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(83, 49);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 3;
            this.buttonX1.Text = "انصراف";
            // 
            // btn0
            // 
            this.btn0.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn0.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn0.Image = global::system.Properties.Resources.ok;
            this.btn0.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btn0.Location = new System.Drawing.Point(92, 256);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(83, 49);
            this.btn0.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn0.TabIndex = 2;
            this.btn0.Text = "تایید";
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            this.btn0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // txt2
            // 
            // 
            // 
            // 
            this.txt2.Border.Class = "TextBoxBorder";
            this.txt2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt2.Location = new System.Drawing.Point(3, 43);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(148, 20);
            this.txt2.TabIndex = 1;
            this.txt2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt2_KeyDown);
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(157, 44);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(34, 15);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "نام مرکز";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(157, 19);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(33, 15);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "کد مرکز";
            // 
            // mtxt1
            // 
            this.mtxt1.Location = new System.Drawing.Point(89, 17);
            this.mtxt1.Mask = "0000";
            this.mtxt1.Name = "mtxt1";
            this.mtxt1.Size = new System.Drawing.Size(62, 20);
            this.mtxt1.TabIndex = 0;
            this.mtxt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxt1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxt1_KeyDown);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dataGridViewX1);
            this.groupPanel1.Location = new System.Drawing.Point(12, 69);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(604, 314);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 10;
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.AllowUserToDeleteRows = false;
            this.dataGridViewX1.AutoGenerateColumns = false;
            this.dataGridViewX1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codemarDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridViewX1.DataSource = this.markazBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.ReadOnly = true;
            this.dataGridViewX1.Size = new System.Drawing.Size(592, 302);
            this.dataGridViewX1.TabIndex = 0;
            this.dataGridViewX1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewX1_KeyDown);
            // 
            // codemarDataGridViewTextBoxColumn
            // 
            this.codemarDataGridViewTextBoxColumn.DataPropertyName = "codemar";
            this.codemarDataGridViewTextBoxColumn.HeaderText = "کد مرکز";
            this.codemarDataGridViewTextBoxColumn.Name = "codemarDataGridViewTextBoxColumn";
            this.codemarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام مرکز";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // markazBindingSource
            // 
            this.markazBindingSource.DataMember = "markaz";
            this.markazBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // markazTableAdapter
            // 
            this.markazTableAdapter.ClearBeforeFill = true;
            // 
            // markaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 454);
            this.ControlBox = false;
            this.Controls.Add(this.groupPanel3);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.itemPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "markaz";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست مراکز";
            this.Load += new System.EventHandler(this.markaz_Load);
            this.itemPanel1.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markazBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.ButtonX btnLeft;
        private DevComponents.DotNetBar.ButtonX btnCenter;
        private DevComponents.DotNetBar.ButtonX btnRight;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.ButtonX btn3;
        private DevComponents.DotNetBar.ButtonX btn2;
        private DevComponents.DotNetBar.ButtonX btn4;
        private DevComponents.DotNetBar.ButtonX btn1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX btn0;
        private DevComponents.DotNetBar.Controls.TextBoxX txt2;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.MaskedTextBox mtxt1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource markazBindingSource;
        private system.DataSetTableAdapters.markazTableAdapter markazTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codemarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}