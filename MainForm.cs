using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using MonopolyProject.Classes;
using System.Data;
using System.Windows.Forms;

namespace MonopolyProject
{
    public partial class MainForm : Form
    {
        ApplicationContextDB db = new ApplicationContextDB();

        public object? DataContext { get; private set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //�����������, ��� ���� ������ �������
            db.Database.EnsureCreated();

            #region ��� Pallets

            //��������� ������ �� ��
            db.Pallets.Load();

            //� ������������� ������ � �������� ���������
            DataContext = db.Pallets.Local.ToObservableCollection();

            palletBindingSource.DataSource = DataContext;

            #endregion

            #region ��� Boxes

            //��������� ������ �� ��
            db.Boxes.Load();

            //� ������������� ������ � �������� ���������
            DataContext = db.Boxes.Local.ToObservableCollection();

            boxBindingSource.DataSource = DataContext;

            #endregion
        }

        private void CreatePalletButton_Click(object sender, EventArgs e)
        {
            try
            {
                //�������� �� ������� ��� �������� �������
                if (string.IsNullOrEmpty(WidthPalletTextBox.Text) || string.IsNullOrEmpty(HeightPalletTextBox.Text) || string.IsNullOrEmpty(DepthPalletTextBox.Text))
                {
                    MessageBox.Show("��� ��������, ��������� ��� ������������ ����", "������ �����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Pallet pallet = new Pallet();

                    pallet.Width = Convert.ToInt32(WidthPalletTextBox.Text);
                    pallet.Height = Convert.ToInt32(HeightPalletTextBox.Text);
                    pallet.Depth = Convert.ToInt32(DepthPalletTextBox.Text);

                    //��� ������� ����������� �� ����� ���� ��������� ������� + 30��.
                    //pallet.Weight = 

                    db.Pallets.Add(pallet);

                    db.SaveChanges();

                    #region ��������� BindingSource ��� dataGrid

                    palletBindingSource.DataSource = null;

                    //��������� ������ �� ��
                    db.Pallets.Load();

                    //� ������������� ������ � �������� ���������
                    DataContext = db.Pallets.Local.ToObservableCollection();

                    palletBindingSource.DataSource = DataContext;

                    #endregion

                    MessageBox.Show("������ ������� ������", "�������� ��������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "�������������� ��������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CreateBoxButton_Click(object sender, EventArgs e)
        {
            try
            {
                //�������� �� ������� ��� �������� �������
                if (string.IsNullOrEmpty(WidthBoxTextBox.Text) || string.IsNullOrEmpty(HeightBoxTextBox.Text) || string.IsNullOrEmpty(DepthBoxTextBox.Text))
                {
                    MessageBox.Show("��� ��������, ��������� ��� ������������ ����", "������ �����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Box box = new Box();

                    box.Width = Convert.ToInt32(WidthBoxTextBox.Text);
                    box.Height = Convert.ToInt32(HeightBoxTextBox.Text);
                    box.Depth = Convert.ToInt32(DepthBoxTextBox.Text);

                    box.PalletId = Convert.ToInt32(NumberPalletComboBox.Text);

                    box.CalculationVolume(box.Width, box.Height, box.Depth);

                    //��������� �� ���� ����� ��������
                    if (ExpirationDateCheckBox.Checked)
                    {
                        box.ExpirationDate = Convert.ToDateTime(ExpirationDateTimePicker.Value.Date);
                    }

                    //��������� �� ���� ������������
                    if (ManufactureDateCheckBox.Checked)
                    {
                        box.ManufactureDate = Convert.ToDateTime(ManufactureDateTimePicker.Value.Date);

                        //���� ������� ���� ������������, ���� �������� �����������
                        box.CalculationExpirationDate(box.ManufactureDate);
                    }

                    db.Boxes.Add(box);

                    db.SaveChanges();

                    #region ��������� BindingSource ��� dataGrid

                    boxBindingSource.DataSource = null;

                    //��������� ������ �� ��
                    db.Boxes.Load();

                    //� ������������� ������ � �������� ���������
                    DataContext = db.Boxes.Local.ToObservableCollection();

                    boxBindingSource.DataSource = DataContext;

                    #endregion

                    MessageBox.Show("������� ������� �������", "�������� ��������", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "�������������� ��������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void ExpirationDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ExpirationDateCheckBox.Checked)
            {
                ExpirationDateTimePicker.Visible = true;
            }
            else
            {
                ExpirationDateTimePicker.Visible = false;
            }
        }

        private void ManufactureDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ManufactureDateCheckBox.Checked)
            {
                ManufactureDateTimePicker.Visible = true;
            }
            else
            {
                ManufactureDateTimePicker.Visible = false;
            }
        }
    }
}