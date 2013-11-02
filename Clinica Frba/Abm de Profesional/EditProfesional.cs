using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;

namespace Clinica_Frba.AbmProfesionales{
    public partial class EditProfesional: Form {

        /// <summary>
        /// Formulario para la creación de profesional nuevo
        /// </summary>
        public EditProfesional() {
            InitializeComponent();
        }

        /// <summary>
        /// Formulario para la edición de un profesional
        /// </summary>
        /// <param name="p_prof"></param>
        public EditProfesional(Profesional p_prof) {
            InitializeComponent();
        }
    }
}
