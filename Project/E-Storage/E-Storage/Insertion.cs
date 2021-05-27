using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

namespace E_Storage
{
    class Insertion
    {
        public void insertUser(string name, string username, string password, string phone, string email, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertUser", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(name + " added to the system successfully", "Success...", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
        }

        public void insertCategory(string name, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(name + " added to the system successfully", "Success...", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
        }

        public void insertProduct(string product, string barcode, int categoryID, DateTime? expiryDate = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertProduct", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
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
                MainClass.ShowMSG(product + " added to the system successfully", "Success...", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
        }

        public void insertSupplier(string company, string contactPerson, string phone, string address, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertSupplier", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@company", company);
                cmd.Parameters.AddWithValue("@contactPerson", contactPerson);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(company + " added to the system successfully", "Success...", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
        }

        private Int64 purchaseInvoiceID;

        public Int64 insertPurchaseInvoice(DateTime date, int doneBy, int supplierID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertPurchaseInvoice", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@doneBy", doneBy);
                cmd.Parameters.AddWithValue("@supplierID", supplierID);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "st_getLastPurchaseID";
                cmd.Parameters.Clear();
                purchaseInvoiceID = Convert.ToInt64(cmd.ExecuteScalar());
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
            return purchaseInvoiceID;
        }
        int pidCount;
        public int insertPurchaseInvoiceDetails(Int64 purchaseID, Int64 productID, int quantity, float totalPrice)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertPurchaseInvoiceDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@purchaseID", purchaseID);
                cmd.Parameters.AddWithValue("@productID", productID);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@totalPrice", totalPrice);
                MainClass.con.Open();
                pidCount = cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch(Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
            return pidCount;
        }

        public void insertStock(Int64 productID, int quantity)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertStock", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@productID", productID);
                cmd.Parameters.AddWithValue("@quantity", quantity);
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

        public void insertDeletedItem(Int64 pid, Int64 productID, int quantity, int userID, DateTime date)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertDeletedItemPI", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pi", pid);
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("@productID", productID);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@date", date);
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

        public void insertProductPrice(Int64 productID, float buyingPrice)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertProductPrice", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@productID", productID);
                cmd.Parameters.AddWithValue("@buyingPrice", buyingPrice);
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
        int saleCount = 0;
        Int64 saleID;
        Retrieval r = new Retrieval();
        Updation u = new Updation();
        public void insertSales(DataGridView gv, string productIDGV, string productQuantityGV, string perUnitPriceGV, string discountGV, int doneBy, DateTime datetime, float totalAmount, float totalDiscount, float amountGiven, float amountReturned, string payType)
        {
            try
            {
                using (TransactionScope sc = new TransactionScope())
                {
                    SqlCommand cmd = new SqlCommand("st_insertSales", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@doneBy", doneBy);
                    cmd.Parameters.AddWithValue("@date", datetime);
                    cmd.Parameters.AddWithValue("@totalAmount", totalAmount);
                    cmd.Parameters.AddWithValue("@totalDiscount", totalDiscount);
                    cmd.Parameters.AddWithValue("@amountGiven", amountGiven);
                    cmd.Parameters.AddWithValue("@amountReturned", amountReturned);
                    if (payType == "Cash")
                    {
                        cmd.Parameters.AddWithValue("@payType", 0);
                    }
                    else if (payType == "Debit Card")
                    {
                        cmd.Parameters.AddWithValue("@payType", 1);
                    }
                    else if (payType == "Credit Card")
                    {
                        cmd.Parameters.AddWithValue("@payType", 2);
                    }
                    MainClass.con.Open();
                    saleCount = cmd.ExecuteNonQuery();
                    if (saleCount > 0)
                    {
                        SqlCommand cmd2 = new SqlCommand("st_getSalesID", MainClass.con);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        saleID = Convert.ToInt64(cmd2.ExecuteScalar());
                        foreach (DataGridViewRow row in gv.Rows)
                        {
                            SqlCommand cmd3 = new SqlCommand("st_insertSalesDetails", MainClass.con);
                            cmd3.CommandType = CommandType.StoredProcedure;
                            cmd3.Parameters.AddWithValue("@saleID", saleID);
                            cmd3.Parameters.AddWithValue("@productID", Convert.ToInt64(row.Cells[productIDGV].Value.ToString()));
                            cmd3.Parameters.AddWithValue("@quantity", Convert.ToInt32(row.Cells[productQuantityGV].Value.ToString()));
                            cmd3.Parameters.AddWithValue("@sellingPrice", Convert.ToSingle(row.Cells[perUnitPriceGV].Value.ToString()));
                            cmd3.Parameters.AddWithValue("@discount", Convert.ToSingle(row.Cells[discountGV].Value.ToString()));
                            cmd3.ExecuteNonQuery();
                            int stockOfProduct = Convert.ToInt32(r.getProductQuantityWithoutConnection(Convert.ToInt64(row.Cells[productIDGV].Value.ToString())));
                            int currentQuanOfProduct = Convert.ToInt32(row.Cells[productQuantityGV].Value.ToString());
                            int finalProductQuantity = stockOfProduct - currentQuanOfProduct;
                            u.updateStockWithoutConnection(Convert.ToInt64(row.Cells[productIDGV].Value.ToString()), finalProductQuantity);
                        }
                    }
                    MainClass.con.Close();
                    MainClass.ShowMSG("Sales added to the system successfully", "Success...", "Success");
                    sc.Complete();
                }
            }
            catch (Exception)
            {
                MainClass.con.Close();
            }
        }
        int x = 0;
        public int insertReturnRefund(Int64 saleID, DateTime date, int doneBy, Int64 productID, Int16 quantity, float amount)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("st_insertReturnRefund", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@saleID", saleID);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@doneBy", doneBy);
                cmd.Parameters.AddWithValue("@productID", productID);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@amount", amount);
                MainClass.con.Open();
                x = cmd.ExecuteNonQuery();
                MainClass.con.Close();

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
            return x;
        }
    }
}