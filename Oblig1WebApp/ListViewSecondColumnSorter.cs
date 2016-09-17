using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oblig1WebApp
{
    /// <summary>
    /// A very simple implementation of the IComparer interface, to sort by the second column in a listview ascending.
    /// </summary>
    class ListViewSecondColumnSorter : IComparer
    {
        public int Compare(object x, object y)
        {
            ListViewItem firstListView = (ListViewItem)x;
            ListViewItem secondListView = (ListViewItem)y;
            return String.Compare(firstListView.SubItems[1].Text, secondListView.SubItems[1].Text);
        }
    }
}
