using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;
using RepoAssistant.Model;

namespace RepoAssistant
{
    using MySql.Data.MySqlClient;

    public partial class FrmRepoAssistant : Form
    {
        private RepoManager manager;

        private IList<Tuple<Control, Control>> relationControls;

        public FrmRepoAssistant()
        {
            InitializeComponent();

            BuildConnectionRadioButtonList();

            InitRelationControl();
        }

        private void BtnSelectDllFile_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                TxtFilePath.Text = openFileDialog1.FileName;
                manager = new RepoManager(TxtFilePath.Text);
                BindClbRepo();
            }
        }

        private void BuildConnectionRadioButtonList()
        {
            foreach (ConnectionStringSettings connection in ConfigurationManager.ConnectionStrings)
            {
                if (connection.ElementInformation.IsPresent)
                {
                    var rbtConnection = new RadioButton() { Text = connection.Name };
                    rbtConnection.Dock = DockStyle.Left;
                    PnConnection.Controls.Add(rbtConnection);
                }
            }
        }

        private void BindClbRepo()
        {
            ClbRepo.Items.Clear();
            ClbProperty.Items.Clear();
            ClearControl(GbProperty);
            ClearControl(PnConstraint);
            foreach (var repo in manager.CurrentRepos)
            {
                ClbRepo.Items.Add(repo, repo.Selected);
            }

            ClbRepo.DisplayMember = "ShowName";
            ClbRepo.ValueMember = "Name";
        }

        private void FrmRepoAssistant_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (manager != null)
            {
                manager.SaveRepoData();
            }
        }

        private void ClbRepo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var repo = ClbRepo.SelectedItem as Repo;
            repo.Selected = ClbRepo.GetItemCheckState(ClbRepo.SelectedIndex) == CheckState.Checked;
            BindClbProperty(repo);
        }

        private void BindClbProperty(Repo repo)
        {
            ClbProperty.Items.Clear();
            ClearControl(GbProperty);
            ClearControl(PnConstraint);
            foreach (var property in repo.RepoProperties)
            {
                ClbProperty.Items.Add(property, property.Selected);
            }

            ClbProperty.DisplayMember = "Name";
            ClbProperty.ValueMember = "Name";
        }

        private void ClbProperty_SelectedIndexChanged(object sender, EventArgs e)
        {
            var repoProperty = ClbProperty.SelectedItem as RepoProperty;
            BindTypeAndConstraint(repoProperty);
        }

        private void BindTypeAndConstraint(RepoProperty repoProperty)
        {
            ClearControl(GbProperty);
            ClearControl(PnConstraint);

            switch (repoProperty.ColumnType)
            {
                case "int":
                    RbtnInt.Checked = true;
                    relationControls.Where(r => r.Item1 == RbtnInt).Select(r => r.Item2 as TextBox).Single().Text = repoProperty.Length.ToString();
                    //TxtInt.Text = repoProperty.Length.ToString();
                    break;
                case "bigint":
                    RbtnBigInt.Checked = true;
                    relationControls.Where(r => r.Item1 == RbtnBigInt).Select(r => r.Item2 as TextBox).Single().Text = repoProperty.Length.ToString();
                    break;
                case "tinyint":
                    RbtnTinyInt.Checked = true;
                    relationControls.Where(r => r.Item1 == RbtnTinyInt).Select(r => r.Item2 as TextBox).Single().Text = repoProperty.Length.ToString();
                    break;
                case "varchar":
                    RbtnVarchar.Checked = true;
                    relationControls.Where(r => r.Item1 == RbtnVarchar).Select(r => r.Item2 as TextBox).Single().Text = repoProperty.Length.ToString();
                    break;
                case "datetime":
                    RbtnDateTime.Checked = true;
                    break;
                case "text":
                    RbtnText.Checked = true;
                    break;
                case "longtext":
                    RbtnLongText.Checked = true;
                    break;
            }

            foreach (var constraint in repoProperty.Constraints)
            {
                if (constraint == "Primary Key")
                {
                    CbPrimaryKey.Checked = true;
                }
                if (constraint == "AUTO_INCREMENT")
                {
                    CbAutoIncrement.Checked = true;
                }
                if (constraint == "Null")
                {
                    RbtnNull.Checked = true;
                }
                if (constraint == "Not Null")
                {
                    RbtnNotNull.Checked = true;
                }
            }
        }

        private void ClearControl(Control control)
        {
            foreach (Control subControl in control.Controls)
            {
                if (subControl is RadioButton)
                {
                    (subControl as RadioButton).Checked = false;
                }
                else if (subControl is CheckBox)
                {
                    (subControl as CheckBox).Checked = false;
                }
                else if (subControl is TextBox)
                {
                    (subControl as TextBox).Text = string.Empty;
                }

                if (subControl.HasChildren)
                {
                    ClearControl(subControl);
                }
            }
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            var repoProperty = ClbProperty.SelectedItem as RepoProperty;
            repoProperty.Selected = ClbProperty.GetItemCheckState(ClbProperty.SelectedIndex) == CheckState.Checked;

            foreach (var control in GbProperty.Controls)
            {
                if (control is RadioButton && (control as RadioButton).Checked)
                {
                    repoProperty.ColumnType = (control as RadioButton).Text;
                    if (relationControls.Any(r => r.Item1 == control))
                    {
                        repoProperty.Length =
                            int.Parse(
                                relationControls.Where(r => r.Item1 == control)
                                                .Select(r => r.Item2 as TextBox)
                                                .Single()
                                                .Text);
                    }
                    break;
                }
            }

            repoProperty.Constraints.Clear();
            foreach (Control control in PnConstraint.Controls)
            {
                if (control is RadioButton && (control as RadioButton).Checked)
                {
                    repoProperty.Constraints.Add(control.Text);
                }
                if (control is CheckBox && (control as CheckBox).Checked)
                {
                    repoProperty.Constraints.Add(control.Text);
                }
            }
        }

        private void InitRelationControl()
        {
            relationControls = new List<Tuple<Control, Control>>();
            relationControls.Add(new Tuple<Control, Control>(RbtnInt, TxtInt));
            relationControls.Add(new Tuple<Control, Control>(RbtnBigInt, TxtBigInt));
            relationControls.Add(new Tuple<Control, Control>(RbtnTinyInt, TxtTinyInt));
            relationControls.Add(new Tuple<Control, Control>(RbtnVarchar, TxtVarchar));
        }

        private void BtnCreateTables_Click(object sender, EventArgs e)
        {
            if (RbtnCreateTable.Checked)
            {
                TxtSql.Text = manager.ToCreateTablesSql();
            }
            else if (RbtnAddColumn.Checked)
            {
                TxtSql.Text = manager.ToAddColumnSql();
            }
            else if (RbtnModifyColumn.Checked)
            {
                TxtSql.Text = manager.ToModifyColumnSql();
            }
        }

        private void BtnExcute_Click(object sender, EventArgs e)
        {
            var conStr = string.Empty;
            foreach (var control in PnConnection.Controls)
            {
                if (control is RadioButton && (control as RadioButton).Checked)
                {
                    conStr = ConfigurationManager.ConnectionStrings[(control as RadioButton).Text].ConnectionString;
                    break;
                }
            }

            if (string.IsNullOrEmpty(conStr))
            {
                MessageBox.Show("请选择数据库连接");
                return;
            }

            if (string.IsNullOrEmpty(TxtSql.Text))
            {
                MessageBox.Show("请生成sql脚本");
                return;
            }

            using (var con = new MySqlConnection(conStr))
            {
                con.Open();
                var cmd = new MySqlCommand(TxtSql.Text, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            if (manager != null)
                BindClbRepo();
        }
    }
}
