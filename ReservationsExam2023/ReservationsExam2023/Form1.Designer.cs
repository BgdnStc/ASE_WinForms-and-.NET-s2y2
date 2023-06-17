namespace ReservationsExam2023
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
            this.btnEnterRez = new System.Windows.Forms.Button();
            this.lvRezervation = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRoomId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCheckIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCheckOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPersons = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tsbSerializeToXml = new System.Windows.Forms.ToolStripButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnterRez
            // 
            this.btnEnterRez.Location = new System.Drawing.Point(634, 415);
            this.btnEnterRez.Name = "btnEnterRez";
            this.btnEnterRez.Size = new System.Drawing.Size(154, 23);
            this.btnEnterRez.TabIndex = 0;
            this.btnEnterRez.Text = "Add Reservation";
            this.btnEnterRez.UseVisualStyleBackColor = true;
            this.btnEnterRez.Click += new System.EventHandler(this.btnEnterRez_Click);
            // 
            // lvRezervation
            // 
            this.lvRezervation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderRoomId,
            this.columnHeaderCheckIn,
            this.columnHeaderCheckOut,
            this.columnHeaderPersons});
            this.lvRezervation.FullRowSelect = true;
            this.lvRezervation.GridLines = true;
            this.lvRezervation.HideSelection = false;
            this.lvRezervation.Location = new System.Drawing.Point(12, 122);
            this.lvRezervation.Name = "lvRezervation";
            this.lvRezervation.Size = new System.Drawing.Size(776, 273);
            this.lvRezervation.TabIndex = 1;
            this.lvRezervation.UseCompatibleStateImageBehavior = false;
            this.lvRezervation.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "ID";
            this.columnHeaderId.Width = 49;
            // 
            // columnHeaderRoomId
            // 
            this.columnHeaderRoomId.Text = "Room ID";
            this.columnHeaderRoomId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderRoomId.Width = 91;
            // 
            // columnHeaderCheckIn
            // 
            this.columnHeaderCheckIn.Text = "Check In";
            this.columnHeaderCheckIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderCheckIn.Width = 179;
            // 
            // columnHeaderCheckOut
            // 
            this.columnHeaderCheckOut.Text = "Check Out";
            this.columnHeaderCheckOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderCheckOut.Width = 186;
            // 
            // columnHeaderPersons
            // 
            this.columnHeaderPersons.Text = "Persons";
            this.columnHeaderPersons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderPersons.Width = 106;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSerializeToXml});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(402, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tsbSerializeToXml
            // 
            this.tsbSerializeToXml.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSerializeToXml.Image = ((System.Drawing.Image)(resources.GetObject("tsbSerializeToXml.Image")));
            this.tsbSerializeToXml.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSerializeToXml.Name = "tsbSerializeToXml";
            this.tsbSerializeToXml.Size = new System.Drawing.Size(111, 24);
            this.tsbSerializeToXml.Text = "SerializeToXml";
            this.tsbSerializeToXml.Click += new System.EventHandler(this.tsbSerializeToXml_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(519, 415);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 74);
            this.label1.TabIndex = 5;
            this.label1.Text = "Reservations:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lvRezervation);
            this.Controls.Add(this.btnEnterRez);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnterRez;
        private System.Windows.Forms.ListView lvRezervation;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderRoomId;
        private System.Windows.Forms.ColumnHeader columnHeaderCheckIn;
        private System.Windows.Forms.ColumnHeader columnHeaderCheckOut;
        private System.Windows.Forms.ColumnHeader columnHeaderPersons;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolStripButton tsbSerializeToXml;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
    }
}

