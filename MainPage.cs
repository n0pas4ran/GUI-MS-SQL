using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace client
{
   public partial class MainPage : Form
   {
      SqlDataAdapter adapter;
      string Log, Password;
      string connectionString;
      bool admin;
      string current_table;
      public MainPage()
      {
         InitializeComponent();

         dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
         dataGridView1.AllowUserToAddRows = false;
         treeView1.Nodes[0].Nodes[0].ContextMenuStrip = contextHolder;
         treeView1.Nodes[0].Nodes[1].ContextMenuStrip = contextRegister;
         treeView1.Nodes[0].Nodes[2].ContextMenuStrip = contextPlace;
         treeView1.Nodes[0].Nodes[3].ContextMenuStrip = contextKoordinati;
         treeView1.Nodes[0].Nodes[4].ContextMenuStrip = contextObject;
         treeView1.Nodes[0].Nodes[5].ContextMenuStrip = contextParametrs;

         treeView1.Visible = false;
         dataGridView1.Visible = false;
         refreshObjB.Visible = false;
         transObjB.Visible = false;
         holderObjB.Visible = false;
         reviewB.Visible = false;
         commercialB.Visible = false;
         holderPlaceB.Visible = false;
         infoB.Visible = false;

         ToolTip t = new ToolTip();
         t.SetToolTip(holderPlaceB, "Информация о владении собственниками земельными участками");
         //t = new ToolTip();
         t.SetToolTip(holderObjB, "Информация о владении собственниками объектами недвижимости");
         t.SetToolTip(reviewB, "Информация о владении собственниками объектами недвижимости на соответствующих земельных участках");
         t.SetToolTip(commercialB, "Информация о наличии комерческой недвижимости");
         t.SetToolTip(refreshObjB, "Обновление данных об эксплуатации всех объектов недвижимости");
         t.SetToolTip(transObjB, "Отформатируйте данные об объектах, добавив соответствующий префикс в название");

       

        }


      private void button1_Click(object sender, EventArgs e)
      {
         Authentification form = new Authentification(this);
         form.Show();
      }

      public void connection(string log, string pass)
      {
         connectionString = $"Server=localhost\\SQLEXPRESS;User ID={log};Password={pass};Trusted_Connection=False;DataBase=kadastr;Encrypt=false; TrustServerCertificate=true;";
         Log = log;
         Password = pass;
         using (SqlConnection conn = new SqlConnection(connectionString))
         {
               treeView1.Visible = true;
               dataGridView1.Visible = true;
               refreshObjB.Visible = true;
               transObjB.Visible = true;
               holderObjB.Visible = true;
               reviewB.Visible = true;
               commercialB.Visible = true;
               holderPlaceB.Visible = true;
               
               if(log == "DBadmin" && pass == "admin")
               {
                  admin = true;
               }
               else
               {
                  admin = false;
               }

               label1.Visible = false;
               button1.Visible = false;
               infoB.Visible = true;
         }
      }
      private void holderPlaceB_Click(object sender, EventArgs e)
      {
         if(admin)
         {
            string request = "holder_place";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                  connection.Open();
                  SqlCommand cmd = new SqlCommand(request, connection);
                  cmd.CommandType = CommandType.StoredProcedure;
                  cmd.ExecuteNonQuery();
                  SqlDataAdapter adapter = new SqlDataAdapter(request, connection);
                  DataSet ds1 = new DataSet();
                  adapter.Fill(ds1);
                  dataGridView1.DataSource = ds1.Tables[0];
                  

            }
         }
         else
         {
            MessageBox.Show("Доступ запрещен");
            return;
         }
      }

      private void holderObjB_Click(object sender, EventArgs e)
      {
         if(admin){
            string request = "holder_obj";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                  connection.Open();
                  SqlCommand cmd = new SqlCommand(request, connection);
                  cmd.CommandType = CommandType.StoredProcedure;
                  cmd.ExecuteNonQuery();
                  SqlDataAdapter adapter = new SqlDataAdapter(request, connection);
                  DataSet ds1 = new DataSet();
                  adapter.Fill(ds1);
                  dataGridView1.DataSource = ds1.Tables[0];

            }
         }
         else
         {
            MessageBox.Show("Доступ запрещен");
            return;
         }
      }

      private void reviewB_Click(object sender, EventArgs e)
      {
         if(admin){
            string request = "select * from review";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                  connection.Open();
                  SqlCommand cmd = new SqlCommand(request, connection);
                  cmd.ExecuteNonQuery();
                  SqlDataAdapter adapter = new SqlDataAdapter(request, connection);
                  DataSet ds1 = new DataSet();
                  adapter.Fill(ds1);
                  dataGridView1.DataSource = ds1.Tables[0];
            }
         }
         else
         {
            MessageBox.Show("Доступ запрещен");
            return;
         }
      }

      private void commercialB_Click(object sender, EventArgs e)
      {
         if(admin){
            string request = "commercial";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                  connection.Open();
                  SqlCommand cmd = new SqlCommand(request, connection);
                  cmd.CommandType = CommandType.StoredProcedure;
                  cmd.ExecuteNonQuery();
                  SqlDataAdapter adapter = new SqlDataAdapter(request, connection);
                  DataSet ds1 = new DataSet();
                  adapter.Fill(ds1);
                  dataGridView1.DataSource = ds1.Tables[0];
            }
         }
         else
         {
            MessageBox.Show("Доступ запрещен");
            return;
         }
      }

      private void refreshObjB_Click(object sender, EventArgs e)
      {
         if(admin){
            string request = "refreshObj";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                  connection.Open();
                  SqlCommand cmd = new SqlCommand(request, connection);
                  cmd.CommandType = CommandType.StoredProcedure;
                  cmd.ExecuteNonQuery();
            }
         }
         else
         {
            MessageBox.Show("Доступ запрещен");
            return;
         }
      }

      private void transObjB_Click(object sender, EventArgs e)
      {
         if(admin){
            string request = "TransacObject";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                  connection.Open();
                  SqlCommand cmd = new SqlCommand(request, connection);
                  cmd.CommandType = CommandType.StoredProcedure;
                  cmd.ExecuteNonQuery();
            }
         }
         else
         {
            MessageBox.Show("Доступ запрещен");
            return;
         }
      }
      private void addHolder_Click(object sender, EventArgs e)
      {
         if(admin){
            addHolderNotion form = new addHolderNotion(Log, Password);
            form.Show();
         }
         else
         {
            MessageBox.Show("Доступ запрещен");
            return;
         }
      }

      private void updateHolder_Click(object sender, EventArgs e)
      {
         if(admin){
            if(current_table == "holder"){
               string inn = dataGridView1.CurrentRow.Cells[0].Value.ToString();
               string sur = dataGridView1.CurrentRow.Cells[1].Value.ToString();
               string name = dataGridView1.CurrentRow.Cells[2].Value.ToString();
               string last = dataGridView1.CurrentRow.Cells[3].Value.ToString();
               string ogr = dataGridView1.CurrentRow.Cells[4].Value.ToString();
               string dop = dataGridView1.CurrentRow.Cells[5].Value.ToString();
               updateHolderNotion form = new updateHolderNotion(Log, Password, Convert.ToInt32(inn), sur, name, last, ogr, dop);
               form.Show();
            }
            else{
               MessageBox.Show("Выбрана неверная таблица");
               return;
            }
         }
         else
         {
            MessageBox.Show("Доступ запрещен");
            return;
         }
      }

      private void deleteHolder_Click(object sender, EventArgs e)
      {
         if(admin){
            if(current_table == "holder"){
               Holder form = new Holder(Log, Password);
               string inn = dataGridView1.CurrentRow.Cells[0].Value.ToString();
               form.db_CLick(Convert.ToInt32(inn));
            }
            else{
               MessageBox.Show("Выбрана неверная таблица");
               return;
            }
         }
         else
         {
            MessageBox.Show("Доступ запрещен");
            return;
         }
      }

      private void addRegister_Click(object sender, EventArgs e)
      {
         if(admin){
            addRegisterNotion form = new addRegisterNotion(Log, Password);
            form.Show();
         }
         else
         {
            MessageBox.Show("Доступ запрещен");
            return;
         }

      }

      private void updateRegister_Click(object sender, EventArgs e)
      {
         if(admin){
            if(current_table == "register"){
               string date = dataGridView1.CurrentRow.Cells[0].Value.ToString();
               string tip = dataGridView1.CurrentRow.Cells[1].Value.ToString();
               string inn = dataGridView1.CurrentRow.Cells[2].Value.ToString();
               updateRegisterNotion form = new updateRegisterNotion(Log, Password, date, tip, inn);
               form.Show();
            }
            else{
               MessageBox.Show("Выбрана неверная таблица");
               return;
            }
         }
         else
         {
            MessageBox.Show("Доступ запрещен");
            return;
         }
      }

      private void deleteRegister_Click(object sender, EventArgs e)
      {
         if(admin){
            if(current_table == "register"){
               Register form = new Register(Log, Password);
               string inn = dataGridView1.CurrentRow.Cells[2].Value.ToString();
               form.db_CLick(inn);
            }
            else{
               MessageBox.Show("Выбрана неверная таблица");
               return;
            }
         }
         else
         {
            MessageBox.Show("Доступ запрещен");
            return;
         }
      }

      private void addPlace_Click(object sender, EventArgs e)
      {
         if(admin){
            addPlaceNotion form = new addPlaceNotion(Log, Password);
            form.Show();
         }else
         {
            MessageBox.Show("Доступ запрещен");
            return;
         }
      }

      private void updatePlace_Click(object sender, EventArgs e)
      {
         if(admin){
            if(current_table == "place"){
               string knp = dataGridView1.CurrentRow.Cells[0].Value.ToString();
               string square = dataGridView1.CurrentRow.Cells[1].Value.ToString();
               string inn = dataGridView1.CurrentRow.Cells[2].Value.ToString();
               updatePlaceNotion form = new updatePlaceNotion(Log, Password, knp, square, inn);
               form.Show();
            }
            else{
               MessageBox.Show("Выбрана неверная таблица");
               return;
            }
         }
         else
         {
            MessageBox.Show("Доступ запрещен");
            return;
         }
      }

      private void deletePlace_Click(object sender, EventArgs e)
      {
         if(admin){
            if(current_table == "place"){
               Place form = new Place(Log, Password);
               string knp = dataGridView1.CurrentRow.Cells[0].Value.ToString();
               form.db_CLick(knp);
            }
            else{
               MessageBox.Show("Выбрана неверная таблица");
               return;
            }
         }
         else
         {
            MessageBox.Show("Доступ запрещен");
            return;
         }
      }

      private void addKoordinati_Click(object sender, EventArgs e)
      {
         if(admin){
            addKoordinatiNotion form = new addKoordinatiNotion(Log, Password);
            form.Show();
         }
         else
         {
            MessageBox.Show("Доступ запрещен");
            return;
         }
      }

      private void updateKoordinati_Click(object sender, EventArgs e)
      {
         if(admin){
            if(current_table == "koordinati"){
               string sistem = dataGridView1.CurrentRow.Cells[0].Value.ToString();
               string x1 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
               string y1 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
               string x2 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
               string y2 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
               string x3 = dataGridView1.CurrentRow.Cells[5].Value.ToString();
               string y3 = dataGridView1.CurrentRow.Cells[6].Value.ToString();
               string x4 = dataGridView1.CurrentRow.Cells[7].Value.ToString();
               string y4 = dataGridView1.CurrentRow.Cells[8].Value.ToString();
               string knp = dataGridView1.CurrentRow.Cells[9].Value.ToString();
               updateKoordinatiNotion form = new updateKoordinatiNotion(Log, Password, sistem, x1, y1, x2, y2, x3, y3, x4, y4, knp);
               form.Show();
            }
            else{
               MessageBox.Show("Выбрана неверная таблица");
               return;
            }
         }
         else
         {
            MessageBox.Show("Доступ запрещен");
            return;
         }
      }

      private void deleteKoordinati_Click(object sender, EventArgs e)
      {
         if(admin){
            if(current_table == "koordinati"){
               Koordinati form = new Koordinati(Log, Password);
               string knp = dataGridView1.CurrentRow.Cells[9].Value.ToString();
               form.db_CLick(knp);
            }
            else{
               MessageBox.Show("Выбрана неверная таблица");
               return;
            }
         }
         else
         {
            MessageBox.Show("Доступ запрещен");
            return;
         }
      }

      private void addObject_Click(object sender, EventArgs e)
      {
         if(admin){
            addObjectNotion form = new addObjectNotion(Log, Password);
            form.Show();
         }
         else
         {
            MessageBox.Show("Доступ запрещен");
            return;
         }

      }

      private void updateObject_Click(object sender, EventArgs e)
      {
         if(admin){
            if(current_table == "object"){
               string kno = dataGridView1.CurrentRow.Cells[0].Value.ToString();
               string vid = dataGridView1.CurrentRow.Cells[1].Value.ToString();
               string nazn = dataGridView1.CurrentRow.Cells[2].Value.ToString();
               string name = dataGridView1.CurrentRow.Cells[3].Value.ToString();
               string byear = dataGridView1.CurrentRow.Cells[4].Value.ToString();
               string uyear = dataGridView1.CurrentRow.Cells[5].Value.ToString();
               string adres = dataGridView1.CurrentRow.Cells[6].Value.ToString();
               string knp = dataGridView1.CurrentRow.Cells[7].Value.ToString();
               updateObjectNotion form = new updateObjectNotion(Log, Password, kno, vid, nazn, name, byear, uyear, adres, knp);
               form.Show();
            }
            else{
               MessageBox.Show("Выбрана неверная таблица");
               return;
            }
         }
         else
         {
            MessageBox.Show("Доступ запрещен");
            return;
         }
      }

      private void deleteObject_Click(object sender, EventArgs e)
      {
         if(admin){
            if(current_table == "object"){
               Object form = new Object(Log, Password);
               string kno = dataGridView1.CurrentRow.Cells[0].Value.ToString();
               form.db_CLick(kno);
            }
            else{
               MessageBox.Show("Выбрана неверная таблица");
               return;
            }
         }
         else
         {
            MessageBox.Show("Доступ запрещен");
            return;
         }
      }

      private void addParametrs_Click(object sender, EventArgs e)
      {
         if(admin){
            addParametrsNotion form = new addParametrsNotion(Log, Password);
            form.Show();
         }
         else
         {
            MessageBox.Show("Доступ запрещен");
            return;
         }
      }

      private void updateParametrs_Click(object sender, EventArgs e)
      {
         if(admin){
            if(current_table == "parametrs"){
               string square = dataGridView1.CurrentRow.Cells[0].Value.ToString();
               string material = dataGridView1.CurrentRow.Cells[1].Value.ToString();
               string floors = dataGridView1.CurrentRow.Cells[2].Value.ToString();
               string price = dataGridView1.CurrentRow.Cells[3].Value.ToString();
               string kno = dataGridView1.CurrentRow.Cells[4].Value.ToString();
               updateParametrsNotion form = new updateParametrsNotion(Log, Password, square, material, floors, price, kno);
               form.Show();
            }
            else{
               MessageBox.Show("Выбрана неверная таблица");
               return;
            }
         }
         else
         {
            MessageBox.Show("Доступ запрещен");
            return;
         }
      }

      private void deleteParametrs_Click(object sender, EventArgs e)
      {
         if(admin){
            if(current_table == "parametrs"){
               Parametrs form = new Parametrs(Log, Password);
               string kno = dataGridView1.CurrentRow.Cells[4].Value.ToString();
               form.db_CLick(kno);
            }
            else{
               MessageBox.Show("Выбрана неверная таблица");
               return;
            }
         }
         else
         {
            MessageBox.Show("Доступ запрещен");
            return;
         }
      }

      private void showHolder_Click(object sender, EventArgs e)
      {

         string sql = "SELECT Inn as 'ИНН',Familia as 'Фамилия', Imya as 'Имя', Otchestvo as 'Отчество', Ogranicheniya as 'Ограничения', Dopolneniya as 'Дополнения'  FROM Holder";
         using (SqlConnection connection = new SqlConnection(connectionString))
         {
               connection.Open();
               adapter = new SqlDataAdapter(sql, connection);

               DataSet ds1 = new DataSet();
               adapter.Fill(ds1);
               dataGridView1.DataSource = ds1.Tables[0];
         }
         current_table = "holder";
      }

      private void showRegister_Click(object sender, EventArgs e)
      {
         string sql = "select Tip as 'Тип регистрации', Date as 'Дата', Inn_h as 'ИНН правообладателя' from Register";
         using (SqlConnection connection = new SqlConnection(connectionString))
         {
               connection.Open();
               adapter = new SqlDataAdapter(sql, connection);

               DataSet ds1 = new DataSet();
               adapter.Fill(ds1);
               dataGridView1.DataSource = ds1.Tables[0];
               // делаем недоступным столбец id для изменения
         }
         current_table = "register";
      }

      private void toolStripMenuItem1_Click(object sender, EventArgs e)
      {
         string sql = "select Kadastr_nomer as 'КНУ', Plowad as 'Площадь участка', Inn_h as 'ИНН правообладателя', Newest_Object as 'Новейший объект' from Place";
         using (SqlConnection connection = new SqlConnection(connectionString))
         {
               connection.Open();
               adapter = new SqlDataAdapter(sql, connection);

               DataSet ds1 = new DataSet();
               adapter.Fill(ds1);
               dataGridView1.DataSource = ds1.Tables[0];
               // делаем недоступным столбец id для изменения
         }
         current_table = "place";
      }

      private void contextKoordinati_Click(object sender, EventArgs e)
      {
         string sql = "select Sistema_koordinat as 'Система координат', x1, y1, x2, y2, x3, y3, x4, y4, KNP as 'КНУ' from Koordinati";
         using (SqlConnection connection = new SqlConnection(connectionString))
         {
               connection.Open();
               adapter = new SqlDataAdapter(sql, connection);

               DataSet ds1 = new DataSet();
               adapter.Fill(ds1);
               dataGridView1.DataSource = ds1.Tables[0];
         }
         current_table = "koordinati";
      }

      private void toolStripMenuItem9_Click(object sender, EventArgs e)
      {
         string sql = "select * from Object";
         using (SqlConnection connection = new SqlConnection(connectionString))
         {
               connection.Open();
               adapter = new SqlDataAdapter(sql, connection);

               DataSet ds1 = new DataSet();
               adapter.Fill(ds1);
               dataGridView1.DataSource = ds1.Tables[0];
               // делаем недоступным столбец id для изменения
         }
         current_table = "object";
      }

      private void toolStripMenuItem13_Click(object sender, EventArgs e)
      {
         string sql = "select * from Parametrs";
         using (SqlConnection connection = new SqlConnection(connectionString))
         {
               connection.Open();
               adapter = new SqlDataAdapter(sql, connection);

               DataSet ds1 = new DataSet();
               adapter.Fill(ds1);
               dataGridView1.DataSource = ds1.Tables[0];
               // делаем недоступным столбец id для изменения
         }
         current_table = "parametrs";
      }

      private void infoB_Click(object sender, EventArgs e)
      {
         MessageBox.Show("-Для управления данными базы данных выберите соответствующее поле " +
             "в верхнем левом углу->ПКМ->действие\n-Для использования различных запросов в БД используйте кнопки в нижней части экрана\n" +
             "(Более подробную информацию о соответствующем запросе можно получить, наведя курсор мыши на кнопку)", "Руководство по эксплуатации", MessageBoxButtons.OK, MessageBoxIcon.Information);
         
      }

      private void roundButton1_Click(object sender, EventArgs e)
      {

      }

      
   }
}
