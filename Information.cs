using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiData
{   /*6.1 Create a separate class file to hold the four data items of the Data Structure
    (use the Data Structure Matrix as a guide). Use private properties for the fields which
    must be of type “string”. The class file must have separate setters and getters,
    add an appropriate IComparable for the Name attribute. Save the class as “Information.cs”.*/ 
    internal class Information : IComparable<Information>
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
        public int CompareTo(Information other)
        {
            return name.CompareTo(other.name);
        }      
    }
}
