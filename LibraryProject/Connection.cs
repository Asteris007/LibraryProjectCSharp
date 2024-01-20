using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryProject
{
    class Connection
    {
        public SqlConnection connect;
        public SqlCommand command;


        private void ConnectionTo()
        {
            connect = new SqlConnection(@"Data Source=DESKTOP-8DO5SBP\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True;");
            command = new SqlCommand();
            command.Connection = connect;
        }


        public Connection()
        {
            ConnectionTo();
        }

        public void Save(Books books)
        {
            try
            {
                command.CommandText = "INSERT INTO Books ([BookID],[Title],[AuthorID],[GenreID],[YearID]) " +
                            "VALUES (@BookID, @Title, @AuthorID, @GenreID, @YearID)";
                command.CommandType = System.Data.CommandType.Text;

                command.Parameters.AddWithValue("@BookID", books.BookID);
                command.Parameters.AddWithValue("@Title", books.Title);
                command.Parameters.AddWithValue("@AuthorID", books.AuthorID);
                command.Parameters.AddWithValue("@GenreID", books.GenreID);
                command.Parameters.AddWithValue("@YearID", books.YearID);

                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err}");
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }

        public void Update(Books books)
        {
            try
            {
                command.CommandText = $"Update Books set [Title] = '{books.Title}',[AuthorID] ='{books.AuthorID}',[GenreID]='{books.GenreID}',[YearID]='{books.YearID}' where [BookID] = '{books.BookID}'";
                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err}");
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }

        public void Delete(Books books)
        {
            try
            {
                command.CommandText = $"Delete from Books  where [BookID] = '{books.BookID}'";
                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err}");
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }
        public void Save(Borrow borrow)
        {
            try
            {

                command.CommandText = $"Insert into Borrow([BorrowID],[ReaderID],[BorrowDate],[ReturnDate]) " +
                    $"values ('{borrow.BorrowID}','{borrow.ReaderID}','{borrow.BorrowDate}','{borrow.ReturnDate}')";
                command.Parameters.AddWithValue("@BorrowID", borrow.BorrowID);
                command.Parameters.AddWithValue("@ReaderID", borrow.ReaderID);
                command.Parameters.AddWithValue("@BorrowDate", borrow.BorrowDate);
                command.Parameters.AddWithValue("@ReturnDate", borrow.ReturnDate);
                



                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err}");
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }




        public void Update(Borrow borrow)
        {
            try
            {
                command.CommandText = $"Update Borrow set [ReaderID] = '{borrow.ReaderID}'," +
                    $"[BorrowDate] = '{borrow.BorrowDate}', [ReturnDate] = '{borrow.ReturnDate}', " +
                    $"[BookID] = '{borrow.BookID}' where [BorrowID] = '{borrow.BorrowID}'";
                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err}");
            }
            finally
            {
                if (connect != null && connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }




        public void Delete(Borrow borrow)
        {
            try
            {
                command.CommandText = $"Delete Borrow where [BorrowID] = '{borrow.BorrowID}'";
                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err}");
            }
            finally
            {
                if (connect != null && connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }


        public void Save(Authors authors)
        {
            try
            {
                command.CommandText = $"Insert into Authors([AuthorID], [AuthorName]) values ('{authors.AuthorID}', '{authors.AuthorName}')";

                command.Parameters.AddWithValue("@AuthorID", authors.AuthorID);
                command.Parameters.AddWithValue("@AuthorName", authors.AuthorName);
                
                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err}");
            }
            finally
            {
                if (connect != null && connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        public void Update(Authors authors)
        {
            try
            {
                command.CommandText = $"Update Authors set [AuthorName] = '{authors.AuthorName}' where [AuthorID] = '{authors.AuthorID}'";
                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err}");
            }
            finally
            {
                if (connect != null && connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        public void Delete(Authors authors)
        {
            try
            {
                command.CommandText = $"Delete Authors where [AuthorID] = '{authors.AuthorID}'";
                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err}");
            }
            finally
            {
                if (connect != null && connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        public void Save(Readers readers)
        {
            try
            {
                command.CommandText = "INSERT INTO Readers ([ReaderID],[FirstName],[SecondName],[LastName],[EGN]) " +
                            "VALUES (@ReaderID, @FirstName, @SecondName, @LastName, @EGN)";
                command.CommandType = System.Data.CommandType.Text;

                command.Parameters.AddWithValue("@ReaderID", readers.ReaderID);
                command.Parameters.AddWithValue("@FirstName", readers.FirstName);
                command.Parameters.AddWithValue("@SecondName", readers.SecondName);
               command.Parameters.AddWithValue("@LastName", readers.LastName);
                command.Parameters.AddWithValue("@EGN", readers.EGN);



                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err}");
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }
        public void Update(Readers readers)
        {
            try
            {
                command.CommandText = $"Update Readers set [FirstName] = '{readers.FirstName}',[SecondName] = '{readers.SecondName}',[LastName] = '{readers.LastName}', [EGN] = '{readers.EGN}' where [ReaderID] = '{readers.ReaderID}'";
                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err}");
            }
            finally
            {
                if (connect != null && connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }
        public void Delete(Readers readers)
        {
            try
            {
                command.CommandText = $"Delete Readers where [ReaderID] = '{readers.ReaderID}'";
                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err}");
            }
            finally
            {
                if (connect != null && connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }


        public void Save(Genre genre)
        {
            try
            {
                command.CommandText = $"Insert into Genre([GenreID], [GenreName]) values ('{genre.GenreID}', '{genre.GenreName}')";

                command.Parameters.AddWithValue("@GenreID", genre.GenreID);
                command.Parameters.AddWithValue("@AGenreName", genre.GenreName);

                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err}");
            }
            finally
            {
                if (connect != null && connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        public void Update(Genre genre)
        {
            try
            {
                command.CommandText = $"Update Genre set [GenreName] = '{genre.GenreName}' where [GenreID] = '{genre.GenreID}'";
                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err}");
            }
            finally
            {
                if (connect != null && connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        public void Delete(Genre genre)
        {
            try
            {
                command.CommandText = $"Delete Genre where [GenreID] = '{genre.GenreID}'";
                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err}");
            }
            finally
            {
                if (connect != null && connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }


        public void Save(Year year)
        {
            try
            {
                command.CommandText = $"Insert into Year([YearID], [YearValue]) values ('{year.YearID}', '{year.YearValue}')";

                command.Parameters.AddWithValue("@YearID", year.YearID);
                command.Parameters.AddWithValue("@YearValue", year.YearValue);

                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err}");
            }
            finally
            {
                if (connect != null && connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        public void Update(Year year)
        {
            try
            {
                command.CommandText = $"Update Year set [GenreName] = '{year.YearValue}' where [GenreID] = '{year.YearID}'";
                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err}");
            }
            finally
            {
                if (connect != null && connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        public void Delete(Year year)
        {
            try
            {
                command.CommandText = $"Delete Year where [YearID] = '{year.YearID}'";
                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err}");
            }
            finally
            {
                if (connect != null && connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }
    }
}
