
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labSQLite
{
    public partial class Fm : Form
    {
        private SQLiteConnection db;
        private int currentTable;

        public Fm()
        {
            InitializeComponent();

            // https://www.sqlite.org/2020/sqlite-dll-win32-x86-3320200.zip

            /*
                TODO
                добавление, редактирование, удаление данных
                после редактирования обновление таблицы
                выборки,фильтры
             */


            db = new SQLiteConnection("myDB.db");
            db.CreateTable<Logs>();
            db.CreateTable<Users>();
            db.CreateTable<Notes>();

            db.Insert(new Logs() { DT = DateTime.Now });
            lvLogs.Columns.Add("DateTime", 220);
            lvLogs.View = View.Details;

            foreach (var item in db.Table<Logs>())
            {
                lvLogs.Items.Add(item.DT.ToString());
            }

            buUsersShow.Click += (s, e) => { dataGridView1.DataSource = db.Table<Users>().ToList(); currentTable = 0; };
            buNotesShow.Click += (s, e) => { dataGridView1.DataSource = db.Table<Notes>().ToList(); currentTable = 1; };

            buRunOne.Click += (s, e) => MessageBox.Show(db.ExecuteScalar<int>(edSQL.Text).ToString());

            buUsersAdd.Click += BuUsersAdd_Click;  
            buNotesAdd.Click += BuNotesAdd_Click;
            buDelete.Click += BuDelete_Click;
            buSearch.Click += BuSearch_Click;
        }

        private void BuSearch_Click(object sender, EventArgs e)
        {
            var searchf = new FmSearch();

            if(searchf.ShowDialog() == DialogResult.OK)
            {
                var table = searchf.dmTable.Text;
                var id = searchf.nuID.Value;
                var fioCaption = searchf.edFIOCaption.Text;
                var agePriority = searchf.edAgePriority.Value;
                var x = searchf.laAgePriority.Text;
                var y = searchf.laFIOCaption.Text;

                List<Users> query = new List<Users>();

                currentTable = (table == "Users") ?  0 : 1;

                if(currentTable == 1)
                {
                    
                }

                if (id != 0 && !string.IsNullOrEmpty(fioCaption) && agePriority != 0)
                {
                    db.Execute($"Select * from {table} where id = (?) and {x} = (?) and {y} = (?) ",
                        id, agePriority, fioCaption);
                }

                else if (id != 0 && string.IsNullOrEmpty(fioCaption) && agePriority == 0)
                {
                    db.Execute($"Select * from {table} where id = (?)",
                        id);
                }

                else if (id == 0 && !string.IsNullOrEmpty(fioCaption) && agePriority == 0)
                {
                    db.Execute($"Select * from {table} where {y} = (?)",
                        fioCaption);
                }

                else if (id == 0 && string.IsNullOrEmpty(fioCaption) && agePriority != 0)
                {
                    db.Execute($"Select * from {table} where {x} = (?)",
                        agePriority);
                }

                else if (id != 0 && !string.IsNullOrEmpty(fioCaption) && agePriority == 0)
                {
                    db.Execute($"Select * from {table} where id = (?) and {y} = (?)",
                        id, fioCaption);
                }

                else if (id != 0 && string.IsNullOrEmpty(fioCaption) && agePriority != 0)
                {
                    db.Execute($"Select * from {table} where id = (?) and {x} = (?)",
                        id, agePriority);
                }

                else if (id == 0 && !string.IsNullOrEmpty(fioCaption) && agePriority != 0)
                {

                        query = db.Query<Users>($"Select * from {table} where {y} = (?) and {x} = (?)",
                        fioCaption, agePriority);
                }

                if (currentTable == 0)
                {
                    dataGridView1.DataSource = db.Table<Users>().ToList();
                }
                else
                {
                    dataGridView1.DataSource = db.Table<Notes>().ToList();
                }
            }
        }

        private void BuDelete_Click(object sender, EventArgs e)
        {
            var delf = new FmDelete();

            if(delf.ShowDialog() == DialogResult.OK)
            {
                var table = delf.dmTable.Text;
                var id = delf.nuID.Value;
                var fioCaption = delf.edFIOCaption.Text;
                var agePriority = delf.edAgePriority.Value;
                var x = delf.laAgePriority.Text;
                var y = delf.laFIOCaption.Text;

                if (id != 0 && !string.IsNullOrEmpty(fioCaption) && agePriority != 0)
                {
                    db.Execute($"Delete from {table} where id = (?) and {x} = (?) and {y} = (?) ",
                        id, agePriority, fioCaption);
                }

                else if (id != 0 && string.IsNullOrEmpty(fioCaption) && agePriority == 0)
                {
                    db.Execute($"Delete from {table} where id = (?)",
                        id);
                }

                else if (id == 0 && !string.IsNullOrEmpty(fioCaption) && agePriority == 0)
                {
                    db.Execute($"Delete from {table} where {y} = (?)",
                        fioCaption);
                }

                else if (id == 0 && string.IsNullOrEmpty(fioCaption) && agePriority != 0)
                {
                    db.Execute($"Delete from {table} where {x} = (?)",
                        agePriority);
                }

                else if (id != 0 && !string.IsNullOrEmpty(fioCaption) && agePriority == 0)
                {
                    db.Execute($"Delete from {table} where id = (?) and {y} = (?)",
                        id,fioCaption);
                }

                else if (id != 0 && string.IsNullOrEmpty(fioCaption) && agePriority != 0)
                {
                    db.Execute($"Delete from {table} where id = (?) and {x} = (?)",
                        id, agePriority);
                }

                else if (id == 0 && !string.IsNullOrEmpty(fioCaption) && agePriority != 0)
                {
                    db.Execute($"Delete from {table} where {y} = (?) and {x} = (?)",
                        fioCaption, agePriority);
                }

                if (table == "Users")
                {
                    currentTable = 0;
                    dataGridView1.DataSource = db.Table<Users>().ToList();
                }
                else
                {
                    currentTable = 1;
                    dataGridView1.DataSource = db.Table<Notes>().ToList();
                }
            }
        }

        private void BuUsersAdd_Click(object sender, EventArgs e)
        {
            var addf = new FmUsersAdd();

            if (addf.ShowDialog() == DialogResult.OK)
            {
                var x = new Users();
                x.FIO = addf.edFIO.Text;
                x.Email = addf.edMail.Text;
                x.Age = (byte)addf.nuAge.Value;
                db.Insert(x);
            }
            dataGridView1.DataSource = db.Table<Users>().ToList();
            
        }

        private void BuNotesAdd_Click(object sender, EventArgs e)
        {
            // (1)
            var addf = new FmNotesAdd();

            if (addf.ShowDialog() == DialogResult.OK)
            {
                var x = new Notes();
                x.Caption = addf.edNotesCaption.Text;
                x.Priority = (byte)addf.edNotesPriority.Value;
                db.Insert(x);
            }
            dataGridView1.DataSource = db.Table<Notes>().ToList();
            // (2)
            //db.Insert(new Notes() { Caption = edNotesCaption.Text, Priority = (byte)edNotesPriority.Value })
        }
    }

    internal class Notes
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Caption { get; set; }
        public byte Priority { get; set; }
    }

    internal class Users
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public string FIO { get; set; }
        public string Email { get; set; }
        public byte Age { get; set; }
    }

    internal class Logs
    {
        public DateTime DT { get; set; }
    }
}
