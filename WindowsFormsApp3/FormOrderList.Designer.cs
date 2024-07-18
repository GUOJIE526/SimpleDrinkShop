namespace WindowsFormsApp3
{
    partial class FormOrderList
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblBuyerInfo = new System.Windows.Forms.Label();
            this.lbxOrdItem = new System.Windows.Forms.ListBox();
            this.lblOutgo = new System.Windows.Forms.Label();
            this.lblBag = new System.Windows.Forms.Label();
            this.lblSumPrice = new System.Windows.Forms.Label();
            this.btnDeleteSelect = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnRcipe = new System.Windows.Forms.Button();
            this.btnExitItem = new System.Windows.Forms.Button();
            this.cboxOnSale = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(417, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "訂單列表";
            // 
            // lblBuyerInfo
            // 
            this.lblBuyerInfo.AutoSize = true;
            this.lblBuyerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblBuyerInfo.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBuyerInfo.Location = new System.Drawing.Point(48, 105);
            this.lblBuyerInfo.Name = "lblBuyerInfo";
            this.lblBuyerInfo.Size = new System.Drawing.Size(205, 47);
            this.lblBuyerInfo.TabIndex = 1;
            this.lblBuyerInfo.Text = "訂購人資訊";
            // 
            // lbxOrdItem
            // 
            this.lbxOrdItem.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbxOrdItem.FormattingEnabled = true;
            this.lbxOrdItem.ItemHeight = 35;
            this.lbxOrdItem.Location = new System.Drawing.Point(56, 180);
            this.lbxOrdItem.Name = "lbxOrdItem";
            this.lbxOrdItem.Size = new System.Drawing.Size(886, 284);
            this.lbxOrdItem.TabIndex = 2;
            // 
            // lblOutgo
            // 
            this.lblOutgo.AutoSize = true;
            this.lblOutgo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblOutgo.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOutgo.Location = new System.Drawing.Point(300, 489);
            this.lblOutgo.Name = "lblOutgo";
            this.lblOutgo.Size = new System.Drawing.Size(94, 47);
            this.lblOutgo.TabIndex = 3;
            this.lblOutgo.Text = "外帶";
            // 
            // lblBag
            // 
            this.lblBag.AutoSize = true;
            this.lblBag.BackColor = System.Drawing.Color.GreenYellow;
            this.lblBag.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBag.Location = new System.Drawing.Point(400, 489);
            this.lblBag.Name = "lblBag";
            this.lblBag.Size = new System.Drawing.Size(131, 47);
            this.lblBag.TabIndex = 4;
            this.lblBag.Text = "購物袋";
            // 
            // lblSumPrice
            // 
            this.lblSumPrice.BackColor = System.Drawing.Color.Violet;
            this.lblSumPrice.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSumPrice.Location = new System.Drawing.Point(589, 489);
            this.lblSumPrice.Name = "lblSumPrice";
            this.lblSumPrice.Size = new System.Drawing.Size(328, 47);
            this.lblSumPrice.TabIndex = 5;
            this.lblSumPrice.Text = "訂單總價 0000元";
            this.lblSumPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDeleteSelect
            // 
            this.btnDeleteSelect.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeleteSelect.Location = new System.Drawing.Point(371, 587);
            this.btnDeleteSelect.Name = "btnDeleteSelect";
            this.btnDeleteSelect.Size = new System.Drawing.Size(238, 50);
            this.btnDeleteSelect.TabIndex = 6;
            this.btnDeleteSelect.Text = "移除選擇品向";
            this.btnDeleteSelect.UseVisualStyleBackColor = true;
            this.btnDeleteSelect.Click += new System.EventHandler(this.btnDeleteSelect_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeleteAll.ForeColor = System.Drawing.Color.Maroon;
            this.btnDeleteAll.Location = new System.Drawing.Point(371, 663);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(238, 50);
            this.btnDeleteAll.TabIndex = 7;
            this.btnDeleteAll.Text = "移除所有品項";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnRcipe
            // 
            this.btnRcipe.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRcipe.ForeColor = System.Drawing.Color.Blue;
            this.btnRcipe.Location = new System.Drawing.Point(659, 587);
            this.btnRcipe.Name = "btnRcipe";
            this.btnRcipe.Size = new System.Drawing.Size(238, 50);
            this.btnRcipe.TabIndex = 8;
            this.btnRcipe.Text = "輸出訂購單txt";
            this.btnRcipe.UseVisualStyleBackColor = true;
            this.btnRcipe.Click += new System.EventHandler(this.btnRcipe_Click);
            // 
            // btnExitItem
            // 
            this.btnExitItem.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExitItem.ForeColor = System.Drawing.Color.Blue;
            this.btnExitItem.Location = new System.Drawing.Point(659, 663);
            this.btnExitItem.Name = "btnExitItem";
            this.btnExitItem.Size = new System.Drawing.Size(238, 50);
            this.btnExitItem.TabIndex = 9;
            this.btnExitItem.Text = "繼續訂購";
            this.btnExitItem.UseVisualStyleBackColor = true;
            this.btnExitItem.Click += new System.EventHandler(this.btnExitItem_Click);
            // 
            // cboxOnSale
            // 
            this.cboxOnSale.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboxOnSale.FormattingEnabled = true;
            this.cboxOnSale.Location = new System.Drawing.Point(56, 496);
            this.cboxOnSale.Name = "cboxOnSale";
            this.cboxOnSale.Size = new System.Drawing.Size(209, 42);
            this.cboxOnSale.TabIndex = 10;
            // 
            // FormOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(990, 754);
            this.Controls.Add(this.cboxOnSale);
            this.Controls.Add(this.btnExitItem);
            this.Controls.Add(this.btnRcipe);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnDeleteSelect);
            this.Controls.Add(this.lblSumPrice);
            this.Controls.Add(this.lblBag);
            this.Controls.Add(this.lblOutgo);
            this.Controls.Add(this.lbxOrdItem);
            this.Controls.Add(this.lblBuyerInfo);
            this.Controls.Add(this.label1);
            this.Name = "FormOrderList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "訂購品項列表";
            this.Load += new System.EventHandler(this.FormOrderList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBuyerInfo;
        private System.Windows.Forms.ListBox lbxOrdItem;
        private System.Windows.Forms.Label lblOutgo;
        private System.Windows.Forms.Label lblBag;
        private System.Windows.Forms.Label lblSumPrice;
        private System.Windows.Forms.Button btnDeleteSelect;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnRcipe;
        private System.Windows.Forms.Button btnExitItem;
        private System.Windows.Forms.ComboBox cboxOnSale;
    }
}