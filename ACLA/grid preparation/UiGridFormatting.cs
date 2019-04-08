using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ACLA
{
    public static class UiGridFormatting
    {
        public static void FormatGrid(DataGridView dgv, DataTable dt, string searchCriteria = null)
        {
            dgv.ReadOnly = true;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.MultiSelect = true;
            dgv.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgv.DataSource = dt;
            dgv.Rows[0].Frozen = true; //first row will always be visible
            dgv.Rows[0].DefaultCellStyle.BackColor = Color.LightYellow;
            if (!string.IsNullOrWhiteSpace(searchCriteria))
            {
            ColourGridUsingStringInput(searchCriteria, Color.LightYellow, 0, dgv);
            }

        }

        private static void ColourGridUsingStringInput(string searchCriteria, Color colour, int columnNumberToCheck,
            DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[columnNumberToCheck].Value.ToString().Contains(searchCriteria))
                {
                    row.DefaultCellStyle.BackColor = colour;
                }
            }
        }

        private static void ColourGridUsingNumberInput(int searchCriteria, Color colour, int columnNumberToCheck,
            DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[columnNumberToCheck].Value.ToString().Contains(searchCriteria.ToString()) &&
                    row.Cells[columnNumberToCheck].Value.ToString().Equals(searchCriteria.ToString()))
                {
                    row.DefaultCellStyle.BackColor = colour;
                }
            }
        }
    }
}