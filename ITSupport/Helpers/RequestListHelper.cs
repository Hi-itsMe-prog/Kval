using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ITSupport.Models;

namespace ITSupport.Helpers
{
    public static class RequestListHelper
    {
        public static List<RequestViewModel> ApplyFilter(
            IEnumerable<RequestViewModel> source,
            string statusCode,
            string search,
            bool searchByUserName = false,
            int? priorityId = null)
        {
            IEnumerable<RequestViewModel> query = source;

            if (!string.IsNullOrEmpty(statusCode))
                query = query.Where(r => r.Status == statusCode);

            if (priorityId.HasValue)
                query = query.Where(r => r.PriorityId == priorityId.Value);

            if (!string.IsNullOrWhiteSpace(search))
            {
                string term = search.Trim();
                query = query.Where(r =>
                    Contains(r.ProblemDesc, term) ||
                    Contains(r.CategoryName, term) ||
                    Contains(r.PriorityName, term) ||
                    (searchByUserName && Contains(r.UserName, term)));
            }

            return query.ToList();
        }

        private static bool Contains(string value, string term) =>
            value != null && value.IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0;

        public static void BindEmployeeGrid(DataGridView dgv, IList<RequestViewModel> data)
        {
            dgv.DataSource = null;
            dgv.Columns.Clear();
            dgv.AutoGenerateColumns = false;

            dgv.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "№", Width = 50 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProblemDesc", HeaderText = "Проблема", FillWeight = 200 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CategoryName", HeaderText = "Категория", Width = 120 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PriorityName", HeaderText = "Приоритет", Width = 100 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StatusDisplay", HeaderText = "Статус", Width = 100 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CreatedAt",
                HeaderText = "Создана",
                Width = 130,
                DefaultCellStyle = { Format = "dd.MM.yyyy HH:mm" }
            });

            dgv.DataSource = data.Select(r => new
            {
                r.Id,
                r.ProblemDesc,
                r.CategoryName,
                r.PriorityName,
                StatusDisplay = FormHelper.FormatStatus(r.Status),
                r.CreatedAt
            }).ToList();
        }

        public static void BindItGrid(DataGridView dgv, IList<RequestViewModel> data)
        {
            dgv.DataSource = null;
            dgv.Columns.Clear();
            dgv.AutoGenerateColumns = false;

            dgv.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "№", Width = 50 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "UserName", HeaderText = "Сотрудник", Width = 140 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProblemDesc", HeaderText = "Проблема", FillWeight = 180 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CategoryName", HeaderText = "Категория", Width = 110 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PriorityName", HeaderText = "Приоритет", Width = 90 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StatusDisplay", HeaderText = "Статус", Width = 90 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CreatedAt",
                HeaderText = "Создана",
                Width = 120,
                DefaultCellStyle = { Format = "dd.MM.yyyy HH:mm" }
            });

            dgv.DataSource = data.Select(r => new
            {
                r.Id,
                r.UserName,
                r.ProblemDesc,
                r.CategoryName,
                r.PriorityName,
                StatusDisplay = FormHelper.FormatStatus(r.Status),
                r.CreatedAt
            }).ToList();
        }
    }
}