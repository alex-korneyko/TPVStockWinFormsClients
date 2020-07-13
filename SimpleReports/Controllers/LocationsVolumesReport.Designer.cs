using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;
using HttpResource;
using SimpleReports.Model.Domain.DataViewObjects;

namespace SimpleReports.Controllers
{
    partial class LocationsVolumesReport
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridVolReports = new System.Windows.Forms.DataGridView();
            this.LocationCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PArtNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quontity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FillCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolumeStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolumeState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridVolReports)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridVolReports
            // 
            this.dataGridVolReports.AllowUserToOrderColumns = true;
            this.dataGridVolReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVolReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVolReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.LocationCode, this.PArtNo, this.Capacity, this.Quontity, this.FillCount, this.VolumeStatus, this.VolumeState});
            this.dataGridVolReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridVolReports.Location = new System.Drawing.Point(0, 0);
            this.dataGridVolReports.Name = "dataGridVolReports";
            this.dataGridVolReports.RowHeadersVisible = false;
            this.dataGridVolReports.Size = new System.Drawing.Size(809, 515);
            this.dataGridVolReports.TabIndex = 0;
            this.dataGridVolReports.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(HeaderMouseClick);
            // 
            // LocationCode
            // 
            this.LocationCode.DataPropertyName = "StockLocationCode";
            this.LocationCode.FillWeight = 80F;
            this.LocationCode.HeaderText = "Location Code";
            this.LocationCode.Name = "LocationCode";
            this.LocationCode.ReadOnly = true;
            this.LocationCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // PArtNo
            // 
            this.PArtNo.DataPropertyName = "materialPartNo";
            this.PArtNo.FillWeight = 120F;
            this.PArtNo.HeaderText = "Part No";
            this.PArtNo.Name = "PArtNo";
            this.PArtNo.ReadOnly = true;
            // 
            // Capacity
            // 
            this.Capacity.DataPropertyName = "locationMaterialCapacity";
            this.Capacity.FillWeight = 80F;
            this.Capacity.HeaderText = "Capacity";
            this.Capacity.Name = "Capacity";
            this.Capacity.ReadOnly = true;
            // 
            // Quontity
            // 
            this.Quontity.DataPropertyName = "quantity";
            this.Quontity.FillWeight = 80F;
            this.Quontity.HeaderText = "Quantity";
            this.Quontity.Name = "Quontity";
            this.Quontity.ReadOnly = true;
            // 
            // FillCount
            // 
            this.FillCount.DataPropertyName = "countForFill";
            this.FillCount.FillWeight = 80F;
            this.FillCount.HeaderText = "Ilość do uzupełnienia";
            this.FillCount.Name = "FillCount";
            this.FillCount.ReadOnly = true;
            // 
            // VolumeStatus
            // 
            this.VolumeStatus.DataPropertyName = "volumeStatus";
            this.VolumeStatus.FillWeight = 140F;
            this.VolumeStatus.HeaderText = "Status Pojemności";
            this.VolumeStatus.Name = "VolumeStatus";
            this.VolumeStatus.ReadOnly = true;
            // 
            // VolumeState
            // 
            this.VolumeState.DataPropertyName = "volumeState";
            this.VolumeState.FillWeight = 160F;
            this.VolumeState.HeaderText = "Ustawienie pojemności";
            this.VolumeState.Name = "VolumeState";
            this.VolumeState.ReadOnly = true;
            // 
            // LocationsVolumesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.dataGridVolReports);
            this.Name = "LocationsVolumesReport";
            this.Size = new System.Drawing.Size(809, 515);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridVolReports)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.DataGridView dataGridVolReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn FillCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PArtNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quontity;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolumeState;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolumeStatus;

        #endregion
    }
}