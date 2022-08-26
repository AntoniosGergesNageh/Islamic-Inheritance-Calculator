using System.Data.SqlClient;
using System.Data;
namespace almarith_project
{
    public partial class Form1 : Form
    {
        SqlConnection sql = new SqlConnection(@"Data Source=.;Initial Catalog=inharitance_calc;Integrated Security=True;");
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
            Save.Enabled = false;
            Delete.Enabled = false;
            Edit.Enabled = false; 
            Cancel.Enabled = false;
            Tarka.Enabled = false;
            Male.Enabled = false;
            Female.Enabled = false;
            Name_elmotawfi.Enabled = false;
            ID_Elmwtafi.Enabled = false;
            update.Enabled = false;
            load();
            Male.Checked = true;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }





        private void guna2Button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            update.Enabled = true;
            Tarka.Text = null;
            Name_elmotawfi.Text = null;
            ID_Elmwtafi.Text = null;
            Delete.Enabled = false;
            Edit.Enabled = false;
            Save.Enabled = true;
            Cancel.Enabled = true;
            Tarka.Enabled = true;
            Male.Enabled = true;
            Female.Enabled = true;
            Name_elmotawfi.Enabled = true;
            ID_Elmwtafi.Enabled = true;

            dataGridView2.Enabled = false;
            dataGridView1.Visible = true;
            dataGridView3.Visible = false;
            dataGridView1.Columns.Clear();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnCount = 4;


            dataGridView1.Columns[0].Name = "النصيب";
            dataGridView1.Columns[1].Name = "نسبة الورث";
            dataGridView1.Columns[2].Name = "رقم البطاقه";

            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.HeaderText = "صلة القرابه";
            cmb.Name = "cmb";
            cmb.MaxDropDownItems = 3;
            cmb.Items.Add("ابن");
            cmb.Items.Add("ابنه");
            cmb.Items.Add("اب"); cmb.Items.Add("ام"); cmb.Items.Add("اخ"); cmb.Items.Add("اخت");

