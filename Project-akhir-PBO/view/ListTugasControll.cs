using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_akhir_PBO.view
{
    public partial class ListTugasControll : UserControl
    {
        public ListTugasControll()
        {
            InitializeComponent();
        }


        #region properties
        string _judul;
        public string judul  // membuat properti judul
        {
            get { return _judul; }
            set { _judul = value; btJudul.Text = value; }
        }
        string _deskripsi;

        public string deskripsi  // membuat properti deskripsi
        {
            get { return _deskripsi; }
            set { _deskripsi = value; btDeskripsi.Text = value; }
        }
        string _id;
        public string id
        {
            get { return _id; } set { _id = value; }
        }
        string _id_mapel;
        public string id_mapel
        {
            get { return _id_mapel; }
            set { _id_mapel = value; }
        }
        string _id_status;
        public string id_status
        {
            get { return _id_status; }
            set { _id_status = value; }
        }
        #endregion

    }
}
