using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace report
{
    public partial class ReportViwer : Form
    {
        public bool open = false;
        public ReportViwer()
        {
            InitializeComponent();
            
        }

        private  void ReportViwer_Load(object sender, EventArgs e)
        {
            rep1();

        }


        private void ReportViwer_FormClosed(object sender, FormClosedEventArgs e)
        {
         //   this.Dispose();
        }


        private void rep1() //already buil
        {
            List<Person> list = RepositoryPerson.Fill();  //get list of students
            reportViewer1.LocalReport.DataSources.Clear(); //clear report
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", list); // set the datasource
            reportViewer1.LocalReport.DataSources.Add(dataset);
            //dataset.Value = list;
            reportViewer1.LocalReport.Refresh(); //разобраться в различиях эттих строк
            reportViewer1.RefreshReport(); // refresh report

        }

        private void rep2() //building
        {
          //  reportViewer1.LocalReport.ReportEmbeddedResource = "Student_ReportViewer.StudentReport.rdlc"; // bind reportviewer with .rdlc
        }
    }
}
