using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace RepoAssistant.Model
{
    class RepoManager
    {
        private Assembly assembly;

        private string currentDllPath;

        private const string DATA_FILE_NAME = "repo.dat";

        public IDictionary<string, IList<Repo>> Repos { get; set; }

        public IList<Repo> CurrentRepos
        {
            get
            {
                return Repos[currentDllPath];
            }
        }

        internal RepoManager(string path)
        {
            currentDllPath = path;
            ReadRepoData();
            InitialCurrentRepos();
        }

        private void InitialCurrentRepos()
        {
            IList<Repo> currentRepos;
            var repoNames = new List<string>();
            assembly = Assembly.LoadFrom(currentDllPath);

            var repoTypes = from t in assembly.GetTypes()
                            where !string.IsNullOrEmpty(t.Namespace) && t.Namespace.Contains("Repo") && t.Name.Contains("Repo")
                            select t;


            if (!Repos.Keys.Contains(currentDllPath))
            {
                currentRepos = new List<Repo>();
                Repos.Add(currentDllPath, currentRepos);
            }
            else
            {
                currentRepos = CurrentRepos;
            }

            foreach (var repoType in repoTypes)
            {
                repoNames.Add(repoType.Name);
                var tempRepo = currentRepos.SingleOrDefault(r => r.Name == repoType.Name);
                if (tempRepo != null)
                {
                    tempRepo.MergeRepoType(repoType);
                }
                else
                {
                    currentRepos.Add(new Repo(repoType));
                }
            }

            foreach (var repo in currentRepos.Where(r => !repoNames.Contains(r.Name)))
            {
                currentRepos.Remove(repo);
            }

        }

        public void SaveRepoData()
        {
            using (Stream stream = new FileStream(DATA_FILE_NAME, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, Repos);
                stream.Close();
            }
        }

        private void ReadRepoData()
        {
            if (File.Exists(DATA_FILE_NAME))
            {
                using (Stream stream = new FileStream(DATA_FILE_NAME, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    IFormatter formatter = new BinaryFormatter();
                    Repos = (IDictionary<string, IList<Repo>>)formatter.Deserialize(stream);
                    stream.Close();
                }
            }
            else
            {
                Repos = new Dictionary<string, IList<Repo>>();
            }
        }

        internal string ToCreateTablesSql()
        {
            var sb = new StringBuilder();
            foreach (var repo in CurrentRepos.Where(r => r.Selected))
            {
                sb.AppendLine();
                sb.AppendLine();
                sb.AppendLine(repo.ToCreateTableSql());
            }
            return sb.ToString();
        }

        internal string ToAddColumnSql()
        {
            var sb = new StringBuilder();
            foreach (var repo in CurrentRepos.Where(r => r.Selected))
            {
                sb.AppendLine();
                sb.AppendLine();
                sb.AppendLine(repo.ToAddColumnSql());
            }
            return sb.ToString();
        }

        internal string ToModifyColumnSql()
        {
            var sb = new StringBuilder();
            foreach (var repo in CurrentRepos.Where(r => r.Selected))
            {
                sb.AppendLine();
                sb.AppendLine();
                sb.AppendLine(repo.ToModifyColumnSql());
            }
            return sb.ToString();
        }
    }
}
