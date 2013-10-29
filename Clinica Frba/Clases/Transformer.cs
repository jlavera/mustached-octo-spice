using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Clases {
    static class Transformer {

        /// <summary>
        /// Recibe tipo de dato, devuelve control
        /// </summary>
        /// <param name="tipo">Tipo de dato</param>
        /// <returns></returns>
        static public Control OptimusPrime(string tipo) {

            switch (tipo) {
                case "tinyint":
                    return new CheckBox();
                default:
                    return new TextBox();
            }

        }

        /// <summary>
        /// Recibe Control, devuelve valor
        /// </summary>
        /// <param name="ctrl">Control</param>
        /// <returns></returns>
        static public String Megatron(Control ctrl) {

            switch (ctrl.GetType().Name) {
                case "CheckBox":
                    return (Convert.ToInt32(((CheckBox) ctrl).Checked)).ToString();
                default:
                    return ctrl.Text;
            }

        }
    }
}