            cmb.Items.Add("زوج");
            cmb.Items.Add("زوجه");
            dataGridView1.Columns.Add(cmb);
            dataGridView1.Columns[3].Name = "الاسم";
            added.Enabled = false;
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.AutoGenerateColumns = true;
        }


        private void update_Click(object sender, EventArgs e)
        {


            double sons_shares = 0;
            double daughters_shares = 0;
            double mother_share = 0;
            double father_share = 0;
            double brother_share = 0;
            double sister_share = 0;
            double husband_share = 0;
            double wives_share = 0;
            double individual_share = 0;
            double one_third_PRS = 0;
            double half_PRS = 0;
            double rem_aft_dau_share = 0;
            double x_share = 0;
            double rem_share = 0;
            double total_share = Convert.ToDouble(Tarka.Text);
            int num_of_sons = 0;
            int num_of_daugthers = 0;
            int father = 0;
            int mother = 0;
            int num_of_bro = 0;
            int num_of_sis = 0;
            int husband = 0;
            int bequest_share = 0;
            double rem_aft_hus = 0;
            double total_PRS;
            int num_of_wives = 0;
            double rem_aft_wif;
            double half = .5, asixth = 0.1666666666666667, one_third = 0.3333333333333333, one_eighth = 0.125, afourth = .25, two_thirds = 0.6666666666666667;
            total_PRS = total_share - bequest_share;


            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item?.Cells[4]?.Value?.ToString() == "ابن")
                {
                    num_of_sons++;
                }
                else if (item?.Cells[4]?.Value?.ToString() == "ابنه")
                {
                    num_of_daugthers++;
                }
                else if (item?.Cells[4]?.Value?.ToString() == "اخ")
                {
                    num_of_bro++;
                }
                else if (item?.Cells[4]?.Value?.ToString() == "اخت")
                {
                    num_of_sis++;
                }
                else if (item?.Cells[4]?.Value?.ToString() == "زوجه")
                {
                    num_of_wives++;

                }
                else if (item?.Cells[4]?.Value?.ToString() == "اب")
                {
                    father++;
                }
                else if (item?.Cells[4]?.Value?.ToString() == "ام")
                {
                    mother++;
                }
                else if (item?.Cells[4]?.Value?.ToString() == "زوج")
                {
                    husband++;
                }
            }


            if (Male.Checked == false)
            {




                //Determine if there are children's shares

                /* solution had been cheked   */
                if (num_of_sons > 0)
                {

                    husband_share = (husband == 1 ? afourth * total_PRS : 0);
                    mother_share = (mother == 1 ? asixth * total_PRS : 0);
                    father_share = (father == 1 ? asixth * total_PRS : 0);

                    x_share = total_PRS - husband_share - mother_share - father_share;
                    // sons shares
                    sons_shares = num_of_sons * (2 * (x_share / (2 * num_of_sons + num_of_daugthers)));
                    // daughters shares
                    daughters_shares = (num_of_daugthers > 0 ? num_of_daugthers * (x_share / (2 * num_of_sons + num_of_daugthers)) : 0);
                }
                //  todo //  مشكلة العول 
                else if (num_of_sons == 0 && num_of_daugthers >= 2)
                {
                    daughters_shares = 2 * (total_PRS / 3);
                    rem_aft_dau_share = total_PRS - daughters_shares;
                    husband_share = (husband == 1 ? afourth * rem_aft_dau_share : 0);
                    mother_share = (mother == 1 ? asixth * rem_aft_dau_share : 0);
                    father_share = (father == 1 ? asixth * rem_aft_dau_share : 0);
                    brother_share = (num_of_bro == 1 ? afourth * rem_aft_dau_share : 0);
                }
                // propblem was  fixed by make the father take the remainder after avery one take his right and if there is no father and we found brother will take the rest 

                else if (num_of_sons == 0 && num_of_daugthers == 1)
                {
                    daughters_shares = total_PRS / 2;
                    husband_share = (husband == 1 ? afourth * total_PRS : 0);

                    mother_share = (mother == 1 ? asixth * total_share : 0);
                    rem_aft_dau_share = total_PRS - (daughters_shares + mother_share);
                    father_share = (father == 1 ? rem_aft_dau_share : 0);
                    brother_share = (num_of_bro == 1 && father == 0 ? rem_aft_dau_share : 0);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && num_of_bro == 0 && num_of_sis == 0)
                {
                    mother_share = (mother == 1 ? one_third * total_PRS : 0);
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    father_share = total_PRS - (mother_share + husband_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 1 && (num_of_bro + num_of_sis) >= 2)
                {
                    mother_share = asixth * total_PRS;
                    husband_share = (husband == 1 ? half * total_PRS : 0);

                    one_third_PRS = one_third * total_PRS;
                    brother_share = num_of_bro * (2 * (one_third_PRS / (2 * num_of_bro + num_of_sis)));
                    sister_share = num_of_sis * (one_third_PRS / (2 * num_of_bro + num_of_sis));
                    mother_share += total_PRS - (mother_share + husband_share + brother_share + sister_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 1 && num_of_bro == 1 && num_of_sis == 0)
                {
                    mother_share = one_third * total_PRS;
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    brother_share = asixth * total_PRS;
                    mother_share += total_PRS - (mother_share + husband_share + brother_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 1 && num_of_bro == 0 && num_of_sis == 1)
                {
                    mother_share = one_third * total_PRS;
                    husband_share = (husband == 1 ? (1 / 2) * total_PRS : 0);
                    sister_share = asixth * total_PRS;
                    mother_share += total_PRS - (mother_share + husband_share + sister_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 0 && num_of_bro == 0 && num_of_sis == 1)
                {
                    husband_share = (husband_share == 1 ? half * total_PRS : 0);
                    sister_share = half * total_PRS;
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 0 && num_of_bro >= 1 && num_of_sis == 0)
                {
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    brother_share = total_PRS - husband_share;
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 0 && num_of_bro == 0 && num_of_sis >= 2)
                {
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    rem_aft_hus = total_PRS - husband_share;

                    sister_share = two_thirds * rem_aft_hus;
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 0 && num_of_bro > 0 && num_of_sis > 0)
                {
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    rem_aft_hus = total_PRS - husband_share;

                    brother_share = num_of_bro * (2 * (rem_aft_hus / (2 * num_of_bro + num_of_sis)));
                    sister_share = num_of_sis * (rem_aft_hus / (2 * num_of_bro + num_of_sis));
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 1 && num_of_bro == 0 && num_of_sis == 0)
                {
                    mother_share = one_third * total_PRS;
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    mother_share += total_PRS - (mother_share + husband_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 0 && num_of_bro == 0 && num_of_sis == 0)
                {
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 1 && (num_of_bro + num_of_sis) >= 2)
                {
                    mother_share = asixth * total_PRS;
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    one_third_PRS = one_third * total_PRS;
                    brother_share = num_of_bro * (2 * (one_third_PRS / (2 * num_of_bro + num_of_sis)));
                    sister_share = num_of_sis * (one_third_PRS / (2 * num_of_bro + num_of_sis));
                    father_share = total_PRS - (mother_share + husband_share + brother_share + sister_share);
                }
                //---------------------------------------------------------------------------------------------------------------------
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 1 && num_of_bro == 0 && num_of_sis == 0)
                {
                    mother_share = 5445;
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    father_share = total_PRS - (mother_share + husband_share + brother_share);
                }

                //----------------------------------------




                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 1 && num_of_bro == 1 && num_of_sis == 0)
                {
                    mother_share = one_third * total_PRS;
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    brother_share = asixth * total_PRS;
                    father_share = total_PRS - (mother_share + husband_share + brother_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 0 && (num_of_bro + num_of_sis) >= 2)
                {
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    one_third_PRS = one_third * total_PRS;
                    brother_share = num_of_bro * (2 * (one_third_PRS / (2 * num_of_bro + num_of_sis)));
                    sister_share = num_of_sis * (one_third_PRS / (2 * num_of_bro + num_of_sis));
                    father_share = total_PRS - (mother_share + husband_share + brother_share + sister_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 1 && num_of_bro == 0 && num_of_sis == 1)
                {
                    mother_share = one_third * total_PRS;
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    sister_share = asixth * total_PRS;
                    father_share = total_PRS - (mother_share + husband_share + sister_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 0 && num_of_bro == 0 && num_of_sis == 1)
                {
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    sister_share = half * total_PRS;
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 0 && num_of_bro >= 1 && num_of_sis == 0)
                {
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    brother_share = total_PRS - husband_share;
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 1 && num_of_bro == 1 && num_of_sis == 0)
                {
                    mother_share = one_third * total_PRS;
                    husband_share = (husband == 1 ? (1 / 2) * total_PRS : 0);
                    brother_share = asixth * total_PRS;
                    father_share += total_PRS - (mother_share + husband_share + brother_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 1 && num_of_bro == 0 && num_of_sis == 1)
                {
                    mother_share = one_third * total_PRS;
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    sister_share = asixth * total_PRS;
                    father_share += total_PRS - (mother_share + husband_share + sister_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 0 && num_of_bro == 1 && num_of_sis == 0)
                {
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    brother_share = asixth * total_PRS;
                    father_share += total_PRS - (husband_share + brother_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 0 && num_of_bro == 0 && num_of_sis == 1)
                {
                    husband_share = (husband == 1 ? half * total_PRS : 0);
                    sister_share = asixth * total_PRS;
                    father_share += total_PRS - (husband_share + sister_share);
                }


                rem_share = total_PRS - (sons_shares + daughters_shares + mother_share + father_share + husband_share + brother_share + sister_share);
                Math.Round(rem_share); Math.Round(brother_share); Math.Round(sister_share); Math.Round(sons_shares); Math.Round(daughters_shares); Math.Round(husband_share); Math.Round(mother_share); Math.Round(father_share); Math.Round(wives_share);




            }
            // if the one who will the other inharite from was a man .....it will be different because if he had a more than one wife
            else
            {


                if (num_of_sons > 0)
                {
                    // wives shares
                    wives_share = (num_of_wives > 0 ? one_eighth * total_PRS : 0);
                    mother_share = (mother == 1 ? asixth * total_PRS : 0);
                    father_share = (father == 1 ? asixth * total_PRS : 0);
                    rem_aft_wif = total_PRS - wives_share - mother_share - father_share;
                    // sons shares
                    sons_shares = num_of_sons * (2 * (rem_aft_wif / (2 * num_of_sons + num_of_daugthers)));
                    // daughters shares
                    daughters_shares = (num_of_daugthers > 0 ? num_of_daugthers * (rem_aft_wif / (2 * num_of_sons + num_of_daugthers)) : 0);
                }
                else if (num_of_sons == 0 && num_of_daugthers >= 2)
                {
                    // wives shares
                    daughters_shares = 2 * (total_PRS / 3);

                    rem_aft_dau_share = total_PRS - daughters_shares;
                    mother_share = (mother == 1 ? asixth * rem_aft_dau_share : 0);
                    father_share = (father == 1 ? asixth * rem_aft_dau_share : 0);
                    wives_share = (num_of_wives > 0 ? one_eighth * rem_aft_dau_share : 0);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 1)
                {
                    daughters_shares = total_PRS / 2;

                    rem_aft_dau_share = total_PRS - daughters_shares;
                    mother_share = (mother == 1 ? asixth * rem_aft_dau_share : 0);
                    father_share = (father == 1 ? asixth * rem_aft_dau_share : 0);
                    wives_share = (num_of_wives > 0 ? one_eighth * rem_aft_dau_share : 0);
                }

                //----------------------------------------------------------------------------
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && num_of_bro == 0 && num_of_sis == 0)
                {
                    mother_share = (mother == 1 ? one_third * total_PRS : 0);
                    half_PRS = total_PRS / 2;
                    rem_aft_wif = total_PRS - mother_share;
                    wives_share = (num_of_wives > 0 ? afourth * rem_aft_wif : 0);
                    father_share = total_PRS - (mother_share + wives_share);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 1 && (num_of_bro + num_of_sis) >= 2)
                {
                    mother_share = asixth * total_PRS;
                    one_third_PRS = one_third * total_PRS;

                    brother_share = num_of_bro * (2 * (one_third_PRS / (2 * num_of_bro + num_of_sis)));
                    sister_share = num_of_sis * (one_third_PRS / (2 * num_of_bro + num_of_sis));
                    half_PRS = total_PRS / 2;
                    wives_share = (num_of_wives > 0 ? afourth * half_PRS : 0);
                    mother_share += total_PRS - (mother_share + brother_share + sister_share + (wives_share * num_of_wives));
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 1 && num_of_bro == 1 && num_of_sis == 0)
                {
                    mother_share = one_third * total_PRS;
                    brother_share = asixth * total_PRS;
                    half_PRS = total_PRS / 2;
                    wives_share = (num_of_wives > 0 ? afourth * half_PRS : 0);
                    mother_share += total_PRS - (mother_share + brother_share + (wives_share * num_of_wives));
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 1 && num_of_bro == 0 && num_of_sis == 1)
                {
                    mother_share = one_third * total_PRS;
                    sister_share = asixth * total_PRS;
                    half_PRS = total_PRS / 2;
                    wives_share = (num_of_wives > 0 ? afourth * total_PRS : 0);
                    mother_share += total_PRS - (mother_share + sister_share + (wives_share * num_of_wives));
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 0 && num_of_bro == 0 && num_of_sis == 1)
                {
                    sister_share = half * total_PRS;
                    half_PRS = total_PRS / 2;
                    wives_share = (num_of_wives > 0 ? afourth * half_PRS : 0);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 0 && num_of_bro >= 1 && num_of_sis == 0)
                {
                    half_PRS = total_PRS / 2;
                    wives_share = (num_of_wives > 0 ? afourth * half_PRS : 0);
                    brother_share = total_PRS - (wives_share * num_of_wives);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 0 && num_of_bro == 0 && num_of_sis >= 2)
                {
                    half_PRS = total_PRS / 2;
                    wives_share = (num_of_wives > 0 ? afourth * half_PRS : 0);
                    rem_aft_wif = total_PRS - (wives_share * num_of_wives);
                    sister_share = two_thirds * rem_aft_wif;
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 0 && num_of_bro > 0 && num_of_sis > 0)
                {
                    half_PRS = total_PRS / 2;
                    wives_share = (num_of_wives > 0 ? afourth * half_PRS : 0);
                    rem_aft_wif = total_PRS - (wives_share * num_of_wives);

                    brother_share = num_of_bro * (2 * (rem_aft_wif / (2 * num_of_bro + num_of_sis)));
                    sister_share = num_of_sis * (rem_aft_wif / (2 * num_of_bro + num_of_sis));
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 1 && num_of_bro == 0 && num_of_sis == 0)
                {
                    mother_share = one_third * total_PRS;
                    half_PRS = total_PRS / 2;
                    wives_share = (num_of_wives > 0 ? afourth * half_PRS : 0);
                    mother_share += total_PRS - (mother_share + (wives_share * num_of_wives));
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 0 && mother == 0 && num_of_bro == 0 && num_of_sis == 0)
                {
                    half_PRS = total_PRS / 2;
                    wives_share = (num_of_wives > 0 ? afourth * total_PRS : 0);
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 1 && (num_of_bro + num_of_sis) >= 2)
                {
                    mother_share = asixth * total_PRS;
                    one_third_PRS = one_third * total_PRS;
                    brother_share = num_of_bro * (2 * (one_third_PRS / (2 * num_of_bro + num_of_sis)));
                    sister_share = num_of_sis * (one_third_PRS / (2 * num_of_bro + num_of_sis));
                    half_PRS = total_PRS / 2;
                    wives_share = (num_of_wives > 0 ? afourth * total_PRS : 0);
                    father_share = total_PRS - (mother_share + brother_share + sister_share + (wives_share * num_of_wives));
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 1 && num_of_bro == 1 && num_of_sis == 0)
                {
                    mother_share = one_third * total_PRS;
                    brother_share = asixth * total_PRS;
                    half_PRS = total_PRS / 2;
                    wives_share = (num_of_wives > 0 ? afourth * half_PRS : 0);
                    father_share = total_PRS - (mother_share + brother_share + (wives_share * num_of_wives));
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 1 && num_of_bro == 0 && num_of_sis == 1)
                {
                    mother_share = one_third * total_PRS;
                    sister_share = asixth * total_PRS;
                    half_PRS = total_PRS / 2;
                    wives_share = (num_of_wives > 0 ? afourth * half_PRS : 0);
                    father_share = total_PRS - (mother_share + sister_share + (wives_share * num_of_wives));
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 0 && (num_of_bro + num_of_sis) >= 2)
                {
                    one_third_PRS = one_third * total_PRS;
                    brother_share = num_of_bro * (2 * (one_third_PRS / (2 * num_of_bro + num_of_sis)));
                    sister_share = num_of_sis * (one_third_PRS / (2 * num_of_bro + num_of_sis));
                    half_PRS = total_PRS / 2;
                    wives_share = (num_of_wives > 0 ? afourth * total_PRS : 0);
                    father_share = total_PRS - (brother_share + sister_share + (wives_share * num_of_wives));
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 0 && num_of_bro == 1 && num_of_sis == 0)
                {
                    brother_share = asixth * total_PRS;
                    half_PRS = total_PRS / 2;
                    wives_share = (num_of_wives > 0 ? afourth * half_PRS : 0);
                    father_share = total_PRS - (mother_share + brother_share + (wives_share * num_of_wives));
                }
                else if (num_of_sons == 0 && num_of_daugthers == 0 && father == 1 && mother == 0 && num_of_bro == 0 && num_of_sis == 1)
                {
                    sister_share = asixth * total_PRS;
                    half_PRS = total_PRS / 2;
                    wives_share = (num_of_wives > 0 ? afourth * half_PRS : 0);
                    father_share += total_PRS - (sister_share + (wives_share * num_of_wives));
                }




                rem_share = total_PRS - (sons_shares + daughters_shares + mother_share + father_share + wives_share + brother_share + sister_share);

             }

            // insert every one's value..!
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item?.Cells[4]?.Value?.ToString() == "ابن")
                    
                {

                    item.Cells[0].Value = Math.Round(sons_shares / num_of_sons, 3) ;
                    item.Cells[1].Value = Math.Round(((sons_shares / num_of_sons) / total_share) * 100 , 3)+ "%";
                }
                else if (item?.Cells[4]?.Value?.ToString() == "ابنه")
                {
                    item.Cells[0].Value = Math.Round(daughters_shares / num_of_daugthers, 3);
                    item.Cells[1].Value = Math.Round(((daughters_shares / num_of_daugthers) / total_share) * 100, 3) + "%";
                }
                else if (item?.Cells[4]?.Value?.ToString() == "اخ")
                {
                    item.Cells[0].Value = Math.Round(brother_share / num_of_bro, 3);
                    item.Cells[1].Value = Math.Round(((brother_share / num_of_bro) / total_share) * 100, 3) + "%";

                }
                else if (item?.Cells[4]?.Value?.ToString() == "اخت")
                {
                    item.Cells[0].Value = Math.Round(sister_share / num_of_sis, 3);
                    item.Cells[1].Value = Math.Round(((sister_share / num_of_sis) / total_share)*  100, 3) + "%";

                }
                else if (item?.Cells[4]?.Value?.ToString() == "زوجه")
                {
                    item.Cells[0].Value = Math.Round(wives_share / num_of_wives, 3);
                    item.Cells[1].Value = Math.Round(((wives_share / num_of_wives) / total_share) * 100, 3) + "%";

                }
                else if (item?.Cells[4]?.Value?.ToString() == "اب")
                {
                    item.Cells[0].Value = Math.Round(father_share / father, 3);
                    item.Cells[1].Value = Math.Round(((father_share / father) / total_share) * 100 , 3)+ "%";

                }
                else if (item?.Cells[4]?.Value?.ToString() == "ام")
                {
                    item.Cells[0].Value = Math.Round(mother_share / mother, 3);
                    item.Cells[1].Value = Math.Round(((mother_share / mother) / total_share)* 100, 3) + "%";

                }
                else if (item?.Cells[4]?.Value?.ToString() == "زوج")
                {
                    item.Cells[0].Value = Math.Round(husband_share / husband, 3);
                    item.Cells[1].Value = Math.Round(((husband_share / husband) / total_share) * 100, 3) + "%";

                }
            }

        }



        private void Save_Click(object sender, EventArgs e)
        {
            
            if (Name_elmotawfi.TextLength <3 ) { MessageBox.Show("برجاء ادخال اسم المتوفي" );  return;  };
            if ( ID_Elmwtafi.TextLength !=0 && ID_Elmwtafi.TextLength != 14 ) { MessageBox.Show(" برجاء ادخال رقم بطاقة المتوفي بشكل صحيح"); return; };
            if (ID_Elmwtafi.TextLength ==0) { MessageBox.Show("برجاء ادخال رقم بطاقة المتوفي "); return; };
            if (Tarka.TextLength == 0) { MessageBox.Show("برجاء ادخال قيمة التركه"); return; };
            




            if (Edit.Enabled == true)
            {

                try
                {
                    if (Edit.Enabled == true)
                    {
                        int numodselectedrow = dataGridView2.CurrentCell.RowIndex;
                        int C = dataGridView2.CurrentRow.Index;
                        string selectedrow_ID = textBox1.Text;
                        SqlCommand c = new SqlCommand();

                        SqlDataAdapter da = new SqlDataAdapter("delete from Tb1 where ID_elmotawfi ='" + selectedrow_ID + "'", sql);


                        c = new SqlCommand("delete from Tb1 where ID_elmotawfi ='" + selectedrow_ID + "'", sql);
                        sql.Open();
                        c.ExecuteNonQuery();
                        c = new SqlCommand("delete from Table_2 where ID_elmotawfi = '" + selectedrow_ID + "'", sql);
                        c.ExecuteNonQuery();
                        sql.Close();
                    }

                    SqlCommand cm = new SqlCommand();
                    cm = new SqlCommand("insert into Table_2(terka,name_elmotawfi,ID_elmotawfi,kind_ofelmtawfi) values(@terka,@name_elmotawfi,@ID_elmotawfi,@kind_ofelmtawfi)", sql);
                    cm.Parameters.Add(new SqlParameter("@ID_elmotawfi", System.Data.SqlDbType.NVarChar)).Value = ID_Elmwtafi.Text;
                    cm.Parameters.Add(new SqlParameter("@terka", System.Data.SqlDbType.Money)).Value = Convert.ToDouble(Tarka.Text);
                    cm.Parameters.Add(new SqlParameter("@name_elmotawfi", System.Data.SqlDbType.NVarChar)).Value = Name_elmotawfi.Text;
                    String sex = (Male.Checked ? "ذكر" : "انثى");
                    cm.Parameters.Add(new SqlParameter("@kind_ofelmtawfi", System.Data.SqlDbType.NVarChar)).Value = sex;
                    sql.Open();
                    cm.ExecuteNonQuery();
                    sql.Close();
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {


                        Double value = Convert.ToDouble(item?.Cells[0]?.Value?.ToString());
                        string inharitance_ratio = item?.Cells[1]?.Value?.ToString();
                        string relation = item?.Cells[4]?.Value?.ToString();
                        string ID = item?.Cells[2]?.Value?.ToString();
                        string name = item?.Cells[3]?.Value?.ToString();

                        cm = new SqlCommand("insert into Tb1(ID,name,inheritance_ratio,relation,value,ID_elmotawfi) values(@ID,@name,@inharitance_ratio ,@relation,@value,@ID_elmotawfi)", sql);
                        cm.Parameters.Add(new SqlParameter("@ID", System.Data.SqlDbType.NVarChar)).Value = ID;
                        cm.Parameters.Add(new SqlParameter("@name", System.Data.SqlDbType.NVarChar)).Value = name;
                        cm.Parameters.Add(new SqlParameter("@inharitance_ratio", System.Data.SqlDbType.NVarChar)).Value = inharitance_ratio;
                        cm.Parameters.Add(new SqlParameter("@relation", System.Data.SqlDbType.NVarChar)).Value = relation;
                        cm.Parameters.Add(new SqlParameter("@value", System.Data.SqlDbType.Money)).Value = value;
                        cm.Parameters.Add(new SqlParameter("@ID_elmotawfi", System.Data.SqlDbType.NVarChar)).Value = ID_Elmwtafi.Text;
                        sql.Open();
                        cm.ExecuteNonQuery();
                        sql.Close();


                    }


                }
                catch
                {
                    if (sql.State == ConnectionState.Open)
                        sql.Close();
                    load();
                }

                MessageBox.Show(" تم حفظ التعديلات بنجاح");
            }
            if (Edit.Enabled == false)
            {

                try
                {
                    if (Edit.Enabled == true)
                    {
                        int numodselectedrow = dataGridView2.CurrentCell.RowIndex;
                        int C = dataGridView2.CurrentRow.Index;
                        string selectedrow_ID = dataGridView2.Rows[numodselectedrow].Cells[0].Value.ToString();
                        SqlCommand c = new SqlCommand();

                        SqlDataAdapter da = new SqlDataAdapter("delete from Tb1 where ID_elmotawfi ='" + selectedrow_ID + "'", sql);


                        c = new SqlCommand("delete from Tb1 where ID_elmotawfi ='" + selectedrow_ID + "'", sql);
                        sql.Open();
                        c.ExecuteNonQuery();
                        c = new SqlCommand("delete from Table_2 where ID_elmotawfi = '" + selectedrow_ID + "'", sql);
                        c.ExecuteNonQuery();
                        sql.Close();
                    }

                    SqlCommand cm = new SqlCommand();
                    cm = new SqlCommand("insert into Table_2(terka,name_elmotawfi,ID_elmotawfi,kind_ofelmtawfi) values(@terka,@name_elmotawfi,@ID_elmotawfi,@kind_ofelmtawfi)", sql);
                    cm.Parameters.Add(new SqlParameter("@ID_elmotawfi", System.Data.SqlDbType.NVarChar)).Value = ID_Elmwtafi.Text;
                    cm.Parameters.Add(new SqlParameter("@terka", System.Data.SqlDbType.Money)).Value = Convert.ToDouble(Tarka.Text);
                    cm.Parameters.Add(new SqlParameter("@name_elmotawfi", System.Data.SqlDbType.NVarChar)).Value = Name_elmotawfi.Text;
                    String sex = (Male.Checked ? "ذكر" : "انثى");
                    cm.Parameters.Add(new SqlParameter("@kind_ofelmtawfi", System.Data.SqlDbType.NVarChar)).Value = sex;
                    sql.Open();
                    cm.ExecuteNonQuery();
                    sql.Close();
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {


                        Double value = Convert.ToDouble(item?.Cells[0]?.Value?.ToString());
                        string inharitance_ratio = item?.Cells[1]?.Value?.ToString();
                        string relation = item?.Cells[4]?.Value?.ToString();
                        string ID = item?.Cells[2]?.Value?.ToString();
                        string name = item?.Cells[3]?.Value?.ToString();

                        cm = new SqlCommand("insert into Tb1(ID,name,inheritance_ratio,relation,value,ID_elmotawfi) values(@ID,@name,@inharitance_ratio ,@relation,@value,@ID_elmotawfi)", sql);
                        cm.Parameters.Add(new SqlParameter("@ID", System.Data.SqlDbType.NVarChar)).Value = ID;
                        cm.Parameters.Add(new SqlParameter("@name", System.Data.SqlDbType.NVarChar)).Value = name;
                        cm.Parameters.Add(new SqlParameter("@inharitance_ratio", System.Data.SqlDbType.NVarChar)).Value = inharitance_ratio;
                        cm.Parameters.Add(new SqlParameter("@relation", System.Data.SqlDbType.NVarChar)).Value = relation;
                        cm.Parameters.Add(new SqlParameter("@value", System.Data.SqlDbType.Money)).Value = value;
                        cm.Parameters.Add(new SqlParameter("@ID_elmotawfi", System.Data.SqlDbType.NVarChar)).Value = ID_Elmwtafi.Text;
                        sql.Open();
                        cm.ExecuteNonQuery();
                        sql.Close();


                    }


                }
                catch
                {
                    if (sql.State == ConnectionState.Open)
                        sql.Close();
                    load();
                }


                MessageBox.Show(" تم حفظ البيانات بنجاح");
            }
            textBox1.Enabled = true; 
            Save.Enabled = false;
            added.Enabled = true;
            string curent_id  = ID_Elmwtafi.Text; 
            textBox1.Text = null;
            textBox1.Text = curent_id; 
        }



        private void Edit_Click(object sender, EventArgs e)
        {

            update.Enabled = true;

            Delete.Enabled = false;
            Save.Enabled = true;
            Edit.Enabled = true;
            Cancel.Enabled = true;
            Tarka.Enabled = true;
            Male.Enabled = true;
            Female.Enabled = true;
            Name_elmotawfi.Enabled = true;
            ID_Elmwtafi.Enabled = true;
            dataGridView1.Visible = true;
            dataGridView3.Visible = false;
            int i = 0;
            try
            {
                for (int ii = 0; ii < dataGridView3.RowCount; ii++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    dataGridView1.Rows.Add(row);
                }

                foreach (DataGridViewRow it in dataGridView1.Rows)
                {

                    it.Cells[0].Value = dataGridView3.Rows[i].Cells[0]?.Value?.ToString();
                    it.Cells[1].Value = dataGridView3.Rows[i].Cells[1]?.Value?.ToString();
                    it.Cells[2].Value = dataGridView3.Rows[i].Cells[2]?.Value?.ToString();
                    it.Cells[3].Value = dataGridView3.Rows[i].Cells[3]?.Value?.ToString();
                    it.Cells[4].Value = dataGridView3.Rows[i].Cells[4]?.Value?.ToString();

                    i++;

                }
            }

            catch { }
   }
        // methode to load data from elmotawfi table 
        public void load()
        {

            sql.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ID_elmotawfi AS رقم_البطاقه, name_elmotawfi  As الاسم, kind_ofelmtawfi AS الجنس, terka AS التركة  FROM Table_2; ", sql);
            DataTable dbt = new DataTable();
            da.Fill(dbt);
            dataGridView2.DataSource = dbt;
            sql.Close();
           

        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            Delete.Enabled = true;
            ID_Elmwtafi.Enabled = false;
            Male.Enabled = false;
            Female.Enabled = false;
            Edit.Enabled = true; 
           // sql.Open();
            dataGridView3.Columns.Clear();
            dataGridView1.Visible = false;
            dataGridView3.Visible = true;


            int numodselectedrow = dataGridView2.CurrentCell.RowIndex;
            string selectedrow_ID = dataGridView2.Rows[numodselectedrow].Cells[0].Value.ToString();
            textBox1.Text = selectedrow_ID; 
            double TERka = Convert.ToDouble(dataGridView2.Rows[numodselectedrow].Cells[3].Value.ToString());
            TERka = Math.Round(TERka, 2);
            Tarka.Text = TERka.ToString();
            Male.Checked = (dataGridView2.Rows[numodselectedrow].Cells[2].Value.ToString() == "ذكر" ? true : false);
            Female.Checked = (dataGridView2.Rows[numodselectedrow].Cells[2].Value.ToString() == "انثى" ? true : false);
            ID_Elmwtafi.Text = dataGridView2.Rows[numodselectedrow].Cells[0].Value.ToString();
            Name_elmotawfi.Text = dataGridView2.Rows[numodselectedrow].Cells[1].Value.ToString();

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                SqlDataAdapter da = new SqlDataAdapter("select t.value as 'النصيب', t.inheritance_ratio as 'نسبة الورث', t.ID as ' رقم البطاقه '   , t.name as'الاسم' ,t.relation as 'صلة القرابه'from Tb1 t where ID_elmotawfi ='" + selectedrow_ID + "'", sql);

                DataTable dbt = new DataTable();
                da.Fill(dbt);
                dataGridView3.DataSource = dbt;

                sql.Close();
            }

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView3.AutoSize = true;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            update.Enabled = true;

            DialogResult result = MessageBox.Show("هل انت متاكد من حزف هذا العنصر ", "window title", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
          if (result==DialogResult.Cancel) { return;  }
            
            if (result == DialogResult.OK)
            {
                int numodselectedrow = dataGridView2.CurrentCell.RowIndex;
                int C = dataGridView2.CurrentRow.Index;
                string selectedrow_ID = textBox1.Text; 


                SqlCommand cm = new SqlCommand();

                SqlDataAdapter da = new SqlDataAdapter("delete from Tb1 where ID_elmotawfi ='" + selectedrow_ID + "'", sql);


                cm = new SqlCommand("delete from Tb1 where ID_elmotawfi ='" + selectedrow_ID + "'", sql);
                sql.Open();
                cm.ExecuteNonQuery();
                cm = new SqlCommand("delete from Table_2 where ID_elmotawfi = '" + selectedrow_ID + "'", sql);
                cm.ExecuteNonQuery();
                sql.Close();

               
            }
 load();
            
            Save.Enabled = false;
            Delete.Enabled = false;
            Edit.Enabled = false;
            added.Enabled = true;
            try
            {
                dataGridView3.Columns.Clear();
            }
            catch { }
            Tarka.Text = null;
            Name_elmotawfi.Text = null;
            ID_Elmwtafi.Text = null;
            update.Enabled = false;


        }


        private void Cancel_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            dataGridView2.Enabled = true;
            Save.Enabled = false;
            Delete.Enabled = false;
            Edit.Enabled = false;
            added.Enabled = true;
            Cancel.Enabled = false;
            try
            {
                dataGridView3.Rows.Clear();
            }
            catch { }
            Tarka.Text = null;
            Name_elmotawfi.Text = null;
            ID_Elmwtafi.Text = null;
            update.Enabled = false;
           
        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void Tarka_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Tarka.Enabled = false;
            Male.Enabled = false;
            Female.Enabled = false;
            Name_elmotawfi.Enabled = false;
            ID_Elmwtafi.Enabled = false;
            Cancel.Enabled = false;
            Edit.Enabled = false;
            Delete.Enabled = false;
            dataGridView3.Columns.Clear();
            ID_Elmwtafi.Text = null;
            Name_elmotawfi.Text = null;
            Tarka.Text = null;

            dataGridView1.Visible = false;
            dataGridView3.Visible = true;
            string selectedrow_ID = textBox1.Text;
          //  ID_Elmwtafi.Text = textBox1.Text;
            SqlCommand cm = new SqlCommand("select terka,kind_ofelmtawfi,name_elmotawfi from Table_2 where ID_elmotawfi = @selectedrow_ID", sql);
            sql.Open();
            cm.Parameters.AddWithValue("@selectedrow_ID", textBox1.Text);
            SqlDataReader Da = cm.ExecuteReader();
            while (Da.Read())
            {
                Name_elmotawfi.Text = Da.GetValue(2).ToString();
                Tarka.Text = Da.GetValue(0).ToString();
                Male.Checked = (Da.GetValue(1).ToString() == "ذكر" ? true : false);
                Female.Checked = (Da.GetValue(1).ToString() == "انثى" ? true : false);
            }
            sql.Close();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                SqlDataAdapter da = new SqlDataAdapter("select t.value as 'النصيب', t.inheritance_ratio as 'نسبة الورث', t.ID as ' رقم البطاقه '   , t.name as'الاسم' ,t.relation as 'صلة القرابه'from Tb1 t where ID_elmotawfi ='" + selectedrow_ID + "'", sql);

                DataTable dbt = new DataTable();
                da.Fill(dbt);
                dataGridView3.DataSource = dbt;

                sql.Close();
            }
            Name_elmotawfi.Enabled = false;


            if (dataGridView3.Rows.Count > 0)
            {
                ID_Elmwtafi.Text = textBox1.Text;

                Edit.Enabled = true;
                Delete.Enabled = true;
            }

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            
            textBox1.Enabled = false; 
            update.Enabled = true;
            added.Enabled = false; 
            Delete.Enabled = false;
            Save.Enabled = true;
           // Edit.Enabled = false;
            Cancel.Enabled = true;
            Tarka.Enabled = true;
            Male.Enabled = true;
            Female.Enabled = true;
            Name_elmotawfi.Enabled = true;
            ID_Elmwtafi.Enabled = true;
            dataGridView1.Visible = true;
            dataGridView3.Visible = false;
            int i = 0;
            try
            {
                for (int ii = 0; ii < dataGridView3.RowCount; ii++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    dataGridView1.Rows.Add(row);
                }

                foreach (DataGridViewRow it in dataGridView1.Rows)
                {

                    it.Cells[0].Value = dataGridView3.Rows[i].Cells[0]?.Value?.ToString();
                    it.Cells[1].Value = dataGridView3.Rows[i].Cells[1]?.Value?.ToString();
                    it.Cells[2].Value = dataGridView3.Rows[i].Cells[2]?.Value?.ToString();
                    it.Cells[3].Value = dataGridView3.Rows[i].Cells[3]?.Value?.ToString();
                    it.Cells[4].Value = dataGridView3.Rows[i].Cells[4]?.Value?.ToString();

                    i++;

                }
            }

            catch { }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
