using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bras_Robot;


namespace ServeurBarman
{

    public partial class PageAccueil : MetroFramework.Forms.MetroForm
    {
        bool estConnecté { get; set; }
        CRS_A255 robot = CRS_A255.Instance;
        private readonly object accessLock = new object();
        List<(int, int)> numcommande = new List<(int, int)>();
        DataBase baseDeDonnees;
        Commande service;
        string commandePrecedente;
        int NumBouteille, ShooterOuNon;
        bool enService;

        public PageAccueil()
        {
            InitializeComponent();
        }
        public void UpdateUIBaseDonné()
        {
            LB_Etat_BD.Text = baseDeDonnees.BaseDonnées.State.ToString();
            LB_Etat_BD.ForeColor = Color.Green;
            LB_Nb_Verre_Shooter.Text = baseDeDonnees.NombreDeShooter();
            LB_NB_VerreRouge.Text = baseDeDonnees.NombreDeVerreRouge();
        }

        private void BTN_Setting_Click(object sender, EventArgs e)
        {
            if (estConnecté)
            {
                if (!enService)
                {
                    DLG_Settings dlg = new DLG_Settings();
                    DialogResult dlg_result = dlg.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Impossible d'atteindre Paramètres, car le robot est en activité!!");
                }
            }
            else
            {
                MessageBox.Show("Robot non connecté...");
            }
        }

        private void BTN_Developers_Click(object sender, EventArgs e)
        {
            Developers dlg = new Developers();
            DialogResult dlg_result = dlg.ShowDialog();
        }

        private void PageAccueil_Load(object sender, EventArgs e)
        {
            Btn_Connecter_Robot.Enabled = false;
            LB_Bras_Robot_Arreter.Visible = false;
            btn_Servir.Enabled = false;
            BTN_Pause_Commande.Enabled = false;
            pbx_Halt.Enabled = false;
        }

        private void Init_PageAcceuil()
        {
            UpdateUIBaseDonné();
            UpdateUIEtatGeneral();
            Task.Run(() =>
            {
                while (true)
                {
                    Thread.Sleep(2000);
                    Show_WaitingDrinksList();

                }
            });
            Task.Run(() => baseDeDonnees.ListeCommande());
        }

        private void Show_WaitingDrinksList()
        {
            if (numcommande.Count != baseDeDonnees.ListeCommande().Count)
            {
                Refresh_WaitingList();

                foreach (var e in numcommande)
                    Invoke((MethodInvoker)(() => LBX_WaitingList.Items.Add(e.Item1)));
                Invoke((MethodInvoker)delegate
                {
                    Update_Etat_Btn_Suppression();
                    LBL_Nb_Commande.Text += LBX_WaitingList.Items.Count.ToString();
                });
            }

        }

        private void Refresh_WaitingList()
        {
            Invoke((MethodInvoker)delegate
            {
                LBX_WaitingList.Items.Clear();
            });
            numcommande.Clear();
            numcommande = baseDeDonnees.ListeCommande();
            if (numcommande.Count != 0)
            {
                NumBouteille = numcommande[0].Item1;
                ShooterOuNon = numcommande[0].Item2;
            }

        }

        private void Btn_pour_servir()
        {
            if (estConnecté)
            {
                btn_Servir.Enabled = true;
                BTN_Pause_Commande.Enabled = true;
            }
        }

        private void ServirClient()
        {
            //Gate toi
            //a la fin d'une commande on call les fonctions pour updater les info en bas, comme ca on verifie si il y des bouteilles vide
            //ou manquante
        }

