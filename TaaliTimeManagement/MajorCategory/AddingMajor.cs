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
    public partial class AddingMajor : TaaliTimeManagement.MasterEntryForm
    {
        public AddingMajor()
        {
            InitializeComponent();
            this.taali = new TaaliDataDataContext();
            this.setAutoComplete();
        }

        protected TaaliDataDataContext taali;
        public Major TheMajor { get; set; }

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            if (!this.boxValidation())
                return;
            this.setData(new Major());
            if (this.taali == null && this.TheMajor == null)
                return;
            try
            {
                taali.Majors.InsertOnSubmit(this.TheMajor);
                taali.SubmitChanges();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("لطفا رشته تحصیلی با مشخصات تکراری وارد نکنید.", "خطا",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.TargetSite + "\n" + ex.Message);
            }
            //this.setExchangeData();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        protected void setData(Major c)
        {
            this.TheMajor = c;
            this.TheMajor.MajorLevel = this.boxMajorLevel.Text.Trim();
            this.TheMajor.Title = this.boxTitle.Text.Trim();
            this.TheMajor.Branch = this.boxBranch.Text.Trim();
        }

        protected void setExchangeData()
        {
            //TaaliClasses.DataExchange.Majors = new List<Major>();
            //TaaliClasses.DataExchange.Majors.Clear();
            //TaaliClasses.DataExchange.Majors.Add(this.TheMajor);
        }

        protected bool boxValidation()
        {
            if (this.boxMajorLevel.CheckEmptinessOrDefault() && this.boxTitle.CheckEmptinessOrDefault())
                return false;
            return true;
        }

        protected void setAutoComplete()
        {
            TaaliClasses.DataList data = new TaaliClasses.DataList();
            var level = from m in data.MajorList()
                        where m.MajorLevel != null && !m.MajorLevel.Equals("")
                        select m.MajorLevel;
            if (level != null && level.Count() > 0)
                boxMajorLevel.AutoCompleteCustomSource.AddRange(level.ToArray());
            var title = from m in data.MajorList()
                        where m.Title != null && !m.Title.Equals("")
                        select m.Title;
            if (title != null && title.Count() > 0)
                boxTitle.AutoCompleteCustomSource.AddRange(title.ToArray());
            var branch = from m in data.MajorList()
                         where m.Branch != null && !m.Branch.Equals("")
                         select m.Branch;
            if (branch != null && branch.Count() > 0)
                boxBranch.AutoCompleteCustomSource.AddRange(branch.ToArray());
        }
    }
}
