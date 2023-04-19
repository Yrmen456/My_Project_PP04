
namespace My_Project_PP04.Control
{
    partial class ProductList
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanelProductList = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelProductList
            // 
            this.flowLayoutPanelProductList.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.flowLayoutPanelProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelProductList.AutoScroll = true;
            this.flowLayoutPanelProductList.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelProductList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelProductList.Location = new System.Drawing.Point(0, 6);
            this.flowLayoutPanelProductList.Name = "flowLayoutPanelProductList";
            this.flowLayoutPanelProductList.Size = new System.Drawing.Size(1064, 446);
            this.flowLayoutPanelProductList.TabIndex = 6;
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanelProductList);
            this.Name = "ProductList";
            this.Size = new System.Drawing.Size(1064, 458);
            this.Load += new System.EventHandler(this.ProductList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProductList;
    }
}
