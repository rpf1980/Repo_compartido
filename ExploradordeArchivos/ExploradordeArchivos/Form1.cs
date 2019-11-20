﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ExploradordeArchivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateTreeView();
        }
        private void PopulateTreeView()
        {
            TreeNode rootNode;
            DirectoryInfo info = new DirectoryInfo(@"../..");
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                treeView1.Nodes.Add(rootNode);
            }
        }
        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "Folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            listView1.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;
            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                {new ListViewItem.ListViewSubItem(item, "Directorio"),new ListViewItem.ListViewSubItem(item,dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {                
                //Switch que usamos para validar tipo de extensión
                switch(file.Extension)
                {
                    case ".txt":
                        {
                            item = new ListViewItem(file.Name, 4); //Item con índice 4 (fichero de texto)
                            subItems = new ListViewItem.ListViewSubItem[] //Array de subitems
                            { new ListViewItem.ListViewSubItem(item, "Fichero"),//Esta línea establece texto a mostrar del item
                              new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())}; //Esta línea correponde a la info del último acceso al fichero
                            item.SubItems.AddRange(subItems); //Añade los subitems
                            listView1.Items.Add(item); //Añade el item completo a la listview
                        }
                        break;
                    case ".pdf":
                        {
                            item = new ListViewItem(file.Name, 3); //Item con índice 3 (documento pdf)
                            subItems = new ListViewItem.ListViewSubItem[] //Array de subitems
                            { new ListViewItem.ListViewSubItem(item, "Documento pdf"),//Esta línea establece texto a mostrar del item
                              new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())}; //Esta línea correponde a la info del último acceso al fichero
                            item.SubItems.AddRange(subItems); //Añade los subitems
                            listView1.Items.Add(item); //Añade el item completo a la listview
                        }
                        break;
                    case ".rar":
                    case".zip":
                        {
                            item = new ListViewItem(file.Name, 5); //Item con índice 4 (Archivo comprimido)
                            subItems = new ListViewItem.ListViewSubItem[] //Array de subitems
                            { new ListViewItem.ListViewSubItem(item, "Archivo comprimido"),//Esta línea establece texto a mostrar del item
                              new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())}; //Esta línea correponde a la info del último acceso al fichero
                            item.SubItems.AddRange(subItems); //Añade los subitems
                            listView1.Items.Add(item); //Añade el item completo a la listview
                        }
                        break;
                    case ".iso":
                        {
                            item = new ListViewItem(file.Name, 2); //Item con índice 2 (Imagen iso)
                            subItems = new ListViewItem.ListViewSubItem[] //Array de subitems
                            { new ListViewItem.ListViewSubItem(item, "Imagen iso"),//Esta línea establece texto a mostrar del item
                              new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())}; //Esta línea correponde a la info del último acceso al fichero
                            item.SubItems.AddRange(subItems); //Añade los subitems
                            listView1.Items.Add(item); //Añade el item completo a la listview
                        }
                        break;
                    case ".png":
                    case ".jpg":
                        {
                            item = new ListViewItem(file.Name, 1); //Item con índice 1 (Imagen)
                            subItems = new ListViewItem.ListViewSubItem[] //Array de subitems
                            { new ListViewItem.ListViewSubItem(item, "Imagen"),//Esta línea establece texto a mostrar del item
                              new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())}; //Esta línea correponde a la info del último acceso al fichero
                            item.SubItems.AddRange(subItems); //Añade los subitems
                            listView1.Items.Add(item); //Añade el item completo a la listview
                        }
                        break;
                    case ".exe":
                        {
                            item = new ListViewItem(file.Name, 6); //Item con índice 6 (Archivo ejecutable)
                            subItems = new ListViewItem.ListViewSubItem[] //Array de subitems
                            { new ListViewItem.ListViewSubItem(item, "Archivo ejecutable"),//Esta línea establece texto a mostrar del item
                              new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())}; //Esta línea correponde a la info del último acceso al fichero
                            item.SubItems.AddRange(subItems); //Añade los subitems
                            listView1.Items.Add(item); //Añade el item completo a la listview
                        }
                        break;
                    default:
                        item = new ListViewItem(file.Name, 7); //Item con índice 7 (Archivo por defecto--> otros)
                        subItems = new ListViewItem.ListViewSubItem[] //Array de subitems
                        { new ListViewItem.ListViewSubItem(item, "Archivo"),//Esta línea establece texto a mostrar del item
                              new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())}; //Esta línea correponde a la info del último acceso al fichero
                        item.SubItems.AddRange(subItems); //Añade los subitems
                        listView1.Items.Add(item); //Añade el item completo a la listview
                        break;
                }             
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void idIconosPequenios_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }
    }
    }
