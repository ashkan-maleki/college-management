using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaaliTimeManagement.TaaliClasses
{
    public class SelectionBinding<TItem>
    {
        public SelectionBinding(System.Windows.Forms.DataGridView theDataGridView, List<TItem> items)
        {
            this.dgv = theDataGridView;
            this.items = items;
        }

        private System.Windows.Forms.DataGridView dgv;
        private List<TItem> items;

        public List<TItem> SelectedItems
        {
            get
            {
                List<TItem> selectedItems = new List<TItem>();
                selectedItems.Clear();
                for (int i = 0; i < dgv.SelectedRows.Count; i++)
                {
                    int j = -1;
                    j = dgv.SelectedRows[i].Index;
                    selectedItems.Add(items[j]);
                }
                return selectedItems;
            }
        }

        public void Refresh(System.Windows.Forms.DataGridView theDataGridView, List<TItem> items)
        {
            this.dgv = theDataGridView;
            this.items = items;
        }

        
    }
}
