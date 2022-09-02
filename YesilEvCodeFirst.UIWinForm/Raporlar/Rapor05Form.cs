using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.DTOs.Rapor;

namespace YesilEvCodeFirst.UIWinForm.Raporlar
{
    public partial class Rapor05Form : Form
    {
        public Rapor05Form()
        {
            InitializeComponent();
        }

        // comboBox1.Items.Add("Madde Favori/Karaliste Sayısı");
        // select s.SupplementID, Count(distinct f.FavListID) as FavCount ,Count(distinct sb.BlackListID) as BlackCount from Supplement s
        // left outer join[SupplementBlackList] sb on sb.SupplementID = s.SupplementID
        // left outer join ProductSupplement pm on s.SupplementID = pm.SupplementID
        // left outer join ProductFavList f on pm.ProductID = f.ProductID
        // group by s.SupplementID

        private void buttonRaporuGetir_Click(object sender, EventArgs e)
        {
            List<Rapor05DTO> list = null;

            using (YesilEvDbContext context = new YesilEvDbContext())
            {
                //var result = 
                //    (
                //        from supplement in context.Supplement
                //        join sb in context.SupplementBlackList 
                //        on supplement.SupplementID equals sb.SupplementID into sbs
                //        from sbResult in sbs.DefaultIfEmpty()
                //        join ps in context.ProductSupplement 
                //        on sbResult.SupplementID equals ps.SupplementID into pss
                //        from psResult in pss.DefaultIfEmpty()
                //        join pf in context.ProductFavList 
                //        on psResult.ProductID equals pf.ProductID into pfs
                //        from pfResult in pfs.DefaultIfEmpty()
                //        group new { supplement, sbResult, psResult, pfResult } by supplement.SupplementID into grup
                //        select new Rapor05DTO
                //        {
                //            SupplementName = grup.Key.ToString(),
                //            FavListCount = grup.Select(x => x.pfResult.FavListID).Distinct().Count(),
                //            BlacListCount = grup.Select(x => x.sbResult.BlackListID).Distinct().Count()
                //        }).ToList();

                //list = result;
            }


            dataGridView1.DataSource = list;
        }
    }
}
