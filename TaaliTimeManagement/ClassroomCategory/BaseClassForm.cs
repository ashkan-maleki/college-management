using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaaliTimeManagement.ClassCategory
{
    public partial class BaseClassForm : MasterForm
    {
        public BaseClassForm()
        {
            InitializeComponent();
            this.bindDataControls(this.classDataGridView, this.Classes);
            this.SelectedClasses = new TaaliClasses.SelectionBinding<Class>(this.classDataGridView, this.Classes);
            this.classDataGridView.MultiSelect = true;
        }

        protected TaaliDataDataContext taali = new TaaliDataDataContext();
        public List<Class> Classes = new TaaliClasses.DataList().ClassList();
        public TaaliClasses.SelectionBinding<Class> SelectedClasses;

        public bool MultiSelect
        {
            get
            {
                return this.classDataGridView.MultiSelect;
            }
            set
            {
                this.classDataGridView.MultiSelect = value;
            }
     }

        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            AddingClass ac = new AddingClass();
            if (ac.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                List<Class> classes = new List<Class>();
                classes.Add(ac.TheClass);
                this.refreshSelectedBinding();
                this.selectData(classes);
            }
        }

        protected override void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (classDataGridView.RowCount > 1 && classDataGridView.SelectedRows.Count != 1)
                    throw new Exception("لطفا فقط یک کلاس انتخاب کنید.");
                if (!(classDataGridView.SelectedRows[0].Index <= classDataGridView.RowCount - 1))
                    throw new Exception("لطفا یک کلاس از کلاس های موجود را انتخاب کنید.");
                if (this.SelectedClasses.SelectedItems != null && this.SelectedClasses.SelectedItems.Count() != 1)
                    throw new Exception();
                EditingClass ec = new EditingClass();
                ec.TheClass = this.SelectedClasses.SelectedItems.First();
                if (ec.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    List<Class> classes = new List<Class>();
                    classes.Add(ec.TheClass);
                    this.refreshSelectedBinding();
                    this.selectData(classes);
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
            SearchingClass sc = new SearchingClass();
            if (sc.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.refreshSelectedBinding();
                this.selectData(sc.Classes);
            }
        }

        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show(this, "آیا مایل به حذف این کلاس هستید؟", "", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading);
                if (dr == System.Windows.Forms.DialogResult.No)
                    return;
                if (classDataGridView.RowCount > 1 && classDataGridView.SelectedRows.Count <= 0)
                    throw new Exception("لطفا حداقل یک کلاس انتخاب کنید.");
                if (this.SelectedClasses.SelectedItems != null && this.SelectedClasses.SelectedItems.Count() <= 0)
                    throw new Exception();
                for (int j = 0; j < classDataGridView.RowCount; j++)
                    if (!(classDataGridView.SelectedRows[0].Index <= classDataGridView.RowCount - 1))
                        throw new Exception("لطفا حداقل یک کلاس از کلاس های موجود را انتخاب کنید.");
                List<Class> cs = new List<Class>();
                foreach (Class c in this.SelectedClasses.SelectedItems)
                {
                    cs.AddRange(from v in taali.Classes
                                where v.ClassID == c.ClassID
                                select v);
                }
                taali.Classes.DeleteAllOnSubmit(cs);
                taali.SubmitChanges();
                this.refreshSelectedBinding();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا",
                       MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.RtlReading);
            }
        }

        protected override void MasterForm_Activated(object sender, EventArgs e)
        {
            //this.refreshSelectedBinding();
            //this.selectData();
        }

        protected void selectData(List<Class> selectedClass)
        {
            this.classDataGridView.ClearSelection();
            if (selectedClass == null || selectedClass.Count == 0)
            {
                if (this.classDataGridView.RowCount > 0)
                    this.classDataGridView.Rows[0].Selected = true;
                return;
            }
            foreach (Class c in selectedClass)
            {
                int j = -1;
                if (this.Classes.Where(cs => cs.ClassID == c.ClassID).Count() > 0)
                    j = this.Classes.IndexOf(this.Classes.Where(cs => cs.ClassID == c.ClassID).Single());
                if (j > -1)
                    this.classDataGridView.Rows[j].Selected = true;
            }
        }

        private void refreshSelectedBinding()
        {
            this.Classes = new TaaliClasses.DataList().ClassList();
            this.bindDataControls(this.classDataGridView, this.Classes);
            this.SelectedClasses.Refresh(this.classDataGridView, this.Classes);
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

        private void BaseClassForm_Load(object sender, EventArgs e)
        {
            this.bindDataControls(this.classDataGridView, this.Classes);
            this.SelectedClasses = new TaaliClasses.SelectionBinding<Class>(this.classDataGridView, this.Classes);
        }
       
    }
}
