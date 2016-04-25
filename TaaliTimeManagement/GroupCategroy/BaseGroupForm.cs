using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaaliTimeManagement.GroupCategroy
{
    public partial class BaseGroupForm : TaaliTimeManagement.MasterForm
    {
        public BaseGroupForm()
        {
            InitializeComponent();
            this.bindDataControls(this.groupDataGridView, this.groups);
            this.SelectedItems = new TaaliClasses.SelectionBinding<Group>(this.groupDataGridView, this.groups);
            this.groupDataGridView.MultiSelect = false;
            this.SelectedGroups = new List<Group>();
        }

        protected TaaliDataDataContext taali = new TaaliDataDataContext();
        private List<Group> groups = new TaaliClasses.DataList().GroupList();
        public TaaliClasses.SelectionBinding<Group> SelectedItems;
        protected List<Group> SelectedGroups;

        public bool MultiSelect
        {
            get
            {
                return this.groupDataGridView.MultiSelect;
            }
            set
            {
                this.groupDataGridView.MultiSelect = value;
            }
        }


        protected void selectData()
        {
            this.groupDataGridView.ClearSelection();
            if (this.SelectedGroups == null || this.SelectedGroups.Count == 0)
            {
                if (this.groupDataGridView.RowCount > 0)
                    this.groupDataGridView.Rows[0].Selected = true;
                return;
            }
            foreach (Group g in this.SelectedGroups)
            {
                int j = -1;
                if (this.groups.Where(gs => gs.GroupID == g.GroupID).Count() > 0)
                    j = this.groups.IndexOf(this.groups.Where(gs => gs.GroupID == g.GroupID).Single());
                if (j > -1)
                    this.groupDataGridView.Rows[j].Selected = true;
            }
        }

        private void refreshSelectedBinding()
        {
            this.groups = new TaaliClasses.DataList().GroupList();
            this.bindDataControls(this.groupDataGridView, this.groups);
            this.SelectedItems.Refresh(this.groupDataGridView, this.groups);
        }

        protected override void btnRefresh_Click(object sender, EventArgs e)
        {
            this.refreshSelectedBinding();
        }

        protected override void MasterForm_Activated(object sender, EventArgs e)
        {

        }

        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            AddingGroup ag = new AddingGroup();
            if (ag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.SelectedGroups = new List<Group>();
                this.SelectedGroups.Add(ag.TheGroup);
                this.refreshSelectedBinding();
                this.selectData();
            }
        }

        protected override void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (groupDataGridView.RowCount > 1 && groupDataGridView.SelectedRows.Count != 1)
                    throw new Exception("لطفا فقط یک گروه انتخاب کنید.");
                if (!(groupDataGridView.SelectedRows[0].Index <= groupDataGridView.RowCount - 1))
                    throw new Exception("لطفا یک گروه از گروه های موجود را انتخاب کنید.");
                if (this.SelectedItems.SelectedItems == null || this.SelectedItems.SelectedItems.Count() != 1)
                    throw new Exception();
                EditingGroup eg = new EditingGroup();
                eg.TheGroup = this.SelectedItems.SelectedItems.First(); 
                if (eg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.SelectedGroups = new List<Group>();
                    this.SelectedGroups.Add(eg.TheGroup);
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
            SearchingGroup sg = new SearchingGroup();
            if (sg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.SelectedGroups = sg.Groups;
                this.refreshSelectedBinding();
                this.selectData();
            }
        }

        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show(this, "آیا مایل به حذف این گروه هستید؟", "", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading);
                if (dr == System.Windows.Forms.DialogResult.No)
                    return;
                if (groupDataGridView.RowCount > 1 && groupDataGridView.SelectedRows.Count <= 0)
                    throw new Exception("لطفا حداقل یک گروه انتخاب کنید.");
                if (this.SelectedItems.SelectedItems == null || this.SelectedItems.SelectedItems.Count() <= 0)
                    throw new Exception();
                for (int j = 0; j < groupDataGridView.RowCount; j++)
                    if (!(groupDataGridView.SelectedRows[0].Index <= groupDataGridView.RowCount - 1))
                        throw new Exception("لطفا حداقل یک گروه از گروه های موجود را انتخاب کنید.");
                List<Group> gs = new List<Group>();
                foreach (Group g in this.SelectedItems.SelectedItems)
                {
                    gs.AddRange(from v in taali.Groups
                                where v.GroupID == g.GroupID
                                select v);
                }
                taali.Groups.DeleteAllOnSubmit(gs);
                taali.SubmitChanges();
                this.refreshSelectedBinding();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message, "خطا",
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
