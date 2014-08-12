using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace RepoAssistant.Model
{
    [Serializable]
    class RepoProperty
    {
        public string Name { get; set; }

        public string ColumnName { get; set; }

        public string ColumnType { get; set; }

        public int? Length { get; set; }

        public bool Selected { get; set; }

        public IList<string> Constraints { get; set; }

        internal RepoProperty(PropertyInfo propertyInfo)
        {
            Name = propertyInfo.Name;
            ColumnName = propertyInfo.Name;
            Selected = true;
            Constraints = new List<string>();
            InitColumn(propertyInfo.PropertyType.Name);
            InitConstraint();
        }

        private void InitColumn(string typeName)
        {
            switch (typeName)
            {
                case "Int16":
                case "Int64":
                    ColumnType = "int";
                    Length = 11;
                    break;
                case "String":
                    ColumnType = "varchar";
                    Length = 200;
                    break;
                case "DateTime":
                    ColumnType = "datetime";
                    Length = 0;
                    break;
            }
        }

        private void InitConstraint()
        {
            if (Name == "Id")
            {
                Constraints.Add("Primary Key");
                Constraints.Add("AUTO_INCREMENT");
            }
        }

        internal string ToColumnSql()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("{0} {1}", ColumnName, ColumnType);
            if (Length.HasValue)
            {
                sb.AppendFormat("({0})", Length.Value);
            }

            foreach (var constraint in Constraints)
            {
                sb.AppendFormat(" {0}", constraint);
            }

            return sb.ToString();
        }
    }
}
