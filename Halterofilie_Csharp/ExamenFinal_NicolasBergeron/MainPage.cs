using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace ExamenFinal_NicolasBergeron
{
    public partial class MainPage : Form
    {
        Bob bob = new Bob();
        

        bool flag = false;
        bool flagAddPoids = false;
         int id = -1;
         int count1 = 0;
         int count2 = 0;
         int count3 = 0;
         int count4 = 0;
         int count5 = 0;
        float num1 = -1, num2 = -1, num3 = -1;

        

        // Connection to the database
        readonly SqlConnection conn = new SqlConnection("Data Source=DESKTOP-5GHT0A1\\SQLEXPRESS;Initial Catalog=MyContacts;Integrated Security=True; MultipleActiveResultSets=true");
        
        public MainPage()
        {
            InitializeComponent();
        }

        //When the form is load, 2 Thread are create for display of Athlete sort by weight and display Athlete history
        private void MainPage_Load(object sender, EventArgs e)
        {
            Thread afficherAthlete = new Thread(() => btnPrint_Click(sender, e));
            Thread afficherAthleteHistorique = new Thread(() => btnPrint_Click(sender, e));

            afficherAthleteHistorique.Start();
            afficherAthlete.Start();
        }        

        /// <summary>
        /// Check if the ID in the textbox is a int.
        /// </summary>
        /// <param name="textbox"></param>
        /// <returns></returns>
        private bool IsOkay(TextBox textbox)
        {
            bool isOkay;
            int idOkay;

            isOkay = int.TryParse(textbox.Text, out idOkay);

            if (!isOkay)
                return false;

            else
            {
                id = idOkay;
                return true;
            }
        }

        /// <summary>
        /// Check if in the textboxs is a float
        /// </summary>
        /// <param name="textbox1"></param>
        /// <param name="textbox2"></param>
        /// <param name="textbox3"></param>
        /// <returns></returns>
        private bool IsNumsOkay(TextBox textbox1, TextBox textbox2, TextBox textbox3)
        {
            bool isNum1Okay, isNum2Okay, isNum3Okay;
            float txtNum1, txtNum2, txtNum3;

            isNum1Okay = float.TryParse(textbox1.Text, out txtNum1);
            isNum2Okay = float.TryParse(textbox2.Text, out txtNum2);
            isNum3Okay = float.TryParse(textbox3.Text, out txtNum3);

            if (!isNum1Okay || !isNum2Okay || !isNum3Okay)
                return false;

            else
            {
                num1 = txtNum1;
                num2 = txtNum2;
                num3 = txtNum3;
                return true;
            }
        }

        /// <summary>
        /// Check if the ID put in the textbox, exist in SQL Table. 
        /// </summary>
        /// <param name="textbox"></param>
        private void CheckId(TextBox textbox)
        {
            var testCommand = new SqlCommand("select * from [Athlete]", conn);
            SqlDataReader dr = testCommand.ExecuteReader();

            while (dr.Read())
            {
                if (dr[0].ToString() == textbox.Text)
                {
                    flag = true;
                    break;
                }
            }
        }

        //***********************************************************************************************************************************
        //Those button change tab in tabControl when click.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            tcMain.SelectTab(tabAjouter);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            tcMain.SelectTab(tabDel);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tcMain.SelectTab(tabAddPoids);
        }

        //When click, the method take informations from the 2 SQL tables and output it in a DataGridView.
        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                tcMain.SelectTab(tabPrint);

                var max = new SqlDataAdapter("Select Id_Athlete, nom, prenom, pays, (SELECT(SELECT MAX(myval) FROM(VALUES(Tentative1), (Tentative2), (Tentative3)) AS value(myval))) AS PoidsMaxSoulever from Athlete a INNER JOIN AthletePoids ap ON a.Id_Athlete = ap.Id ORDER BY PoidsMaxSoulever DESC, prenom ASC;", conn);
                DataTable dt = new DataTable();
                max.Fill(dt);

                afficherAthleteDgv.DataSource = dt;
                afficherAthleteDgv.AutoGenerateColumns = false;
            }));
        }

        //When click, the method do an inner join between 2 SQL tables and output the result into a DataGridView.
        private void btnPrintHistorique_Click(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                tcMain.SelectTab(tabPrintHistorique);

                var adapt = new SqlDataAdapter("SELECT Id_Athlete, nom, prenom, pays, Tentative1, Tentative2, Tentative3 FROM Athlete a INNER JOIN AthletePoids ap ON a.Id_Athlete = ap.Id;", conn);
                DataTable dt = new DataTable();
                adapt.Fill(dt);

                affichageHistoriqueDgv.DataSource = dt;
                afficherAthleteDgv.AutoGenerateColumns = false;
            }));
        }

        private void btnAddPoids_Click(object sender, EventArgs e)
        {
            tcMain.SelectTab(tabAddPoids);
        }

        //When click, a MessageBox appair and ask you if you want to leave, if yes the program close.
        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show("Voulez-vous vraiment quitter ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (reponse == DialogResult.Yes)
                Application.Exit();
        }
        //***********************************************************************************************************************************

        // The method check if there's 5 Athlete, if not then the method add the informations of the 
        // Athletes in SQL Table.
        private void btnAddAthlete_Click(object sender, EventArgs e)
        {
            bool nom, prenom, pays;
            Regex regex = new Regex("^[a-zA-Z]+$");

            nom = regex.IsMatch(txtNameAdd.Text);
            prenom = regex.IsMatch(txtPrenomAdd.Text);
            pays = regex.IsMatch(txtPaysAdd.Text);

            conn.Open();
            string test = "SELECT COUNT(Id_Athlete) FROM Athlete";
            var command = new SqlCommand(test, conn);
            Int32 check = ((Int32?)command.ExecuteScalar()) ?? 0;

            if (!IsOkay(txtIDAdd))
                MessageBox.Show("Le ID doit être un entier!");

            else
            {
                if (!nom)
                    MessageBox.Show("Le nom doit seulement contenir des lettres!");

                else if (!prenom)
                    MessageBox.Show("Le prénom doit seulement contenir des lettres!");

                else if (pays)
                    MessageBox.Show("Le pays doit seulement contenir des lettres!");

                else
                {
                    CheckId(txtIDAdd);
                    if (flag)
                        MessageBox.Show("Il peut seulement avoir 1 ID unique par athlète!");

                    else
                    {
                        if (check < 5)
                        {
                            SqlCommand cmd = new SqlCommand("insert into Athlete values(@Id, @nom, @prenom, @pays)", conn);

                            cmd.Parameters.AddWithValue("@Id", id);
                            cmd.Parameters.AddWithValue("@nom", txtNameAdd.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@prenom", txtPrenomAdd.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@pays", txtPaysAdd.Text.ToUpper());

                            cmd.ExecuteNonQuery();

                            MessageBox.Show(txtPrenomAdd.Text + " " + txtNameAdd.Text + " ajouter à la liste d'athlète.");
                        }
                        else
                            MessageBox.Show("Il peut seulement avoir 5 athlètes par compétition!");
                    }
                }
            }

            txtIDAdd.Text = "";
            txtNameAdd.Text = "";
            txtPrenomAdd.Text = "";
            txtPaysAdd.Text = "";
            conn.Close();
            flag = false;
            id = -1;
        }

        //When click, the text inside the textboxs in Ajouter Athlete become "".
        private void btnInitialiserAdd_Click(object sender, EventArgs e)
        {
            txtIDAdd.Text = "";
            txtNameAdd.Text = "";
            txtPrenomAdd.Text = "";
            txtPaysAdd.Text = "";
        }

        //When click, the method check if athele exist if yes, then proceed to delete the athlete in SQL tables.
        private void btnSupDel_Click(object sender, EventArgs e)
        {
            conn.Open();
            CheckId(txtIDDel);

            if (!IsOkay(txtIDDel))
                MessageBox.Show("Le ID doit être un entier!");
            else
            {
                if (flag)
                {
                    SqlCommand cmdPoids = new SqlCommand("delete from AthletePoids where Id = @Id", conn);
                    cmdPoids.Parameters.AddWithValue("@Id", id);
                    cmdPoids.ExecuteNonQuery();

                    SqlCommand cmd = new SqlCommand("delete from Athlete where Id_Athlete = @Id_Athlete", conn);
                    cmd.Parameters.AddWithValue("@Id_Athlete", id);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Athlète supprimé.");
                }
                else
                    MessageBox.Show("Athlète n'existe pas.");
            }

            txtIDDel.Text = "";
            conn.Close();
            flag = false;
            id = -1;
        }

        //When click, the text inside the textbox in Supprimer/Mise à jour Athlète become "".
        private void btnInitialiserDel_Click(object sender, EventArgs e)
        {
            txtIDDel.Text = "";
        }

        //When click, the method check if athlete exist in both SQL tables(Athlete | AthletePoids).
        //if athlete exist in Athlete put not in AthletePoids then is 3 Tentatives are added to the table AthletePoids
        private void btnAddPoid_Click(object sender, EventArgs e)
        {
            conn.Open();

            if (!IsOkay(txtIdPoid))
                MessageBox.Show("Le ID doit être un entier!");

            else if (!IsNumsOkay(txtTenta1, txtTenta2, txtTenta3))
                MessageBox.Show("Les Tentatives doivent être un nombre!");

            else
            {
                SqlCommand cmd = new SqlCommand("insert into AthletePoids values(@Id, @Tentative1, @Tentative2, @Tentative3)", conn);
                CheckId(txtIdPoid);

                var testCommand = new SqlCommand("select * from [AthletePoids]", conn);
                SqlDataReader dr = testCommand.ExecuteReader();

                while (dr.Read())
                {
                    if (dr[0].ToString() == txtIdPoid.Text)
                    {
                        flagAddPoids = true;
                        break;
                    }
                }

                if (flag && !flagAddPoids)
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Tentative1", num1);
                    cmd.Parameters.AddWithValue("@Tentative2", num2);
                    cmd.Parameters.AddWithValue("@Tentative3", num3);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Les poids ont été ajouté !");
                }
                else if (!flag)
                    MessageBox.Show("Le ID de l'athlète n'existe pas !");

                else
                    MessageBox.Show("L'athlète a déjà des poids! Allez dans la section Mise à jour Athlète pour modifier les poids.");
            }

            txtIdPoid.Text = "";
            txtTenta1.Text = "";
            txtTenta2.Text = "";
            txtTenta3.Text = "";
            conn.Close();
            flag = false; flagAddPoids = false;
            id = -1;
            num1 = -1; num2 = -1; num3 = -1;
        }

        //When click, the text inside the textboxs in Ajouter Poids Soulevé become "".
        private void btnIniPoid_Click(object sender, EventArgs e)
        {
            txtIdPoid.Text = "";
            txtTenta1.Text = "";
            txtTenta2.Text = "";
            txtTenta3.Text = "";
        }

        //When click, the method check if Athlete exist if yes, then the weights are update in AthletePoids table.
        private void btnUpdateAthlete_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (!IsOkay(txtIDUpdate))
                MessageBox.Show("Le ID doit être un entier!");

            else if (!IsNumsOkay(txtTentaUpdate1, txtTentaUpdate2, txtTentaUpdate3))
                MessageBox.Show("Les Tentatives doivent être un nombre!");

            else
            {
                SqlCommand cmd = new SqlCommand("update AthletePoids set Tentative1 = @Tentative1, Tentative2 = @Tentative2, Tentative3 = @Tentative3 where Id = @Id", conn);
                CheckId(txtIDUpdate);

                if (flag)
                {
                    switch (id) 
                    {
                        case 1:
                            count1++;
                            bob.count1 = count1;
                            break;

                        case 2:
                            count2++;
                            bob.count2 = count2;
                            break;

                        case 3:
                            count3++;
                            bob.count3 = count3;
                            break;

                        case 4:
                            count4++;
                            bob.count4 = count4;
                            break;

                        case 5:
                            count5++;
                            bob.count5 = count5;
                            break;
                    }
                    bob.Save("counts.xml");

                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Tentative1", num1);
                    cmd.Parameters.AddWithValue("@Tentative2", num2);
                    cmd.Parameters.AddWithValue("@Tentative3", num3);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Les poids ont été modifié !");
                }
                else
                    MessageBox.Show("L'athlète n'existe pas !");
            }

            txtIDUpdate.Text = "";
            txtTentaUpdate1.Text = "";
            txtTentaUpdate2.Text = "";
            txtTentaUpdate3.Text = "";
            conn.Close();
            flag = false;
            id = -1;
            num1 = -1; num2 = -1; num3 = -1;
        }

        //When click, the text inside the textboxs in Supprimer/Mise à jour Athlète become "".
        private void btnInitialiseUpdate_Click(object sender, EventArgs e)
        {
            txtIDUpdate.Text = "";
            txtTentaUpdate1.Text = "";
            txtTentaUpdate2.Text = "";
            txtTentaUpdate3.Text = "";
        }
    }
}