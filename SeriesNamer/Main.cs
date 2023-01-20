using BrightIdeasSoftware;
using Figri;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace SeriesNamer
{
    public partial class Main : Form
    {
        TypedObjectListView<FileEntry> fileObjects;

        public Main()
        {
            InitializeComponent();
            fileObjects = new TypedObjectListView<FileEntry>(dFileObjects);
            loadSongs();
        }

        private void dAddFile_Click(object sender, EventArgs e)
        {
            if (dFileBrowse.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in dFileBrowse.FileNames)
                {
                    addFile(file);
                }
                saveSongs();
            }
        }

        private void addFile(string file)
        {
            if (isMovieFile(file))
            {
                dFileObjects.AddObject(new FileEntry(file));
            }
        }

        private bool isMovieFile(string file)
        {
            string ext = Path.GetExtension(file);
            if (ext == ".avi") return true;
            else if (ext == ".divx") return true;
            else if (ext == ".mkv") return true;
            else if (ext == ".ogm") return true;
            else if (ext == ".mp4") return true;
            else return false;
        }

        private void dAddFolder_Click(object sender, EventArgs e)
        {
            if (dFolderBrowse.ShowDialog() == DialogResult.OK)
            {
                addFolder(dFolderBrowse.SelectedPath);
            }
        }

        private void addFolder(string p)
        {
            foreach (string file in Directory.GetFiles(p, "*.*", SearchOption.AllDirectories))
            {
                addFile(file);
            }
            saveSongs();
        }

        private void tagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<FileEntry> infos = new List<FileEntry>(fileObjects.SelectedObjects);
            FromFilename st = new FromFilename(infos);
            if (st.ShowDialog() == DialogResult.OK)
            {
                dFileObjects.RefreshObjects(dFileObjects.SelectedObjects);
                saveSongs();
            }
        }

        private void lookUpInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void attributeToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AttributeTools st = new AttributeTools(fileObjects.SelectedObjects);
            if (st.ShowDialog() == DialogResult.OK)
            {
                dFileObjects.RefreshObjects(dFileObjects.SelectedObjects);
                saveSongs();
            }
        }



        private string getShowDir()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SeriesNamer");
        }

        private string getShowPath()
        {
            return Path.Combine(getShowDir(), "shows.json");
        }

        private void loadSongs()
        {
            try
            {
                var project = Project.Load(getShowPath());
                foreach(var s in project.Files)
                {
                    dFileObjects.AddObject(s);
                }
            }
            catch (Exception)
            {
            }
        }

        private void saveSongs()
        {
            new DirectoryInfo(getShowDir()).Create();
            var project = new Project { Files = fileObjects.Objects.ToList() };
            project.Save(getShowPath());
        }

        private void moveFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoveTool st = new MoveTool(fileObjects.SelectedObjects);
            st.ShowDialog();
            dFileObjects.RefreshObjects(dFileObjects.SelectedObjects);
            saveSongs();
        }

        private void removeSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dFileObjects.RemoveObjects(dFileObjects.SelectedObjects);
        }
    }
}
