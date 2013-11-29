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
                    query = "SELECT DATENAME(month,  DateAdd( month , T.Mes , 0 ) - 1) 'Mes', "+
                                "X.esp_descripcion 'Especialidad', " +
                                "(SELECT COUNT(1) FROM " + DB.schema + "cancelacion JOIN " + DB.schema + "turno ON tur_id = tuA_turno WHERE tur_especialidad=x.esp_id AND DATEPART(MONTH, tur_fechaYHoraTurno) = t.Mes AND DATEPART(YEAR, tur_fechaYHoraTurno)=" + agno + ") 'Cantidad de Cancelaciones' " +
                            "FROM " + DB.schema + "estEspecialidades(" + agno + ", " + meses[0] + ") X, " +
                            "(SELECT " + meses[0] + " 'Mes' UNION SELECT " + meses[1] + " UNION SELECT " + meses[2] + " UNION SELECT " + meses[3] + " UNION SELECT " + meses[4] + " UNION SELECT " + meses[5] + ") T";
                    
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
                    query = "SELECT DATENAME(month,  DateAdd( month , T.Mes , 0 ) - 1) 'Mes', " +
                                "X.Afiliado 'Afiliado', "+
                                "(SELECT COUNT(1) FROM " + DB.schema + "bonoFarmacia JOIN " + DB.schema + "compra ON cmp_id=bfa_compra WHERE bfa_habilitado=1 AND bfa_fechaVencimiento<'" + FuncionesBoludas.GetDateTime() + "' AND cmp_afiliado=X.afi_id AND DATEPART(MONTH, bfa_fechaImpresion)=T.Mes AND DATEPART(YEAR, bfa_fechaImpresion)=" + agno + ") 'Cantidad bonos vencidos' " +
                                "FROM " + DB.schema + "estVencidos(" + agno + ", " + meses[0] + ", '" + FuncionesBoludas.GetDateTime() + "') X , " +
                                "(SELECT " + meses[0] + " 'Mes' UNION SELECT " + meses[1] + " UNION SELECT " + meses[2] + " UNION SELECT " + meses[3] + " UNION SELECT " + meses[4] + " UNION SELECT " + meses[5] + ") T";

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
                    query = "SELECT DATENAME(month,  DateAdd( month , T.Mes , 0 ) - 1) 'Mes', " +
                                "X.esp_descripcion 'Especialidad', " +
                                "(SELECT COUNT(1) FROM " + DB.schema + "turno WHERE tur_especialidad=X.esp_id AND DATEPART(MONTH, tur_fechaYHoraTurno)=T.Mes AND DATEPART(YEAR, tur_fechaYHoraTurno)=" + agno + ") 'Cantidad de bonos farmacia recetados' "+
                                "FROM " + DB.schema + "estRecetados(" + agno + ", " + meses[0] + ")  X, " +
                                "(SELECT " + meses[0] + " 'Mes' UNION SELECT " + meses[1] + " UNION SELECT " + meses[2] + " UNION SELECT " + meses[3] + " UNION SELECT " + meses[4] + " UNION SELECT " + meses[5] + ") T";

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
                    query = "SELECT DATENAME(month,  DateAdd( month , T.Mes , 0 ) - 1) 'Mes', " +
                                    "X.Afiliado 'Afiliado', " +
		                                "(SELECT COUNT(bfa_id)+COUNT(bco_id) " +
                                        "FROM " + DB.schema + "afiliado " +
                                            "JOIN " + DB.schema + "bonoConsulta ON bco_afiliado=afi_id AND " +
                                                                                 "bco_afiliado!=(SELECT cmp_afiliado FROM " + DB.schema + "compra WHERE cmp_id=bco_compra) AND " +
											                                     "DATEPART(MONTH, bco_fechaCompa)=T.Mes AND " +
                                                                                 "DATEPART(YEAR, bco_fechaCompa)=" + agno + " " +
                                            "LEFT JOIN " + DB.schema + "bonoFarmacia ON bfa_afiliado=afi_id AND " +
                                                                                      "bfa_afiliado!=(SELECT cmp_afiliado FROM " + DB.schema + "compra WHERE cmp_id=bfa_compra) AND " +
													                                  "DATEPART(MONTH, bfa_fechaImpresion)=T.mes AND " +
                                                                                      "DATEPART(YEAR, bfa_fechaImpresion)=" + agno + " " +
			                                "WHERE afi_id=X.afi_id) 'Cantidad de bonos no cobrados por el' " +
                                    "FROM " + DB.schema + "estNoEsTuyo(" + agno + ", " + meses[0] + ") X, " +
                                    "(SELECT " + meses[0] + " 'Mes' UNION SELECT " + meses[1] + " UNION SELECT " + meses[2] + " UNION SELECT " + meses[3] + " UNION SELECT " + meses[4] + " UNION SELECT " + meses[5] + ") T";
                    res = DB.ExecuteReader(query);
                    break;
                default:
                    return;
            }


            foreach (DataRow dr in res.Rows)
                dataGridView.Rows.Add(dr[0], dr[1], dr[2]);
        }
    }
}
