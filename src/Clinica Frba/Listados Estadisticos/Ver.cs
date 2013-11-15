using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;

namespace Clinica_Frba.Listados_Estadisticos {
    public partial class Ver : Form {

        private string tipo;
        private DataTable res;
        private int agno;
        private int[] meses = new int[6];
        private int mesInicial;


        //schema done
        //2013 done
        //getdate done
        //meses 



        public Ver(int _mesIni,int _agno, string _tipo) {
            InitializeComponent();

            mesInicial = _mesIni;

            for (int i = 0; i < meses.Length; meses[i++] = _mesIni++) ; // Reinosa #1

            tipo = _tipo;
            agno = _agno;
        }
        
        private void Ver_Load(object sender, EventArgs e) {
            string query;
            //--Ejecutar query según el listado que pidió
            switch (tipo) {
                case "b1":
                    dataGridView.Columns.Add("mes", "Mes");
                    dataGridView.Columns.Add("especialidad", "Especialidad");
                    dataGridView.Columns.Add("cantidad", "Cantidad de cancelaciones");
                    /*
                     * Top 5 de las especialidades que más se registraron cancelaciones, tanto de pacientes como de profesionales
                     * Dentro del FORM elije cuales son las especialidades que quire evaluar, en el intervalo pedido.
                     * Una vez que sabe que especailidades son, hace el producto cartesiano con una tabla de 6 meses par aque por cada especialidad en el TOP5
                     * Por cada uno de los meses, en un subquery busca cuantas cencelaciones hubieron en ese mes en particular
                    */
                    query = "SELECT DATENAME(month,  DateAdd( month , T.Mes , 0 ) - 1) 'Mes', X.esp_descripcion 'Especialidad', (SELECT COUNT(1) FROM " + DB.schema + "turnoAudit JOIN " + DB.schema + "turno ON tur_id = tuA_turno WHERE tur_especialidad=x.esp_id AND DATEPART(MONTH, tur_fechaYHoraTurno) = t.Mes AND DATEPART(YEAR, tur_fechaYHoraTurno)=" + agno + ") 'Cantidad de Cancelaciones' FROM (SELECT TOP 5 esp_descripcion, esp_id FROM " + DB.schema + "turnoAudit JOIN " + DB.schema + "turno ON tur_id = tuA_turno JOIN " + DB.schema + "especialidad ON tur_especialidad = esp_id WHERE DATEPART(MONTH, tur_fechaYHoraTurno)>="+mesInicial+" AND DATEPART(MONTH, tur_fechaYHoraTurno)<="+(mesInicial + 5) +" AND DATEPART(YEAR, tur_fechaYHoraTurno)=" + agno + " GROUP BY esp_descripcion, esp_id ORDER BY COUNT(esp_descripcion) DESC) X, (SELECT " + meses[0] + " 'Mes' UNION SELECT " + meses[1] + " UNION SELECT " + meses[2] + " UNION SELECT " + meses[3] + " UNION SELECT " + meses[4] + " UNION SELECT " + meses[5] + ") T";
                    
                    res = DB.ExecuteReader(query);
                    break;

                case "b2":
                    dataGridView.Columns.Add("mes", "Mes");
                    dataGridView.Columns.Add("afiliado", "Afiliado");
                    dataGridView.Columns.Add("cantidad", "Cantidad de bonos vencidos");
                    /*
                     * Top 5 de la cantidad total de bonos farmacia vencidos por afiliado
                     * Devuelta, dentro del FORM esta la seleccion del TOP 5 de los bonos que no estan consumidos, pero estan vencidos al dia de la fecha, y que pertenezcan al semestre del año elejido
                     * Despues de le hace un producto cartesiano con los meses
                     * y con un subselect se calcula la cantidad de bonos vencidos por mes
                    */
                    query = "SELECT DATENAME(month,  DateAdd( month , T.Mes , 0 ) - 1) 'Mes', X.Afiliado 'Afiliado', (SELECT COUNT(1) FROM " + DB.schema + "bonoFarmacia WHERE bfa_habilitado=1 AND bfa_fechaVencimiento<'" + FuncionesBoludas.GetDateTime() + "' AND bfa_comprador=X.afi_id AND DATEPART(MONTH, bfa_fechaImpresion)=T.Mes AND DATEPART(YEAR, bfa_fechaImpresion)=" + agno + ") 'Cantidad bonos vencidos' FROM (SELECT TOP 5 afi_id, usu_apellido + ', ' + usu_nombre 'Afiliado' FROM " + DB.schema + "bonoFarmacia JOIN " + DB.schema + "vAfiliado ON bfa_comprador=afi_id WHERE bfa_habilitado=1 AND bfa_fechaVencimiento<'" + FuncionesBoludas.GetDateTime() + "' AND bfa_comprador=afi_id  AND DATEPART(MONTH, bfa_fechaImpresion)>="+mesInicial+" AND DATEPART(MONTH, bfa_fechaImpresion)<="+(mesInicial + 5) +" AND DATEPART(YEAR, bfa_fechaImpresion)=" + agno + " GROUP BY afi_id, usu_apellido + ', ' + usu_nombre ORDER BY  COUNT(1) DESC) X , (SELECT " + meses[0] + " 'Mes' UNION SELECT " + meses[1] + " UNION SELECT " + meses[2] + " UNION SELECT " + meses[3] + " UNION SELECT " + meses[4] + " UNION SELECT " + meses[5] + ") T";

                    res = DB.ExecuteReader(query);
                    break;

                case "b3":
                    dataGridView.Columns.Add("mes", "Mes");
                    dataGridView.Columns.Add("especialidad", "Especialidad");
                    dataGridView.Columns.Add("cantidad", "Cantidad de bonos farmacia recetados");
                    /*
                     * Top 5 de las especialidades de médicos con más bonos de farmacia recetados. 
                     * Misma estrategia, dentro del FORM esta el query para elejir el TOP 5, y despues por producto cartesiano se desglosa cada uno, mostrando la cantidad con un subselect
                    */
                    query = "SELECT DATENAME(month,  DateAdd( month , T.Mes , 0 ) - 1) 'Mes', X.esp_descripcion 'Especialidad', (SELECT COUNT(1) FROM " + DB.schema + "turno WHERE tur_especialidad=X.esp_id AND DATEPART(MONTH, tur_fechaYHoraTurno)=T.Mes AND DATEPART(YEAR, tur_fechaYHoraTurno)=" + agno + ") 'Cantidad de bonos farmacia recetados' FROM (SELECT TOP 5 esp_id, esp_descripcion FROM " + DB.schema + "turno JOIN " + DB.schema + "especialidad ON esp_id=tur_especialidad WHERE tur_bonoConsulta IS NOT NULL AND DATEPART(MONTH, tur_fechaYHoraTurno)>=" + mesInicial + " AND DATEPART(MONTH, tur_fechaYHoraTurno)<="+(mesInicial + 5) +" AND DATEPART(YEAR, tur_fechaYHoraTurno)=" + agno + " GROUP BY esp_descripcion, esp_id ORDER BY COUNT(1) DESC) X, (SELECT " + meses[0] + " 'Mes' UNION SELECT " + meses[1] + " UNION SELECT " + meses[2] + " UNION SELECT " + meses[3] + " UNION SELECT " + meses[4] + " UNION SELECT " + meses[5] + ") T";

                    res = DB.ExecuteReader(query);
                    break;

                case "b4":
                    dataGridView.Columns.Add("mes", "Mes");
                    dataGridView.Columns.Add("afiliado", "Afiliado");
                    dataGridView.Columns.Add("cantidad", "Cantidad de bonos no cobrados por el mismo");
                    /*
                     * Top 10 de los afiliados que utilizaron bonos que ellos mismo no compraron.
                     * Me repito
                    */
                    query = "SELECT DATENAME(month,  DateAdd( month , T.Mes , 0 ) - 1) 'Mes', X.Afiliado 'Afiliado', (SELECT COUNT(bfa_id)+COUNT(bco_id) FROM " + DB.schema + "afiliado LEFT JOIN " + DB.schema + "bonoConsulta ON bco_comprador=afi_id AND bco_afiliado!=afi_id AND DATEPART(MONTH, bco_fechaCompa)=T.Mes AND DATEPART(YEAR, bco_fechaCompa)=" + agno + " LEFT JOIN " + DB.schema + "bonoFarmacia ON bfa_comprador=afi_id AND bfa_afiliado!=afi_id AND DATEPART(MONTH, bfa_fechaImpresion)=T.mes AND DATEPART(YEAR, bfa_fechaImpresion)=" + agno + " WHERE afi_id=X.afi_id) 'Cantidad de bonos no cobrados por el' FROM (SELECT TOP 10 afi_id, usu_apellido + ', ' + usu_nombre 'Afiliado' FROM " + DB.schema + "vAfiliado LEFT JOIN " + DB.schema + "bonoConsulta ON bco_comprador=afi_id AND bco_afiliado!=afi_id AND DATEPART(MONTH, bco_fechaCompa)>="+mesInicial+" AND DATEPART(MONTH, bco_fechaCompa)<="+(mesInicial + 5) +" AND DATEPART(YEAR, bco_fechaCompa)=" + agno + " LEFT JOIN " + DB.schema + "bonoFarmacia ON bfa_comprador=afi_id AND bfa_afiliado!=afi_id AND DATEPART(MONTH, bfa_fechaImpresion)>="+mesInicial+" AND DATEPART(MONTH, bfa_fechaImpresion)<="+(mesInicial + 5) +" AND DATEPART(YEAR, bfa_fechaImpresion)=" + agno + " GROUP BY afi_id, usu_apellido + ', ' + usu_nombre ORDER BY COUNT(bfa_id)+COUNT(bco_id) DESC) X, (SELECT " + meses[0] + " 'Mes' UNION SELECT " + meses[1] + " UNION SELECT " + meses[2] + " UNION SELECT " + meses[3] + " UNION SELECT " + meses[4] + " UNION SELECT " + meses[5] + ") T";

                    res = DB.ExecuteReader(query);
                    break;
            }

            foreach (DataRow dr in res.Rows)
                dataGridView.Rows.Add(dr[0], dr[1], dr[2]);
        }
    }
}
