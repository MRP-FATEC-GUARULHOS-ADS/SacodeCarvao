﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRP_SdC
{
    public partial class ExplosaoProduto : Form
    {
        public List<Componente> componentes = null;

        public ExplosaoProduto()
        {
            InitializeComponent();
        }
    }
}