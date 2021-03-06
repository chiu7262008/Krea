﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Design;
using System.Windows.Forms;
using System.ComponentModel;

namespace Krea.GameEditor.PropertyGridEditors
{

    public class CheckBoxEditor : UITypeEditor
    {

        public override bool GetPaintValueSupported(ITypeDescriptorContext context)
        {
            return true;

        }


        public override void PaintValue(PaintValueEventArgs e)
        {
            if (e.Value != null)
            {
                if ((bool)e.Value == true)
                    e.Graphics.DrawImage(Properties.Resources.validateBlue, e.Bounds);
                else
                    e.Graphics.DrawImage(Properties.Resources.cancelOrange, e.Bounds);
            }
            
          
        }


    }
}

