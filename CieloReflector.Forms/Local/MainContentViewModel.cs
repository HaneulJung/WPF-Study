using CieloReflector.Forms.Local.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CieloReflector.Forms.Local
{
    public class MainContentViewModel
    {
        public List<TreeModel> Types { get; init; }

        public MainContentViewModel()
        {
            Types = GetTypes();
        }

        private static List<TreeModel> GetTypes()
        {
            List<TreeModel> tree = new List<TreeModel>();
            TreeFolderModel all = new TreeFolderModel("All");
            TreeFolderModel systems = new TreeFolderModel("Systems");

            List<Assembly> assems = AppDomain.CurrentDomain.GetAssemblies().ToList();

            while (assems.Any())
            {
                Assembly assem = assems.First();
                assems.Remove(assem);

                all.Items.Add(new TreeModel(assem));

                if (assem.FullName.Contains("System."))
                {
                    systems.Items.Add(new TreeModel(assem));
                }
            }

            tree.Add(all);
            tree.Add(systems);

            return tree;
        }
    }
}
