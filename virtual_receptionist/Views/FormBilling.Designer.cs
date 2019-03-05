﻿namespace virtual_receptionist.Views
{
    partial class FormBilling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBilling));
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.ColumnItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPrintInvoice = new System.Windows.Forms.Button();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.buttonUpdateItem = new System.Windows.Forms.Button();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.printDialogPrinter = new System.Windows.Forms.PrintDialog();
            this.printDocumentInvoice = new System.Drawing.Printing.PrintDocument();
            this.groupBoxBillingData = new System.Windows.Forms.GroupBox();
            this.listViewToBill = new System.Windows.Forms.ListView();
            this.columnHeaderBookingID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGuest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRoom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNumberOfGuests = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderArrivalDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDepartureDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxBookingToBill = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.groupBoxBookingToBill.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.AllowUserToDeleteRows = false;
            this.dataGridViewItems.AllowUserToResizeColumns = false;
            this.dataGridViewItems.AllowUserToResizeRows = false;
            this.dataGridViewItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnItem,
            this.ColumnPrice,
            this.ColumnUnit,
            this.ColumnQuantity});
            this.dataGridViewItems.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewItems.MultiSelect = false;
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.ReadOnly = true;
            this.dataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItems.Size = new System.Drawing.Size(874, 274);
            this.dataGridViewItems.TabIndex = 8;
            this.dataGridViewItems.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewItems_RowsAdded);
            this.dataGridViewItems.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewItems_RowsRemoved);
            // 
            // ColumnItem
            // 
            this.ColumnItem.DataPropertyName = "Tétel";
            this.ColumnItem.HeaderText = "Tétel";
            this.ColumnItem.Name = "ColumnItem";
            this.ColumnItem.ReadOnly = true;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.DataPropertyName = "Ár";
            this.ColumnPrice.HeaderText = "Ár";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            // 
            // ColumnUnit
            // 
            this.ColumnUnit.DataPropertyName = "Egység";
            this.ColumnUnit.HeaderText = "Egység";
            this.ColumnUnit.Name = "ColumnUnit";
            this.ColumnUnit.ReadOnly = true;
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.DataPropertyName = "Mennyiség";
            this.ColumnQuantity.HeaderText = "Mennyiség";
            this.ColumnQuantity.Name = "ColumnQuantity";
            this.ColumnQuantity.ReadOnly = true;
            // 
            // buttonPrintInvoice
            // 
            this.buttonPrintInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrintInvoice.Enabled = false;
            this.buttonPrintInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPrintInvoice.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrintInvoice.Image")));
            this.buttonPrintInvoice.Location = new System.Drawing.Point(892, 222);
            this.buttonPrintInvoice.Name = "buttonPrintInvoice";
            this.buttonPrintInvoice.Size = new System.Drawing.Size(157, 64);
            this.buttonPrintInvoice.TabIndex = 5;
            this.buttonPrintInvoice.Text = "Számla nyomtatása";
            this.buttonPrintInvoice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPrintInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonPrintInvoice.UseVisualStyleBackColor = true;
            this.buttonPrintInvoice.Click += new System.EventHandler(this.buttonPrintInvoice_Click);
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddItem.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddItem.Image")));
            this.buttonAddItem.Location = new System.Drawing.Point(892, 12);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(157, 64);
            this.buttonAddItem.TabIndex = 2;
            this.buttonAddItem.Text = "Tétel hozzáadása";
            this.buttonAddItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // buttonUpdateItem
            // 
            this.buttonUpdateItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdateItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdateItem.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdateItem.Image")));
            this.buttonUpdateItem.Location = new System.Drawing.Point(892, 82);
            this.buttonUpdateItem.Name = "buttonUpdateItem";
            this.buttonUpdateItem.Size = new System.Drawing.Size(157, 64);
            this.buttonUpdateItem.TabIndex = 3;
            this.buttonUpdateItem.Text = "Tétel módosítása";
            this.buttonUpdateItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUpdateItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonUpdateItem.UseVisualStyleBackColor = true;
            this.buttonUpdateItem.Click += new System.EventHandler(this.buttonUpdateItem_Click);
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteItem.Image")));
            this.buttonDeleteItem.Location = new System.Drawing.Point(892, 152);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(157, 64);
            this.buttonDeleteItem.TabIndex = 4;
            this.buttonDeleteItem.Text = "Tétel törlése";
            this.buttonDeleteItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDeleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDeleteItem.UseVisualStyleBackColor = true;
            this.buttonDeleteItem.Click += new System.EventHandler(this.buttonDeleteItem_Click);
            // 
            // printDialogPrinter
            // 
            this.printDialogPrinter.UseEXDialog = true;
            // 
            // groupBoxBillingData
            // 
            this.groupBoxBillingData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBillingData.Location = new System.Drawing.Point(577, 292);
            this.groupBoxBillingData.Name = "groupBoxBillingData";
            this.groupBoxBillingData.Size = new System.Drawing.Size(472, 265);
            this.groupBoxBillingData.TabIndex = 9;
            this.groupBoxBillingData.TabStop = false;
            this.groupBoxBillingData.Text = "Számlázási adatok";
            // 
            // listViewToBill
            // 
            this.listViewToBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewToBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderBookingID,
            this.columnGuest,
            this.columnHeaderRoom,
            this.columnHeaderNumberOfGuests,
            this.columnHeaderArrivalDate,
            this.columnHeaderDepartureDate});
            this.listViewToBill.GridLines = true;
            this.listViewToBill.Location = new System.Drawing.Point(6, 19);
            this.listViewToBill.MultiSelect = false;
            this.listViewToBill.Name = "listViewToBill";
            this.listViewToBill.Size = new System.Drawing.Size(547, 240);
            this.listViewToBill.TabIndex = 10;
            this.listViewToBill.UseCompatibleStateImageBehavior = false;
            this.listViewToBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderBookingID
            // 
            this.columnHeaderBookingID.Text = "Foglalás azonosító";
            this.columnHeaderBookingID.Width = 150;
            // 
            // columnGuest
            // 
            this.columnGuest.Text = "Vendég neve";
            this.columnGuest.Width = 150;
            // 
            // columnHeaderRoom
            // 
            this.columnHeaderRoom.Text = "Szoba";
            this.columnHeaderRoom.Width = 150;
            // 
            // columnHeaderNumberOfGuests
            // 
            this.columnHeaderNumberOfGuests.Text = "Vendégszám";
            this.columnHeaderNumberOfGuests.Width = 150;
            // 
            // columnHeaderArrivalDate
            // 
            this.columnHeaderArrivalDate.Text = "Érkezés";
            this.columnHeaderArrivalDate.Width = 150;
            // 
            // columnHeaderDepartureDate
            // 
            this.columnHeaderDepartureDate.Text = "Távozás";
            this.columnHeaderDepartureDate.Width = 150;
            // 
            // groupBoxBookingToBill
            // 
            this.groupBoxBookingToBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBookingToBill.Controls.Add(this.listViewToBill);
            this.groupBoxBookingToBill.Location = new System.Drawing.Point(12, 292);
            this.groupBoxBookingToBill.Name = "groupBoxBookingToBill";
            this.groupBoxBookingToBill.Size = new System.Drawing.Size(559, 265);
            this.groupBoxBookingToBill.TabIndex = 11;
            this.groupBoxBookingToBill.TabStop = false;
            this.groupBoxBookingToBill.Text = "Számlázandó foglalás";
            // 
            // FormBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 569);
            this.Controls.Add(this.groupBoxBookingToBill);
            this.Controls.Add(this.groupBoxBillingData);
            this.Controls.Add(this.buttonDeleteItem);
            this.Controls.Add(this.buttonUpdateItem);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.buttonPrintInvoice);
            this.Controls.Add(this.dataGridViewItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Számla kiállítása | Virtual Receptionist";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.groupBoxBookingToBill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.Button buttonPrintInvoice;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Button buttonUpdateItem;
        private System.Windows.Forms.Button buttonDeleteItem;
        private System.Windows.Forms.PrintDialog printDialogPrinter;
        private System.Drawing.Printing.PrintDocument printDocumentInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
        private System.Windows.Forms.GroupBox groupBoxBillingData;
        private System.Windows.Forms.ListView listViewToBill;
        private System.Windows.Forms.ColumnHeader columnHeaderBookingID;
        private System.Windows.Forms.ColumnHeader columnGuest;
        private System.Windows.Forms.ColumnHeader columnHeaderRoom;
        private System.Windows.Forms.ColumnHeader columnHeaderNumberOfGuests;
        private System.Windows.Forms.ColumnHeader columnHeaderArrivalDate;
        private System.Windows.Forms.ColumnHeader columnHeaderDepartureDate;
        private System.Windows.Forms.GroupBox groupBoxBookingToBill;
    }
}
