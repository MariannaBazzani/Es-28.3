using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_28._3
{
    public partial class Appartamento : Component
    {
        public Appartamento()
        {
            InitializeComponent();
        }

        public Appartamento(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
