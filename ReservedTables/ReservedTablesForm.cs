using ReservedTables.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace ReservedTables
{
    public partial class ReservedTablesForm : Form
    {
        string path = @"C:\Users\nikol\source\repos\ReservedTables\ReservedTables\Clients.xml";
        Client client;
        DataTable table = new DataTable();
        //DataSet dataSet;
        bool isEmpty = true;
        public ReservedTablesForm()
        {
            InitializeComponent();
        }
        private void ReservedTablesForm_Load(object sender, EventArgs e)
        {

        }
        private void bt_serialization_Click(object sender, EventArgs e)
        {
            try
            {
                table = GetInfoFromDataGridView(dataGridView);
                Client[] clients = new Client[table.Rows.Count];
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    int id = Convert.ToInt32(dataGridView.Rows[i].Cells[0].Value);
                    string fullName = dataGridView.Rows[i].Cells[1].Value.ToString();
                    int tableNumber = Convert.ToInt32(dataGridView.Rows[i].Cells[2].Value);
                    string reservationTime = dataGridView.Rows[i].Cells[3].Value.ToString();
                    int age = Convert.ToInt32(dataGridView.Rows[i].Cells[4].Value);
                    long phoneNumber = Convert.ToInt64(dataGridView.Rows[i].Cells[5].Value);
                    client = new Client(id, fullName, tableNumber, reservationTime, age, phoneNumber);
                    clients[i] = client;
                }
                XmlSerializer formatter = new XmlSerializer(typeof(Client[]));
                using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(stream, clients);

                    MessageBox.Show("Объект сериализован" , "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bе_deserialization_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer formatter = new XmlSerializer(typeof(Client[]));
                DataTable table = GetInfoFromDataGridView(dataGridView);
                table.Rows.Clear();
                using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
                {
                    Client[] clients = (Client[])formatter.Deserialize(stream);
                    foreach (Client client in clients)
                    {
                        object[] rowElements = new object[table.Columns.Count];
                        rowElements[0] = client.Id;
                        rowElements[1] = client.FullName;
                        rowElements[2] = client.TableNumber;
                        rowElements[3] = client.ReservationTime;
                        rowElements[4] = client.Age;
                        rowElements[5] = client.PhoneNumber;
                        table.Rows.Add(rowElements);
                    }
                }
                dataGridView.Columns.Clear();
                dataGridView.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bt_delete_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewCell cell in dataGridView.SelectedCells)
                {
                    dataGridView.Rows.RemoveAt(cell.RowIndex);
                }
                DataTable table = GetInfoFromDataGridView(dataGridView);
                DataSet dataset = new DataSet();
                dataset.Tables.Add(table);
                dataset.WriteXml("Clients.xml");
                dataGridView.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private DataTable GetInfoFromDataGridView(DataGridView dataDridView)
        {
            table = new DataTable("Clients");
            int columnIndex = 0;
            foreach (DataGridViewColumn column in dataDridView.Columns)
            {
                if (column.Visible)
                {
                    table.Columns.Add(dataDridView.Columns[columnIndex++].HeaderText);
                }
            }

            object[] rowElements = new object[dataDridView.Columns.Count];
            for (int j = 0; j < dataDridView.Rows.Count - 1; j++)
            {
                for (int i = 0; i < dataDridView.Rows[j].Cells.Count; i++)
                {
                    while (isEmpty)
                    {
                        if (dataDridView.Rows[j].Cells[i].Value == null ||
                                    dataDridView.Rows[j].Cells[i].Value == DBNull.Value ||
                                    String.IsNullOrWhiteSpace(dataDridView.Rows[j].Cells[i].Value.ToString()))
                        {
                            MessageBox.Show($"Пожалуйста, заполните пустую ячейку в {j + 1} строке и {i + 1} столбце", "Предупреждение",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            isEmpty = true;
                        }
                        else if(dataDridView.Rows[j].Cells[i].Value != null &&
                              dataDridView.Rows[j].Cells[i].Value != DBNull.Value &&
                              !String.IsNullOrWhiteSpace(dataDridView.Rows[j].Cells[i].Value.ToString()))
                        {
                            rowElements[i] = dataDridView.Rows[j].Cells[i].Value;
                            isEmpty=false;
                        }
                    }
                        
                }
                table.Rows.Add(rowElements);
            }
            return table;
        }
        #region var
        /*
        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                try
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        path = dialog.FileName;

                        XmlSerializer serializer = new XmlSerializer(typeof(Client));
                        StreamReader reader = new StreamReader(path);

                        var input = serializer.Deserialize(reader);
                        reader.Close();
                        dataGridView.DataSource = input;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   
        }
        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog fileDialog = new SaveFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = fileDialog.FileName;
                XmlSerializer serializer = new XmlSerializer(typeof(Client));
                StreamWriter writer = new StreamWriter(path);
                serializer.Serialize(writer, dataGridView.DataSource);
                writer.Close();
            }

        }
        */
        #endregion
        private void deleteTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    DeleteByValue();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void DeleteByValue()
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["ФИО"].Value.Equals(deleteTextBox.Text))
                {
                    dataGridView.Rows.RemoveAt(row.Index);
                    break;
                }
            }
            DataTable table = GetInfoFromDataGridView(dataGridView);
            DataSet dataset = new DataSet();
            dataset.Tables.Add(table);
            dataset.WriteXml("Clients.xml");
            dataGridView.Refresh();
        }
        private void bt_deleteByValue_Click(object sender, EventArgs e)
        {
            DeleteByValue();
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                dataGridView.Rows.Remove(row);
            }
            DataTable table = GetInfoFromDataGridView(dataGridView);
            DataSet dataset = new DataSet();
            dataset.Tables.Add(table);
            dataset.WriteXml("Clients.xml");
            dataGridView.Refresh();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
