using System;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;

namespace GroupFilter {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            // Binds the pivot grid to data.
            this.salesPersonTableAdapter.Fill(this.nwindDataSet.SalesPerson);

            // Gets the field group from the collection.
            PivotGridGroup OrderDateGroup = pivotGridControl1.Groups[0];

            // Locks the PivotGroupFilterValues object by disabling visual updates.
            OrderDateGroup.FilterValues.BeginUpdate();

            // Sets the filter type. 
            // It specifies that the PivotGridControl should display only filter values.
            OrderDateGroup.FilterValues.FilterType = PivotFilterType.Included;

            // Creates a filter value and adds it to the PivotGroupFilterValues.Values collection.
            OrderDateGroup.FilterValues.Values.Add(new PivotGroupFilterValue(2014));

            // Creates a filter value and adds it to the PivotGroupFilterValues.Values collection.
            // Then creates a child value of the filter value and adds it to the parent value collection.
            OrderDateGroup.FilterValues.Values.Add(2015).ChildValues.Add(1);

            // Unlocks the PivotGroupFilterValues object.
            OrderDateGroup.FilterValues.EndUpdate();
        }
    }
}
