using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Security.Authentication.ExtendedProtection;

namespace Proyecto_Final_Programacion_2
{
    internal class ClassBottonFormPrincipal : Button
    {
        //propiedades
        private int borderSize = 0; //Tamaño de borde
        private int borderRadius = 40; //Tamanio de radio
        private Color borderColor = Color.PaleVioletRed; //color del borde

        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        public int BorderRadius
        {
            get
            {
                return borderRadius;
            }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public Color BackGroundColor
        {
            get
            {
                return this.BackColor;
            }
            set
            {
                this.BackColor = value;
            }
        }

        public Color TextColor
        {
            get
            {
                return this.ForeColor;
            }
            set
            {
                this.ForeColor = value;
            }
        }
        //constructor
        public ClassBottonFormPrincipal()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
        }
        //Metodos
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {


            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }
        //anulamos evento pintura del boton para ampliar la funcionalidad
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);  
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width-0.8F, this.Height - 1);
        
            if (borderRadius > 2)  //boton redondeado
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath (rectBorder, borderRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using  (Pen penBorder = new Pen (borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    //superficie del boton
                    this.Region = new Region(pathSurface);
                    //borde de la superficia en hd
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    //borde del boton 
                    if (borderSize >= 1)
                        //dibujo de borde del control
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else  //boton normal
            {
                this.Region = new Region(rectSurface);
                //borde del boton
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height-1);

                    }
                }
            }
        }
        //anulamos el evento identificador creado
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }
    }
}
