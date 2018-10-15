using System.Windows.Forms;

namespace M3u_to_folder
{
    class M3uData
    {
        public M3uManager mngr;
        public string folder;
        public CheckedListBox listbox;

        public M3uData(M3uManager m, string f, CheckedListBox clb)
        {
            mngr = m;
            folder = f;
            listbox = clb;
        }
    }
}
