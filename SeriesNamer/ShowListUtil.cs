using Figri;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SeriesNamer;

public class ShowListUtil
{
    private ListView dResult;
    private Dictionary<string, int> widths;
    private int defaultWidth;

    public ShowListUtil(ListView lv, Dictionary<string, int> widths, int defaultWidth)
    {
        this.dResult = lv;
        this.widths = widths == null ? new Dictionary<string, int>() : widths;
        this.defaultWidth = defaultWidth;

        dResult.View = View.Details;
        dResult.FullRowSelect = true;
        dResult.LabelEdit = false;
        dResult.LabelWrap = false;
        dResult.AllowColumnReorder = true;
        dResult.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        //dResult.
    }

    public void saveCurrentHeaderSizes()
    {
        foreach (ColumnHeader ch in dResult.Columns)
        {
            setWidthOf(ch.Name, ch.Width);
        }
    }

    public void addHeadersFromFirst()
    {
        FileEntry sh = (FileEntry)dResult.Items[0].Tag;
        foreach (string s in sh.AttributeNames)
        {
            addHeader(s, s);
        }
    }

    public void addHeadersFromAll()
    {
        HashSet<string> set = FileEntry.ExtractUsedAttributes(AllInfos);

        foreach (string s in set)
        {
            addHeader(s, s);
        }
    }

    public void removeAllHeaders()
    {
        saveCurrentHeaderSizes();
        dResult.Columns.Clear();
    }

    public void addHeader(string name, string display)
    {
        ColumnHeader ch = new ColumnHeader();
        ch.Text = display;
        ch.Name = name.ToLower();
        ch.Width = getWidthOf(ch.Name);
        dResult.Columns.Add(ch);
    }

    private int getWidthOf(string aname)
    {
        string name = aname.ToLower();
        if (widths.ContainsKey(name)) return widths[name];
        else return defaultWidth;
    }
    private void setWidthOf(string aname, int width)
    {
        string name = aname.ToLower();
        widths[name] = width;
    }

    public void addSeveral(IEnumerable<FileEntry> infos)
    {
        foreach (FileEntry info in infos)
        {
            ListViewItem it = new ListViewItem();
            it.Tag = info;
            dResult.Items.Add(it);
            updateText(it);
        }
    }

    IEnumerable<ListViewItem> Items
    {
        get
        {
            foreach (ListViewItem lvi in dResult.Items)
            {
                yield return lvi;
            }
        }
    }

    public void updateAllText()
    {
        updateAllText(Items);
    }

    public void updateAllText(IEnumerable<ListViewItem> its)
    {
        foreach (ListViewItem it in its)
        {
            updateText(it);
        }
    }

    public void updateText(ListViewItem it)
    {
        FileEntry sh = (FileEntry)it.Tag;
        List<string> cols = new List<string>(ColumnNames);
        List<string> values = sh.match(cols);
        it.SubItems.Clear();
        bool first = true;
        foreach (string t in values)
        {
            if (first) it.Text = t;
            else it.SubItems.Add(t);
            first = false;
        }
    }

    private IEnumerable<string> ColumnNames
    {
        get
        {
            foreach (ColumnHeader ch in dResult.Columns)
            {
                yield return ch.Text;
            }
        }
    }

    private static FileEntry InfoFromItem(ListViewItem it)
    {
        return (FileEntry)it.Tag;
    }

    internal void addSingle(params FileEntry[] sh)
    {
        addSeveral(sh);
    }

    internal IEnumerable<FileEntry> SelectedInfos
    {
        get
        {
            foreach (ListViewItem it in SelectedItems)
            {
                yield return InfoFromItem(it);
            }
        }
    }

    internal IEnumerable<FileEntry> AllInfos
    {
        get
        {
            foreach (ListViewItem it in Items)
            {
                yield return InfoFromItem(it);
            }
        }
    }

    internal IEnumerable<ListViewItem> SelectedItems
    {
        get
        {
            foreach (ListViewItem it in dResult.SelectedItems)
            {
                yield return it;
            }
        }
    }

    internal void remove(IEnumerable<ListViewItem> lvis)
    {
        foreach (ListViewItem i in lvis)
        {
            dResult.Items.Remove(i);
        }
    }
}
