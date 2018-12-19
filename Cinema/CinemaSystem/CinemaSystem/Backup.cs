using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CinemaSystem.EF_Class;
using System.Windows.Forms;

namespace CinemaSystem
{
    class Backup
    {
        CinemaEntities context;
        string now;
        const string path = "..\\..\\..\\..\\DataBaseBackup\\";

        public Backup(CinemaEntities context)
        {
            this.context = context;
            
        }

        public void runBackup()
        {
            //variable hold path and dynamic folder name for backing up
            string backPathNFolderByTime = Create_backupFolder(path);
            
            Backup_Customer(backPathNFolderByTime);

            Backup_Hall(backPathNFolderByTime);

            Backup_Movie(backPathNFolderByTime);

            Backup_Order(backPathNFolderByTime);

            Backup_OrdersSnacks(backPathNFolderByTime);

            Backup_Schedule(backPathNFolderByTime);

            Backup_SeatsOrders(backPathNFolderByTime);

            MessageBox.Show("Backup success !");
        }

        private string Create_backupFolder(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            now = DateTime.Now.ToString("dddd,dd MMMM yyyy HH_mm_ss");
            Directory.CreateDirectory(path + "\\" + now);
            string output = path + "\\" + now + "\\";
            return output;
        }

        //back up customer context
        private void Backup_Customer(string path)
        {
            var query = context.Customers.ToList();
            FileInfo file = new FileInfo(path + "customers" + ".xml");
            StreamWriter sw = file.CreateText();
            var writer = new System.Xml.Serialization.XmlSerializer(typeof(List<Customer>));
            writer.Serialize(sw, query);
            sw.Close();
        }


        //back up hall context
        private void Backup_Hall(string path)
        {
            var query = context.Halls.ToList();
            FileInfo file = new FileInfo(path + "halls" + ".xml");
            //StreamWriter sw = file.AppendText();
            StreamWriter sw = file.CreateText();
            var writer = new System.Xml.Serialization.XmlSerializer(typeof(List<Hall>));
            writer.Serialize(sw, query);
            sw.Close();
        }

        //back up movie context
        private void Backup_Movie(string path)
        {
            var query = context.Movies.ToList();
            FileInfo file = new FileInfo(path + "movies" + ".xml");
            StreamWriter sw = file.CreateText();
            var writer = new System.Xml.Serialization.XmlSerializer(typeof(List<Movie>));
            writer.Serialize(sw, query);
            sw.Close();
        }

        //back up order context
        private void Backup_Order(string path)
        {
            var query = context.Orders.ToList();
            FileInfo file = new FileInfo(path + "orders" + ".xml");
            StreamWriter sw = file.CreateText();
            var writer = new System.Xml.Serialization.XmlSerializer(typeof(List<Order>));
            writer.Serialize(sw, query);
            sw.Close();
        }

        //back up orderSnacks context
        private void Backup_OrdersSnacks(string path)
        {
            var query = context.OrdersSnacks.ToList();
            FileInfo file = new FileInfo(path + "ordersSnacks" + ".xml");
            StreamWriter sw = file.CreateText();
            var writer = new System.Xml.Serialization.XmlSerializer(typeof(List<OrdersSnack>));
            writer.Serialize(sw, query);
            sw.Close();
        }

        //back up schedule context
        private void Backup_Schedule(string path)
        {
            var query = context.Schedules.ToList();
            FileInfo file = new FileInfo(path + "schedules" + ".xml");
            StreamWriter sw = file.CreateText();
            var writer = new System.Xml.Serialization.XmlSerializer(typeof(List<Schedule>));
            writer.Serialize(sw, query);
            sw.Close();
        }


        //back up seatOrder context
        private void Backup_SeatsOrders(string path)
        {
            var query = context.SeatsOrders.ToList();
            FileInfo file = new FileInfo(path + "seatsOrders" + ".xml");
            StreamWriter sw = file.CreateText();
            var writer = new System.Xml.Serialization.XmlSerializer(typeof(List<SeatsOrder>));
            writer.Serialize(sw, query);
            sw.Close();
        }
    }
}
