using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiData
{
    internal class Information 
    {
        private string name;
        private string structure;
        private string definition;
        private string category;

        public Information() { }
        #region Getters
        public string GetName()
        {
            return name;
        }
        public string GetStructure()
        {
            return structure;
        }
        public string GetDefinition()
        {
            return definition;
        }
        public string GetCategory()
        {
            return category;
        }
        #endregion Getters
        #region Setters
        public void SetName (string newName)
        {
            name = newName;
        }
        public void SetStructure (string newStructure)
        {
            structure = newStructure;
        }
        public void SetDefinition (string newDefinition)
        {
            definition = newDefinition;
        }
        public void SetCategory (string newCategory)
        {
            category = newCategory;
        }
        #endregion Setters
    }
}
