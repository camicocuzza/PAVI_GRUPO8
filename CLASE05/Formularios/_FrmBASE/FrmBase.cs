﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASE05.Formularios.FrmBASE
{
     public partial class FrmBase : Form
    {
        bool dragging;
        int posicionX, posicionY;

        public bool _FormularioMovil { get; set; }
        public bool Pp_minimizarVisible
        {
            set { btn_minimizar.Visible = value; }
        }
        public bool Pp_maximizarVisible
        {
            set { btn_maximizar.Visible = value; }
        }
        public FrmBase()
        {
            InitializeComponent();
            this._FormularioMovil = true;
        }
                
        private void btn_minimizar_MouseMove(object sender, MouseEventArgs e)
        {
            this.btn_minimizar.BackgroundImage = CLASE05.Properties.Resources.btn_minimizar;
            this.btn_minimizar.FlatAppearance.BorderSize = 4;
        }

        private void btn_minimizar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_minimizar.BackgroundImage = CLASE05.Properties.Resources.btn_minimizar;
            this.btn_minimizar.FlatAppearance.BorderSize = 1;
        }
        private void btn_maximizar_MouseMove(object sender, MouseEventArgs e)
        {
            this.btn_maximizar.BackgroundImage = CLASE05.Properties.Resources.btn_maximizar;
            this.btn_maximizar.FlatAppearance.BorderSize = 4;
        }
        private void btn_maximizar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_maximizar.BackgroundImage = CLASE05.Properties.Resources.btn_maximizar;
            this.btn_maximizar.FlatAppearance.BorderSize = 1;
        }
        private void btn_cerrar_MouseMove(object sender, MouseEventArgs e)
        {
            this.btn_cerrar.BackgroundImage = CLASE05.Properties.Resources.cerrar_r;
        }
        private void btn_cerrar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_cerrar.BackgroundImage = CLASE05.Properties.Resources.btn_cerrar;
        }
        private void FrmBase_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            posicionX = e.X;
            posicionY = e.Y;
        }
        private void FrmBase_MouseMove(object sender, MouseEventArgs e)
        {
            if (_FormularioMovil == false)
                return;
            if (dragging == true)
            {
                this.Location = new Point(this.Location.X + e.X - posicionX, this.Location.Y + e.Y - posicionY);
                this.Refresh();
            }
        }
        private void FrmBase_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.cerrar();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
            {
                Screen screen = Screen.FromControl(this);
                int x = screen.WorkingArea.X - screen.Bounds.X;
                int y = screen.WorkingArea.Y - screen.Bounds.Y;
                this.MaximizedBounds = new Rectangle(x, y,
                    screen.WorkingArea.Width, screen.WorkingArea.Height);
                this.MaximumSize = screen.WorkingArea.Size;
                this.WindowState = FormWindowState.Maximized;
            }
        }
       
        public void cerrar()
        {
            this.Close();
        }
    }
}
