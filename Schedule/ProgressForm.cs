using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace Scheduling_Interviews.Schedule
{
    public partial class ProgressForm : Form
    {
        private int selected;
        private bool pause = false;
        int counter;

        SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kriss\Documents\Applications.mdf;Integrated Security=True;Connect Timeout=30");


        string sql = "SELECT id, firstName, lastName, email,  PhoneNo, gender, interviewStatus FROM AllApplications";

        public ProgressForm()
        {
            InitializeComponent();
            progresslistView.View = View.Details;
            progress();

            //Add Column Header


            progresslistView.Columns.Add("First Name", 150);
            progresslistView.Columns.Add("Last Name", 150);
            progresslistView.Columns.Add("EmailAdress", 150);
            progresslistView.Columns.Add("Status", 150);
        }

          
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tokenbutton_Click(object sender, EventArgs e)
        {


        }


        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (pause == false)
                {

                    pause = true;
                    pausebutton.Text = "Resume";
                }
                else
                {
                    pause = false;
                    pausebutton.Text = "Hold";
                }
                MyScheduler.status(pause);
            }
        }

        private void ProgressForm_Load(object sender, EventArgs e)
        {

        }

        private void progress()
        {
            String ConnectionString = ConfigurationManager.ConnectionStrings["Scheduling_Interviews.Properties.Settings.SchedulingDatabaseConnectionString"].ConnectionString;

            string sql = "SELECT FirstName, LastName, EmailAddress, Status FROM Applicants";

            SqlConnection cnn = new SqlConnection(ConnectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            //cmd.ExecuteNonQuery();
            //SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            SqlDataReader Reader = cmd.ExecuteReader();
            progresslistView.Items.Clear();

            while (Reader.Read())
            {

                ListViewItem lv = new ListViewItem(Reader.GetString(0));
                lv.SubItems.Add(Reader.GetString(1));
                lv.SubItems.Add(Reader.GetString(2));
                lv.SubItems.Add(Reader.GetString(3));
                // lv.SubItems.Add(Reader.GetString(4));

                progresslistView.Items.Add(lv);
                //Reader.GetInt32(0).ToString()

            }

            Reader.Close();

            cnn.Close();


        }

        private void trackbutton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var allChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var resultToken = new string(Enumerable.Repeat(allChar, 8).Select(token => token[random.Next(token.Length)]).ToArray());


            var encryptedText = Encrypt(resultToken, "test");
            MessageBox.Show("Encrypted Text: " + encryptedText);
            var decryptedText = Decrypt(encryptedText, "test");
            MessageBox.Show("Decrypted Text: " + decryptedText);


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private const int Keysize = 256;

        // This constant determines the number of iterations for the password bytes generation function.
        private const int DerivationIterations = 1000;

        public static string Encrypt(string plainText, string passPhrase)
        {
            // Salt and IV is randomly generated each time, but is preprended to encrypted cipher text
            // so that the same Salt and IV values can be used when decrypting.  
            var saltStringBytes = Generate256BitsOfRandomEntropy();
            var ivStringBytes = Generate256BitsOfRandomEntropy();
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                cryptoStream.FlushFinalBlock();
                                // Create the final bytes as a concatenation of the random salt bytes, the random iv bytes and the cipher bytes.
                                var cipherTextBytes = saltStringBytes;
                                cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
                                cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Convert.ToBase64String(cipherTextBytes);
                            }
                        }
                    }
                }
            }
        }

        public static string Decrypt(string cipherText, string passPhrase)
        {
            // Get the complete stream of bytes that represent:
            // [32 bytes of Salt] + [32 bytes of IV] + [n bytes of CipherText]
            var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
            // Get the saltbytes by extracting the first 32 bytes from the supplied cipherText bytes.
            var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
            // Get the IV bytes by extracting the next 32 bytes from the supplied cipherText bytes.
            var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
            // Get the actual cipher text bytes by removing the first 64 bytes from the cipherText string.
            var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();

            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream(cipherTextBytes))
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                            {
                                var plainTextBytes = new byte[cipherTextBytes.Length];
                                var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                            }
                        }
                    }
                }
            }
        }
        private static byte[] Generate256BitsOfRandomEntropy()
        {
            var randomBytes = new byte[32]; // 32 Bytes will give us 256 bits.
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                // Fill the array with cryptographically secure random bytes.
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }
    }












}


