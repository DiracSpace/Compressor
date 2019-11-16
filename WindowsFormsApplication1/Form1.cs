using System;
using System.Data;
using System.Windows.Forms;
using System.Security;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        DataTable simbolos = new DataTable();
        int pos, l, ns, nb, bpc, tb;

        public Form1()
        {
            InitializeComponent();
            simbolos.Columns.Add("Ind", typeof(int));
            simbolos.Columns.Add("Simbolo", typeof(string));
            simbolos.Columns.Add("Frec", typeof(int));
            simbolos.Columns.Add("Visitado", typeof(bool));
            simbolos.Columns.Add("Izq", typeof(int));
            simbolos.Columns.Add("Der", typeof(int));
            simbolos.Columns.Add("Código",typeof(string));
            simbolos.Columns.Add("Bits", typeof(int));
            simbolos.Columns.Add("Bits por caracter", typeof(int));

            gdvSimbolos.DataSource = simbolos;
            gdvSimbolos.Columns["Visitado"].Visible = false;
            /*gdvSimbolos.Columns["Ind"].Visible = false;
            gdvSimbolos.Columns["Izq"].Visible = false;
            gdvSimbolos.Columns["Der"].Visible = false;
            gdvSimbolos.Columns["Código"].Visible = false;
            gdvSimbolos.Columns["Bits"].Visible = false;
            gdvSimbolos.Columns["Bits por caracter"].Visible = false;*/
        }

        private void BtnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog()
            {
                FileName = "Selecciona un archivo de texto",
                Filter = "Text files (*.txt) | *.txt",
                Title = "Seleccionar archivo"
            };

            if (fd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var ruta = fd.FileName;
                    txtExaminar.Text = ruta;
                    rtxtTexto.Text = File.ReadAllText(ruta);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                procesarTexto();
            }
        }
        private void procesarTexto()
        {
            string s, s1, s2;
            int j, f1, f2, p1, p2;

            l = rtxtTexto.TextLength;
            j = -1;
            /*************************** Ingrear los primeros nodos al arbol ************************************/
            for (int i = 0; i < l; i++)
            {
                s = rtxtTexto.Text.Substring(i, 1);
                pos = buscarSimbolo(s);
                if (pos >= 0)
                    simbolos.Rows[pos][2] = Int32.Parse(simbolos.Rows[pos][2].ToString()) + 1;
                else
                    simbolos.Rows.Add(new Object[] { j += 1, s, 1, false, -1, -1,"" });
            }
            ns = j;

            /*************************************** Generar arbol ********************************************/
            for (int i = 0; i < ns; i++)
            {
                p1 = buscarMenor();
                f1 = Int32.Parse(simbolos.Rows[p1][2].ToString());
                s1 = simbolos.Rows[p1][1].ToString();                
                simbolos.Rows[p1]["Visitado"] = true;

                p2 = buscarMenor();
                f2 = Int32.Parse(simbolos.Rows[p2][2].ToString());
                s2 = simbolos.Rows[p2][1].ToString();
                simbolos.Rows[p2]["Visitado"] = true;

                simbolos.Rows.Add(new Object[] { j += 1, s1 + s2, f1 + f2, false, p1, p2, "" });
            }

            /****************************************** Generar códigos *************************************/
            for (int i = 1; i <= ns; i++)
            {
                asignarCero(Int32.Parse(simbolos.Rows[simbolos.Rows.Count - i]["Izq"].ToString()));
                asignarUno(Int32.Parse(simbolos.Rows[simbolos.Rows.Count - i]["Der"].ToString()));
            }


            /************************************ Calcular longitudes ********************************************/
            for (int i = 0; i <= ns; i++)
            {
                nb = simbolos.Rows[i]["Código"].ToString().Length;
                bpc = nb * Int32.Parse(simbolos.Rows[i]["Frec"].ToString());
                simbolos.Rows[i]["Bits"] = nb;
                simbolos.Rows[i]["Bits por caracter"] = bpc;
                tb = tb + bpc;
            }

            /****************************** Mostrar información ************************************************/
            txtCaracteres.Text = l.ToString();
            txtAntes.Text = (l * 8).ToString();
            txtDespues.Text = tb.ToString();
            MostrarNodos(chkNodos.Checked);
        }

        private int buscarMenor()
        {
            int m, f, pos = 0;
            bool b;
            m = l + 1;
            for (int i = 0; i < simbolos.Rows.Count; i++)
            {
                f = Int32.Parse(simbolos.Rows[i][2].ToString());
                b = Boolean.Parse(simbolos.Rows[i]["Visitado"].ToString());
                if (f < m && !b)
                {
                    m = f;
                    pos = i;
                }
            }
            return pos;
        }

        private int buscarSimbolo(string s)
        {
            int p = -1;
            if (simbolos.Rows.Count > 1)                
                for (int i = 0; i < simbolos.Rows.Count; i++)          
                    if (s == simbolos.Rows[i][1].ToString())                
                        return i;                            
            return p;
        }

        private void asignarCero(int p)
        {
            if (Int32.Parse(simbolos.Rows[p]["Izq"].ToString()) == -1)
                simbolos.Rows[p]["Código"] = simbolos.Rows[p]["Código"].ToString() + "0";
            else
            {
                asignarCero(Int32.Parse(simbolos.Rows[p]["Izq"].ToString()));
                asignarCero(Int32.Parse(simbolos.Rows[p]["Der"].ToString()));
            }
        }

        private void asignarUno(int p)
        {
            if( Int32.Parse(simbolos.Rows[p]["Der"].ToString()) == -1)
                simbolos.Rows[p]["Código"] = simbolos.Rows[p]["Código"].ToString() + "1";
            else
            {
                asignarUno(Int32.Parse(simbolos.Rows[p]["izq"].ToString()));
                asignarUno(Int32.Parse(simbolos.Rows[p]["Der"].ToString()));
            }
        }













        private void ChkIndice_CheckedChanged(object sender, EventArgs e)
        {
            gdvSimbolos.Columns["Ind"].Visible = chkIndice.Checked;
        }


        private void MostrarNodos(bool b)
        {
            for (int i = ns + 1; i < ns + ns + 1; i++)
            {
                gdvSimbolos.Rows[i].Visible = b;
            }
        }

        private void ChkNodos_CheckedChanged(object sender, EventArgs e)
        {
            MostrarNodos(chkNodos.Checked);
            /*for(int i = ns+1; i<ns+ns+1; i++)
            {
                gdvSimbolos.Rows[i].Visible = chkNodos.Checked;
            }*/
        }

        private void ChkHijos_CheckedChanged(object sender, EventArgs e)
        {
            gdvSimbolos.Columns["Izq"].Visible = chkHijos.Checked;
            gdvSimbolos.Columns["Der"].Visible = chkHijos.Checked;
        }

        private void ChkCodigo_CheckedChanged(object sender, EventArgs e)
        {
            gdvSimbolos.Columns["Código"].Visible = chkCodigo.Checked;
        }

        private void ChkInfo_CheckedChanged(object sender, EventArgs e)
        {
            gdvSimbolos.Columns["Bits"].Visible = chkInfo.Checked;
            gdvSimbolos.Columns["Bits por caracter"].Visible = chkInfo.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
