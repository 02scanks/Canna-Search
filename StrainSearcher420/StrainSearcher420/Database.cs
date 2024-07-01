using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System;
using StrainSearcher420;
using System.Drawing;

public class Database 
{
    string connectionString = "server=localhost;port=3306;database=canna_search;user=root;password=";

    public bool Login(string username, string password) 
    {
        string query = "SELECT * FROM users WHERE user = @username AND password = @password";

        try
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    connection.Open();

                    int result = Convert.ToInt32(command.ExecuteScalar());
                    if (result > 0)
                    {
                        Main mainForm = new Main();
                        mainForm.Show();

                        return true;
                    }
                    else 
                    {
                        MessageBox.Show("Username Or Password Incorrect");
                    }
                }
            }
        }
        catch (Exception ex) 
        {
            MessageBox.Show($"ERROR: {ex.Message}");
        }

        return false;
    }

    public void AddToHybridDB(string name, string thcRating, string cbdRating, string overallRating, string filePath, string imageName, string effect, string negatives, string taste) 
    {
        string query = "INSERT INTO hybrid (name, thc, cbd, stars, imageData, imageName, effects, negatives, taste) values (@name, @thcRating, @cbdRating, @overallRating, @imageData, @imageName, @effect, @negative, @taste)";
        byte[] imageData = File.ReadAllBytes(filePath);
        
        using (MySqlConnection connection = new MySqlConnection(connectionString)) 
        {
            connection.Open();

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@thcRating", thcRating);
                    command.Parameters.AddWithValue("@cbdRating", cbdRating);
                    command.Parameters.AddWithValue("@overallRating", overallRating);
                    command.Parameters.AddWithValue("@imageData", imageData);
                    command.Parameters.AddWithValue("@imageName", imageName);
                    command.Parameters.AddWithValue("@effect", effect);
                    command.Parameters.AddWithValue("@negative", negatives);
                    command.Parameters.AddWithValue("@taste", taste);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Added To Database");
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"ERROR: {ex.Message}");
            }
            
        }
    }

    public void AddToIndicaDB(string name, string thcRating, string cbdRating, string overallRating, string filePath, string imageName, string effect, string negatives, string taste)
    {
        string query = "INSERT INTO indica (name, thc, cbd, stars, imageData, imageName, effects, negatives, taste) values (@name, @thcRating, @cbdRating, @overallRating, @imageData, @imageName, @effect, @negative, @taste)";
        byte[] imageData = File.ReadAllBytes(filePath);

        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open();

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@thcRating", thcRating);
                    command.Parameters.AddWithValue("@cbdRating", cbdRating);
                    command.Parameters.AddWithValue("@overallRating", overallRating);
                    command.Parameters.AddWithValue("@imageData", imageData);
                    command.Parameters.AddWithValue("@imageName", imageName);
                    command.Parameters.AddWithValue("@effect", effect);
                    command.Parameters.AddWithValue("@negative", negatives);
                    command.Parameters.AddWithValue("@taste", taste);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Added To Database");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
            }

        }
    }

    public void AddToSativaDB(string name, string thcRating, string cbdRating, string overallRating, string filePath, string imageName, string effect, string negatives, string taste)
    {
        string query = "INSERT INTO sativa (name, thc, cbd, stars, imageData, imageName, effects, negatives, taste) values (@name, @thcRating, @cbdRating, @overallRating, @imageData, @imageName, @effect, @negative, @taste)";
        byte[] imageData = File.ReadAllBytes(filePath);

        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open();

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@thcRating", thcRating);
                    command.Parameters.AddWithValue("@cbdRating", cbdRating);
                    command.Parameters.AddWithValue("@overallRating", overallRating);
                    command.Parameters.AddWithValue("@imageData", imageData);
                    command.Parameters.AddWithValue("@imageName", imageName);
                    command.Parameters.AddWithValue("@effect", effect);
                    command.Parameters.AddWithValue("@negative", negatives);
                    command.Parameters.AddWithValue("@taste", taste);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Added To Database");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
            }

        }
    }

    public void PopulateHybrids(Panel hybridPanel, int multiplier)
    {
        string query = "SELECT name, thc, cbd, stars, imageData, imageName, effects, negatives, taste FROM hybrid";

        using (var connection = new MySqlConnection(connectionString))
        {
            using (var command = new MySqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Create a new instance of TemplateControl for each database entry
                            TemplateControl newTemplate = new TemplateControl();

                            string name = reader.GetString("name");
                            string thc = reader.GetString("thc");
                            string cbd = reader.GetString("cbd");
                            string rating = reader.GetString("stars");
                            byte[] imageData = reader["imageData"] as byte[];
                            string imageName = reader.GetString("imageName");
                            string effects = reader.GetString("effects");
                            string negatives = reader.GetString("negatives");
                            string taste = reader.GetString("taste");

                            // Display image if imageData is not null
                            if (imageData != null)
                            {
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    Image image = Image.FromStream(ms);
                                    newTemplate.Image = image;
                                }
                            }

                            // Set the properties of the TemplateControl
                            newTemplate.StrainName = name;
                            newTemplate.THC = thc;
                            newTemplate.CBD = cbd;
                            newTemplate.Effects = effects;
                            newTemplate.Negatives = negatives;
                            newTemplate.Taste = taste;
                            newTemplate.Rating = rating;

                            // Multiply the depth of the panel by however many other panels there are
                            int locationY = 103 * multiplier;
                            newTemplate.Location = new Point(0, locationY);

                            // Add the newTemplate to the hybridPanel
                            hybridPanel.Controls.Add(newTemplate);

                            multiplier++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"ERROR: {ex.Message}");
                }
            }
        }
    }

    public void PopulateSativas(Panel sativaPanel, int multiplier)
    {
        string query = "SELECT name, thc, cbd, stars, imageData, imageName, effects, negatives, taste FROM sativa";

        using (var connection = new MySqlConnection(connectionString))
        {
            using (var command = new MySqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Create a new instance of TemplateControl for each database entry
                            TemplateControl newTemplate = new TemplateControl();

                            string name = reader.GetString("name");
                            string thc = reader.GetString("thc");
                            string cbd = reader.GetString("cbd");
                            string rating = reader.GetString("stars");
                            byte[] imageData = reader["imageData"] as byte[];
                            string imageName = reader.GetString("imageName");
                            string effects = reader.GetString("effects");
                            string negatives = reader.GetString("negatives");
                            string taste = reader.GetString("taste");

                            // Display image if imageData is not null
                            if (imageData != null)
                            {
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    Image image = Image.FromStream(ms);
                                    newTemplate.Image = image;
                                }
                            }

                            // Set the properties of the TemplateControl
                            newTemplate.StrainName = name;
                            newTemplate.THC = thc;
                            newTemplate.CBD = cbd;
                            newTemplate.Effects = effects;
                            newTemplate.Negatives = negatives;
                            newTemplate.Taste = taste;
                            newTemplate.Rating = rating;

                            // Multiply the depth of the panel by however many other panels there are
                            int locationY = 103 * multiplier;
                            newTemplate.Location = new Point(0, locationY);

                            // Add the newTemplate to the hybridPanel
                            sativaPanel.Controls.Add(newTemplate);

                            multiplier++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"ERROR: {ex.Message}");
                }
            }
        }
    }

    public void PopulateIndicas(Panel indicaPanel, int multiplier)
    {
        string query = "SELECT name, thc, cbd, stars, imageData, imageName, effects, negatives, taste FROM indica";

        using (var connection = new MySqlConnection(connectionString))
        {
            using (var command = new MySqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Create a new instance of TemplateControl for each database entry
                            TemplateControl newTemplate = new TemplateControl();

                            string name = reader.GetString("name");
                            string thc = reader.GetString("thc");
                            string cbd = reader.GetString("cbd");
                            string rating = reader.GetString("stars");
                            byte[] imageData = reader["imageData"] as byte[];
                            string imageName = reader.GetString("imageName");
                            string effects = reader.GetString("effects");
                            string negatives = reader.GetString("negatives");
                            string taste = reader.GetString("taste");

                            // Display image if imageData is not null
                            if (imageData != null)
                            {
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    Image image = Image.FromStream(ms);
                                    newTemplate.Image = image;
                                }
                            }

                            // Set the properties of the TemplateControl
                            newTemplate.StrainName = name;
                            newTemplate.THC = thc;
                            newTemplate.CBD = cbd;
                            newTemplate.Effects = effects;
                            newTemplate.Negatives = negatives;
                            newTemplate.Taste = taste;
                            newTemplate.Rating = rating;

                            // Multiply the depth of the panel by however many other panels there are
                            int locationY = 103 * multiplier;
                            newTemplate.Location = new Point(0, locationY);

                            // Add the newTemplate to the hybridPanel
                            indicaPanel.Controls.Add(newTemplate);

                            multiplier++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"ERROR: {ex.Message}");
                }
            }
        }
    }

}