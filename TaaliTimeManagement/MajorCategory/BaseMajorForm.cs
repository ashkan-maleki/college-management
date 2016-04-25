using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaaliTimeManagement.MajorCategory
{
    public partial class BaseMajorForm : TaaliTimeManagement.MasterForm
    {
        public BaseMajorForm()
        {
            InitializeComponent();
            this.bindDataControls(this.majorDataGridView, this.majors);
            this.SelectedMajors = new TaaliClasses.SelectionBinding<Major>(this.majorDataGridView, this.majors);
            this.majorDataGridView.MultiSelect = false;
            this.SelectedItems = new List<Major>();
        }

        protected TaaliDataDataContext taali = new TaaliDataDataContext();
        private List<Major> majors = new TaaliClasses.DataList().MajorList();
        public TaaliClasses.SelectionBinding<Major> SelectedMajors;
        protected List<Major> SelectedItems;

        public bool MultiSelect
        {
            get
            {
                return this.majorDataGridView.MultiSelect;
            }
            set
            {
                this.majorDataGridView.MultiSelect = value;
            }
        }


        protected void selectData()
        {
            //this.majorDataGridView.ClearSelection();
            //if (TaaliClasses.DataExchange.Majors == null || TaaliClasses.DataExchange.Majors.Count == 0)
            //{
            //    if (this.majorDataGridView.RowCount > 0)
            //        this.majorDataGridView.Rows[0].Selected = true;
            //    return;
            //}
            //foreach (Major m in TaaliClasses.DataExchange.Majors)
            //{
            //    int j = -1;
            //    if (this.majors.Where(ms => ms.MajorID == m.MajorID).Count() > 0)
            //        j = this.majors.IndexOf(this.majors.Where(ms => ms.MajorID == m.MajorID).Single());
            //    if (j > -1)
            //        this.majorDataGridView.Rows[j].Selected = true;
            //}
            this.majorDataGridView.ClearSelection();
            if (this.SelectedItems == null || this.SelectedItems.Count == 0)
            {
                if (this.majorDataGridView.RowCount > 0)
                    this.majorDataGridView.Rows[0].Selected = true;
                return;
            }
            foreach (Major m in this.SelectedItems)
            {
                int j = -1;
                if (this.majors.Where(ms => ms.MajorID == m.MajorID).Count() > 0)
                    j = this.majors.IndexOf(this.majors.Where(ms => ms.MajorID == m.MajorID).Single());
                if (j > -1)
                    this.majorDataGridView.Rows[j].Selected = true;
            }
        }

        private void refreshSelectedBinding()
        {
            this.majors = new TaaliClasses.DataList().MajorList();
            this.bindDataControls(this.majorDataGridView, this.majors);
            this.SelectedMajors.Refresh(this.majorDataGridView, this.majors);
        }

        protected override void btnRefresh_Click(object sender, EventArgs e)
        {
            this.refreshSelectedBinding();
        }

        protected override void MasterForm_Activated(object sender, EventArgs e)
        {
            //this.refreshSelectedBinding();
            //this.selectData();
        }

        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            //this.showForm(new AddingMajor());
            AddingMajor am = new AddingMajor();
            if (am.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.SelectedItems = new List<Major>();
                this.SelectedItems.Add(am.TheMajor);
                this.refreshSelectedBinding();
                this.selectData();
            }
        }

        protected override void btnEdit_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (majorDataGridView.RowCount > 1 && majorDataGridView.SelectedRows.Count != 1)
            //        throw new Exception("لطفا فقط یک رشته انتخاب کنید.");
            //    if (!(majorDataGridView.SelectedRows[0].Index <= majorDataGridView.RowCount - 1))
            //        throw new Exception("لطفا یک رشته از رشته های موجود را انتخاب کنید.");
            //    if (TaaliClasses.DataExchange.Majors != null && TaaliClasses.DataExchange.Majors.Count() != 1)
            //        throw new Exception();
            //    EditingMajor em = new EditingMajor();
            //    TaaliClasses.DataExchange.Majors = new List<Major>();
            //    TaaliClasses.DataExchange.Majors = this.SelectedMajors.SelectedItems;
            //    em.TheMajor = this.SelectedMajors.SelectedItems.First();
            //    this.showForm(em);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "خطا",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
            //            MessageBoxOptions.RtlReading);
            //}
            try
            {
                if (majorDataGridView.RowCount > 1 && majorDataGridView.SelectedRows.Count != 1)
                    throw new Exception("لطفا فقط یک رشته انتخاب کنید.");
                if (!(majorDataGridView.SelectedRows[0].Index <= majorDataGridView.RowCount - 1))
                    throw new Exception("لطفا یک رشته از رشته های موجود را انتخاب کنید.");
                if (this.SelectedItems != null && this.SelectedItems.Count() != 1)
                    throw new Exception();
                EditingMajor em = new EditingMajor();
                em.TheMajor = this.SelectedMajors.SelectedItems.First();
                if (em.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.SelectedItems = new List<Major>();
                    this.SelectedItems.Add(em.TheMajor);
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
            //TaaliClasses.DataExchange.Majors = this.SelectedMajors.SelectedItems;
            //this.showForm(new SearchingMajor());
            SearchingMajor sm = new SearchingMajor();
            if (sm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.SelectedItems = sm.Majors;
                this.refreshSelectedBinding();
                this.selectData();
            }
        }

        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DialogResult dr = MessageBox.Show(this, "آیا مایل به حذف این رشته هستید؟", "", MessageBoxButtons.YesNo,
            //     MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading);
            //    if (dr == System.Windows.Forms.DialogResult.No)
            //        return;
            //    if (majorDataGridView.RowCount > 1 && majorDataGridView.SelectedRows.Count <= 0)
            //        throw new Exception("لطفا حداقل یک رشته انتخاب کنید.");
            //    TaaliClasses.DataExchange.Majors = this.SelectedMajors.SelectedItems;
            //    if (TaaliClasses.DataExchange.Majors != null && TaaliClasses.DataExchange.Majors.Count() <= 0)
            //        throw new Exception();
            //    for (int j = 0; j < majorDataGridView.RowCount; j++)
            //        if (!(majorDataGridView.SelectedRows[0].Index <= majorDataGridView.RowCount - 1))
            //            throw new Exception("لطفا حداقل یک رشته از رشته های موجود را انتخاب کنید.");
            //    List<Major> ms = new List<Major>();
            //    foreach (Major m in TaaliClasses.DataExchange.Majors)
            //    {
            //        ms.AddRange(from v in taali.Majors
            //                    where v.MajorID == m.MajorID
            //                    select v);
            //    }
            //    taali.Majors.DeleteAllOnSubmit(ms);
            //    taali.SubmitChanges();
            //    this.refreshSelectedBinding();
            //}
            //catch (System.Data.SqlClient.SqlException ex)
            //{
            //    MessageBox.Show(".شما نمی توانید این رشته تحصیلی را حذف کنید", "خطا",
            //                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
            //                MessageBoxOptions.RtlReading);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "خطا",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
            //            MessageBoxOptions.RtlReading);
            //}
            try
            {
                DialogResult dr = MessageBox.Show(this, "آیا مایل به حذف این رشته هستید؟", "", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading);
                if (dr == System.Windows.Forms.DialogResult.No)
                    return;
                if (majorDataGridView.RowCount > 1 && majorDataGridView.SelectedRows.Count <= 0)
                    throw new Exception("لطفا حداقل یک رشته انتخاب کنید.");
                if (this.SelectedMajors.SelectedItems != null && this.SelectedMajors.SelectedItems.Count() <= 0)
                    throw new Exception();
                for (int j = 0; j < majorDataGridView.RowCount; j++)
                    if (!(majorDataGridView.SelectedRows[0].Index <= majorDataGridView.RowCount - 1))
                        throw new Exception("لطفا حداقل یک رشته از رشته های موجود را انتخاب کنید.");
                List<Major> ms = new List<Major>();
                foreach (Major m in this.SelectedMajors.SelectedItems)
                {
                    ms.AddRange(from v in taali.Majors
                                where v.MajorID == m.MajorID
                                select v);
                }
                taali.Majors.DeleteAllOnSubmit(ms);
                taali.SubmitChanges();
                this.refreshSelectedBinding();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(".شما نمی توانید این رشته تحصیلی را حذف کنید", "خطا",
                            MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading);
            }
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
