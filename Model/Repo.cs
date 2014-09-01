using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace RepoAssistant.Model
{
    [Serializable]
    class Repo
    {
        public string Name { get; set; }

        public string TableName { get; set; }

        public string ShowName
        {
            get
            {
                return string.Format("{0}({1})", Name, TableName);
            }

        }

        public bool Selected { get; set; }

        public IList<RepoProperty> RepoProperties { get; set; }

        internal Repo(Type type)
        {
            Name = type.Name;
            TableName = type.Name.Replace("Repo", string.Empty);
            Selected = false;
            RepoProperties = new List<RepoProperty>();
            LoadProperties(type.GetProperties());
        }

        internal void MergeRepoType(Type type)
        {
            LoadProperties(type.GetProperties());
        }

        internal void LoadProperties(PropertyInfo[] propertyInfos)
        {
            var repoPropertyNames = new List<string>();
            foreach (var propertyInfo in propertyInfos)
            {
                repoPropertyNames.Add(propertyInfo.Name);
                if (!RepoProperties.Any(p => p.Name == propertyInfo.Name))
                {
                    RepoProperties.Add(new RepoProperty(propertyInfo));
                }
            }

            foreach (var repoProperty in RepoProperties.Where(p => !repoPropertyNames.Contains(p.Name)).ToArray())
            {
                RepoProperties.Remove(repoProperty);
            }
        }

        internal string ToCreateTableSql()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("DROP TABLE IF EXISTS {0};", TableName);
            sb.AppendLine();
            sb.AppendFormat("CREATE TABLE IF NOT EXISTS {0} (", TableName);
            sb.AppendLine();
            var ie = RepoProperties.Where(r => r.Selected).GetEnumerator();
            if (ie.MoveNext())
            {
                sb.Append(ie.Current.ToColumnSql());
            }

            while (ie.MoveNext())
            {
                sb.AppendLine(",");
                sb.Append(ie.Current.ToColumnSql());
            }

            sb.AppendLine();
            sb.AppendLine(");");
            return sb.ToString();
        }

        internal string ToAddColumnSql()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("ALTER TABLE {0}", TableName);
            sb.AppendLine();

            var ie = RepoProperties.Where(r => r.Selected).GetEnumerator();
            if (ie.MoveNext())
            {
                sb.Append("ADD COLUMN ");
                sb.Append(ie.Current.ToColumnSql());
            }

            while (ie.MoveNext())
            {
                sb.AppendLine(",");
                sb.Append("ADD COLUMN ");
                sb.Append(ie.Current.ToColumnSql());
            }
            sb.AppendLine(";");
            return sb.ToString();
        }

        internal string ToModifyColumnSql()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("ALTER TABLE {0}", TableName);
            sb.AppendLine();

            var ie = RepoProperties.Where(r => r.Selected).GetEnumerator();
            if (ie.MoveNext())
            {
                sb.Append("MODIFY COLUMN ");
                sb.Append(ie.Current.ToColumnSql());
            }

            while (ie.MoveNext())
            {
                sb.AppendLine(",");
                sb.Append("MODIFY COLUMN ");
                sb.Append(ie.Current.ToColumnSql());
            }
            sb.AppendLine(";");
            return sb.ToString();
        }
    }
}
