using RubricaForm.ServiceOnDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RubricaForm
{
    public partial class Form1 : Form
    {
        public int selectedId { get; set; }

        private Contatto selectedContatto;

        public Form1()
        {
            InitializeComponent();
        }

        private void LabelNome_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshRubrica();
        }

        private void RefreshRubrica()
        {
            cbxRubrica.Items.Clear();
            ServiceClient service = new ServiceClient();
            List<Contatto> rubrica = service.GetAllContatti().ToList();
            foreach (var c in rubrica)
            {
                cbxRubrica.Items.Add(c);
                cbxRubrica.DisplayMember = "Cognome";
                cbxRubrica.ValueMember = "Id";
            }
        }

        private void BtnSaveSubscribeForm_Click(object sender, EventArgs e)
        {
            ServiceClient service = new ServiceClient();
            service.Subscribe(TakeContatto());
            RefreshRubrica();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceClient service = new ServiceClient();
            Contatto flagContatto = TakeContatto();
            flagContatto.Id = selectedContatto.Id;
            service.UpdateContatto(flagContatto);
            RefreshRubrica();
        }

        private Contatto TakeContatto()
        {
            return new Contatto()
            {
                Nome = TxtName.Text,
                Cognome = TxtLastName.Text,
                NumberPhone = TxtNumberPhone.Text,
                BirthDay = (DateTime)BirthdayDatePicker.Value
            };
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiceClient service = new ServiceClient();
            if (cbxRubrica.SelectedItem == null) 
                return;
            selectedContatto = (Contatto)cbxRubrica.SelectedItem;
            selectedContatto = service.GetContatto(selectedContatto.Id);
            if (selectedContatto == null)
                return;
            TxtName.Text = selectedContatto.Nome;
            TxtLastName.Text = selectedContatto.Cognome;
            TxtNumberPhone.Text = selectedContatto.NumberPhone;
            BirthdayDatePicker.Value = (DateTime)selectedContatto.BirthDay;
        }
    }
}
