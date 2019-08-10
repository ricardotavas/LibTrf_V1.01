using System;
using System.Windows.Forms;
using Trf2L;

namespace App
{
    public partial class Form1 : Form
    {
        private IProtocolo DLL = new Protocolo();

        Byte cntMsg = 0;                                // Contador de envio automático

        UInt16 cnt = 0;                                 // Número de bytes válidos no buffer
        Byte[] buf = new Byte[512];                     // Buffer 

        String textWyma="";                             // Guarda a string no formato do interpretador Wyma
        Boolean flagEdit = false;                       // Indica se o usuário entrou com caracteres no TextBox

        public Form1()
        {
            InitializeComponent();

            comboBaudRate.SelectedIndex = 3;
            comboCom.SelectedItem = "COM1";

            DLL.IP = textBox_IP.Text;
            DLL.Comport = comboCom.SelectedIndex + 1;
            DLL.Baudrate = comboBaudRate.SelectedItem.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioUDP.Checked = true;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkMsgAuto.Checked == true)
            {
                if (++cntMsg == 1)
                {
                    textWyma = "Mensag 1";
                }
                else if (cntMsg == 2)
                {
                    textWyma = Convert.ToString(Convert.ToChar(221));
                    textWyma += "Mensag 2";
                }
                else if (cntMsg == 3)
                {
                    textWyma = Convert.ToString(Convert.ToChar(222));
                    textWyma += "Mensag 3";
                }
                else if (cntMsg == 4)
                {
                    textWyma = Convert.ToString(Convert.ToChar(223));
                    textWyma += "Mensag 4";
                    cntMsg = 0;
                }

                doArrayProtocol();

                if (radioUDP.Checked)
                {
                    Send_Set(Protocolo.ITF_UDP);
                }
                else if (radioTCP.Checked)
                {
                    Send_Set(Protocolo.ITF_TCP);
                }
                else if (radioUART.Checked)
                {
                    Send_Set(Protocolo.ITF_UART);
                }
            }
        }

        private void textBox_IP_TextChanged(object sender, EventArgs e)
        {
            DLL.IP = textBox_IP.Text;
        }

        private void button_SendSet_Click_1(object sender, EventArgs e)
        {
            doArrayProtocol();

            if (radioUDP.Checked)
            {
                Send_Set(Protocolo.ITF_UDP);
            }
            else if (radioTCP.Checked)
            {
                Send_Set(Protocolo.ITF_TCP);
            }
            else if (radioUART.Checked)
            {
                Send_Set(Protocolo.ITF_UART);
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textLog.Clear();
        }

        private void button_ClearText_Click(object sender, EventArgs e)
        {
            textWyma = "";
            textMessage.Clear();
        }

        private void comboPos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Armazena comando binario na variavel
            textWyma += Convert.ToString(Convert.ToChar(Convert.ToInt32(comboPos.SelectedItem.ToString().Substring(0, 3))));
            // No textbox mostra comando amigavel
            textMessage.Text += "<Pos" + comboPos.SelectedItem.ToString().Substring(0, 3) + ">";
            textMessage.Focus();
            textMessage.Select(textMessage.Text.Length, 0);
        }

        private void comboFon_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Armazena comando binario na variavel
            textWyma += Convert.ToString(Convert.ToChar(Convert.ToInt32 (comboFon.SelectedItem.ToString().Substring(0,3))));
            // No textbox mostra comando amigavel
            textMessage.Text += "<Fon" + comboFon.SelectedItem.ToString().Substring(0, 3) + ">";
            textMessage.Focus();
            textMessage.Select(textMessage.Text.Length, 0);
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Back || e.KeyData == Keys.Enter)
                flagEdit = false;
            else
                flagEdit = true;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (flagEdit && textMessage.Text!="")
                textWyma += textMessage.Text.Substring(textMessage.Text.Length - 1, 1);
            flagEdit = false;
        }

        private void button_IncMsgAuto_Click(object sender, EventArgs e)
        {
            if (timer1.Interval > 100)
                timer1.Interval -= 100;
            label_speedMsg.Text = timer1.Interval + "mSeg";
        }

        private void button_decMsgAuto_Click(object sender, EventArgs e)
        {
            if (timer1.Interval < 9900)
                timer1.Interval += 100;
            label_speedMsg.Text = timer1.Interval + "mSeg";
        }

        private void button_incspeed_Click(object sender, EventArgs e)
        {
            if (timer1.Interval > 100)
                timer1.Interval -= 100;
        }

        private void button_decspeed_Click(object sender, EventArgs e)
        {
            if (timer1.Interval < 9900)
                timer1.Interval += 100;
        }

        private void doArrayProtocol()
        {
            if (tabControl1.SelectedTab.Text == "Mensagens")
            {
                cnt = 0;
                while (cnt < (textWyma.Length))
                {
                    buf[cnt] = (byte)(Convert.ToChar(textWyma.Substring(cnt, 1)));
                    cnt++;
                }

            }
        }

        private void Send_Set(Byte interf)
        {
            button_SendSet.Enabled = false;

            Byte frame = DLL.SetRequest(interf, cnt, buf);
            String result = "SEND SET   Valor: " + System.Text.Encoding.ASCII.GetString(buf,0,cnt) + " " + Convert.ToChar(13) + Convert.ToChar(10);
            textLog.Text += result;

            Byte flag = 0;
            DLL.WaitResponse(interf, ref flag, frame);

            result = "RECEIVE flag: ";
            result += Convert.ToString(Convert.ToInt32(flag));
            result += Convert.ToChar(13);
            textLog.Text += result;

            button_SendSet.Enabled = true;
        }
        private void radioUDP_CheckedChanged(object sender, EventArgs e)
        {
            textBox_IP.Enabled = true;
            comboCom.Enabled = false;
            comboBaudRate.Enabled = false;
            DLL.Disconnect_UART();
        }

        private void radioTCP_CheckedChanged(object sender, EventArgs e)
        {
            textBox_IP.Enabled = true;
            comboCom.Enabled = false;
            comboBaudRate.Enabled = false;
            DLL.Disconnect_UART();
        }
        private void radioUART_CheckedChanged(object sender, EventArgs e)
        {
            textBox_IP.Enabled = false;
            comboCom.Enabled = true;
            comboBaudRate.Enabled = true;
            DLL.Connect_UART();
        }

        private void comboCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            DLL.Disconnect_UART();
            DLL.Comport = comboCom.SelectedIndex + 1;
            if (DLL.Connect_UART())
                label_statusCom.Text="Disponível";
            else
                label_statusCom.Text = "Não disponível";
        }

        private void comboBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            DLL.Disconnect_UART();
            DLL.Baudrate = comboBaudRate.SelectedItem.ToString();
            if (DLL.Connect_UART())
                label_statusCom.Text = "Disponível";
            else
                label_statusCom.Text = "Não disponível";
        }
    }
}
