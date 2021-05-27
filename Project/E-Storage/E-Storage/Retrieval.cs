using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Storage
{
    class Retrieval
    {
        public void showUsers(DataGridView gv, DataGridViewColumn userIDGV, DataGridViewColumn nameGV, DataGridViewColumn usernameGV, DataGridViewColumn passwordGV, DataGridViewColumn phoneGV, DataGridViewColumn emailGV, DataGridViewColumn statusGV, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getUsersData", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getUsersDataLike", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                userIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["Name"].ToString();
                usernameGV.DataPropertyName = dt.Columns["Username"].ToString();
                passwordGV.DataPropertyName = dt.Columns["Password"].ToString();
                phoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                emailGV.DataPropertyName = dt.Columns["Email"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.ShowMSG("Unable to load users data.", "Error", "Error");
            }
        }

        public void showCategories(DataGridView gv, DataGridViewColumn categoryGV, DataGridViewColumn categoryNameGV, DataGridViewColumn statusGV, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getCategoriesData", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getCategoriesDataLike", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                categoryGV.DataPropertyName = dt.Columns["ID"].ToString();
                categoryNameGV.DataPropertyName = dt.Columns["Category"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.ShowMSG("Unable to load categories data.", "Error", "Error");
            }
        }

        public void getList(string proc, ComboBox cb, string displayMember, string valueMember)
        {
            try
            {
                cb.DataSource = null;
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select..." };
                dt.Rows.InsertAt(dr, 0);
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;
                cb.DataSource = dt;
            }
            catch(Exception)
            {

            }
        }

        public void getListWithTwoParameters(string proc, ComboBox cb, string displayMember, string valueMember, string param1, object val1, string param2, object val2)
        {
            try
            {
                cb.DataSource = null;
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param1, val1);
                cmd.Parameters.AddWithValue(param2, val2);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select..." };
                dt.Rows.InsertAt(dr, 0);
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;
                cb.DataSource = dt;
            }
            catch (Exception)
            {

            }
        }

        public void showSalesDataViaID(Int64 saleID, DataGridView gv, DataGridViewColumn saleIDGV, DataGridViewColumn barcodeGV, DataGridViewColumn productGV, DataGridViewColumn quantityGV, DataGridViewColumn productPriceGV, DataGridViewColumn productDiscountGV, DataGridViewColumn totalPerProductDiscountGV, DataGridViewColumn perProductTotalGV, DataGridViewColumn totalDiscountGV, DataGridViewColumn totalAmountGV, DataGridViewColumn amountGivenGV, DataGridViewColumn amountReturnedGV, DataGridViewColumn dateGV, DataGridViewColumn userGV, DataGridViewColumn payTypeGV, DataGridViewColumn productIDGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getSalesReceiptWRTSalesID", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@saleID", saleID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                saleIDGV.DataPropertyName = dt.Columns["Sale_ID"].ToString();
                barcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                productGV.DataPropertyName = dt.Columns["Product"].ToString();
                quantityGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                productPriceGV.DataPropertyName = dt.Columns["Product_Price"].ToString();
                productDiscountGV.DataPropertyName = dt.Columns["Product_Discount"].ToString();
                totalPerProductDiscountGV.DataPropertyName = dt.Columns["Total_Per_Product_Discount"].ToString();
                perProductTotalGV.DataPropertyName = dt.Columns["Per_Product_Total"].ToString();
                totalDiscountGV.DataPropertyName = dt.Columns["Total_Discount"].ToString();
                totalAmountGV.DataPropertyName = dt.Columns["Total_Amount"].ToString();
                amountGivenGV.DataPropertyName = dt.Columns["Amount_Given"].ToString();
                amountReturnedGV.DataPropertyName = dt.Columns["Amount_Returned"].ToString();
                dateGV.DataPropertyName = dt.Columns["Date"].ToString();
                userGV.DataPropertyName = dt.Columns["User"].ToString();
                payTypeGV.DataPropertyName = dt.Columns["Pay_Type"].ToString();
                productIDGV.DataPropertyName = dt.Columns["Product_ID"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.ShowMSG("Unable to load products data.", "Error", "Error");
            }
        }

        public void showProducts(DataGridView gv, DataGridViewColumn productIDGV, DataGridViewColumn productNameGV, DataGridViewColumn barcodeGV, DataGridViewColumn expiryDateGV, DataGridViewColumn categoryGV, DataGridViewColumn categoryIDGV, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getProductsData", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getProductsDataLike", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                productIDGV.DataPropertyName = dt.Columns["Product_ID"].ToString();
                productNameGV.DataPropertyName = dt.Columns["Product"].ToString();
                barcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                expiryDateGV.DataPropertyName = dt.Columns["Expiry_Date"].ToString();
                categoryGV.DataPropertyName = dt.Columns["Category"].ToString();
                categoryIDGV.DataPropertyName = dt.Columns["Category_ID"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.ShowMSG("Unable to load products data.", "Error", "Error");
            }
        }

        public void showDailySales(DateTime date, DataGridView gv, DataGridViewColumn saleIDGV, DataGridViewColumn userGV, DataGridViewColumn totalAmountGV, DataGridViewColumn totalDiscountGV, DataGridViewColumn amountGivenGV, DataGridViewColumn amountReturnedGV, DataGridViewColumn userIDGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getDailySales", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date", date);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                saleIDGV.DataPropertyName = dt.Columns["Sale_ID"].ToString();
                userGV.DataPropertyName = dt.Columns["User"].ToString();
                totalAmountGV.DataPropertyName = dt.Columns["Total_Amount"].ToString();
                totalDiscountGV.DataPropertyName = dt.Columns["Total_Discount"].ToString();
                amountGivenGV.DataPropertyName = dt.Columns["Amount_Given"].ToString();
                amountReturnedGV.DataPropertyName = dt.Columns["Returned_Amount"].ToString();
                userIDGV.DataPropertyName = dt.Columns["User_ID"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.ShowMSG("Unable to load categories data.", "Error", "Error");
            }
        }
        private object productStockCount = 0;
        public object getProductQuantity(Int64 productID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductQuantity", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@productID", productID);
                MainClass.con.Open();
                productStockCount = cmd.ExecuteScalar();
                MainClass.con.Close();
            }
            catch (Exception)
            {

            }
            return productStockCount;
        }

        public object getProductQuantityWithoutConnection(Int64 productID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductQuantity", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@productID", productID);
                productStockCount = cmd.ExecuteScalar();
            }
            catch (Exception)
            {

            }
            return productStockCount;
        }

        public void showPurchaseInvoiceDetails(Int64 pid, DataGridView gv, DataGridViewColumn mPIDGV, DataGridViewColumn productIDGV, DataGridViewColumn productNameGV, DataGridViewColumn quantityGV, DataGridViewColumn perUnitPriceGV, DataGridViewColumn totalAmountGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getPurchaseInvoiceDitails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pid", pid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                mPIDGV.DataPropertyName = dt.Columns["mPID"].ToString();
                productIDGV.DataPropertyName = dt.Columns["Product_ID"].ToString();
                productNameGV.DataPropertyName = dt.Columns["Product"].ToString();
                quantityGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                perUnitPriceGV.DataPropertyName = dt.Columns["Per_Unit_Price"].ToString();
                totalAmountGV.DataPropertyName = dt.Columns["Total_Price"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.ShowMSG("Unable to load categories data.", "Error", "Error");
            }
        }

        public void showProductsWRTCategory(int categoryID, DataGridView gv, DataGridViewColumn productIDGV, DataGridViewColumn productNameGV, DataGridViewColumn buyingPriceGV, DataGridViewColumn sellingPriceGV, DataGridViewColumn discountGV, DataGridViewColumn profitPercentageGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductsWRTCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@categoryID", categoryID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                productIDGV.DataPropertyName = dt.Columns["Product_ID"].ToString();
                productNameGV.DataPropertyName = dt.Columns["Product"].ToString();
                buyingPriceGV.DataPropertyName = dt.Columns["Buying_Price"].ToString();
                sellingPriceGV.DataPropertyName = dt.Columns["Selling_Price"].ToString();
                discountGV.DataPropertyName = dt.Columns["Discount"].ToString();
                profitPercentageGV.DataPropertyName = dt.Columns["Profit_Percentage"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.ShowMSG("Unable to load products data.", "Error", "Error");
            }
        }

        public static int USER_ID
        {
            get;
            private set;
        }

        public static string EMP_NAME
        {
            get;
            private set;
        }

        public void showSalesReport(ReportViewer rv, string proc, string param1 = null, object val1 = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                if (param1 != null && val1 != null)
                {
                    cmd.Parameters.AddWithValue(param1, val1);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                rv.LocalReport.ReportPath = "C:/Users/Evita/Desktop/Project/E-Storage/E-Storage/SalesReceipt.rdlc";
                rv.LocalReport.DataSources.Clear();
                rv.LocalReport.DataSources.Add(rds);
                rv.RefreshReport();
            }
            catch (Exception ex)
            {
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }

        public void showSalesReturnReport(ReportViewer rv, string proc, string param1 = null, object val1 = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                if (param1 != null && val1 != null)
                {
                    cmd.Parameters.AddWithValue(param1, val1);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                rv.LocalReport.ReportPath = "C:/Users/Evita/Desktop/Project/E-Storage/E-Storage/SalesReturnReceipt.rdlc";
                rv.LocalReport.DataSources.Clear();
                rv.LocalReport.DataSources.Add(rds);
                rv.RefreshReport();
            }
            catch (Exception ex)
            {
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }
        private string[] productsData = new string[6];
        public string[] getProductsWRTBarcode(string barcode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductByBarcode", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", barcode);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        productsData[0] = dr[0].ToString();
                        productsData[1] = dr[1].ToString();
                        productsData[2] = dr[2].ToString();
                    }
                }
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
                throw;
            }
            return productsData;
        }

        public string[] getProductsWRTBarcode1(string barcode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductByBarcode1", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", barcode);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        productsData[0] = dr[0].ToString();
                        productsData[1] = dr[1].ToString();
                        productsData[2] = dr[2].ToString();
                        productsData[3] = dr[3].ToString();
                        productsData[4] = dr[4].ToString();
                        productsData[5] = dr[5].ToString();
                    }
                }
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
                throw;
            }
            return productsData;
        }
        private static string user_name=null, pass_word=null;
        private static bool checkLogin;
        public static bool getUserDetails(string username, string password)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getUserDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    checkLogin = true;
                    while (dr.Read())
                    {
                        USER_ID = Convert.ToInt32(dr["ID"].ToString());
                        EMP_NAME = dr["Name"].ToString();
                        user_name = dr["Username"].ToString();
                        pass_word = dr["Password"].ToString();
                    }
                }
                else
                {
                    checkLogin = false;
                    if (username != null && password != null)
                    {
                        if (user_name != username && pass_word == password)
                        {
                            MainClass.ShowMSG("Invalid Username", "Error", "Error");
                        }
                        else if (user_name == username && pass_word != password)
                        {
                            MainClass.ShowMSG("Invalid Password", "Error", "Error");
                        }
                        else if (user_name != username && pass_word != password)
                        {
                            MainClass.ShowMSG("Invalid Username and Password", "Error", "Error");
                        }

                    }
                }
                MainClass.con.Close();
            }
            catch(Exception)
            {
                MainClass.con.Close();
                MainClass.ShowMSG("Unable to login...", "Error", "Error");
            }
            return checkLogin;
        }

        public void showSuppliers(DataGridView gv, DataGridViewColumn supplierIDGV, DataGridViewColumn companyGV, DataGridViewColumn contactPersonGV, DataGridViewColumn phoneGV, DataGridViewColumn addressGV, DataGridViewColumn statusGV, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getSuppliersData", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getSuppliersDataLike", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                supplierIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                companyGV.DataPropertyName = dt.Columns["Company"].ToString();
                contactPersonGV.DataPropertyName = dt.Columns["Contact_Person"].ToString();
                phoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                addressGV.DataPropertyName = dt.Columns["Address"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.ShowMSG("Unable to load suppliers data.", "Error", "Error");
            }
        }
        private bool cheackPPExistance;
        private object[] productPriceDetails = new object[5];
        public object[] cheackProductPriceExistance(Int64 productID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_checkProductPriceExist", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@productID", productID);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        productPriceDetails[0] = dr[0].ToString();
                        productPriceDetails[1] = dr[1].ToString();
                        productPriceDetails[2] = dr[2].ToString();
                        productPriceDetails[3] = dr[3].ToString();
                        productPriceDetails[4] = dr[4].ToString();
                    }
                }
                else
                {
                    Array.Clear(productPriceDetails, 0, productPriceDetails.Length);
                }
                MainClass.con.Close();
            }
            catch(Exception)
            {

            }
            return productPriceDetails;
        }

        public void showStockDetails(DataGridView gv, DataGridViewColumn productIDGV, DataGridViewColumn productGV, DataGridViewColumn barcodeGV, DataGridViewColumn expiryDateGV, DataGridViewColumn buyingPriceGV, DataGridViewColumn sellingPriceGV, DataGridViewColumn categoryGV, DataGridViewColumn availableStockGV, DataGridViewColumn statusGV, DataGridViewColumn totalAmountGV, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getAllStock", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getStocksDataLike", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                productIDGV.DataPropertyName = dt.Columns["Product_ID"].ToString();
                productGV.DataPropertyName = dt.Columns["Product"].ToString();
                barcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                expiryDateGV.DataPropertyName = dt.Columns["Expiry_Date"].ToString();
                buyingPriceGV.DataPropertyName = dt.Columns["Buying_Price"].ToString();
                sellingPriceGV.DataPropertyName = dt.Columns["Selling_Price"].ToString();
                categoryGV.DataPropertyName = dt.Columns["Category"].ToString();
                availableStockGV.DataPropertyName = dt.Columns["Available_Stock"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                totalAmountGV.DataPropertyName = dt.Columns["Total_Amount"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.ShowMSG("Unable to load stock data.", "Error", "Error");
            }
        }
    }
}
