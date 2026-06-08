using System.Drawing;
using System.Windows.Forms;

namespace ITSupport.Helpers
{
    public static class FormHelper
    {
        public static readonly Color PrimaryPastel = Color.FromArgb(189, 210, 252);
        public static readonly Color SuccessPastel = Color.FromArgb(187, 247, 208);
        public static readonly Color DangerPastel = Color.FromArgb(254, 202, 202);
        public static readonly Color WarningPastel = Color.FromArgb(253, 230, 138);
        public static readonly Color DarkPastel = Color.FromArgb(51, 65, 85);
        public static readonly Color LightPastel = Color.FromArgb(248, 250, 252);
        public static readonly Color GrayPastel = Color.FromArgb(148, 163, 184);
        public static readonly Color WhitePastel = Color.FromArgb(255, 255, 255);

        public static void ConfigureDataGridView(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.BackgroundColor = WhitePastel;
            dgv.EnableHeadersVisualStyles = false;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
            dgv.RowTemplate.Height = 38;
            dgv.GridColor = Color.FromArgb(226, 232, 240);

            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = PrimaryPastel;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = DarkPastel;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.ColumnHeadersHeight = 42;

            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            dgv.DefaultCellStyle.ForeColor = DarkPastel;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgv.DefaultCellStyle.SelectionForeColor = DarkPastel;
            dgv.DefaultCellStyle.Padding = new Padding(5, 0, 5, 0);

            dgv.AlternatingRowsDefaultCellStyle.BackColor = LightPastel;
        }

        public static void StyleButton(Button btn, Color backColor)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = backColor;
            btn.ForeColor = DarkPastel;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.UseCompatibleTextRendering = false;
            btn.FlatAppearance.MouseOverBackColor = ControlPaint.Light(backColor, 0.85f);
            btn.FlatAppearance.MouseDownBackColor = ControlPaint.Dark(backColor, 0.9f);
        }

        public static void StyleTextBox(TextBox txt, bool isMultiline = false)
        {
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            txt.BackColor = LightPastel;
            txt.ForeColor = DarkPastel;
        }

        public static void StyleComboBox(ComboBox cmb)
        {
            cmb.FlatStyle = FlatStyle.Flat;
            cmb.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb.Height = 34;
            cmb.BackColor = LightPastel;
            cmb.ForeColor = DarkPastel;
        }

        public static void StyleForm(Form form)
        {
            form.BackColor = LightPastel;
            form.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MaximizeBox = false;
        }

        public static void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowInfo(string message)
        {
            MessageBox.Show(message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowWarning(string message)
        {
            MessageBox.Show(message, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult ShowQuestion(string message)
        {
            return MessageBox.Show(message, "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static string[] StatusFilterItems { get; } =
        {
            "Все", "Новый", "В работе", "Решён", "Закрыт"
        };

        public static string StatusFilterToCode(string display)
        {
            switch (display)
            {
                case "Новый": return "New";
                case "В работе": return "InProgress";
                case "Решён": return "Resolved";
                case "Закрыт": return "Closed";
                default: return null;
            }
        }

        public static string FormatStatus(string status)
        {
            switch (status)
            {
                case "New": return "Новый";
                case "InProgress": return "В работе";
                case "Resolved": return "Решён";
                case "Closed": return "Закрыт";
                default: return status ?? "—";
            }
        }

        public static void StyleLabel(Label lbl, bool isTitle = false)
        {
            lbl.ForeColor = isTitle ? DarkPastel : GrayPastel;
            lbl.Font = new Font("Segoe UI", isTitle ? 14 : 9, isTitle ? FontStyle.Bold : FontStyle.Regular);
            lbl.BackColor = Color.Transparent;
        }
    }
}