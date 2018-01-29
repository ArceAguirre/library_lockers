using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ListViewEmbeddedControls;
using System.Collections.Generic;

namespace ListViewManager
{
    class ListViewManager : ListViewEx
    {
        /// <summary>
        /// 
        /// </summary>
        public ListViewManager() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="All"></param>
        public void DeleteSelectedIndex(bool All)
        {
            if (All)
            {
                for (int i = this.Items.Count - 1; i >= 0; i--)
                {
                    this.Items.RemoveAt(i);
                }
            }
            else
            {
                if (this.SelectedIndices.Count <= 1)
                {
                    foreach (int index in this.SelectedIndices)
                    {
                        this.Items.RemoveAt(index);
                    }
                }
                else
                {
                    for (int i = this.SelectedIndices.Count - 1; i >= 0; i--)
                        this.Items.RemoveAt(this.SelectedIndices[i]);

                }

            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Item"></param>
        /// <returns></returns>
        private int ItemIndex(string Item)
        {
            for (int i = 0; i < this.Items.Count; i++)
            {
                if (((this.Items[i])).Text == Item)
                    return this.Items.IndexOf(this.Items[i]);
            }
            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Item"></param>
        /// <returns></returns>
        private bool ItemExist(string Item)
        {
            for (int i = 0; i < this.Items.Count; i++)
            {
                if (((this.Items[i])).Text == Item)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Item"></param>
        /// <param name="SubItemText"></param>
        public void SetItemSubItems(string Item, List<string> SubItemText)
        {
            if (ItemExist(Item))
            {
                for (int i = 0; i < SubItemText.Count; i++)
                {
                    ((ListViewItem)this.Items[ItemIndex(Item)]).SubItems.Add(SubItemText[i]);
                }
            }
            else
            {
                this.Items.Add(Item);

                for (int i = 0; i < SubItemText.Count; i++)
                {
                    ((ListViewItem)this.Items[ItemIndex(Item)]).SubItems.Add(SubItemText[i]);
                }
            }

            this.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            this.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Item"></param>
        /// <param name="SubItemText"></param>
        public void SetItemSubItems(string Item, string SubItemText)
        {
            if (ItemExist(Item))
            { 
                ((ListViewItem)this.Items[ItemIndex(Item)]).SubItems.Add(SubItemText);
            }
            else
            {
                this.Items.Add(Item);
                ((ListViewItem)this.Items[ItemIndex(Item)]).SubItems.Add(SubItemText);
            }

            this.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            this.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="SubitemIndex"></param>
        /// <returns></returns>
        public string GetSubItemsFromSelectedIndex(int SubitemIndex)
        {
            ListViewItem.ListViewSubItemCollection subitems = new ListViewItem.ListViewSubItemCollection(null);

            if (this.SelectedItems.Count == 1)
            {
                foreach (var item in this.SelectedItems)
                {
                    subitems = ((ListViewItem)item).SubItems;
                }
                return subitems[SubitemIndex].Text;
            }
            else
                return "";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="SubItemText"></param>
        /// <returns></returns>
        public void UpdateItemSubItems(List<string> SubItemText)
        {
            ListViewItem.ListViewSubItemCollection subitems = new ListViewItem.ListViewSubItemCollection(null);
            int index = 0;

            if (this.SelectedItems.Count == 1)
            {
                foreach (var item in this.SelectedItems)
                {
                    subitems = ((ListViewItem)item).SubItems;
                }
                foreach (var Subitem in subitems)
                {
                    ((ListViewItem.ListViewSubItem)Subitem).Text = SubItemText[index];
                    index++;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<string> GetSubItemsFromSelectedIndexAsList()
        {
            ListViewItem.ListViewSubItemCollection subitems = new ListViewItem.ListViewSubItemCollection(null);
            List<string> SubItemsList = new List<string>();

            if (this.SelectedItems.Count <= 1)
            {
                foreach (var item in this.SelectedItems[0].SubItems)
                {
                    SubItemsList.Add(((ListViewItem.ListViewSubItem)item).Text);
                }
                return SubItemsList;
            }
            else
                return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ArrayList GetSubItemsFromSelectedIndexAsArray()
        {
            ListViewItem.ListViewSubItemCollection subitems = new ListViewItem.ListViewSubItemCollection(null);
            ArrayList SubItemsList = new ArrayList();

            if (this.SelectedItems.Count <= 1)
            {
                foreach (var item in this.SelectedItems[0].SubItems)
                {
                    SubItemsList.Add(((ListViewItem.ListViewSubItem)item).Text);
                }
                return SubItemsList;
            }
            else
                return null;
        }

        public void RemoveRange(int index, int count)
        {
            for (int i = count - 1; i >= index; i--)
            {
                this.Items.RemoveAt(i);
            }
        }

    }
}
