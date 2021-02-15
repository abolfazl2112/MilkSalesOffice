namespace system
{
    partial class analizeshir_list
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btn2 = new DevComponents.DotNetBar.ButtonX();
            this.btn1 = new DevComponents.DotNetBar.ButtonX();
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.btnLeft = new DevComponents.DotNetBar.ButtonX();
            this.btnCenter = new DevComponents.DotNetBar.ButtonX();
            this.btnRight = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.codemoshDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nobatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charbiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.microbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tozihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analizeshirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new system.DataSet();
            this.analizeshirTableAdapter = new system.DataSetTableAdapters.analizeshirTableAdapter();
            this.groupPanel1.SuspendLayout();
            this.itemPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analizeshirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.buttonX2);
            this.groupPanel1.Controls.Add(this.buttonX1);
            this.groupPanel1.Controls.Add(this.btn2);
            this.groupPanel1.Controls.Add(this.btn1);
            this.groupPanel1.Location = new System.Drawing.Point(12, 391);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(826, 55);
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
            this.groupPanel1.TabIndex = 12;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Image = global::system.Properties.Resources.delete_;
            this.buttonX2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonX2.Location = new System.Drawing.Point(214, 3);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.buttonX2.Size = new System.Drawing.Size(196, 41);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 19;
            this.buttonX2.Text = "حذف";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            this.buttonX2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn1_KeyDown);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::system.Properties.Resources.edit;
            this.buttonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonX1.Location = new System.Drawing.Point(416, 3);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2);
            this.buttonX1.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.ShiftIns);
            this.buttonX1.Size = new System.Drawing.Size(185, 41);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 18;
            this.buttonX1.Text = "ویرایش";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            this.buttonX1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn1_KeyDown);
            // 
            // btn2
            // 
            this.btn2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn2.Image = global::system.Properties.Resources.back;
            this.btn2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btn2.Location = new System.Drawing.Point(3, 3);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(201, 41);
            this.btn2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn2.TabIndex = 17;
            this.btn2.Text = "خروج";
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            this.btn2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn1_KeyDown);
            // 
            // btn1
            // 
            this.btn1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn1.Image = global::system.Properties.Resources.adding;
            this.btn1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btn1.Location = new System.Drawing.Point(607, 3);
            this.btn1.Name = "btn1";
            this.btn1.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            this.btn1.Size = new System.Drawing.Size(206, 41);
            this.btn1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn1.TabIndex = 16;
            this.btn1.Text = "جدید";
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            this.btn1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn1_KeyDown);
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
            this.itemPanel1.Size = new System.Drawing.Size(826, 50);
            this.itemPanel1.TabIndex = 11;
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
            this.btnLeft.Size = new System.Drawing.Size(204, 42);
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
            this.btnCenter.Size = new System.Drawing.Size(391, 42);
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
            this.btnRight.Size = new System.Drawing.Size(213, 42);
            this.btnRight.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRight.TabIndex = 6;
            this.btnRight.TabStop = false;
            this.btnRight.Text = "چاپ لیست";
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            this.btnRight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn1_KeyDown);
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.dataGridViewX1);
            this.groupPanel2.Location = new System.Drawing.Point(12, 68);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(826, 317);
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
            this.groupPanel2.TabIndex = 10;
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.AllowUserToDeleteRows = false;
            this.dataGridViewX1.AutoGenerateColumns = false;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codemoshDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.nobatDataGridViewTextBoxColumn,
            this.charbiDataGridViewTextBoxColumn,
            this.damaDataGridViewTextBoxColumn,
            this.microbDataGridViewTextBoxColumn,
            this.tozihDataGridViewTextBoxColumn});
            this.dataGridViewX1.DataSource = this.analizeshirBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.ReadOnly = true;
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX1.Size = new System.Drawing.Size(814, 305);
            this.dataGridViewX1.TabIndex = 0;
            this.dataGridViewX1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewX1_KeyDown);
            // 
            // codemoshDataGridViewTextBoxColumn
            // 
            this.codemoshDataGridViewTextBoxColumn.DataPropertyName = "codemosh";
            this.codemoshDataGridViewTextBoxColumn.HeaderText = "کد مشتری";
            this.codemoshDataGridViewTextBoxColumn.Name = "codemoshDataGridViewTextBoxColumn";
            this.codemoshDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام مشتری";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "تاریخ";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nobatDataGridViewTextBoxColumn
            // 
            this.nobatDataGridViewTextBoxColumn.DataPropertyName = "nobat";
            this.nobatDataGridViewTextBoxColumn.HeaderText = "نوبت کاری";
            this.nobatDataGridViewTextBoxColumn.Name = "nobatDataGridViewTextBoxColumn";
            this.nobatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // charbiDataGridViewTextBoxColumn
            // 
            this.charbiDataGridViewTextBoxColumn.DataPropertyName = "charbi";
            this.charbiDataGridViewTextBoxColumn.HeaderText = "درصد چربی";
            this.charbiDataGridViewTextBoxColumn.Name = "charbiDataGridViewTextBoxColumn";
            this.charbiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // damaDataGridViewTextBoxColumn
            // 
            this.damaDataGridViewTextBoxColumn.DataPropertyName = "dama";
            this.damaDataGridViewTextBoxColumn.HeaderText = "دما";
            this.damaDataGridViewTextBoxColumn.Name = "damaDataGridViewTextBoxColumn";
            this.damaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // microbDataGridViewTextBoxColumn
            // 
            this.microbDataGridViewTextBoxColumn.DataPropertyName = "microb";
            this.microbDataGridViewTextBoxColumn.HeaderText = "بار میکربی";
            this.microbDataGridViewTextBoxColumn.Name = "microbDataGridViewTextBoxColumn";
            this.microbDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tozihDataGridViewTextBoxColumn
            // 
            this.tozihDataGridViewTextBoxColumn.DataPropertyName = "tozih";
            this.tozihDataGridViewTextBoxColumn.HeaderText = "توضیحات";
            this.tozihDataGridViewTextBoxColumn.Name = "tozihDataGridViewTextBoxColumn";
            this.tozihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // analizeshirBindingSource
            // 
            this.analizeshirBindingSource.DataMember = "analizeshir";
            this.analizeshirBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // analizeshirTableAdapter
            // 
            this.analizeshirTableAdapter.ClearBeforeFill = true;
            // 
            // analizeshir_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 446);
            this.ControlBox = false;
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.itemPanel1);
            this.Controls.Add(this.groupPanel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "analizeshir_list";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست آنالیز شیر";
            this.Load += new System.EventHandler(this.analizeshir_list_Load);
            this.groupPanel1.ResumeLayout(false);
            this.itemPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analizeshirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX btn2;
        private DevComponents.DotNetBar.ButtonX btn1;
        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.ButtonX btnLeft;
        private DevComponents.DotNetBar.ButtonX btnCenter;
        private DevComponents.DotNetBar.ButtonX btnRight;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource analizeshirBindingSource;
        private system.DataSetTableAdapters.analizeshirTableAdapter analizeshirTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codemoshDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nobatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn charbiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn damaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn microbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tozihDataGridViewTextBoxColumn;
    }
}