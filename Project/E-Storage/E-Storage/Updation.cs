using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Storage
{
    class Updation
    {
        public void updateUser(int id, string name, string username, string password, string phone, string email, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateUser", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(name + " updated to the system successfully", "Success...", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
        }

        public void updateCategory(int id, string name, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(name + " updated to the system successfully", "Success...", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
        }

        public void updateSalesQuantity(Int64 saleID, Int16 quantity)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateQuantityInSalesDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@saleID", saleID);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
        }

        public void updateProduct(Int64 id, string product, string barcode, int categoryID, DateTime? expiryDate = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateProduct", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", product);
                cmd.Parameters.AddWithValue("@barcode", barcode);
                if (expiryDate == null)
                {
                    cmd.Parameters.AddWithValue("@expiryDate", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@expiryDate", expiryDate);
                }
                cmd.Parameters.AddWithValue("@categoryID", categoryID);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(product + " updated to the system successfully", "Success...", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
        }

        public void updateStock(Int64 productID, int quantity)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateStock", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@productID", productID);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
            }
        }

        public void updateStockWithoutConnection(Int64 productID, int quantity)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateStock", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@productID", productID);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MainClass.con.Close();
            }
        }

        public void updateProductPrice(Int64 productID, float buyingPrice, float sellingPrice = 0, float discount = 0, float profitPercentage = 0)
        {
            try
            {
                SqlCommand cmd;
                if (sellingPrice == 0 && discount == 0 && profitPercentage == 0)
                {
                    cmd = new SqlCommand("st_updateProductPrice1", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@productID", productID);
                    cmd.Parameters.AddWithValue("@buyingPrice", buyingPrice);
                }
                else
                {
                    cmd = new SqlCommand("st_updateProductPrice", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@productID", productID);
                    cmd.Parameters.AddWithValue("@buyingPrice", buyingPrice);
                    cmd.Parameters.AddWithValue("@sellingPrice", sellingPrice);
                    cmd.Parameters.AddWithValue("@discount", discount);
                    cmd.Parameters.AddWithValue("@profitPercentage", profitPercentage);
                }
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
            }
        }

        public void updateSupplier(int id, string company, string contactPerson, string phone, string address, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateSupplier", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@company", company);
                cmd.Parameters.AddWithValue("@contactPerson", contactPerson);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(company + " updated to the system successfully", "Success...", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
        }
    }
}