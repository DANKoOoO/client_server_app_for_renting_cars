using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public interface IEntity
    {
        string Tablename { get; }
        string TableAlias { get; }
        string InsertValues { get; }
        string IdNaziv { get; }
        string JoinTable { get; }
        string JoinCondition { get; }
        string SelectColumns { get; }
        string WhereClause1 { get; }
        string SetColumn { get; }
        string WhereClause2 { get; }
        string ChildTable { get; }
        string ChildInsertValues { get; }
        string ChildJoinTable { get; }
        string ChildJoinCondition { get; }
        List<IEntity> GetEntities(SqlDataReader reader);
    }
}
