using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YesilEvCodeFirst.UIWinForm.Raporlar
{
    public partial class Rapor16Form : Form
    {
        public Rapor16Form()
        {
            InitializeComponent();
        }

        private void Rapor16Form_Load(object sender, EventArgs e)
        {

        }
    }
}

//IQueryable<Job> jobs = (from j in _db.Jobs
//                        join jt in _db.JobTranslators on j.Id equals jt.JobId into jts
//
//                        from jtResult in jts.DefaultIfEmpty()
//
//                        join jr in _db.JobRevisors on jtResult.Id equals jr.JobId into jrs
//                        from jrResult in jrs.DefaultIfEmpty()
//
//                        join u in _db.Users on jtResult.UserId equals u.Id into jtU
//                        from jtUResult in jtU.DefaultIfEmpty()

//                        where jtUResult.Id == userId
//                        orderby j.Id
//                        select j).Concat(
//                        from j in _db.Jobs
//                        join jt in _db.JobTranslators on j.Id equals jt.JobId into jts
//                        from jtResult in jts.DefaultIfEmpty()
//                        join jr in _db.JobRevisors on jtResult.Id equals jr.JobId into jrs
//                        from jrResult in jrs.DefaultIfEmpty()
//                        join u in _db.Users on jrResult.UserId equals u.Id into jrU
//                        from jrUResult in jrU.DefaultIfEmpty()
//                        where jtUResult.Id == userId
//                        orderby j.Id
//                        select j
//                        ).Distinct()
