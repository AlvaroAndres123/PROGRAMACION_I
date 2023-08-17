using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjCalculadora
{
    public partial class frmCalculadora : Form
    {
        private decimal _Operand;
        private string _Operator;
        private string _Operandt;

        public frmCalculadora()
        {
            InitializeComponent();
            Reset();
        }

        private void Reset()
        {
            _Operand = 0;
            _Operator = "";
            _Operandt = "0";



            txtResult.Text = "0";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }


        private void btnText_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string buttonText = btn.Text;
            SetOperandTask(buttonText);
        }


        private void SetOperandTask(string value)
        {
            // Si es el valor numérico
            if (value == "9" || value == "8" || value == "7" ||
                value == "6" || value == "5" || value == "4" ||
                value == "3" || value == "2" || value == "1" || value == "0" || value == ".")
            {
                if (_Operandt == "0")
                {
                    _Operandt = value; // Reemplazar el cero inicial
                }
                else
                {
                    _Operandt += value;
                }
                txtResult.Text = _Operandt;
            }
            // Si el valor es un operador
            else if (value == "+" || value == "-" || value == "*" || value == "/")
            {
                if (_Operandt != "")
                {
                    _Operator = value;
                    _Operand = decimal.Parse(_Operandt);
                    _Operandt = "";
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void Delete()
        {
            if (_Operandt.Length > 1)
            {
                _Operandt = _Operandt.Substring(0, _Operandt.Length - 1);
            }
            else
            {
                _Operandt = "0";

                txtResult.Text = _Operandt;
            }
        }



        private void DoOperation()
        {
            decimal result = 0;
            if (_Operator == "+")
            {
                result = _Operand + decimal.Parse(_Operandt);
            }
            else if (_Operator == "-")
            {
                result = _Operand - decimal.Parse(_Operandt);
            }
            else if (_Operator == "*")
            {
                result = _Operand * decimal.Parse(_Operandt);
            }
            else if (_Operator == "/")
            {
                result = _Operand / decimal.Parse(_Operandt);
            }

            _Operandt = result.ToString();
            txtResult.Text = _Operandt;

            _Operator = "";
            _Operand = result;
        }


        private void btnEqual_Click(object sender, EventArgs e)
        {
            DoOperation();
        }

        private void frmCalculadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetOperandTask(e.KeyChar.ToString());
        }
    }
}
