
using System.Data;

namespace ProyectoCRUD
{
    public static class Estudiante
    {
        public static DataTable Buscar(string carnet, string seccion)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Carnet");
            table.Columns.Add("Nombre");
            table.Columns.Add("Seccion");

            table.Rows.Add("A001", "Juan Pérez", "A");
            table.Rows.Add("A002", "Ana García", "B");
            return table;
        }
    }
}
