using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Interfaces;

namespace MetroPanelSlide.Panel
{
    public partial class pnlOne : pnlSlider, IMetroControl
    {
        public pnlOne(Form owner) : base(owner)
        {
            InitializeComponent();
            this.StyleManager.Update();
        }
    }
}
