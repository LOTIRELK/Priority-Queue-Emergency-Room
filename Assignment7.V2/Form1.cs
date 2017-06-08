using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7.V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmboPriority.SelectedIndex = 0;
        }
        string name = "";
        int priority=0;
        DateTime now = DateTime.Now;
        PriorityQueue<Employee> pq = new PriorityQueue<Employee>();
        private void Form1_Load(object sender, EventArgs e)
        {
           

            Employee e1 = new Employee("Aiden", 1, now.ToString("HH:mm:ss"));
            Employee e2 = new Employee("Ryan", 2, now.ToString("HH:mm:ss"));
            Employee e3 = new Employee("Mary", 5, now.ToString("HH:mm:ss"));
            Employee e4 = new Employee("Roger", 4, now.ToString("HH:mm:ss"));
            Employee e5 = new Employee("Mike", 3, now.ToString("HH:mm:ss"));
            
            // And so on for e3, e4, e5, e6
          
            pq.Enqueue(e1);
            
            pq.Enqueue(e2);
         
            pq.Enqueue(e3);
           
            pq.Enqueue(e4);
           
            pq.Enqueue(e5);
           
            

            if (pq.Count() > 0)
            {
               
                string[] splited = pq.ToString().Split(' ');
                foreach(string word in splited)
                {
                    lbPatients.Items.Add(word);
                }

            }
            lbPatients.Items.RemoveAt(lbPatients.Items.Count - 1);
        }

        private void txtPatientsName_TextChanged(object sender, EventArgs e)
        {
             name = Convert.ToString(txtPatientsName.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now; 
            Employee i  = new Employee(name,priority, time.ToString("HH:mm:ss"));
            pq.Enqueue(i);
            lbPatients.Items.Clear();
            if (pq.Count() > 0)
            {

                string[] splited = pq.ToString().Split(' ');
                foreach (string word in splited)
                {
                    lbPatients.Items.Add(word);
                }
            }

        }

        private void cmboPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            priority = cmboPriority.SelectedIndex;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
           Employee i = pq.Dequeue();
            MessageBox.Show("Please call "+i.lastName,
                               "Patient Called", MessageBoxButtons.OK,
                               MessageBoxIcon.Exclamation,
                               MessageBoxDefaultButton.Button1);
            lbPatients.Items.Clear();
            if (pq.Count() > 0)
            {

                string[] splited = pq.ToString().Split(' ');
                foreach (string word in splited)
                {
                    
                    lbPatients.Items.Add(word);
                    
                }
            }
            else
                MessageBox.Show("There are no patients in the queue.",
                                "Warning", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
        }
    }
}
