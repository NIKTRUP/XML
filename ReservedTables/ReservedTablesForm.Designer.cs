
namespace ReservedTables
{
    partial class ReservedTablesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservedTablesForm));
            this.bt_serialization = new System.Windows.Forms.Button();
            this.MainPage = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bе_deserialization = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.bt_menu = new System.Windows.Forms.ToolStripSplitButton();
            this.label_deleteClient = new System.Windows.Forms.ToolStripLabel();
            this.deleteTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.bt_deleteByValue = new System.Windows.Forms.ToolStripButton();
            this.MainPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_serialization
            // 
            this.bt_serialization.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_serialization.Location = new System.Drawing.Point(0, 0);
            this.bt_serialization.Name = "bt_serialization";
            this.bt_serialization.Size = new System.Drawing.Size(130, 44);
            this.bt_serialization.TabIndex = 1;
            this.bt_serialization.Text = "Сериализация";
            this.bt_serialization.UseVisualStyleBackColor = true;
            this.bt_serialization.Click += new System.EventHandler(this.bt_serialization_Click);
            // 
            // MainPage
            // 
            this.MainPage.ColumnCount = 2;
            this.MainPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.MainPage.Controls.Add(this.panel1, 1, 0);
            this.MainPage.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.MainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPage.Location = new System.Drawing.Point(0, 0);
            this.MainPage.Name = "MainPage";
            this.MainPage.RowCount = 1;
            this.MainPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainPage.Size = new System.Drawing.Size(723, 401);
            this.MainPage.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_clear);
            this.panel1.Controls.Add(this.bе_deserialization);
            this.panel1.Controls.Add(this.bt_delete);
            this.panel1.Controls.Add(this.bt_serialization);
            this.panel1.Location = new System.Drawing.Point(588, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 365);
            this.panel1.TabIndex = 1;
            // 
            // bt_clear
            // 
            this.bt_clear.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_clear.Location = new System.Drawing.Point(0, 150);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(130, 44);
            this.bt_clear.TabIndex = 4;
            this.bt_clear.Text = "Очистить всё";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // bе_deserialization
            // 
            this.bе_deserialization.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bе_deserialization.Location = new System.Drawing.Point(0, 50);
            this.bе_deserialization.Name = "bе_deserialization";
            this.bе_deserialization.Size = new System.Drawing.Size(130, 44);
            this.bе_deserialization.TabIndex = 3;
            this.bе_deserialization.Text = "Десериализация";
            this.bе_deserialization.UseVisualStyleBackColor = true;
            this.bе_deserialization.Click += new System.EventHandler(this.bе_deserialization_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_delete.Location = new System.Drawing.Point(0, 100);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(130, 44);
            this.bt_delete.TabIndex = 2;
            this.bt_delete.Text = "Удалить";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.mainToolStrip, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.582278F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.41772F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(579, 395);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.FullName,
            this.tableNumber,
            this.reservationTime,
            this.age,
            this.phoneNumber});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 28);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(573, 364);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.Format = "N0";
            this.id.DefaultCellStyle = dataGridViewCellStyle5;
            this.id.FillWeight = 76.14214F;
            this.id.HeaderText = "id";
            this.id.MaxInputLength = 3;
            this.id.MinimumWidth = 25;
            this.id.Name = "id";
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.ToolTipText = "Номер Клиента";
            this.id.Width = 40;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.FillWeight = 104.7716F;
            this.FullName.HeaderText = "ФИО";
            this.FullName.MaxInputLength = 50;
            this.FullName.Name = "FullName";
            this.FullName.ToolTipText = "Фамилия Имя Отчество";
            // 
            // tableNumber
            // 
            this.tableNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tableNumber.FillWeight = 104.7716F;
            this.tableNumber.HeaderText = "Номер столика";
            this.tableNumber.MaxInputLength = 3;
            this.tableNumber.Name = "tableNumber";
            this.tableNumber.ToolTipText = "Номер столика";
            // 
            // reservationTime
            // 
            this.reservationTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Format = "t";
            dataGridViewCellStyle6.NullValue = null;
            this.reservationTime.DefaultCellStyle = dataGridViewCellStyle6;
            this.reservationTime.FillWeight = 104.7716F;
            this.reservationTime.HeaderText = "Время";
            this.reservationTime.MaxInputLength = 5;
            this.reservationTime.Name = "reservationTime";
            this.reservationTime.ToolTipText = "Время начала брони (бронь всегда не более 2ч)";
            // 
            // age
            // 
            this.age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            this.age.DefaultCellStyle = dataGridViewCellStyle7;
            this.age.FillWeight = 104.7716F;
            this.age.HeaderText = "Возраст";
            this.age.MaxInputLength = 3;
            this.age.Name = "age";
            this.age.ToolTipText = "Возраст клиента для статистики";
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = null;
            this.phoneNumber.DefaultCellStyle = dataGridViewCellStyle8;
            this.phoneNumber.FillWeight = 104.7716F;
            this.phoneNumber.HeaderText = "Номер Телефона";
            this.phoneNumber.MaxInputLength = 11;
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.ToolTipText = "Номер телефона клиента (отправить автоматическое напоминание , позвонить)";
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bt_menu,
            this.label_deleteClient,
            this.deleteTextBox,
            this.bt_deleteByValue});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(579, 25);
            this.mainToolStrip.TabIndex = 6;
            this.mainToolStrip.Text = "Меню";
            // 
            // bt_menu
            // 
            this.bt_menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_menu.Image = ((System.Drawing.Image)(resources.GetObject("bt_menu.Image")));
            this.bt_menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_menu.Name = "bt_menu";
            this.bt_menu.Size = new System.Drawing.Size(32, 22);
            this.bt_menu.Text = "Меню";
            // 
            // label_deleteClient
            // 
            this.label_deleteClient.Name = "label_deleteClient";
            this.label_deleteClient.Size = new System.Drawing.Size(105, 22);
            this.label_deleteClient.Text = "Удалить Клиента :";
            // 
            // deleteTextBox
            // 
            this.deleteTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteTextBox.Name = "deleteTextBox";
            this.deleteTextBox.Size = new System.Drawing.Size(100, 25);
            this.deleteTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.deleteTextBox_KeyDown);
            // 
            // bt_deleteByValue
            // 
            this.bt_deleteByValue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_deleteByValue.Image = ((System.Drawing.Image)(resources.GetObject("bt_deleteByValue.Image")));
            this.bt_deleteByValue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_deleteByValue.Name = "bt_deleteByValue";
            this.bt_deleteByValue.Size = new System.Drawing.Size(23, 22);
            this.bt_deleteByValue.Text = "Удалить по значению";
            this.bt_deleteByValue.Click += new System.EventHandler(this.bt_deleteByValue_Click);
            // 
            // ReservedTablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 401);
            this.Controls.Add(this.MainPage);
            this.Name = "ReservedTablesForm";
            this.Text = "ReservedTables";
            this.Load += new System.EventHandler(this.ReservedTablesForm_Load);
            this.MainPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_serialization;
        private System.Windows.Forms.TableLayoutPanel MainPage;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bе_deserialization;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripLabel label_deleteClient;
        private System.Windows.Forms.ToolStripTextBox deleteTextBox;
        private System.Windows.Forms.ToolStripButton bt_deleteByValue;
        private System.Windows.Forms.ToolStripSplitButton bt_menu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

