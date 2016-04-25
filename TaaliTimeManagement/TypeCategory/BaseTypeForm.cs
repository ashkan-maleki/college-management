using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaaliTimeManagement.TypeCategory
{
    public partial class BaseTypeForm : TaaliTimeManagement.MasterForm
    {
        public BaseTypeForm()
        {
            InitializeComponent();
            this.bindDataControls(this.typeDataGridView, this.types);
            this.SelectedTypes = new TaaliClasses.SelectionBinding<SubjectType>(this.typeDataGridView, this.types);
            this.selectedItems = new List<SubjectType>();
        }

        protected TaaliDataDataContext taali = new TaaliDataDataContext();
        private List<SubjectType> types = new TaaliClasses.DataList().TypeList();
        public TaaliClasses.SelectionBinding<SubjectType> SelectedTypes;
        protected List<SubjectType> selectedItems;


        public bool MultiSelect
        {
            get
            {
                return this.typeDataGridView.MultiSelect;
            }
            set
            {
                this.typeDataGridView.MultiSelect = value;
            }
        }

        protected void selectData()
        {
            this.typeDataGridView.ClearSelection();
            if (this.selectedItems == null || this.selectedItems.Count == 0)
            {
                if (this.typeDataGridView.RowCount > 0)
                    this.typeDataGridView.Rows[0].Selected = true;
                return;
            }
            foreach (SubjectType st in this.selectedItems)
            {
                int j = -1;
                if (this.types.Where(sts => sts.SubjectTypeID == st.SubjectTypeID).Count() > 0)
                    j = this.types.IndexOf(this.types.Where(sts => sts.SubjectTypeID == st.SubjectTypeID).Single());
                if (j > -1)
                    this.typeDataGridView.Rows[j].Selected = true;
            }
        }

        private void refreshSelectedBinding()
        {
            this.types = new TaaliClasses.DataList().TypeList();
            this.bindDataControls(this.typeDataGridView, this.types);
            this.SelectedTypes.Refresh(this.typeDataGridView, this.types);
        }

        protected override void MasterForm_Activated(object sender, EventArgs e)
        {
           
        }

        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            AddingType at = new AddingType();
            if (at.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.selectedItems = new List<SubjectType>();
                this.selectedItems.Add(at.TheType);
                this.refreshSelectedBinding();
                this.selectData();
            }
        }

        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show(this, "آیا مایل به حذف این نوع درس هستید؟", "", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading);
                if (dr == System.Windows.Forms.DialogResult.No)
                    return;
                if (typeDataGridView.RowCount > 1 && typeDataGridView.SelectedRows.Count <= 0)
                    throw new Exception("لطفا حداقل یک نوع درس انتخاب کنید.");
                if (this.SelectedTypes.SelectedItems == null || this.SelectedTypes.SelectedItems.Count <= 0)
                    throw new Exception();
                for (int j = 0; j < typeDataGridView.RowCount; j++)
                    if (!(typeDataGridView.SelectedRows[0].Index <= typeDataGridView.RowCount - 1))
                        throw new Exception("لطفا حداقل یک نوع درس از نوع درس های موجود را انتخاب کنید.");
                List<SubjectType> sts = new List<SubjectType>();
                foreach (SubjectType st in this.SelectedTypes.SelectedItems)
                {
                    sts.AddRange(from t in taali.SubjectTypes
                                 where t.SubjectTypeID == st.SubjectTypeID
                                 select t);
                }
                taali.SubjectTypes.DeleteAllOnSubmit(sts);
                taali.SubmitChanges();
                this.refreshSelectedBinding();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("لطفا نوع درس با مشخصات تکراری وارد نکنید.", "خطا",
                       MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.RtlReading);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.TargetSite + "\n" + ex.Message);
            }
        }

        protected override void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (typeDataGridView.RowCount > 1 && typeDataGridView.SelectedRows.Count != 1)
                    throw new Exception("لطفا فقط یک نوع درس انتخاب کنید.");
                if (!(typeDataGridView.SelectedRows[0].Index <= typeDataGridView.RowCount - 1))
                    throw new Exception("لطفا یک نوع درس از نوع درس های موجود را انتخاب کنید.");
                if (this.SelectedTypes.SelectedItems == null || this.SelectedTypes.SelectedItems.Count != 1)
                    throw new Exception();
                EditingType et = new EditingType();
                et.TheType = this.SelectedTypes.SelectedItems.First();
                if (et.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.selectedItems = new List<SubjectType>();
                    this.selectedItems.Add(et.TheType);
                    this.refreshSelectedBinding();
                    this.selectData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا",
                       MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.RtlReading);
            }
        }
        protected override void btnSearch_Click(object sender, EventArgs e)
        {
            SearchingType st = new SearchingType();
            if (st.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.selectedItems = st.Types;
                this.refreshSelectedBinding();
                this.selectData();
            }
        }

        protected override void btnRefresh_Click(object sender, EventArgs e)
        {
            this.refreshSelectedBinding();
        }

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        protected override void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