        private void Btn_ResetCommande_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Êtes-vous certain de vouloir vider la liste de commande?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                baseDeDonnees.SupprimerCommande();
            }
        }

        private void pbx_Halt_Click(object sender, EventArgs e)
        {
            robot.Halt();
            LB_Bras_Robot_Arreter.Visible = true;
            if (LBX_WaitingList.Items.Count != 0)
            {
                btn_Servir.Enabled = true;
                BTN_Pause_Commande.Enabled = false;
            }

        }

        private void Btn_Connecter_Robot_Click(object sender, EventArgs e)
        {
            robot.ConnexionRobot();
            Thread.Sleep(2000);
            if (robot.Connected)
            {
                UpdateUIConnectionRobot();
            }
            else
            {
                MessageBox.Show("Connexion robot impossible");
                robot.Deconnexion();
            }
        }
        public void UpdateUIEtatGeneral()
        {
            LB_Etat_BD.Text = baseDeDonnees.BaseDonnées.State.ToString();
            BTN_Connecter_BD.Enabled = false;
            LB_Etat_BD.ForeColor = Color.Green;
            LB_Nb_Verre_Shooter.Text = baseDeDonnees.NombreDeShooter();
            LB_Nb_Bouteille.Text = baseDeDonnees.NombreIngredients();
            LB_NB_VerreRouge.Text = baseDeDonnees.NombreDeVerreRouge();

        }
        public void UpdateUIConnectionRobot()
        {
            estConnecté = true;
            pbx_Halt.Enabled = true;
            Update_Etat_Btn_Suppression();
            Btn_Connecter_Robot.Enabled = false;
            LB_Etat_Connection_Robot.Text = "Connecté";
            LB_Etat_Connection_Robot.ForeColor = Color.Green;
        }

        private void BTN_Pause_Commande_Click(object sender, EventArgs e)
        {
            btn_Servir.Enabled = true;
            BTN_Pause_Commande.Enabled = false;
            enService = false;
        }

        private void BTN_Suprimé_Cmd_Click(object sender, EventArgs e)
        {
            if (LBX_WaitingList.SelectedIndex != -1)
            {
                int NumCommand = int.Parse(LBX_WaitingList.GetItemText(LBX_WaitingList.SelectedItem));
                LBX_WaitingList.Items.RemoveAt(LBX_WaitingList.SelectedIndex);

                baseDeDonnees.Effacer_Commande_Choisi(NumCommand);
            }
        }

        private void btn_Servir_Click(object sender, EventArgs e)
        {
            LB_Bras_Robot_Arreter.Visible = false;
            BTN_Pause_Commande.Enabled = true;
            btn_Servir.Enabled = false;
            ServirClient();
        }

        private void BTN_Remplir_Verre_Shooter_Click(object sender, EventArgs e)
        {
            baseDeDonnees.AjouterShooter((int)NUD_NbVerre_Ajouter.Value);
            UpdateUIEtatGeneral();
        }

        private void BTN_deconnexion_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_Connecter_BD_Click(object sender, EventArgs e)
        {
            Connexion_BD();
        }
        public void Connexion_BD()
        {
            baseDeDonnees = DataBase.instance_bd;
            baseDeDonnees.Connexion(TBX_Username.Text, TBX_Password.Text);
            if (baseDeDonnees.BdConnected)
            {
                Init_PageAcceuil();
                Btn_Connecter_Robot.Enabled = true;
                BTN_Remplir_Verre_Shooter.Enabled = true;
            }

            TBX_Password.Enabled = false;
            TBX_Username.Enabled = false;
        }

        private void LBX_WaitingList_SizeChanged(object sender, EventArgs e)
        {
            Update_Etat_Btn_Suppression();

        }

        private void LB_Nb_Bouteille_TextChanged(object sender, EventArgs e)
        {
            
            if(int.Parse( baseDeDonnees.NombreIngredients()) == 0)
            {
                LBX_Activities.Items.Add("Aucune Bouteille Disponible");
            }
            else if(int.Parse(baseDeDonnees.NombreIngredients()) != 6)
            {
               List<string> IngredientManquant = baseDeDonnees.QuelIngredientNonDisponible();
                foreach (var s in IngredientManquant)
                    LBX_Activities.Items.Add(s + " n'est pas disponile");
            }
        }

        private void LB_NB_VerreRouge_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(baseDeDonnees.NombreDeVerreRouge()) == 0)
            {
                LBX_Activities.Items.Add("Aucun Verre Ordinaire Disponible");
            }
        }

        private void LB_Nb_Verre_Shooter_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(baseDeDonnees.NombreDeVerreRouge()) == 0)
            {
                LBX_Activities.Items.Add("Aucun Verre a shooter Disponible");
            }
        }

        private void Update_Etat_Btn_Suppression()
        {
            if (LBX_WaitingList.Items.Count == 0)
            {
                BTN_Supprimer_Cmd.Enabled = false;
                Btn_ResetCommande.Enabled = false;
                btn_Servir.Enabled = false;
                BTN_Pause_Commande.Enabled = false;
                enService = false;
            }
            else 
            {
                Btn_ResetCommande.Enabled = true;
                BTN_Supprimer_Cmd.Enabled = true;
                if (estConnecté)
                    btn_Servir.Enabled = true;
            }
        }
    }
    public class DataBase
    {

        public OracleConnection BaseDonnées { get; private set; } = new OracleConnection();
        public bool BdConnected { get; private set; } = false;
        public static readonly DataBase instance_bd = new DataBase();

        private DataBase()
        {
        }

        public void Connexion(string user, string pass)
        {

            try
            {
                string dsource = "(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 205.237.244.251)(PORT = 1521)) (CONNECT_DATA =(SERVICE_NAME = orcl.clg.qc.ca)))";
                string bd = "Data Source=" + dsource + ";User id=" + user + ";Password=" + pass;
                BaseDonnées.ConnectionString = bd;
                BaseDonnées.Open();
            }
            catch (Exception) { MessageBox.Show("Erreur de connexion!!!"); }
            BdConnected = true;

        }

        public void FermerConnexion()
        {
            BaseDonnées.Close();
        }

        public bool Ingredient_Est_Disponible(int num)
        {
            List<object> listeIngredient = new List<object>();
            bool ingredientDisponible = true;

            string cmd = "select e.bouteillepresente from ingredient e inner join commande c on e.codebouteille=c.ingredient where c.numcommande=" + num.ToString();

            OracleCommand listeDiv = new OracleCommand(cmd, BaseDonnées);
            listeDiv.CommandType = CommandType.Text;
            OracleDataReader divisionReader = listeDiv.ExecuteReader();
            try
            {
                while (divisionReader.Read())
                {
                    listeIngredient.Add(divisionReader.GetValue(0));
                }
                divisionReader.Close();
            }
            catch (Exception sel) { MessageBox.Show(sel.Message.ToString()); }

            foreach (var s in listeIngredient)
            {
                if (s.Equals("0"))
                {
                    ingredientDisponible = false;
                }
            }
            return ingredientDisponible;
        }

        public List<(int, int)> ListeCommande()
        {
            while (true)
            {
                List<(int, int)> numcommande = new List<(int, int)>();
                string cmd = "select numcommande,shooter from commande";
                try
                {
                    OracleCommand listeDiv = new OracleCommand(cmd, BaseDonnées);
                    listeDiv.CommandType = CommandType.Text;
                    OracleDataReader divisionReader = listeDiv.ExecuteReader();
                    while (divisionReader.Read())
                    {
                        numcommande.Add((divisionReader.GetInt32(0), divisionReader.GetInt32(1)));
                    }
                    divisionReader.Close();
                }
                catch (Exception sel) { MessageBox.Show(sel.Message.ToString()); }

                //ON ORDONNE LA LISTE DES COMMANDES
                for (int i = 0; i < numcommande.Count; ++i)
                {
                    for (int j = 0; j < numcommande.Count; ++j)
                        if (numcommande[i].Item1 == numcommande[j].Item1 && i != j)
                            numcommande.Remove(numcommande[j]);
                }
                return numcommande;
            }
        }

        public string NombreDeShooter()
        {
            string nombreShooter = "";
            string cmd = "select nbshooter from verreshooter";
            OracleCommand listeDiv = new OracleCommand(cmd, BaseDonnées);
            listeDiv.CommandType = CommandType.Text;
            OracleDataReader divisionReader = listeDiv.ExecuteReader();
            try
            {
                divisionReader.Read();

                nombreShooter = divisionReader.GetInt32(0).ToString();

                divisionReader.Close();
            }
            catch (Exception sel) { MessageBox.Show(sel.Message.ToString()); }

            return nombreShooter;
        }


        public string NombreDeVerreRouge()
        {
            string nombreVerreRouge = "";
            string cmd1 = "select nbverre from verrerouge";
            OracleCommand listeDiv1 = new OracleCommand(cmd1, BaseDonnées);
            listeDiv1.CommandType = CommandType.Text;
            OracleDataReader divisionReader1 = listeDiv1.ExecuteReader();
            try
            {
                while (divisionReader1.Read())
                {
                    nombreVerreRouge = divisionReader1.GetInt32(0).ToString();
                }
                divisionReader1.Close();
            }
            catch (Exception sel) { MessageBox.Show(sel.Message.ToString()); }

            return nombreVerreRouge;
        }


        public string NombreIngredients()
        {
            string nbreIngredients = "";
            string cmd = "select count(*) from ingredient where BOUTEILLEPRESENTE = 1";
            OracleCommand listeDiv = new OracleCommand(cmd, BaseDonnées);
            listeDiv.CommandType = CommandType.Text;
            OracleDataReader divisionReader = listeDiv.ExecuteReader();
            try
            {
                while (divisionReader.Read())
                {
                    nbreIngredients = divisionReader.GetInt32(0).ToString();
                }
                divisionReader.Close();
            }
            catch (Exception sel) { MessageBox.Show(sel.Message.ToString()); }

            return nbreIngredients;
        }
        public List<string> QuelIngredientNonDisponible()
        {
            List<string> nbreIngredients = new List<string>();
            string cmd = "select NOMBOUTEILLE from ingredient where BOUTEILLEPRESENTE = 0";
            OracleCommand listeDiv = new OracleCommand(cmd, BaseDonnées);
            listeDiv.CommandType = CommandType.Text;
            OracleDataReader divisionReader = listeDiv.ExecuteReader();
            try
            {
                while (divisionReader.Read())
                {
                    nbreIngredients.Add(divisionReader.GetString(0));
                }
                divisionReader.Close();
            }
            catch (Exception sel) { MessageBox.Show(sel.Message.ToString()); }

            return nbreIngredients;
        }
        public void Effacer_Commande_Choisi(int nombre)
        {
            try
            {
                string cmd = "DELETE FROM Commande WHERE NUMCOMMANDE='" + nombre + "'";
                OracleCommand disc = new OracleCommand(cmd, BaseDonnées);
                disc.ExecuteNonQuery();
            }
            catch (Exception sel) { MessageBox.Show(sel.Message.ToString()); }

            try
            {
                string cmd1 = "commit";
                OracleCommand disc1 = new OracleCommand(cmd1, BaseDonnées);
                disc1.ExecuteNonQuery();
            }
            catch (Exception) { MessageBox.Show(" Échec de l'enregistrement."); }
        }


        public void AjouterShooter(int nombre)
        {
            try
            {
                string cmd = "UPDATE verreshooter SET NBSHOOTER =" + nombre;

                OracleCommand disc = new OracleCommand(cmd, BaseDonnées);
                disc.ExecuteNonQuery();
            }
            catch (Exception sel) { MessageBox.Show(sel.Message.ToString()); }

            try
            {
                string cmd1 = "commit";
                OracleCommand disc1 = new OracleCommand(cmd1, BaseDonnées);
                disc1.ExecuteNonQuery();
            }
            catch (Exception) { MessageBox.Show(" Échec de l'enregistrement."); }
        }

        public void SupprimerCommande()
        {
            try
            {
                string cmd = "delete  from commande";

                OracleCommand disc = new OracleCommand(cmd, BaseDonnées);
                disc.ExecuteNonQuery();
            }
            catch (Exception sel) { MessageBox.Show(sel.Message); }
        }


        public void SupprimerCommande(int num)
        {
            try
            {
                string cmd = "delete  from commande where numcommande=" + num.ToString();

                OracleCommand disc = new OracleCommand(cmd, BaseDonnées);
                disc.ExecuteNonQuery();
            }
            catch (Exception sel) { MessageBox.Show(sel.Message.ToString()); }
        }
    }

    public class Commande
    {
        private SpecificateurCommande commande;

        public Commande(int num)
        {
            if (num == 0)
                commande = new Commande_Normale();
            else
                commande = new Shooter();
        }



        public SpecificateurCommande TypeReel()
        {
            return commande.TypeReel();
        }


        public List<(Position, int)> ListerIngredients(int numcom)
        {
            return commande.Ingredients(numcom);
        }
    }


    public abstract class SpecificateurCommande
    {
        protected DataBase Connexion { get; } = DataBase.instance_bd;

        public abstract List<(Position, int)> Ingredients(int numcom);

        public abstract SpecificateurCommande TypeReel();

    }

    class Shooter : SpecificateurCommande
    {
        List<(Position, int)> ingredients = new List<(Position, int)>();
        public Shooter() : base()
        {

        }
        public override List<(Position, int)> Ingredients(int numcom)
        {
            string cmd = "select e.POSITIONX,e.POSITIONY,e.POSITIONZ,c.QTY from ingredient e inner join commande c on e.codebouteille=c.ingredient where c.numcommande=" + numcom.ToString();

            OracleCommand listeDiv = new OracleCommand(cmd, Connexion.BaseDonnées);
            listeDiv.CommandType = CommandType.Text;
            OracleDataReader divisionReader = listeDiv.ExecuteReader();
            try
            {
                while (divisionReader.Read())
                {
                    ingredients.Add((new Position(divisionReader.GetInt32(0), divisionReader.GetInt32(1), divisionReader.GetInt32(2)), divisionReader.GetInt32(3)));
                }
                divisionReader.Close();
            }
            catch (Exception sel) { MessageBox.Show(sel.Message.ToString()); }

            return ingredients;
        }

        public override SpecificateurCommande TypeReel()
        {
            return new Shooter();
        }
    }

    public class Commande_Normale : SpecificateurCommande
    {
        List<(Position, int)> ingredients = new List<(Position, int)>();
        public Commande_Normale() : base()
        {

        }
        public override SpecificateurCommande TypeReel()
        {
            return new Commande_Normale();
        }

        public override List<(Position, int)> Ingredients(int numcom)
        {
            string cmd = "select e.POSITIONX,e.POSITIONY,e.POSITIONZ,c.QTY from ingredient e inner join commande c on e.codebouteille=c.ingredient where numcommande=" + numcom.ToString();

            OracleCommand listeDiv = new OracleCommand(cmd, Connexion.BaseDonnées);
            listeDiv.CommandType = CommandType.Text;
            OracleDataReader divisionReader = listeDiv.ExecuteReader();
            try
            {
                while (divisionReader.Read())
                {
                    ingredients.Add((new Position(divisionReader.GetInt32(0), divisionReader.GetInt32(1), divisionReader.GetInt32(2)), divisionReader.GetInt32(3)));
                }
                divisionReader.Close();
            }
            catch (Exception sel) { MessageBox.Show(sel.Message.ToString()); }

            return ingredients;
        }
    }
}