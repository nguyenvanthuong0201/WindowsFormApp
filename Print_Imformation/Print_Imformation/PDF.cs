using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Print_Imformation
{
    public partial class PDF : DevExpress.XtraReports.UI.XtraReport
    {
        public PDF()
        {
            InitializeComponent();
        }

        public XRCheckBox CreateXRCheckBox()
        {
            // Create an XRCheckBox control.
            XRCheckBox xrCheckBox1 = new XRCheckBox();

            xrCheckBox1.ExpressionBindings.AddRange(new ExpressionBinding[] {
    // Bind the CheckState property to the UnitsInStock data field.
            new ExpressionBinding("BeforePrint", "CheckState", "Iif([UnitsInStock]>=1,\'Checked\', \'Unchecked\')"),
    // Change the control's text depending on the UnitsInStock data field value.
            new ExpressionBinding("BeforePrint", "Text",
           "Iif([UnitsInStock]>0,\'Units in Stock: \' + [UnitsInStock], \'None\')")});

            // Set the control size.
            xrCheckBox1.SizeF = new SizeF(150F, 20F);

            return xrCheckBox1;
        }
        public void checkbox()
        {
            xrCheckBox1.CheckState = checked;
            xrCheckBox1.Checked = true;
        }
    }
}
